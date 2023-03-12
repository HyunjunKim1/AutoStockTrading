
namespace AutoStockTrading.Forms.Popup
{
    partial class form_Login
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
            this.gPnl_Login = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gPnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gPnl_Login
            // 
            this.gPnl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.gPnl_Login.BorderColor = System.Drawing.Color.Silver;
            this.gPnl_Login.BorderThickness = 2;
            this.gPnl_Login.Controls.Add(this.label1);
            this.gPnl_Login.Controls.Add(this.btn_Login);
            this.gPnl_Login.Controls.Add(this.btn_Logout);
            this.gPnl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPnl_Login.Location = new System.Drawing.Point(0, 0);
            this.gPnl_Login.Name = "gPnl_Login";
            this.gPnl_Login.Size = new System.Drawing.Size(385, 215);
            this.gPnl_Login.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_Login.BorderRadius = 4;
            this.btn_Login.BorderThickness = 1;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btn_Login.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(79, 79);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(208, 40);
            this.btn_Login.TabIndex = 81;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Animated = true;
            this.btn_Logout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_Logout.BorderRadius = 4;
            this.btn_Logout.BorderThickness = 1;
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.btn_Logout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(79, 136);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(208, 40);
            this.btn_Logout.TabIndex = 80;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 43);
            this.label1.TabIndex = 82;
            this.label1.Text = "Admin Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(385, 215);
            this.Controls.Add(this.gPnl_Login);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Login";
            this.gPnl_Login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gPnl_Login;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2Button btn_Logout;
    }
}