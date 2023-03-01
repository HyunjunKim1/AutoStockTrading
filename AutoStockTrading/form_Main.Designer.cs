
namespace AutoStockTrading
{
    partial class form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.pnl_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Title = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_MarginRight = new System.Windows.Forms.Panel();
            this.pnl_MarginLeft = new System.Windows.Forms.Panel();
            this.pnl_MarginBottom = new System.Windows.Forms.Panel();
            this.pnl_MarginTop = new System.Windows.Forms.Panel();
            this.pnl_StatusIcon = new System.Windows.Forms.Panel();
            this.iBtn_Status = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnl_Dock1 = new System.Windows.Forms.Panel();
            this.pnl_Dock2 = new System.Windows.Forms.Panel();
            this.pnl_Dock3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.pnl_StatusIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(917, 560);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI.TabIndex = 0;
            // 
            // lbl_Log
            // 
            this.lbl_Log.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_Log.Location = new System.Drawing.Point(0, 584);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(1019, 25);
            this.lbl_Log.TabIndex = 2;
            this.lbl_Log.Text = "[04:34:40:617] [System] Successfully loaded the program.";
            this.lbl_Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnl_Main.Controls.Add(this.pnl_Dock3);
            this.pnl_Main.Controls.Add(this.pnl_Dock2);
            this.pnl_Main.Controls.Add(this.pnl_Dock1);
            this.pnl_Main.Controls.Add(this.pnl_StatusIcon);
            this.pnl_Main.Controls.Add(this.pnl_Title);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(5, 5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1009, 574);
            this.pnl_Main.TabIndex = 3;
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Controls.Add(this.lbl_Version);
            this.pnl_Title.Controls.Add(this.guna2ControlBox3);
            this.pnl_Title.Controls.Add(this.guna2ControlBox2);
            this.pnl_Title.Controls.Add(this.Btn_Close);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnl_Title.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_Title.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1009, 27);
            this.pnl_Title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Auto Stock Trading";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Version
            // 
            this.lbl_Version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Version.Location = new System.Drawing.Point(833, 0);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(86, 27);
            this.lbl_Version.TabIndex = 4;
            this.lbl_Version.Text = "Ver 1.2.3";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(919, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(30, 27);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(949, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 27);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Close.CustomClick = true;
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Close.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Close.IconColor = System.Drawing.Color.Black;
            this.Btn_Close.Location = new System.Drawing.Point(979, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 27);
            this.Btn_Close.TabIndex = 1;
            // 
            // pnl_MarginRight
            // 
            this.pnl_MarginRight.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_MarginRight.Enabled = false;
            this.pnl_MarginRight.Location = new System.Drawing.Point(1014, 0);
            this.pnl_MarginRight.Name = "pnl_MarginRight";
            this.pnl_MarginRight.Size = new System.Drawing.Size(5, 584);
            this.pnl_MarginRight.TabIndex = 6;
            // 
            // pnl_MarginLeft
            // 
            this.pnl_MarginLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MarginLeft.Enabled = false;
            this.pnl_MarginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_MarginLeft.Name = "pnl_MarginLeft";
            this.pnl_MarginLeft.Size = new System.Drawing.Size(5, 584);
            this.pnl_MarginLeft.TabIndex = 7;
            // 
            // pnl_MarginBottom
            // 
            this.pnl_MarginBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_MarginBottom.Enabled = false;
            this.pnl_MarginBottom.Location = new System.Drawing.Point(5, 579);
            this.pnl_MarginBottom.Name = "pnl_MarginBottom";
            this.pnl_MarginBottom.Size = new System.Drawing.Size(1009, 5);
            this.pnl_MarginBottom.TabIndex = 8;
            // 
            // pnl_MarginTop
            // 
            this.pnl_MarginTop.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MarginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MarginTop.Enabled = false;
            this.pnl_MarginTop.Location = new System.Drawing.Point(5, 0);
            this.pnl_MarginTop.Name = "pnl_MarginTop";
            this.pnl_MarginTop.Size = new System.Drawing.Size(1009, 5);
            this.pnl_MarginTop.TabIndex = 9;
            // 
            // pnl_StatusIcon
            // 
            this.pnl_StatusIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_StatusIcon.Controls.Add(this.iBtn_Status);
            this.pnl_StatusIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_StatusIcon.Location = new System.Drawing.Point(0, 27);
            this.pnl_StatusIcon.Name = "pnl_StatusIcon";
            this.pnl_StatusIcon.Size = new System.Drawing.Size(32, 547);
            this.pnl_StatusIcon.TabIndex = 3;
            // 
            // iBtn_Status
            // 
            this.iBtn_Status.BackColor = System.Drawing.Color.Transparent;
            this.iBtn_Status.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_Status.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.iBtn_Status.Image = ((System.Drawing.Image)(resources.GetObject("iBtn_Status.Image")));
            this.iBtn_Status.ImageOffset = new System.Drawing.Point(0, 0);
            this.iBtn_Status.ImageRotate = 0F;
            this.iBtn_Status.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Status.Location = new System.Drawing.Point(0, 0);
            this.iBtn_Status.Name = "iBtn_Status";
            this.iBtn_Status.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iBtn_Status.Size = new System.Drawing.Size(32, 37);
            this.iBtn_Status.TabIndex = 3;
            this.iBtn_Status.Tag = "STATUS";
            // 
            // pnl_Dock1
            // 
            this.pnl_Dock1.AutoScroll = true;
            this.pnl_Dock1.AutoScrollMargin = new System.Drawing.Size(0, 1);
            this.pnl_Dock1.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnl_Dock1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Dock1.Location = new System.Drawing.Point(32, 27);
            this.pnl_Dock1.Name = "pnl_Dock1";
            this.pnl_Dock1.Size = new System.Drawing.Size(312, 547);
            this.pnl_Dock1.TabIndex = 4;
            // 
            // pnl_Dock2
            // 
            this.pnl_Dock2.AutoScroll = true;
            this.pnl_Dock2.AutoScrollMargin = new System.Drawing.Size(0, 1);
            this.pnl_Dock2.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnl_Dock2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Dock2.Location = new System.Drawing.Point(344, 27);
            this.pnl_Dock2.Name = "pnl_Dock2";
            this.pnl_Dock2.Size = new System.Drawing.Size(665, 547);
            this.pnl_Dock2.TabIndex = 5;
            // 
            // pnl_Dock3
            // 
            this.pnl_Dock3.AutoScroll = true;
            this.pnl_Dock3.AutoScrollMargin = new System.Drawing.Size(0, 1);
            this.pnl_Dock3.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnl_Dock3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Dock3.Location = new System.Drawing.Point(705, 27);
            this.pnl_Dock3.Name = "pnl_Dock3";
            this.pnl_Dock3.Size = new System.Drawing.Size(304, 547);
            this.pnl_Dock3.TabIndex = 6;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 609);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_MarginTop);
            this.Controls.Add(this.pnl_MarginBottom);
            this.Controls.Add(this.pnl_MarginLeft);
            this.Controls.Add(this.pnl_MarginRight);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.axKHOpenAPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_StatusIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        public System.Windows.Forms.Label lbl_Log;
        private Guna.UI2.WinForms.Guna2Panel pnl_Main;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Title;
        private System.Windows.Forms.Label lbl_Version;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox Btn_Close;
        private System.Windows.Forms.Panel pnl_MarginRight;
        private System.Windows.Forms.Panel pnl_MarginLeft;
        private System.Windows.Forms.Panel pnl_MarginBottom;
        private System.Windows.Forms.Panel pnl_MarginTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Dock3;
        private System.Windows.Forms.Panel pnl_Dock2;
        private System.Windows.Forms.Panel pnl_Dock1;
        private System.Windows.Forms.Panel pnl_StatusIcon;
        private Guna.UI2.WinForms.Guna2ImageButton iBtn_Status;
    }
}

