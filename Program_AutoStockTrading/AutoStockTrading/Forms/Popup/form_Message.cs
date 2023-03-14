using AutoStockTrading.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoStockTrading.Reference.CommonFunction;

namespace AutoStockTrading.Forms.Popup
{
    public partial class form_Message : Form
    {
        public form_Message()
        {
            InitializeComponent();
        }

        public form_Message(E_MESSAGE Type, string Message) : this()
        {
            switch (Type)
            {
                case E_MESSAGE.OK:
                case E_MESSAGE.OK_TIMER:
                    btn_Yes.Visible = false;
                    btn_No.Visible = false;
                    break;
                case E_MESSAGE.YESNO:
                case E_MESSAGE.YESNO_TIMER:
                    btn_Ok.Visible = false;
                    break;
            }

            btn_Content.Text = Message;
            Global.AddLog($"[Message] {Message}");
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            Global.AddLog("[Message] Click the YES button.");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Global.AddLog("[Message] Click the OK button.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            Global.AddLog("[Message] Click the NO button.");
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
