namespace PersetionLayerCRM
{
    partial class UC_frmLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.PLicense = new System.Windows.Forms.Panel();
            this.PEnter = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.PictureBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PLicense.SuspendLayout();
            this.PEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // symbolBox1
            // 
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Location = new System.Drawing.Point(153, 16);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(140, 143);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.symbolBox1.TabIndex = 0;
            this.symbolBox1.Text = "symbolBox1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWelcome.Location = new System.Drawing.Point(40, 171);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWelcome.Size = new System.Drawing.Size(378, 18);
            this.lblWelcome.TabIndex = 47;
            this.lblWelcome.Text = "برای ورود به حساب کاربری اطلاعات خود را وارد نمایید\r\n";
            // 
            // PLicense
            // 
            this.PLicense.Controls.Add(this.PEnter);
            this.PLicense.Controls.Add(this.txtpassword);
            this.PLicense.Controls.Add(this.txtUsername);
            this.PLicense.Location = new System.Drawing.Point(8, 192);
            this.PLicense.Name = "PLicense";
            this.PLicense.Size = new System.Drawing.Size(446, 124);
            this.PLicense.TabIndex = 56;
            // 
            // PEnter
            // 
            this.PEnter.Controls.Add(this.btnEnter);
            this.PEnter.Controls.Add(this.lblEnter);
            this.PEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PEnter.Location = new System.Drawing.Point(41, 81);
            this.PEnter.Name = "PEnter";
            this.PEnter.Size = new System.Drawing.Size(128, 35);
            this.PEnter.TabIndex = 59;
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.btnEnter.Location = new System.Drawing.Point(7, 4);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(37, 27);
            this.btnEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEnter.TabIndex = 42;
            this.btnEnter.TabStop = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEnter.Location = new System.Drawing.Point(48, 10);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(77, 16);
            this.lblEnter.TabIndex = 43;
            this.lblEnter.Text = "ورود به حساب";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtpassword.Border.BackColor = System.Drawing.Color.Snow;
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpassword.Location = new System.Drawing.Point(41, 47);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PreventEnterBeep = true;
            this.txtpassword.Size = new System.Drawing.Size(358, 28);
            this.txtpassword.TabIndex = 58;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.WatermarkText = "کلمه عبور";
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtUsername.Border.BackColor = System.Drawing.Color.Snow;
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUsername.Location = new System.Drawing.Point(40, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PreventEnterBeep = true;
            this.txtUsername.Size = new System.Drawing.Size(358, 28);
            this.txtUsername.TabIndex = 57;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.WatermarkText = "نام کاربری";
            // 
            // UC_frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.PLicense);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.symbolBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_frmLogin";
            this.Size = new System.Drawing.Size(454, 517);
            this.PLicense.ResumeLayout(false);
            this.PEnter.ResumeLayout(false);
            this.PEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel PLicense;
        private System.Windows.Forms.Panel PEnter;
        private System.Windows.Forms.PictureBox btnEnter;
        private System.Windows.Forms.Label lblEnter;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
    }
}
