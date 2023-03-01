using AutoStockTrading.Reference;
using static AutoStockTrading.Reference.CommonFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading
{
    public partial class form_Splash : Form
    {
        WhileThread _threadSplash;
        public form_Splash()
        {
            InitializeComponent();

            lbl_Version.Text = Program.Version;

            _threadSplash = new WhileThread(10, Loading);

            _step = 0;
        }

        int _step = 0;

        private void Loading()
        {
            switch (_step)
            {
                case 0:
                    break;

                case 100:
                    Global.AddLog("########## Complete loading program ##########");
                    this.DialogResult = DialogResult.OK;
                    _threadSplash.Stop();

                    this.BeginInvoke(new Action(() =>
                    {
                        this.Close();
                    }));
                    return;
            }

            _step++;

            this.Invoke(new Action(() =>
            {
                gBox_Status.Text = $"Program Loading ... {_step}%";
            }));

            if (Global.Timeout.IsTimeOut(100))
            {
                this.Invoke(new Action(() =>
                {
                    gBox_Status.Text = $"Error - Program Loading Timeout...";
                }));
                _threadSplash.Stop();
            }
        }
    }
}
