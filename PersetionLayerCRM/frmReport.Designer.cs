namespace PersetionLayerCRM
{
    partial class frmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GBSercheCustomer = new System.Windows.Forms.GroupBox();
            this.btnPrintReport = new XanderUI.XUIButton();
            this.RBListOldYear = new System.Windows.Forms.RadioButton();
            this.RBListOldMonth = new System.Windows.Forms.RadioButton();
            this.RbInvoicesOldWeek = new System.Windows.Forms.RadioButton();
            this.RBActivitys = new System.Windows.Forms.RadioButton();
            this.RBCustomerList = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowReportResultDisigning = new XanderUI.XUIButton();
            this.btnPrintReportDate = new XanderUI.XUIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.MaskedTextBox();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.RBSellsUser = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBBack = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GBSercheCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBSercheCustomer
            // 
            this.GBSercheCustomer.Controls.Add(this.btnPrintReport);
            this.GBSercheCustomer.Controls.Add(this.RBListOldYear);
            this.GBSercheCustomer.Controls.Add(this.RBListOldMonth);
            this.GBSercheCustomer.Controls.Add(this.RbInvoicesOldWeek);
            this.GBSercheCustomer.Controls.Add(this.RBActivitys);
            this.GBSercheCustomer.Controls.Add(this.RBCustomerList);
            this.GBSercheCustomer.Controls.Add(this.label2);
            this.GBSercheCustomer.Controls.Add(this.label6);
            this.GBSercheCustomer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSercheCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.GBSercheCustomer.Location = new System.Drawing.Point(735, 4);
            this.GBSercheCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.GBSercheCustomer.Name = "GBSercheCustomer";
            this.GBSercheCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.GBSercheCustomer.Size = new System.Drawing.Size(377, 256);
            this.GBSercheCustomer.TabIndex = 6;
            this.GBSercheCustomer.TabStop = false;
            this.GBSercheCustomer.Text = "گزارش چابی";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrintReport.ButtonImage = global::PersetionLayerCRM.Properties.Resources.print;
            this.btnPrintReport.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPrintReport.ButtonText = "چاپ گذارش";
            this.btnPrintReport.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPrintReport.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.CornerRadius = 20;
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReport.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrintReport.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPrintReport.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPrintReport.Location = new System.Drawing.Point(7, 210);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(137, 39);
            this.btnPrintReport.TabIndex = 36;
            this.btnPrintReport.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReport.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // RBListOldYear
            // 
            this.RBListOldYear.AutoSize = true;
            this.RBListOldYear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBListOldYear.Location = new System.Drawing.Point(204, 202);
            this.RBListOldYear.Name = "RBListOldYear";
            this.RBListOldYear.Size = new System.Drawing.Size(166, 20);
            this.RBListOldYear.TabIndex = 6;
            this.RBListOldYear.TabStop = true;
            this.RBListOldYear.Text = "لیست فروش سال گذشته";
            this.RBListOldYear.UseVisualStyleBackColor = true;
            // 
            // RBListOldMonth
            // 
            this.RBListOldMonth.AutoSize = true;
            this.RBListOldMonth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBListOldMonth.Location = new System.Drawing.Point(212, 165);
            this.RBListOldMonth.Name = "RBListOldMonth";
            this.RBListOldMonth.Size = new System.Drawing.Size(158, 20);
            this.RBListOldMonth.TabIndex = 5;
            this.RBListOldMonth.TabStop = true;
            this.RBListOldMonth.Text = "لیست فروش ماه گذشته";
            this.RBListOldMonth.UseVisualStyleBackColor = true;
            // 
            // RbInvoicesOldWeek
            // 
            this.RbInvoicesOldWeek.AutoSize = true;
            this.RbInvoicesOldWeek.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbInvoicesOldWeek.Location = new System.Drawing.Point(201, 128);
            this.RbInvoicesOldWeek.Name = "RbInvoicesOldWeek";
            this.RbInvoicesOldWeek.Size = new System.Drawing.Size(169, 20);
            this.RbInvoicesOldWeek.TabIndex = 4;
            this.RbInvoicesOldWeek.TabStop = true;
            this.RbInvoicesOldWeek.Text = "لیست فروش هفته گذشته";
            this.RbInvoicesOldWeek.UseVisualStyleBackColor = true;
            // 
            // RBActivitys
            // 
            this.RBActivitys.AutoSize = true;
            this.RBActivitys.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBActivitys.Location = new System.Drawing.Point(198, 93);
            this.RBActivitys.Name = "RBActivitys";
            this.RBActivitys.Size = new System.Drawing.Size(172, 20);
            this.RBActivitys.TabIndex = 3;
            this.RBActivitys.TabStop = true;
            this.RBActivitys.Text = "تمام فعالیت های ثبت شده";
            this.RBActivitys.UseVisualStyleBackColor = true;
            // 
            // RBCustomerList
            // 
            this.RBCustomerList.AutoSize = true;
            this.RBCustomerList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCustomerList.Location = new System.Drawing.Point(222, 57);
            this.RBCustomerList.Name = "RBCustomerList";
            this.RBCustomerList.Size = new System.Drawing.Size(148, 20);
            this.RBCustomerList.TabIndex = 2;
            this.RBCustomerList.TabStop = true;
            this.RBCustomerList.Text = "مشتریان ثبت نام شده";
            this.RBCustomerList.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "گزارش مورد نظر خود را وارد کنید:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(996, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "جست و جو:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowReportResultDisigning);
            this.groupBox1.Controls.Add(this.btnPrintReportDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.RBSellsUser);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(735, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(377, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش براساس تاریخ";
            // 
            // btnShowReportResultDisigning
            // 
            this.btnShowReportResultDisigning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowReportResultDisigning.ButtonImage = global::PersetionLayerCRM.Properties.Resources.Done;
            this.btnShowReportResultDisigning.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnShowReportResultDisigning.ButtonText = "نمایش نتیجه";
            this.btnShowReportResultDisigning.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnShowReportResultDisigning.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowReportResultDisigning.CornerRadius = 20;
            this.btnShowReportResultDisigning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowReportResultDisigning.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowReportResultDisigning.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnShowReportResultDisigning.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowReportResultDisigning.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnShowReportResultDisigning.Location = new System.Drawing.Point(235, 232);
            this.btnShowReportResultDisigning.Name = "btnShowReportResultDisigning";
            this.btnShowReportResultDisigning.Size = new System.Drawing.Size(137, 39);
            this.btnShowReportResultDisigning.TabIndex = 35;
            this.btnShowReportResultDisigning.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowReportResultDisigning.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowReportResultDisigning.Click += new System.EventHandler(this.btnShowReportResultDisigning_Click);
            // 
            // btnPrintReportDate
            // 
            this.btnPrintReportDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrintReportDate.ButtonImage = global::PersetionLayerCRM.Properties.Resources.print;
            this.btnPrintReportDate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnPrintReportDate.ButtonText = "چاپ گذارش";
            this.btnPrintReportDate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnPrintReportDate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReportDate.CornerRadius = 20;
            this.btnPrintReportDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReportDate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrintReportDate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnPrintReportDate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReportDate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPrintReportDate.Location = new System.Drawing.Point(7, 232);
            this.btnPrintReportDate.Name = "btnPrintReportDate";
            this.btnPrintReportDate.Size = new System.Drawing.Size(137, 39);
            this.btnPrintReportDate.TabIndex = 23;
            this.btnPrintReportDate.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintReportDate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "تا تاریخ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "از تاریخ";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(59, 187);
            this.txtEndDate.Mask = "00/00/0000";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 26);
            this.txtEndDate.TabIndex = 33;
            this.txtEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(214, 187);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 26);
            this.txtStartDate.TabIndex = 8;
            this.txtStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(260, 137);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(110, 20);
            this.radioButton9.TabIndex = 32;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "موجودی هر کالا";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // RBSellsUser
            // 
            this.RBSellsUser.AutoSize = true;
            this.RBSellsUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSellsUser.Location = new System.Drawing.Point(268, 107);
            this.RBSellsUser.Name = "RBSellsUser";
            this.RBSellsUser.Size = new System.Drawing.Size(102, 20);
            this.RBSellsUser.TabIndex = 31;
            this.RBSellsUser.TabStop = true;
            this.RBSellsUser.Text = "فروش هر کاربر";
            this.RBSellsUser.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(145, 77);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(226, 20);
            this.radioButton7.TabIndex = 30;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "فعالیت های ثبت شده توسط هر کاربر";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(223, 50);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(148, 20);
            this.radioButton6.TabIndex = 29;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "مشتریان ثبت نام شده";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "گزارش و تاریخ مدنظر خود را وارد نمایید:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(996, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "جست و جو:";
            // 
            // PBBack
            // 
            this.PBBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBBack.Image = global::PersetionLayerCRM.Properties.Resources.Back;
            this.PBBack.Location = new System.Drawing.Point(19, 514);
            this.PBBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBBack.Name = "PBBack";
            this.PBBack.Size = new System.Drawing.Size(41, 32);
            this.PBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBack.TabIndex = 21;
            this.PBBack.TabStop = false;
            this.PBBack.Click += new System.EventHandler(this.PBBack_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBack.Location = new System.Drawing.Point(62, 523);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(120, 16);
            this.lblBack.TabIndex = 22;
            this.lblBack.Text = "بازگشت به صفحه اصلی";
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(12, 4);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(80, 77);
            this.xuiClock1.TabIndex = 24;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 2;
            chartArea1.BorderColor = System.Drawing.Color.DimGray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(158, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))),
        System.Drawing.Color.Red,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Teal};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(511, 425);
            this.chart1.TabIndex = 25;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1126, 559);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.xuiClock1);
            this.Controls.Add(this.PBBack);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBSercheCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReport";
            this.GBSercheCustomer.ResumeLayout(false);
            this.GBSercheCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBSercheCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RBListOldYear;
        private System.Windows.Forms.RadioButton RBListOldMonth;
        private System.Windows.Forms.RadioButton RbInvoicesOldWeek;
        private System.Windows.Forms.RadioButton RBActivitys;
        private System.Windows.Forms.RadioButton RBCustomerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton RBSellsUser;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtEndDate;
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.PictureBox PBBack;
        private System.Windows.Forms.Label lblBack;
        private XanderUI.XUIButton btnPrintReport;
        private XanderUI.XUIButton btnShowReportResultDisigning;
        private XanderUI.XUIButton btnPrintReportDate;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}