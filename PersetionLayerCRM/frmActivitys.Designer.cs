namespace PersetionLayerCRM
{
    partial class frmActivitys
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
            this.GBAddCustomer = new System.Windows.Forms.GroupBox();
            this.pbInsertActivitys = new System.Windows.Forms.PictureBox();
            this.txtNameAc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDateTimeActivitys = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbActivity = new System.Windows.Forms.CheckBox();
            this.txtTitleActivitys = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pbInsertUser = new System.Windows.Forms.PictureBox();
            this.pbInsertCustomer = new System.Windows.Forms.PictureBox();
            this.txtNameUserSerching = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pbInsert = new System.Windows.Forms.PictureBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtPhoneNumberSerching = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripstion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GBSercheCustomer = new System.Windows.Forms.GroupBox();
            this.CBPhoneNumber = new System.Windows.Forms.CheckBox();
            this.CBNameAndFamily = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvActivty = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDescriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.PBBack = new System.Windows.Forms.PictureBox();
            this.GBAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertActivitys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateTimeActivitys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsert)).BeginInit();
            this.GBSercheCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivty)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).BeginInit();
            this.SuspendLayout();
            // 
            // GBAddCustomer
            // 
            this.GBAddCustomer.Controls.Add(this.pbInsertActivitys);
            this.GBAddCustomer.Controls.Add(this.txtNameAc);
            this.GBAddCustomer.Controls.Add(this.txtDateTimeActivitys);
            this.GBAddCustomer.Controls.Add(this.cbActivity);
            this.GBAddCustomer.Controls.Add(this.txtTitleActivitys);
            this.GBAddCustomer.Controls.Add(this.pbInsertUser);
            this.GBAddCustomer.Controls.Add(this.pbInsertCustomer);
            this.GBAddCustomer.Controls.Add(this.txtNameUserSerching);
            this.GBAddCustomer.Controls.Add(this.pbInsert);
            this.GBAddCustomer.Controls.Add(this.lblInsert);
            this.GBAddCustomer.Controls.Add(this.txtPhoneNumberSerching);
            this.GBAddCustomer.Controls.Add(this.txtDescripstion);
            this.GBAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBAddCustomer.Location = new System.Drawing.Point(13, 14);
            this.GBAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBAddCustomer.Name = "GBAddCustomer";
            this.GBAddCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBAddCustomer.Size = new System.Drawing.Size(968, 209);
            this.GBAddCustomer.TabIndex = 1;
            this.GBAddCustomer.TabStop = false;
            this.GBAddCustomer.Text = "افزدون فعالیت جدید";
            // 
            // pbInsertActivitys
            // 
            this.pbInsertActivitys.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.pbInsertActivitys.Location = new System.Drawing.Point(636, 119);
            this.pbInsertActivitys.Name = "pbInsertActivitys";
            this.pbInsertActivitys.Size = new System.Drawing.Size(39, 39);
            this.pbInsertActivitys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsertActivitys.TabIndex = 21;
            this.pbInsertActivitys.TabStop = false;
            this.pbInsertActivitys.Click += new System.EventHandler(this.pbInsertActivitys_Click);
            // 
            // txtNameAc
            // 
            this.txtNameAc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNameAc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNameAc.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtNameAc.Border.BackColor = System.Drawing.Color.Snow;
            this.txtNameAc.Border.Class = "TextBoxBorder";
            this.txtNameAc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtNameAc.Location = new System.Drawing.Point(682, 119);
            this.txtNameAc.Name = "txtNameAc";
            this.txtNameAc.PreventEnterBeep = true;
            this.txtNameAc.Size = new System.Drawing.Size(281, 30);
            this.txtNameAc.TabIndex = 20;
            this.txtNameAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameAc.WatermarkText = "دسته بندی فعالیت";
            // 
            // txtDateTimeActivitys
            // 
            // 
            // 
            // 
            this.txtDateTimeActivitys.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDateTimeActivitys.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDateTimeActivitys.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDateTimeActivitys.ButtonDropDown.Visible = true;
            this.txtDateTimeActivitys.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDateTimeActivitys.IsPopupCalendarOpen = false;
            this.txtDateTimeActivitys.Location = new System.Drawing.Point(164, 162);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtDateTimeActivitys.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDateTimeActivitys.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtDateTimeActivitys.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDateTimeActivitys.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDateTimeActivitys.MonthCalendar.DisplayMonth = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.txtDateTimeActivitys.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDateTimeActivitys.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDateTimeActivitys.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDateTimeActivitys.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDateTimeActivitys.MonthCalendar.TodayButtonVisible = true;
            this.txtDateTimeActivitys.Name = "txtDateTimeActivitys";
            this.txtDateTimeActivitys.Size = new System.Drawing.Size(226, 22);
            this.txtDateTimeActivitys.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtDateTimeActivitys.TabIndex = 19;
            this.txtDateTimeActivitys.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtDateTimeActivitys.WatermarkColor = System.Drawing.SystemColors.ControlText;
            // 
            // cbActivity
            // 
            this.cbActivity.AutoSize = true;
            this.cbActivity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivity.Location = new System.Drawing.Point(386, 170);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(248, 23);
            this.cbActivity.TabIndex = 14;
            this.cbActivity.Text = "برای این فعالیت یادآور تنظیم کنید";
            this.cbActivity.UseVisualStyleBackColor = true;
            // 
            // txtTitleActivitys
            // 
            this.txtTitleActivitys.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtTitleActivitys.Border.BackColor = System.Drawing.Color.Snow;
            this.txtTitleActivitys.Border.Class = "TextBoxBorder";
            this.txtTitleActivitys.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTitleActivitys.Location = new System.Drawing.Point(640, 162);
            this.txtTitleActivitys.Name = "txtTitleActivitys";
            this.txtTitleActivitys.PreventEnterBeep = true;
            this.txtTitleActivitys.Size = new System.Drawing.Size(323, 30);
            this.txtTitleActivitys.TabIndex = 13;
            this.txtTitleActivitys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitleActivitys.WatermarkText = "موضوع فعالیت";
            // 
            // pbInsertUser
            // 
            this.pbInsertUser.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.pbInsertUser.Location = new System.Drawing.Point(636, 73);
            this.pbInsertUser.Name = "pbInsertUser";
            this.pbInsertUser.Size = new System.Drawing.Size(39, 39);
            this.pbInsertUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsertUser.TabIndex = 11;
            this.pbInsertUser.TabStop = false;
            this.pbInsertUser.Click += new System.EventHandler(this.pbInsertUser_Click);
            // 
            // pbInsertCustomer
            // 
            this.pbInsertCustomer.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.pbInsertCustomer.Location = new System.Drawing.Point(636, 28);
            this.pbInsertCustomer.Name = "pbInsertCustomer";
            this.pbInsertCustomer.Size = new System.Drawing.Size(39, 39);
            this.pbInsertCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsertCustomer.TabIndex = 10;
            this.pbInsertCustomer.TabStop = false;
            this.pbInsertCustomer.Click += new System.EventHandler(this.pbInsertCustomer_Click);
            // 
            // txtNameUserSerching
            // 
            this.txtNameUserSerching.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNameUserSerching.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNameUserSerching.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtNameUserSerching.Border.BackColor = System.Drawing.Color.Snow;
            this.txtNameUserSerching.Border.Class = "TextBoxBorder";
            this.txtNameUserSerching.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtNameUserSerching.Location = new System.Drawing.Point(681, 73);
            this.txtNameUserSerching.Name = "txtNameUserSerching";
            this.txtNameUserSerching.PreventEnterBeep = true;
            this.txtNameUserSerching.Size = new System.Drawing.Size(281, 30);
            this.txtNameUserSerching.TabIndex = 9;
            this.txtNameUserSerching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameUserSerching.WatermarkText = "جستجو کاربر براساس نام کاربری\r\n";
            // 
            // pbInsert
            // 
            this.pbInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInsert.Image = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.pbInsert.Location = new System.Drawing.Point(7, 167);
            this.pbInsert.Name = "pbInsert";
            this.pbInsert.Size = new System.Drawing.Size(36, 26);
            this.pbInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInsert.TabIndex = 8;
            this.pbInsert.TabStop = false;
            this.pbInsert.Click += new System.EventHandler(this.pbInsert_Click);
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInsert.Location = new System.Drawing.Point(44, 169);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(86, 16);
            this.lblInsert.TabIndex = 4;
            this.lblInsert.Text = "ثبت فعالیت جدید";
            // 
            // txtPhoneNumberSerching
            // 
            this.txtPhoneNumberSerching.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPhoneNumberSerching.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhoneNumberSerching.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtPhoneNumberSerching.Border.BackColor = System.Drawing.Color.Snow;
            this.txtPhoneNumberSerching.Border.Class = "TextBoxBorder";
            this.txtPhoneNumberSerching.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPhoneNumberSerching.Location = new System.Drawing.Point(681, 28);
            this.txtPhoneNumberSerching.Name = "txtPhoneNumberSerching";
            this.txtPhoneNumberSerching.PreventEnterBeep = true;
            this.txtPhoneNumberSerching.Size = new System.Drawing.Size(281, 30);
            this.txtPhoneNumberSerching.TabIndex = 2;
            this.txtPhoneNumberSerching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumberSerching.WatermarkText = "جستجو مشتری براساس شماره تماس";
            // 
            // txtDescripstion
            // 
            this.txtDescripstion.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtDescripstion.Border.BackColor = System.Drawing.Color.Snow;
            this.txtDescripstion.Border.Class = "TextBoxBorder";
            this.txtDescripstion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtDescripstion.Location = new System.Drawing.Point(7, 28);
            this.txtDescripstion.Multiline = true;
            this.txtDescripstion.Name = "txtDescripstion";
            this.txtDescripstion.PreventEnterBeep = true;
            this.txtDescripstion.Size = new System.Drawing.Size(623, 124);
            this.txtDescripstion.TabIndex = 1;
            this.txtDescripstion.WatermarkText = "توضیحات فعالیت را وارد کنید";
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
            this.GBSercheCustomer.Location = new System.Drawing.Point(13, 224);
            this.GBSercheCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBSercheCustomer.Name = "GBSercheCustomer";
            this.GBSercheCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GBSercheCustomer.Size = new System.Drawing.Size(968, 69);
            this.GBSercheCustomer.TabIndex = 20;
            this.GBSercheCustomer.TabStop = false;
            this.GBSercheCustomer.Text = "جستجو پیشرفته";
            // 
            // CBPhoneNumber
            // 
            this.CBPhoneNumber.AutoSize = true;
            this.CBPhoneNumber.Location = new System.Drawing.Point(22, 29);
            this.CBPhoneNumber.Name = "CBPhoneNumber";
            this.CBPhoneNumber.Size = new System.Drawing.Size(79, 20);
            this.CBPhoneNumber.TabIndex = 7;
            this.CBPhoneNumber.Text = "نام مشتری";
            this.CBPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // CBNameAndFamily
            // 
            this.CBNameAndFamily.AutoSize = true;
            this.CBNameAndFamily.Location = new System.Drawing.Point(147, 29);
            this.CBNameAndFamily.Name = "CBNameAndFamily";
            this.CBNameAndFamily.Size = new System.Drawing.Size(73, 20);
            this.CBNameAndFamily.TabIndex = 6;
            this.CBNameAndFamily.Text = "نام کاربر";
            this.CBNameAndFamily.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(247, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
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
            this.txtSerch.Location = new System.Drawing.Point(316, 23);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.PreventEnterBeep = true;
            this.txtSerch.Size = new System.Drawing.Size(562, 30);
            this.txtSerch.TabIndex = 2;
            this.txtSerch.TextChanged += new System.EventHandler(this.txtSerch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(885, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "جست و جو:";
            // 
            // dgvActivty
            // 
            this.dgvActivty.AllowUserToAddRows = false;
            this.dgvActivty.AllowUserToDeleteRows = false;
            this.dgvActivty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivty.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivty.Location = new System.Drawing.Point(12, 301);
            this.dgvActivty.Name = "dgvActivty";
            this.dgvActivty.ReadOnly = true;
            this.dgvActivty.Size = new System.Drawing.Size(969, 209);
            this.dgvActivty.TabIndex = 8;
            this.dgvActivty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivty_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(373, 522);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "صفحه";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(554, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "صفحه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(443, 522);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "0\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(512, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "0\r\n";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBack.Location = new System.Drawing.Point(57, 521);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(113, 13);
            this.lblBack.TabIndex = 25;
            this.lblBack.Text = "بازگشت به صفحه اصلی";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(476, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "از";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(818, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "0\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(860, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "تمام مشتریان تا این لجظه:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDescriptions,
            this.DeleteCMS});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // showDescriptions
            // 
            this.showDescriptions.Image = global::PersetionLayerCRM.Properties.Resources.InfoBlack;
            this.showDescriptions.Name = "showDescriptions";
            this.showDescriptions.Size = new System.Drawing.Size(136, 22);
            this.showDescriptions.Text = "نمایش جزٍییات";
            this.showDescriptions.Click += new System.EventHandler(this.showDescriptions_Click);
            // 
            // DeleteCMS
            // 
            this.DeleteCMS.Image = global::PersetionLayerCRM.Properties.Resources.Delete;
            this.DeleteCMS.Name = "DeleteCMS";
            this.DeleteCMS.Size = new System.Drawing.Size(136, 22);
            this.DeleteCMS.Text = "حذف";
            this.DeleteCMS.Click += new System.EventHandler(this.DeleteCMS_Click);
            // 
            // PBBack
            // 
            this.PBBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBBack.Image = global::PersetionLayerCRM.Properties.Resources.Back;
            this.PBBack.Location = new System.Drawing.Point(15, 517);
            this.PBBack.Name = "PBBack";
            this.PBBack.Size = new System.Drawing.Size(36, 22);
            this.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBack.TabIndex = 22;
            this.PBBack.TabStop = false;
            this.PBBack.Click += new System.EventHandler(this.PBBack_Click);
            // 
            // frmActivitys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(985, 551);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PBBack);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvActivty);
            this.Controls.Add(this.GBSercheCustomer);
            this.Controls.Add(this.GBAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActivitys";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmActivitys";
            this.Load += new System.EventHandler(this.frmActivitys_Load);
            this.GBAddCustomer.ResumeLayout(false);
            this.GBAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertActivitys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateTimeActivitys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsert)).EndInit();
            this.GBSercheCustomer.ResumeLayout(false);
            this.GBSercheCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivty)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAddCustomer;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDateTimeActivitys;
        private System.Windows.Forms.CheckBox cbActivity;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitleActivitys;
        private System.Windows.Forms.PictureBox pbInsertUser;
        private System.Windows.Forms.PictureBox pbInsertCustomer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameUserSerching;
        private System.Windows.Forms.PictureBox pbInsert;
        private System.Windows.Forms.Label lblInsert;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumberSerching;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripstion;
        private System.Windows.Forms.GroupBox GBSercheCustomer;
        private System.Windows.Forms.CheckBox CBPhoneNumber;
        private System.Windows.Forms.CheckBox CBNameAndFamily;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvActivty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PBBack;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDescriptions;
        private System.Windows.Forms.ToolStripMenuItem DeleteCMS;
        private System.Windows.Forms.PictureBox pbInsertActivitys;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameAc;
    }
}