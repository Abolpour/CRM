namespace PersetionLayerCRM
{
    partial class FrmCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBAddCustomer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.GBSercheCustomer = new System.Windows.Forms.GroupBox();
            this.CBPhoneNumber = new System.Windows.Forms.CheckBox();
            this.CBNameAndFamily = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountCustomer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Update_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBack = new XanderUI.XUISuperButton();
            this.GBAddCustomer.SuspendLayout();
            this.GBSercheCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAddCustomer
            // 
            this.GBAddCustomer.Controls.Add(this.label2);
            this.GBAddCustomer.Controls.Add(this.btnInsert);
            this.GBAddCustomer.Controls.Add(this.txtName);
            this.GBAddCustomer.Controls.Add(this.txtPhoneNumber);
            this.GBAddCustomer.Controls.Add(this.label1);
            this.GBAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBAddCustomer.Location = new System.Drawing.Point(15, 2);
            this.GBAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.GBAddCustomer.Name = "GBAddCustomer";
            this.GBAddCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.GBAddCustomer.Size = new System.Drawing.Size(1099, 75);
            this.GBAddCustomer.TabIndex = 0;
            this.GBAddCustomer.TabStop = false;
            this.GBAddCustomer.Text = "افزدون مشتری جدید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "شماره تماس:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsert.ButtonImage = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.btnInsert.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsert.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsert.ButtonText = "ثبت اطلاعات";
            this.btnInsert.CornerRadius = 15;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsert.HoverTextColor = System.Drawing.Color.White;
            this.btnInsert.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnInsert.Location = new System.Drawing.Point(6, 26);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsert.Size = new System.Drawing.Size(125, 42);
            this.btnInsert.SuperSelected = false;
            this.btnInsert.TabIndex = 3;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtName.Border.BackColor = System.Drawing.Color.Snow;
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(636, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(348, 38);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtPhoneNumber.Border.BackColor = System.Drawing.Color.Snow;
            this.txtPhoneNumber.Border.Class = "TextBoxBorder";
            this.txtPhoneNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(180, 27);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PreventEnterBeep = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(348, 38);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(996, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام مشتری:";
            // 
            // GBSercheCustomer
            // 
            this.GBSercheCustomer.Controls.Add(this.CBPhoneNumber);
            this.GBSercheCustomer.Controls.Add(this.CBNameAndFamily);
            this.GBSercheCustomer.Controls.Add(this.label4);
            this.GBSercheCustomer.Controls.Add(this.txtSerch);
            this.GBSercheCustomer.Controls.Add(this.label6);
            this.GBSercheCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSercheCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBSercheCustomer.Location = new System.Drawing.Point(15, 76);
            this.GBSercheCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.GBSercheCustomer.Name = "GBSercheCustomer";
            this.GBSercheCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.GBSercheCustomer.Size = new System.Drawing.Size(1099, 78);
            this.GBSercheCustomer.TabIndex = 5;
            this.GBSercheCustomer.TabStop = false;
            this.GBSercheCustomer.Text = "جستجو پیشرفته";
            // 
            // CBPhoneNumber
            // 
            this.CBPhoneNumber.AutoSize = true;
            this.CBPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBPhoneNumber.Location = new System.Drawing.Point(8, 34);
            this.CBPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBPhoneNumber.Name = "CBPhoneNumber";
            this.CBPhoneNumber.Size = new System.Drawing.Size(90, 20);
            this.CBPhoneNumber.TabIndex = 7;
            this.CBPhoneNumber.Text = "شماره تماس";
            this.CBPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // CBNameAndFamily
            // 
            this.CBNameAndFamily.AutoSize = true;
            this.CBNameAndFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBNameAndFamily.Location = new System.Drawing.Point(138, 34);
            this.CBNameAndFamily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBNameAndFamily.Name = "CBNameAndFamily";
            this.CBNameAndFamily.Size = new System.Drawing.Size(118, 20);
            this.CBNameAndFamily.TabIndex = 6;
            this.CBNameAndFamily.Text = "نام و نام خانوادگی";
            this.CBNameAndFamily.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(308, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "بر اساس:";
            // 
            // txtSerch
            // 
            this.txtSerch.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtSerch.Border.BackColor = System.Drawing.Color.Snow;
            this.txtSerch.Border.Class = "TextBoxBorder";
            this.txtSerch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSerch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerch.Location = new System.Drawing.Point(387, 27);
            this.txtSerch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.PreventEnterBeep = true;
            this.txtSerch.Size = new System.Drawing.Size(602, 38);
            this.txtSerch.TabIndex = 2;
            this.txtSerch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerch.TextChanged += new System.EventHandler(this.txtSerch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(996, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "جست و جو:";
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomer.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Location = new System.Drawing.Point(15, 160);
            this.DgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCustomer.Size = new System.Drawing.Size(1099, 320);
            this.DgvCustomer.TabIndex = 6;
            this.DgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomer_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(919, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "تمام مشتریان تا این لجظه:";
            // 
            // lblCountCustomer
            // 
            this.lblCountCustomer.AutoSize = true;
            this.lblCountCustomer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCountCustomer.Location = new System.Drawing.Point(869, 497);
            this.lblCountCustomer.Name = "lblCountCustomer";
            this.lblCountCustomer.Size = new System.Drawing.Size(18, 19);
            this.lblCountCustomer.TabIndex = 9;
            this.lblCountCustomer.Text = "0\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(549, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "از";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(590, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "0\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(512, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "0\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(637, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "صفحه";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(433, 498);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "صفحه";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Update_TSMI,
            this.Delete_TSMI,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 54);
            // 
            // Update_TSMI
            // 
            this.Update_TSMI.Image = global::PersetionLayerCRM.Properties.Resources.Update;
            this.Update_TSMI.Name = "Update_TSMI";
            this.Update_TSMI.Size = new System.Drawing.Size(110, 22);
            this.Update_TSMI.Text = "ویرایش";
            this.Update_TSMI.Click += new System.EventHandler(this.Update_TSMI_Click);
            // 
            // Delete_TSMI
            // 
            this.Delete_TSMI.Image = global::PersetionLayerCRM.Properties.Resources.Delete;
            this.Delete_TSMI.Name = "Delete_TSMI";
            this.Delete_TSMI.Size = new System.Drawing.Size(110, 22);
            this.Delete_TSMI.Text = "حذف";
            this.Delete_TSMI.Click += new System.EventHandler(this.Delete_TSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.ButtonImage = global::PersetionLayerCRM.Properties.Resources.Back;
            this.btnBack.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnBack.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnBack.ButtonText = "بازگشت";
            this.btnBack.CornerRadius = 15;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(20, 485);
            this.btnBack.Name = "btnBack";
            this.btnBack.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.SelectedTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(125, 42);
            this.btnBack.SuperSelected = false;
            this.btnBack.TabIndex = 17;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1126, 534);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCountCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvCustomer);
            this.Controls.Add(this.GBSercheCustomer);
            this.Controls.Add(this.GBAddCustomer);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCustomer_KeyUp);
            this.GBAddCustomer.ResumeLayout(false);
            this.GBAddCustomer.PerformLayout();
            this.GBSercheCustomer.ResumeLayout(false);
            this.GBSercheCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumber;
        private System.Windows.Forms.GroupBox GBSercheCustomer;
        private System.Windows.Forms.CheckBox CBPhoneNumber;
        private System.Windows.Forms.CheckBox CBNameAndFamily;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Update_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Delete_TSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private XanderUI.XUISuperButton btnInsert;
        private XanderUI.XUISuperButton btnBack;
    }
}