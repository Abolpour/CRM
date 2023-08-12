namespace PersetionLayerCRM
{
    partial class frmMsgBox
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
            this.lblTitleMassageSample = new System.Windows.Forms.Label();
            this.lblErrorPerstion = new System.Windows.Forms.Label();
            this.lblErrorEnglish = new System.Windows.Forms.Label();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnYes = new DevComponents.DotNetBar.ButtonX();
            this.PBMsg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleMassageSample
            // 
            this.lblTitleMassageSample.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMassageSample.ForeColor = System.Drawing.Color.Snow;
            this.lblTitleMassageSample.Location = new System.Drawing.Point(12, 14);
            this.lblTitleMassageSample.Name = "lblTitleMassageSample";
            this.lblTitleMassageSample.Size = new System.Drawing.Size(303, 24);
            this.lblTitleMassageSample.TabIndex = 0;
            this.lblTitleMassageSample.Text = "موضوع پیغام نمونه";
            this.lblTitleMassageSample.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblErrorPerstion
            // 
            this.lblErrorPerstion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPerstion.ForeColor = System.Drawing.Color.Snow;
            this.lblErrorPerstion.Location = new System.Drawing.Point(13, 51);
            this.lblErrorPerstion.Name = "lblErrorPerstion";
            this.lblErrorPerstion.Size = new System.Drawing.Size(351, 58);
            this.lblErrorPerstion.TabIndex = 2;
            this.lblErrorPerstion.Text = "موضوع پیغام نمونه";
            this.lblErrorPerstion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblErrorEnglish
            // 
            this.lblErrorEnglish.Font = new System.Drawing.Font("IRANSansWeb", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEnglish.ForeColor = System.Drawing.Color.Snow;
            this.lblErrorEnglish.Location = new System.Drawing.Point(12, 121);
            this.lblErrorEnglish.Name = "lblErrorEnglish";
            this.lblErrorEnglish.Size = new System.Drawing.Size(351, 44);
            this.lblErrorEnglish.TabIndex = 3;
            this.lblErrorEnglish.Text = "Error Or Message Detalis...";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(3, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnYes
            // 
            this.btnYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYes.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(84, 190);
            this.btnYes.Name = "btnYes";
            this.btnYes.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "بله";
            this.btnYes.TextColor = System.Drawing.Color.White;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // PBMsg
            // 
            this.PBMsg.Image = global::PersetionLayerCRM.Properties.Resources.info;
            this.PBMsg.Location = new System.Drawing.Point(321, 12);
            this.PBMsg.Name = "PBMsg";
            this.PBMsg.Size = new System.Drawing.Size(42, 35);
            this.PBMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMsg.TabIndex = 1;
            this.PBMsg.TabStop = false;
            // 
            // frmMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(375, 225);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblErrorEnglish);
            this.Controls.Add(this.lblErrorPerstion);
            this.Controls.Add(this.PBMsg);
            this.Controls.Add(this.lblTitleMassageSample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMsgBox";
            ((System.ComponentModel.ISupportInitialize)(this.PBMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTitleMassageSample;
        public System.Windows.Forms.Label lblErrorPerstion;
        public System.Windows.Forms.Label lblErrorEnglish;
        public DevComponents.DotNetBar.ButtonX btnClose;
        public DevComponents.DotNetBar.ButtonX btnYes;
        public System.Windows.Forms.PictureBox PBMsg;
    }
}