namespace PersetionLayerCRM
{
    partial class frmListInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertIsList = new XanderUI.XUISuperButton();
            this.btnSelect = new XanderUI.XUISuperButton();
            this.DgvProduct1 = new System.Windows.Forms.DataGridView();
            this.txtNameProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvProduct2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSerching = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCountInvoices = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new XanderUI.XUISuperButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInsertAndPrint = new XanderUI.XUISuperButton();
            this.cbIsCheckedOut = new System.Windows.Forms.CheckBox();
            this.txtCut = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPayable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listNameAndPrice = new System.Windows.Forms.ListBox();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnInsertIsList);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.DgvProduct1);
            this.groupBox1.Controls.Add(this.txtNameProduct);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1140, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن فاکتور جدید";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "شماره تماس مشتری خودرا وارد نمایید:\r\n";
            // 
            // btnInsertIsList
            // 
            this.btnInsertIsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnInsertIsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertIsList.ButtonImage = global::PersetionLayerCRM.Properties.Resources.SumAdd;
            this.btnInsertIsList.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsertIsList.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsertIsList.ButtonText = "";
            this.btnInsertIsList.CornerRadius = 15;
            this.btnInsertIsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertIsList.Enabled = false;
            this.btnInsertIsList.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsertIsList.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsertIsList.HoverTextColor = System.Drawing.Color.White;
            this.btnInsertIsList.ImagePosition = XanderUI.XUISuperButton.imgPosition.Right;
            this.btnInsertIsList.Location = new System.Drawing.Point(663, 82);
            this.btnInsertIsList.Name = "btnInsertIsList";
            this.btnInsertIsList.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsertIsList.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsertIsList.Size = new System.Drawing.Size(38, 36);
            this.btnInsertIsList.SuperSelected = false;
            this.btnInsertIsList.TabIndex = 26;
            this.btnInsertIsList.TextColor = System.Drawing.Color.White;
            this.btnInsertIsList.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsertIsList.Click += new System.EventHandler(this.btnInsertIsList_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelect.ButtonImage = global::PersetionLayerCRM.Properties.Resources.Oki;
            this.btnSelect.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnSelect.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnSelect.ButtonText = "";
            this.btnSelect.CornerRadius = 15;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSelect.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnSelect.HoverTextColor = System.Drawing.Color.White;
            this.btnSelect.ImagePosition = XanderUI.XUISuperButton.imgPosition.Right;
            this.btnSelect.Location = new System.Drawing.Point(664, 42);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnSelect.SelectedTextColor = System.Drawing.Color.White;
            this.btnSelect.Size = new System.Drawing.Size(38, 36);
            this.btnSelect.SuperSelected = false;
            this.btnSelect.TabIndex = 25;
            this.btnSelect.TextColor = System.Drawing.Color.White;
            this.btnSelect.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // DgvProduct1
            // 
            this.DgvProduct1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProduct1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvProduct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProduct1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvProduct1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProduct1.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvProduct1.Enabled = false;
            this.DgvProduct1.Location = new System.Drawing.Point(653, 128);
            this.DgvProduct1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvProduct1.Name = "DgvProduct1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProduct1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvProduct1.Size = new System.Drawing.Size(481, 155);
            this.DgvProduct1.TabIndex = 12;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNameProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNameProduct.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtNameProduct.Border.BackColor = System.Drawing.Color.Snow;
            this.txtNameProduct.Border.Class = "TextBoxBorder";
            this.txtNameProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtNameProduct.Enabled = false;
            this.txtNameProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(718, 83);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PreventEnterBeep = true;
            this.txtNameProduct.Size = new System.Drawing.Size(415, 31);
            this.txtNameProduct.TabIndex = 3;
            this.txtNameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameProduct.WatermarkText = "جستجومیان محصولات";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtPhoneNumber.Border.BackColor = System.Drawing.Color.Snow;
            this.txtPhoneNumber.Border.Class = "TextBoxBorder";
            this.txtPhoneNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(718, 43);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PreventEnterBeep = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(415, 31);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvProduct2);
            this.groupBox3.Controls.Add(this.txtSerching);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(14, 313);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1140, 269);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لست فاکتورها";
            // 
            // DgvProduct2
            // 
            this.DgvProduct2.AllowUserToAddRows = false;
            this.DgvProduct2.AllowUserToDeleteRows = false;
            this.DgvProduct2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProduct2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProduct2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvProduct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProduct2.DefaultCellStyle = dataGridViewCellStyle16;
            this.DgvProduct2.Location = new System.Drawing.Point(6, 63);
            this.DgvProduct2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvProduct2.Name = "DgvProduct2";
            this.DgvProduct2.ReadOnly = true;
            this.DgvProduct2.Size = new System.Drawing.Size(1126, 200);
            this.DgvProduct2.TabIndex = 13;
            this.DgvProduct2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct2_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DoneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::PersetionLayerCRM.Properties.Resources.Delete;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.DeleteToolStripMenuItem.Text = "حذف";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Image = global::PersetionLayerCRM.Properties.Resources.Update;
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.UpdateToolStripMenuItem.Text = "ویرایش";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DoneToolStripMenuItem
            // 
            this.DoneToolStripMenuItem.Image = global::PersetionLayerCRM.Properties.Resources.Done;
            this.DoneToolStripMenuItem.Name = "DoneToolStripMenuItem";
            this.DoneToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.DoneToolStripMenuItem.Text = "تسویه حساب";
            this.DoneToolStripMenuItem.Click += new System.EventHandler(this.DoneToolStripMenuItem_Click);
            // 
            // txtSerching
            // 
            this.txtSerching.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtSerching.Border.BackColor = System.Drawing.Color.Snow;
            this.txtSerching.Border.Class = "TextBoxBorder";
            this.txtSerching.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSerching.Location = new System.Drawing.Point(6, 26);
            this.txtSerching.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSerching.Name = "textBoxX2";
            this.txtSerching.PreventEnterBeep = true;
            this.txtSerching.Size = new System.Drawing.Size(1126, 28);
            this.txtSerching.TabIndex = 13;
            this.txtSerching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerching.WatermarkText = " جستجو براساس نام مشتری وشماره تماس  مشتری و شماره فاکتور\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(402, 597);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "صفحه";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(613, 598);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "صفحه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(484, 597);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "0\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(564, 598);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "0\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(522, 597);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "از";
            // 
            // lblCountInvoices
            // 
            this.lblCountInvoices.AutoSize = true;
            this.lblCountInvoices.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountInvoices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCountInvoices.Location = new System.Drawing.Point(892, 598);
            this.lblCountInvoices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountInvoices.Name = "lblCountInvoices";
            this.lblCountInvoices.Size = new System.Drawing.Size(18, 19);
            this.lblCountInvoices.TabIndex = 18;
            this.lblCountInvoices.Text = "0\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(959, 597);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "تعداد فاکتور های ثبت شده :";
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
            this.btnBack.Location = new System.Drawing.Point(15, 592);
            this.btnBack.Name = "btnBack";
            this.btnBack.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.SelectedTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(125, 28);
            this.btnBack.SuperSelected = false;
            this.btnBack.TabIndex = 25;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsertAndPrint);
            this.groupBox2.Controls.Add(this.cbIsCheckedOut);
            this.groupBox2.Controls.Add(this.txtCut);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblPayable);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblSumPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listNameAndPrice);
            this.groupBox2.Controls.Add(this.lblDatetime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblPhoneNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(638, 267);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btnInsertAndPrint
            // 
            this.btnInsertAndPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnInsertAndPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertAndPrint.ButtonImage = global::PersetionLayerCRM.Properties.Resources.print;
            this.btnInsertAndPrint.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsertAndPrint.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsertAndPrint.ButtonText = "ثبت اطلاعات و چاپ فاکتور";
            this.btnInsertAndPrint.CornerRadius = 15;
            this.btnInsertAndPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertAndPrint.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsertAndPrint.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsertAndPrint.HoverTextColor = System.Drawing.Color.White;
            this.btnInsertAndPrint.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnInsertAndPrint.Location = new System.Drawing.Point(21, 217);
            this.btnInsertAndPrint.Name = "btnInsertAndPrint";
            this.btnInsertAndPrint.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsertAndPrint.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsertAndPrint.Size = new System.Drawing.Size(171, 38);
            this.btnInsertAndPrint.SuperSelected = false;
            this.btnInsertAndPrint.TabIndex = 27;
            this.btnInsertAndPrint.TextColor = System.Drawing.Color.White;
            this.btnInsertAndPrint.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsertAndPrint.Click += new System.EventHandler(this.btnInsertAndPrint_Click_1);
            // 
            // cbIsCheckedOut
            // 
            this.cbIsCheckedOut.AutoSize = true;
            this.cbIsCheckedOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.cbIsCheckedOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIsCheckedOut.Location = new System.Drawing.Point(255, 232);
            this.cbIsCheckedOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIsCheckedOut.Name = "cbIsCheckedOut";
            this.cbIsCheckedOut.Size = new System.Drawing.Size(94, 20);
            this.cbIsCheckedOut.TabIndex = 25;
            this.cbIsCheckedOut.Text = "پرداخت میشود";
            this.cbIsCheckedOut.UseVisualStyleBackColor = false;
            // 
            // txtCut
            // 
            this.txtCut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            // 
            // 
            // 
            this.txtCut.Border.BackColor = System.Drawing.Color.Snow;
            this.txtCut.Border.Class = "TextBoxBorder";
            this.txtCut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtCut.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCut.Location = new System.Drawing.Point(67, 121);
            this.txtCut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCut.Name = "txtCut";
            this.txtCut.PreventEnterBeep = true;
            this.txtCut.Size = new System.Drawing.Size(100, 29);
            this.txtCut.TabIndex = 13;
            this.txtCut.Text = "0";
            this.txtCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(290, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "مبلغ تخفیف";
            // 
            // lblPayable
            // 
            this.lblPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayable.Location = new System.Drawing.Point(46, 163);
            this.lblPayable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayable.Name = "lblPayable";
            this.lblPayable.Size = new System.Drawing.Size(135, 16);
            this.lblPayable.TabIndex = 11;
            this.lblPayable.Text = "0";
            this.lblPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "مبلغ قابل پرداخت";
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumPrice.Location = new System.Drawing.Point(50, 88);
            this.lblSumPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(135, 16);
            this.lblSumPrice.TabIndex = 9;
            this.lblSumPrice.Text = "0";
            this.lblSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "جمع مبلغ خرید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "محصولات ذکر شده را با شرایط زیر خریداری نموده اند.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listNameAndPrice
            // 
            this.listNameAndPrice.FormattingEnabled = true;
            this.listNameAndPrice.ItemHeight = 16;
            this.listNameAndPrice.Location = new System.Drawing.Point(361, 91);
            this.listNameAndPrice.Name = "listNameAndPrice";
            this.listNameAndPrice.Size = new System.Drawing.Size(270, 164);
            this.listNameAndPrice.TabIndex = 6;
            // 
            // lblDatetime
            // 
            this.lblDatetime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.Location = new System.Drawing.Point(21, 28);
            this.lblDatetime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(135, 16);
            this.lblDatetime.TabIndex = 5;
            this.lblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "در تاریخ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(225, 28);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(128, 16);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "با شماره تماس";
            // 
            // lblName
            // 
            this.lblName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(452, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 16);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "آقا/خانوم";
            // 
            // frmListInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1168, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCountInvoices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmListInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListFactor";
            this.Load += new System.EventHandler(this.frmListInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNameProduct;
        private System.Windows.Forms.DataGridView DgvProduct1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvProduct2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerching;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCountInvoices;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUISuperButton btnSelect;
        private XanderUI.XUISuperButton btnInsertIsList;
        private XanderUI.XUISuperButton btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoneToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private XanderUI.XUISuperButton btnInsertAndPrint;
        private System.Windows.Forms.CheckBox cbIsCheckedOut;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCut;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPayable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listNameAndPrice;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
    }
}