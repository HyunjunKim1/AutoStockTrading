using AutoStockTrading.Reference;
using BaseForm;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading.Forms
{
    public partial class form_Status : NotFlickingForm
    {
        public form_Status()
        {
            InitializeComponent();
        }
        public void UpdateUI()
        {
            if (this.InvokeRequired) { this.Invoke(new Action(() => { UpdateUI(); })); return; }

            //ChangeSafetyIcon(iBox_Login, CMF.System.Safety.Initialized);
        }

        private void ChangeSafetyIcon(Guna2TextBox iBox, bool isChecked)
        {
            using (Image oldImage = iBox.IconLeft)
            {
                iBox.IconLeft = isChecked ? Properties.Resources.CHECK_ON : Properties.Resources.CHECK_OFF;
            }
        }
    }
}
