
namespace AutoStockTrading
{
    partial class form_Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Splash));
            this.GCircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // GCircleProgressBar
            // 
            this.GCircleProgressBar.AnimationSpeed = 0.1F;
            this.GCircleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.GCircleProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.GCircleProgressBar.FillThickness = 12;
            this.GCircleProgressBar.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCircleProgressBar.ForeColor = System.Drawing.Color.White;
            this.GCircleProgressBar.Location = new System.Drawing.Point(75, 185);
            this.GCircleProgressBar.Minimum = 0;
            this.GCircleProgressBar.Name = "GCircleProgressBar";
            this.GCircleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GCircleProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GCircleProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.GCircleProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.GCircleProgressBar.ProgressThickness = 12;
            this.GCircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GCircleProgressBar.ShowText = true;
            this.GCircleProgressBar.Size = new System.Drawing.Size(183, 183);
            this.GCircleProgressBar.TabIndex = 30;
            this.GCircleProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.GCircleProgressBar.Value = 10;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(113, 399);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(114, 14);
            this.guna2HtmlLabel1.TabIndex = 31;
            this.guna2HtmlLabel1.Text = "Copyright, Ver 1.0.0";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(39, 44);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(255, 27);
            this.guna2HtmlLabel2.TabIndex = 32;
            this.guna2HtmlLabel2.Text = "Kiwoom Auto Stock Trading";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(75, 77);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(196, 102);
            this.guna2ImageButton1.TabIndex = 33;
            // 
            // form_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(336, 464);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.GCircleProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar GCircleProgressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}