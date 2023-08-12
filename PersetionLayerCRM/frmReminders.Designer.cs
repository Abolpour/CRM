namespace PersetionLayerCRM
{
    partial class frmReminders
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
            this.GBSercheCustomer = new System.Windows.Forms.GroupBox();
            this.CBPhoneNumber = new System.Windows.Forms.CheckBox();
            this.CBNameAndFamily = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.GBAddCustomer = new System.Windows.Forms.GroupBox();
            this.PBInsertUserName = new System.Windows.Forms.PictureBox();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSerchUser_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtReminderInfo = new System.Windows.Forms.RichTextBox();
            this.PBInsert = new System.Windows.Forms.PictureBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtTitile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انجامشدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PBBack = new System.Windows.Forms.PictureBox();
            this.GBSercheCustomer.SuspendLayout();
            this.GBAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsertUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).BeginInit();
            this.SuspendLayout();
            // 
            // GBSercheCustomer
            // 
            this.GBSercheCustomer.Controls.Add(this.CBPhoneNumber);
            this.GBSercheCustomer.Controls.Add(this.CBNameAndFamily);
            this.GBSercheCustomer.Controls.Add(this.label4);
            this.GBSercheCustomer.Controls.Add(this.txtSerch);
            this.GBSercheCustomer.Controls.Add(this.label6);
            this.GBSercheCustomer.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSercheCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBSercheCustomer.Location = new System.Drawing.Point(13, 109);
            this.GBSercheCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBSercheCustomer.Name = "GBSercheCustomer";
            this.GBSercheCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBSercheCustomer.Size = new System.Drawing.Size(974, 78);
            this.GBSercheCustomer.TabIndex = 23;
            this.GBSercheCustomer.TabStop = false;
            this.GBSercheCustomer.Text = "جستجو پیشرفته";
            // 
            // CBPhoneNumber
            // 
            this.CBPhoneNumber.AutoSize = true;
            this.CBPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPhoneNumber.Location = new System.Drawing.Point(8, 32);
            this.CBPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.CBPhoneNumber.Name = "CBPhoneNumber";
            this.CBPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.CBPhoneNumber.TabIndex = 7;
            this.CBPhoneNumber.Text = "موضوع یادآوری";
            this.CBPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // CBNameAndFamily
            // 
            this.CBNameAndFamily.AutoSize = true;
            this.CBNameAndFamily.Location = new System.Drawing.Point(188, 32);
            this.CBNameAndFamily.Margin = new System.Windows.Forms.Padding(4);
            this.CBNameAndFamily.Name = "CBNameAndFamily";
            this.CBNameAndFamily.Size = new System.Drawing.Size(82, 26);
            this.CBNameAndFamily.TabIndex = 6;
            this.CBNameAndFamily.Text = "نام کاربری";
            this.CBNameAndFamily.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(312, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
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
            this.txtSerch.Location = new System.Drawing.Point(383, 25);
            this.txtSerch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.PreventEnterBeep = true;
            this.txtSerch.Size = new System.Drawing.Size(583, 37);
            this.txtSerch.TabIndex = 2;
            this.txtSerch.TextChanged += new System.EventHandler(this.txtSerch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(1032, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "جست و جو:";
            // 
            // GBAddCustomer
            // 
            this.GBAddCustomer.Controls.Add(this.PBInsertUserName);
            this.GBAddCustomer.Controls.Add(this.dateTimeInput1);
            this.GBAddCustomer.Controls.Add(this.txtSerchUser_Name);
            this.GBAddCustomer.Controls.Add(this.txtReminderInfo);
            this.GBAddCustomer.Controls.Add(this.PBInsert);
            this.GBAddCustomer.Controls.Add(this.lblInsert);
            this.GBAddCustomer.Controls.Add(this.txtTitile);
            this.GBAddCustomer.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBAddCustomer.Location = new System.Drawing.Point(13, 1);
            this.GBAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBAddCustomer.Name = "GBAddCustomer";
            this.GBAddCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBAddCustomer.Size = new System.Drawing.Size(974, 108);
            this.GBAddCustomer.TabIndex = 22;
            this.GBAddCustomer.TabStop = false;
            this.GBAddCustomer.Text = "افزدون مشتری جدید";
            // 
            // PBInsertUserName
            // 
            this.PBInsertUserName.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.PBInsertUserName.Location = new System.Drawing.Point(642, 25);
            this.PBInsertUserName.Margin = new System.Windows.Forms.Padding(4);
            this.PBInsertUserName.Name = "PBInsertUserName";
            this.PBInsertUserName.Size = new System.Drawing.Size(42, 33);
            this.PBInsertUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInsertUserName.TabIndex = 21;
            this.PBInsertUserName.TabStop = false;
            this.PBInsertUserName.Click += new System.EventHandler(this.PBInsertUserName_Click);
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(8, 25);
            this.dateTimeInput1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(157, 29);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 20;
            this.dateTimeInput1.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.dateTimeInput1.WatermarkColor = System.Drawing.SystemColors.ControlText;
            // 
            // txtSerchUser_Name
            // 
            this.txtSerchUser_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSerchUser_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSerchUser_Name.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtSerchUser_Name.Border.BackColor = System.Drawing.Color.Snow;
            this.txtSerchUser_Name.Border.Class = "TextBoxBorder";
            this.txtSerchUser_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSerchUser_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerchUser_Name.Location = new System.Drawing.Point(692, 25);
            this.txtSerchUser_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerchUser_Name.Name = "txtSerchUser_Name";
            this.txtSerchUser_Name.PreventEnterBeep = true;
            this.txtSerchUser_Name.Size = new System.Drawing.Size(274, 31);
            this.txtSerchUser_Name.TabIndex = 10;
            this.txtSerchUser_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerchUser_Name.WatermarkText = "جستجو کاربر براساس نام ";
            // 
            // txtReminderInfo
            // 
            this.txtReminderInfo.Location = new System.Drawing.Point(172, 27);
            this.txtReminderInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtReminderInfo.Name = "txtReminderInfo";
            this.txtReminderInfo.Size = new System.Drawing.Size(462, 73);
            this.txtReminderInfo.TabIndex = 9;
            this.txtReminderInfo.Text = "";
            // 
            // PBInsert
            // 
            this.PBInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBInsert.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.PBInsert.Location = new System.Drawing.Point(8, 66);
            this.PBInsert.Margin = new System.Windows.Forms.Padding(4);
            this.PBInsert.Name = "PBInsert";
            this.PBInsert.Size = new System.Drawing.Size(42, 33);
            this.PBInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInsert.TabIndex = 8;
            this.PBInsert.TabStop = false;
            this.PBInsert.Click += new System.EventHandler(this.PBInsert_Click);
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInsert.Location = new System.Drawing.Point(66, 74);
            this.lblInsert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(77, 22);
            this.lblInsert.TabIndex = 4;
            this.lblInsert.Text = "ثبت اطلاعات";
            // 
            // txtTitile
            // 
            this.txtTitile.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtTitile.Border.BackColor = System.Drawing.Color.Snow;
            this.txtTitile.Border.Class = "TextBoxBorder";
            this.txtTitile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTitile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitile.Location = new System.Drawing.Point(642, 66);
            this.txtTitile.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitile.Name = "txtTitile";
            this.txtTitile.PreventEnterBeep = true;
            this.txtTitile.Size = new System.Drawing.Size(324, 31);
            this.txtTitile.TabIndex = 1;
            this.txtTitile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitile.WatermarkText = "موضوع یادآور";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(357, 608);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 14);
            this.label13.TabIndex = 43;
            this.label13.Text = "صفحه";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(568, 608);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 14);
            this.label12.TabIndex = 42;
            this.label12.Text = "صفحه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(438, 608);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 14);
            this.label11.TabIndex = 41;
            this.label11.Text = "0\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(519, 608);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 14);
            this.label10.TabIndex = 40;
            this.label10.Text = "0\r\n";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBack.Location = new System.Drawing.Point(70, 608);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(128, 14);
            this.lblBack.TabIndex = 39;
            this.lblBack.Text = "بازگشت به صفحه اصلی";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(477, 608);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "از";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(722, 612);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "0\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(763, 612);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "تعداد کل یادآورهای انجام نشده در این لحظه";
            // 
            // dgvReminder
            // 
            this.dgvReminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReminder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminder.Location = new System.Drawing.Point(13, 196);
            this.dgvReminder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.Size = new System.Drawing.Size(974, 398);
            this.dgvReminder.TabIndex = 34;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.انجامشدToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 70);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::PersetionLayerCRM.Properties.Resources.Update;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::PersetionLayerCRM.Properties.Resources.Delete;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // انجامشدToolStripMenuItem
            // 
            this.انجامشدToolStripMenuItem.Image = global::PersetionLayerCRM.Properties.Resources.Done;
            this.انجامشدToolStripMenuItem.Name = "انجامشدToolStripMenuItem";
            this.انجامشدToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.انجامشدToolStripMenuItem.Text = "انجام شد";
            // 
            // PBBack
            // 
            this.PBBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBBack.Image = global::PersetionLayerCRM.Properties.Resources.Back;
            this.PBBack.Location = new System.Drawing.Point(14, 601);
            this.PBBack.Margin = new System.Windows.Forms.Padding(4);
            this.PBBack.Name = "PBBack";
            this.PBBack.Size = new System.Drawing.Size(49, 28);
            this.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBack.TabIndex = 36;
            this.PBBack.TabStop = false;
            this.PBBack.Click += new System.EventHandler(this.PBBack_Click);
            // 
            // frmReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1003, 635);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PBBack);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvReminder);
            this.Controls.Add(this.GBSercheCustomer);
            this.Controls.Add(this.GBAddCustomer);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReminders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReminders";
            this.Load += new System.EventHandler(this.frmReminders_Load);
            this.GBSercheCustomer.ResumeLayout(false);
            this.GBSercheCustomer.PerformLayout();
            this.GBAddCustomer.ResumeLayout(false);
            this.GBAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsertUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSercheCustomer;
        private System.Windows.Forms.CheckBox CBPhoneNumber;
        private System.Windows.Forms.CheckBox CBNameAndFamily;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBAddCustomer;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerchUser_Name;
        private System.Windows.Forms.RichTextBox txtReminderInfo;
        private System.Windows.Forms.PictureBox PBInsert;
        private System.Windows.Forms.Label lblInsert;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PBBack;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.PictureBox PBInsertUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انجامشدToolStripMenuItem;
    }
}