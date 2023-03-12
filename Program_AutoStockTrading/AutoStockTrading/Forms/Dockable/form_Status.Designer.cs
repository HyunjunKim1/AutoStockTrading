
namespace AutoStockTrading.Forms.Dockable
{
    partial class form_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Status));
            this.pnl_Title = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_MarginLeft = new System.Windows.Forms.Panel();
            this.pnl_MarginRight = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBox_InMotion = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iBox_test = new Guna.UI2.WinForms.Guna2TextBox();
            this.iBox_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.iBtn_Popup = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnl_Title.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.pnl_Title.Size = new System.Drawing.Size(250, 26);
            this.pnl_Title.TabIndex = 3;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(224, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Status";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_MarginLeft
            // 
            this.pnl_MarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MarginLeft.Location = new System.Drawing.Point(0, 26);
            this.pnl_MarginLeft.Name = "pnl_MarginLeft";
            this.pnl_MarginLeft.Size = new System.Drawing.Size(10, 267);
            this.pnl_MarginLeft.TabIndex = 4;
            // 
            // pnl_MarginRight
            // 
            this.pnl_MarginRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_MarginRight.Location = new System.Drawing.Point(240, 26);
            this.pnl_MarginRight.Name = "pnl_MarginRight";
            this.pnl_MarginRight.Size = new System.Drawing.Size(10, 267);
            this.pnl_MarginRight.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tBox_InMotion);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(10, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 44);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Now Front";
            // 
            // tBox_InMotion
            // 
            this.tBox_InMotion.BorderColor = System.Drawing.Color.Silver;
            this.tBox_InMotion.BorderRadius = 4;
            this.tBox_InMotion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBox_InMotion.DefaultText = "종목 검색";
            this.tBox_InMotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBox_InMotion.FillColor = System.Drawing.Color.Black;
            this.tBox_InMotion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tBox_InMotion.ForeColor = System.Drawing.Color.White;
            this.tBox_InMotion.IconLeftSize = new System.Drawing.Size(0, 0);
            this.tBox_InMotion.Location = new System.Drawing.Point(3, 19);
            this.tBox_InMotion.Name = "tBox_InMotion";
            this.tBox_InMotion.PasswordChar = '\0';
            this.tBox_InMotion.PlaceholderText = "";
            this.tBox_InMotion.ReadOnly = true;
            this.tBox_InMotion.SelectedText = "";
            this.tBox_InMotion.Size = new System.Drawing.Size(224, 22);
            this.tBox_InMotion.TabIndex = 1;
            this.tBox_InMotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(10, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 223);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Safety";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.iBox_test, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iBox_Login, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 201);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // iBox_test
            // 
            this.iBox_test.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_test.BorderRadius = 4;
            this.iBox_test.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iBox_test.DefaultText = "Check, Test";
            this.iBox_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBox_test.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_test.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_test.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iBox_test.ForeColor = System.Drawing.Color.Black;
            this.iBox_test.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_test.IconLeft = global::AutoStockTrading.Properties.Resources.CHECK_OFF;
            this.iBox_test.Location = new System.Drawing.Point(115, 3);
            this.iBox_test.Name = "iBox_test";
            this.iBox_test.PasswordChar = '\0';
            this.iBox_test.PlaceholderText = "";
            this.iBox_test.ReadOnly = true;
            this.iBox_test.SelectedText = "";
            this.iBox_test.Size = new System.Drawing.Size(106, 44);
            this.iBox_test.TabIndex = 1;
            // 
            // iBox_Login
            // 
            this.iBox_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_Login.BorderRadius = 4;
            this.iBox_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iBox_Login.DefaultText = "Login";
            this.iBox_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBox_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iBox_Login.ForeColor = System.Drawing.Color.Black;
            this.iBox_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.iBox_Login.IconLeft = global::AutoStockTrading.Properties.Resources.CHECK_ON;
            this.iBox_Login.Location = new System.Drawing.Point(3, 3);
            this.iBox_Login.Name = "iBox_Login";
            this.iBox_Login.PasswordChar = '\0';
            this.iBox_Login.PlaceholderText = "";
            this.iBox_Login.ReadOnly = true;
            this.iBox_Login.SelectedText = "";
            this.iBox_Login.Size = new System.Drawing.Size(106, 44);
            this.iBox_Login.TabIndex = 5;
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
            this.iBtn_Popup.Location = new System.Drawing.Point(224, 0);
            this.iBtn_Popup.Name = "iBtn_Popup";
            this.iBtn_Popup.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.iBtn_Popup.Size = new System.Drawing.Size(26, 26);
            this.iBtn_Popup.TabIndex = 1;
            // 
            // form_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(250, 293);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pnl_MarginRight);
            this.Controls.Add(this.pnl_MarginLeft);
            this.Controls.Add(this.pnl_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Status";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Status";
            this.pnl_Title.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnl_Title;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2ImageButton iBtn_Popup;
        private System.Windows.Forms.Panel pnl_MarginLeft;
        private System.Windows.Forms.Panel pnl_MarginRight;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2TextBox tBox_InMotion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox iBox_test;
        private Guna.UI2.WinForms.Guna2TextBox iBox_Login;
    }
}