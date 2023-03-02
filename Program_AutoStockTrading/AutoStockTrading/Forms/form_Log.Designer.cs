
namespace AutoStockTrading.Forms
{
    partial class form_Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Log));
            this.pnl_Title = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.iBtn_Popup = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBox_StopAutoScroll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.RTbox_Log = new System.Windows.Forms.RichTextBox();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.lbl_Title);
            this.pnl_Title.Controls.Add(this.iBtn_Popup);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_Title.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Title.ForeColor = System.Drawing.Color.Black;
            this.pnl_Title.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(234, 26);
            this.pnl_Title.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(208, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Log";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iBtn_Popup
            // 
            this.iBtn_Popup.BackColor = System.Drawing.Color.Transparent;
            this.iBtn_Popup.CheckedState.ImageSize = new System.Drawing.Size(22, 22);
            this.iBtn_Popup.Dock = System.Windows.Forms.DockStyle.Right;
            this.iBtn_Popup.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.iBtn_Popup.Image = ((System.Drawing.Image)(resources.GetObject("iBtn_Popup.Image")));
            this.iBtn_Popup.ImageOffset = new System.Drawing.Point(0, 0);
            this.iBtn_Popup.ImageRotate = 0F;
            this.iBtn_Popup.ImageSize = new System.Drawing.Size(20, 20);
            this.iBtn_Popup.Location = new System.Drawing.Point(208, 0);
            this.iBtn_Popup.Name = "iBtn_Popup";
            this.iBtn_Popup.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.iBtn_Popup.Size = new System.Drawing.Size(26, 26);
            this.iBtn_Popup.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.cBox_StopAutoScroll);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 30);
            this.panel1.TabIndex = 4;
            // 
            // cBox_StopAutoScroll
            // 
            this.cBox_StopAutoScroll.Animated = true;
            this.cBox_StopAutoScroll.AutoSize = true;
            this.cBox_StopAutoScroll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.cBox_StopAutoScroll.CheckedState.BorderRadius = 0;
            this.cBox_StopAutoScroll.CheckedState.BorderThickness = 0;
            this.cBox_StopAutoScroll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.cBox_StopAutoScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.cBox_StopAutoScroll.Location = new System.Drawing.Point(126, 0);
            this.cBox_StopAutoScroll.Name = "cBox_StopAutoScroll";
            this.cBox_StopAutoScroll.Size = new System.Drawing.Size(108, 30);
            this.cBox_StopAutoScroll.TabIndex = 11;
            this.cBox_StopAutoScroll.Text = "Stop auto scroll";
            this.cBox_StopAutoScroll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cBox_StopAutoScroll.UncheckedState.BorderRadius = 0;
            this.cBox_StopAutoScroll.UncheckedState.BorderThickness = 0;
            this.cBox_StopAutoScroll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cBox_StopAutoScroll.CheckedChanged += new System.EventHandler(this.cBox_StopAutoScroll_CheckedChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Animated = true;
            this.btn_Clear.BorderColor = System.Drawing.Color.Silver;
            this.btn_Clear.BorderRadius = 4;
            this.btn_Clear.BorderThickness = 1;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btn_Clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(0, 0);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(66, 30);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // RTbox_Log
            // 
            this.RTbox_Log.BackColor = System.Drawing.Color.Black;
            this.RTbox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTbox_Log.DetectUrls = false;
            this.RTbox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTbox_Log.ForeColor = System.Drawing.Color.Yellow;
            this.RTbox_Log.HideSelection = false;
            this.RTbox_Log.Location = new System.Drawing.Point(0, 26);
            this.RTbox_Log.Name = "RTbox_Log";
            this.RTbox_Log.Size = new System.Drawing.Size(234, 194);
            this.RTbox_Log.TabIndex = 5;
            this.RTbox_Log.Text = "";
            // 
            // form_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(234, 250);
            this.Controls.Add(this.RTbox_Log);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Log";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Log";
            this.pnl_Title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Title;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2ImageButton iBtn_Popup;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox cBox_StopAutoScroll;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private System.Windows.Forms.RichTextBox RTbox_Log;
    }
}