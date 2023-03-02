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

        private void form_Splash_Load(object sender, EventArgs e)
        {
            SetImage(pBox_LoadIniFiles, Properties.Resources.LED_RED);
            SetImage(pBox_CreateForms,  Properties.Resources.LED_RED);

            _threadSplash.Start();
        }
        public void SetImage(PictureBox pBox, Bitmap image)
        {
            using (Image oldImage = pBox.BackgroundImage)
            {
                pBox.BackgroundImage = image;
            }
        }

        int _step = 0;

        private void Loading()
        {
            switch (_step)
            {
                // 넣어야할 내용들 .... 뭐뭐가 있을까?
                // 1. form 생성하는거 넣어야함.
                // 2. 필요 Ini 파일들 불러오는 부분 넣어야함.
                case 0:
                    Global.AddLog("########## Start loading program ##########");
                    Global.Timeout.Start();
                    break;

                case 10:
                    Global.Form.CreateFormWithUiThread(FORM_NAME.STATUS);
                    break;

                case 20:
                    Global.Form.CreateFormWithUiThread(FORM_NAME.LOG);
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

            if (Global.Timeout.IsTimeOut(10000))
            {
                this.Invoke(new Action(() =>
                {
                    gBox_Status.Text = $"Error - Program Loading Timeout...";
                }));
                _threadSplash.Stop();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _threadSplash.Stop();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
