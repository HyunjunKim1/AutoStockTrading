using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;

namespace AutoStockTrading.Forms.Dockable
{
    public partial class form_Log : NotFlickingForm
    {
        public form_Log()
        {
            InitializeComponent();
        }

        public void AddLog(string text)
        {
            if (this.InvokeRequired) { this.BeginInvoke(new Action(() => { AddLog(text); })); return; }

            if (RTbox_Log.Lines.Length > 600)
                RTbox_Log.Clear();

            if (RTbox_Log.IsDisposed == false)
                RTbox_Log.AppendText(text + Environment.NewLine);
        }

        private void cBox_StopAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            RTbox_Log.HideSelection = cBox_StopAutoScroll.Checked;
            RTbox_Log.ScrollToCaret();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            RTbox_Log.Clear();
        }
    }
}
