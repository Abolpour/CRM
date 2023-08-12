namespace PersetionLayerCRM
{
    partial class frmLogin
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
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.PBack = new System.Windows.Forms.Panel();
            this.PBBack = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.PBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.progressBarX1.Location = new System.Drawing.Point(4, 511);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(974, 23);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.progressBarX1.TabIndex = 0;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // PBack
            // 
            this.PBack.Controls.Add(this.PBBack);
            this.PBack.Controls.Add(this.lblBack);
            this.PBack.Location = new System.Drawing.Point(4, 499);
            this.PBack.Name = "PBack";
            this.PBack.Size = new System.Drawing.Size(176, 35);
            this.PBack.TabIndex = 1;
            this.PBack.Visible = false;
            // 
            // PBBack
            // 
            this.PBBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBBack.Image = global::PersetionLayerCRM.Properties.Resources.Back;
            this.PBBack.Location = new System.Drawing.Point(4, 4);
            this.PBBack.Margin = new System.Windows.Forms.Padding(4);
            this.PBBack.Name = "PBBack";
            this.PBBack.Size = new System.Drawing.Size(37, 27);
            this.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBack.TabIndex = 42;
            this.PBBack.TabStop = false;
            this.PBBack.Click += new System.EventHandler(this.PBBack_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBack.Location = new System.Drawing.Point(43, 10);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(129, 16);
            this.lblBack.TabIndex = 43;
            this.lblBack.Text = "انصراف و خروج از برنامه";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLoad.Location = new System.Drawing.Point(402, 492);
            this.lblLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoad.Size = new System.Drawing.Size(203, 16);
            this.lblLoad.TabIndex = 44;
            this.lblLoad.Text = "درحال بارگذاری اطلاعات برنامه...";
            this.lblLoad.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWelcome.Location = new System.Drawing.Point(365, 221);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWelcome.Size = new System.Drawing.Size(240, 16);
            this.lblWelcome.TabIndex = 45;
            this.lblWelcome.Text = "به نرم افزار مدیریت مشتریان خوش آمدین";
            this.lblWelcome.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(981, 537);
            this.Controls.Add(this.PBack);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblLoad);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.PBack.ResumeLayout(false);
            this.PBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.Panel PBack;
        private System.Windows.Forms.PictureBox PBBack;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblWelcome;
    }
}