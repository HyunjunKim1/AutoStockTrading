using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading.Reference
{
    public enum FORM_NAME // ...FORM추가...
    {
        LOG,
        SEARCH_CODE,
        SEARCH_NAME,
        
    }
    class FormManager
    {
        public form_Main Main;


        List<(Panel panel, Form form)> _pairList = new List<(Panel panel, Form form)>();
        List<Form> _etcFormList = new List<Form>();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr childWindowHandle, IntPtr parentWindowHandle);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        public void ThreadSorting()
        {
            Process currentProcess = Process.GetCurrentProcess();

            foreach (ProcessThread processThread in currentProcess.Threads)
            {
                processThread.ProcessorAffinity = currentProcess.ProcessorAffinity;
            }
        }

        public void CreatePanelAndSetForm(Panel mainPanel, Form form, bool dock)
        {
            Main.Invoke(new Action(() =>
            {
                Panel subPanel = new Panel();
                subPanel.Size = form.Size;
                subPanel.Dock = DockStyle.Top;
                mainPanel.Controls.Add(subPanel);
                mainPanel.Controls.SetChildIndex(subPanel, 0); // 서순

                SetParent(form.Handle, subPanel.Handle);

                _pairList.Add((subPanel, form));
            }));

            form.Invoke(new Action(() =>
            {
                SetWindowPos(form.Handle, IntPtr.Zero, 0, 0, form.Width, form.Height, 0);
            }));

            if (dock)
                Dock(form);
            else
                Undock(form);
        }
        private void form_Resize(object sender, EventArgs e)
        {
            Form form = (sender as Form);
            if (form.WindowState == FormWindowState.Minimized)
                Dock(form);
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Form form = (sender as Form);
            Global.Form.Undock(form);
        }

        private void Popup_FormCosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Form form = (sender as Form);
            form.WindowState = FormWindowState.Normal;
            form.Hide();
            form.ShowInTaskbar = false;
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = (sender as Form);
            form = null;
        }

        private void form_VisibleChanged(object sender, EventArgs e)
        {
            Form form = (sender as Form);
            FORM_NAME formName = (FORM_NAME)Enum.Parse(typeof(FORM_NAME), form.Tag.ToString());
            Global.Form.Main?.ChangeMainButtonColor(formName, form.Visible);
        }

        private void form_StyleChanged(object sender, EventArgs e)
        {
            Form form = (sender as Form);
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "pnl_Title")
                    ctrl.Visible = (form.FormBorderStyle == FormBorderStyle.None);
            }
        }

        private void iBtn_Popup_Click(object sender, EventArgs e)
        {
            Guna2ImageButton button = (sender as Guna2ImageButton);
            Popup(button.FindForm());
        }
        public void Dispose()
        {
            for (int i = 0; i < _pairList.Count; i++)
            {
                _pairList[i].form.FormClosing -= form_FormClosing;
            }

            for (int i = 0; i < _pairList.Count; i++)
            {
                _pairList[i].form.Invoke(new Action(() =>
                {
                    _pairList[i].form.Close();
                }));
            }

            for (int i = 0; i < _etcFormList.Count; i++)
            {
                _etcFormList[i].FormClosing -= Popup_FormCosing;
            }

            for (int i = 0; i < _etcFormList.Count; i++)
            {
                _etcFormList[i].Invoke(new Action(() =>
                {
                    _etcFormList[i].Close();
                }));
            }
        }

        private void Dock(Form form)
        {
            for (int i = 0; i < _pairList.Count; i++)
            {
                if (_pairList[i].form.Equals(form))
                {
                    ChangeProperty(_pairList[i].panel.Parent, "Visible", true);
                    ChangeProperty(_pairList[i].panel, "Visible", true);

                    ChangeProperty(form, "FormBorderStyle", FormBorderStyle.None);

                    SetParent(GetHandle(form), GetHandle(_pairList[i].panel));
                    SetWindowPos(GetHandle(form), IntPtr.Zero, 0, 0, _pairList[i].panel.Width, _pairList[i].panel.Height, 0);

                    ChangeProperty(form, "Visible", true);
                    break;
                }
            }
        }

        private void Popup(Form form)
        {
            for (int i = 0; i < _pairList.Count; i++)
            {
                if (_pairList[i].form.Equals(form))
                {
                    SetParent(GetHandle(form), IntPtr.Zero);

                    ChangeProperty(form, "FormBorderStyle", FormBorderStyle.Sizable);
                    ChangeProperty(form, "Visible", true);
                    ChangeProperty(form, "TopMost", false);
                    ChangeProperty(form, "TopMost", true);

                    Point pointInScreen = new Point(Main.Location.X + _pairList[i].panel.Parent.Location.X + _pairList[i].panel.Location.X + 10,
                                                    Main.Location.Y + _pairList[i].panel.Parent.Location.Y + _pairList[i].panel.Location.Y + 10);

                    SetWindowPos(GetHandle(form), IntPtr.Zero, pointInScreen.X, pointInScreen.Y, _pairList[i].panel.Width + 15, _pairList[i].panel.Height + 13, 0);

                    ChangeProperty(_pairList[i].panel, "Visible", false);
                    CheckAndChangeMainPanelVisible(_pairList[i].panel);
                    break;
                }
            }
        }

        private void Undock(Form form)
        {
            for (int i = 0; i < _pairList.Count; i++)
            {
                if (_pairList[i].form.Equals(form))
                {
                    ChangeProperty(form, "Visible", false);

                    ChangeProperty(_pairList[i].panel, "Visible", false);

                    CheckAndChangeMainPanelVisible(_pairList[i].panel);
                    break;
                }
            }
        }
        private void CheckAndChangeMainPanelVisible(Panel panel)
        {
            Control mainPanel = panel.Parent;
            bool allPanelHide = false;
            for (int i = 0; i < _pairList.Count; i++)
            {
                if (_pairList[i].panel.Parent == mainPanel && _pairList[i].panel.Visible)
                {
                    allPanelHide = true;
                    break;
                }
            }

            ChangeProperty(mainPanel, "Visible", allPanelHide);
        }

        public void DockOrHide(Form form)
        {
            if (form.Visible)
                Undock(form);
            else
                Dock(form);
        }

        private IntPtr GetHandle(Control control)
        {
            IntPtr handle = IntPtr.Zero;

            control.Invoke(new Action(() =>
            {
                handle = control.Handle;
            }));

            return handle;
        }

        private void ChangeProperty<T>(Control control, string propertyName, T value)
        {
            control.Invoke(new Action(() =>
            {
                control.GetType().GetProperty(propertyName).SetValue(control, value);
            }));
        }
    }
}
