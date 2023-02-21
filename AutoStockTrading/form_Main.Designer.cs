
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.종목검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.종목검색ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_Menu_Login,
            this.m_Menu_Logout,
            this.m_Menu_Status,
            this.m_Menu_Account,
            this.m_Menu_Exit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // m_Menu_Login
            // 
            this.m_Menu_Login.Name = "m_Menu_Login";
            this.m_Menu_Login.Size = new System.Drawing.Size(122, 22);
            this.m_Menu_Login.Text = "로그인";
            this.m_Menu_Login.Click += new System.EventHandler(this.m_Menu_Login_Click);
            // 
            // m_Menu_Logout
            // 
            this.m_Menu_Logout.Name = "m_Menu_Logout";
            this.m_Menu_Logout.Size = new System.Drawing.Size(122, 22);
            this.m_Menu_Logout.Text = "로그아웃";
            this.m_Menu_Logout.Click += new System.EventHandler(this.m_Menu_Logout_Click);
            // 
            // m_Menu_Status
            // 
            this.m_Menu_Status.Name = "m_Menu_Status";
            this.m_Menu_Status.Size = new System.Drawing.Size(122, 22);
            this.m_Menu_Status.Text = "접속상태";
            // 
            // m_Menu_Account
            // 
            this.m_Menu_Account.Name = "m_Menu_Account";
            this.m_Menu_Account.Size = new System.Drawing.Size(122, 22);
            this.m_Menu_Account.Text = "계좌조회";
            // 
            // m_Menu_Exit
            // 
            this.m_Menu_Exit.Name = "m_Menu_Exit";
            this.m_Menu_Exit.Size = new System.Drawing.Size(180, 22);
            this.m_Menu_Exit.Text = "종료";
            this.m_Menu_Exit.Click += new System.EventHandler(this.m_Menu_Exit_Click);
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
            // 종목검색ToolStripMenuItem
            // 
            this.종목검색ToolStripMenuItem.Name = "종목검색ToolStripMenuItem";
            this.종목검색ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.종목검색ToolStripMenuItem.Text = "종목 검색";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 609);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.axKHOpenAPI);
            this.Controls.Add(this.menuStrip1);
            this.Name = "form_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_Menu_Login;
        private System.Windows.Forms.ToolStripMenuItem m_Menu_Logout;
        private System.Windows.Forms.ToolStripMenuItem m_Menu_Status;
        private System.Windows.Forms.ToolStripMenuItem m_Menu_Account;
        private System.Windows.Forms.ToolStripMenuItem m_Menu_Exit;
        public System.Windows.Forms.Label lbl_Log;
        private System.Windows.Forms.ToolStripMenuItem 종목검색ToolStripMenuItem;
    }
}

