using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BisnessLagicLayer;
using CRM_Utility;
using BesinesEntitis;
using Stimulsoft.Report;
namespace PersetionLayerCRM
{
    public partial class frmListInvoice : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmListInvoice()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        int id = 0;
        CustomerBLL CBll = new CustomerBLL();
        Customer customer = new Customer();
        ///////////////////////////////////
        ProductBLL Pbll = new ProductBLL();
        Product product = new Product();
        List<Product> productsList = new List<Product>();
        ///////////////////////////////////
        MsgBoxClass.MsgBox Msg = new MsgBoxClass.MsgBox();
        ///////////////////////////////////
        InvoiceBLL InvoiceBLL = new InvoiceBLL();


        bool btnIsvalid(string txtName)
        {
            //For Check btnSelect
            bool isvalid = true;
            if (txtNameProduct.Text == "" && btnSelect.Enabled == true)
            {
                txtNameProduct.Enabled = true;
                DgvProduct1.Enabled = true;
                groupBox2.Enabled = true;
                btnInsertIsList.Enabled = true;
                isvalid = false;
            }
            else
            {
                txtNameProduct.Enabled = false;
                DgvProduct1.Enabled = false;
                groupBox2.Enabled = false;
                btnInsertIsList.Enabled = false;
                isvalid = true;
            }
            return isvalid;
        }


        void BindGrid()
        {
            DgvProduct1.DataSource = null;
            DgvProduct1.DataSource = productsList;
            DgvProduct1.Columns["id"].Visible = false;
            DgvProduct1.Columns["DeleteStatus"].Visible = false;
            DgvProduct1.Columns["Stock"].Visible = false;
            DgvProduct1.Columns["RegDate"].Visible = false;
            DgvProduct1.Columns["Name"].HeaderText = "نام محصول";
            DgvProduct1.Columns["Price"].HeaderText = "قیمت محصول";
        }


        void BindGrid2()
        {
            // DgvProduct2.Columns["ردیف"].Visible = false;
            DgvProduct2.DataSource = null;
            DgvProduct2.DataSource = InvoiceBLL.Read();
            // CountInvoices
            lblCountInvoices.Text = InvoiceBLL.CountInvoices();
        }


        bool valid()
        {
            //For Checked TextBox
            bool isvalid = true;
            if (txtPhoneNumber.Text == "")
            {
                RtlMessageBox.Show("لطفا شماره تماس فرد را انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                isvalid = false;
            }
            else if (txtNameProduct.Text == "")
            {
                RtlMessageBox.Show("لطفا نام کالای خریداری شده را انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameProduct.Focus();
                isvalid = false;
            }
            return isvalid;
        }


        private void frmListInvoice_Load(object sender, EventArgs e)
        {

            ///=> Lbl Date Time
            lblDatetime.Text = MetodExtations.ToShamsi(DateTime.Now);

            ///=> Phone Number For Customer In frmActivitys
            AutoCompleteStringCollection phone = new AutoCompleteStringCollection();
            foreach (var item in CBll.ReadPhoneNumbers())
            {
                phone.Add(item);
            }
            txtPhoneNumber.AutoCompleteCustomSource = phone;
            //////////////////////////////
            ///=> Name Product For Prodcut In frmInvoice
            AutoCompleteStringCollection NameProduct = new AutoCompleteStringCollection();
            foreach (var item in Pbll.ReadByName())
            {
                NameProduct.Add(item);
            }
            txtNameProduct.AutoCompleteCustomSource = NameProduct;


            BindGrid2();
        }


        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnIsvalid(txtPhoneNumber.Text);
            if (txtPhoneNumber.Text == "")
            {
                RtlMessageBox.Show("لطفا شماره تماس فرد را انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                customer = CBll.ReadByName(txtPhoneNumber.Text);
                txtPhoneNumber.Enabled = false;
                btnSelect.Enabled = false;
                lblName.Text = customer.Name;
                lblPhoneNumber.Text = customer.Phone;
            }
        }


        private void btnInsertIsList_Click(object sender, EventArgs e)
        {
            if (txtNameProduct.Text == "")
            {
                RtlMessageBox.Show("لطفا نام کالای خریداری شده را انتخاب کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                product = Pbll.ReadByNameList(txtNameProduct.Text);
                productsList.Add(product);
                BindGrid();
                string TextListBox = product.Name + "به ارزش" + product.Price.ToRial() + "ریال";
                listNameAndPrice.Items.Add(TextListBox);
                double sum = 0;
                foreach (var item in productsList.ToList())
                {
                    sum = sum + item.Price;
                }
                lblSumPrice.Text = sum.ToRial();
                lblPayable.Text = (sum - Convert.ToDouble(txtCut.Text)).ToRial();
            
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Msg.MyShowDialg("هشدار", InvoiceBLL.Delete(id), "Deleted Invoices Row", true, false);
            BindGrid2();
        }


        private void DgvProduct2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(DgvProduct2.CurrentRow.Cells["ردیف"].Value.ToString());
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }


        private void DoneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = RtlMessageBox.Show("تسویه حساب انجام شده ؟", "ثبت حساب ها", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                InvoiceBLL.Done(id);
            }
            BindGrid2();
        }


        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvProduct2.CurrentRow != null)
            {
                txtPhoneNumber.Text = DgvProduct2.CurrentRow.Cells["شماره تماس مشتری"].Value.ToString();
                txtPhoneNumber.Enabled = false;
                btnSelect.Enabled = false;
                txtNameProduct.Text = DgvProduct2.CurrentRow.Cells["نام کالا"].Value.ToString();
                lblName.Text = DgvProduct2.CurrentRow.Cells["نام مشتری"].Value.ToString();
                lblPhoneNumber.Text = DgvProduct2.CurrentRow.Cells["شماره تماس مشتری"].Value.ToString();
                lblDatetime.Text = DgvProduct2.CurrentRow.Cells["تاریخ ثبت"].Value.ToString();
                cbIsCheckedOut.Checked = Convert.ToBoolean(DgvProduct2.CurrentRow.Cells["پرداخت شده"].Value.ToString());
                lblPayable.Text = DgvProduct2.CurrentRow.Cells["قیمت کالا"].Value.ToString();
                lblSumPrice.Text= DgvProduct2.CurrentRow.Cells["مجموعه قیمت"].Value.ToString();
                btnInsertAndPrint.ButtonText = "ویرایش اطلاعات";

                /*
                 * ادامه فعل آپدیت باید یک ورودی به فعل ثبتمون بدیم و
                 * قسمت کلاس باید تعغیر کنهه 
                 *قسمت فعل ثبت باید تعفیر کند 
                 */
            }
            else
                MessageBox.Show("Null");
        }

        private void btnInsertAndPrint_Click_1(object sender, EventArgs e)
        {
            if (valid())
            {
                Invoice invoice = new Invoice();
                invoice.RegDate = DateTime.Now;
                if (cbIsCheckedOut.Checked)
                {
                    invoice.IsCheckOut = true;
                    invoice.CkeckOutDate = DateTime.Now;
                }
                else
                {
                    invoice.IsCheckOut = false;
                }
                BindGrid2();
                DialogResult res = Msg.MyShowDialg("ااطلاعیه", InvoiceBLL.Create(invoice, customer, productsList) + "آیا قصد چاپ فاکتور را دارید؟", "", true, false);
                if (res == DialogResult.Yes)
                {
                    StiReport sti = new StiReport();
                    sti.Load(@"D:\CRNFinalProject\DataAccessLayer\bin\Debug\InvoiceReport.mrt");
                    sti.Dictionary.Variables["InvoiceNum"].Value = InvoiceBLL.ReadInvoiceNumIsReport();
                    sti.Dictionary.Variables["Date"].Value = lblDatetime.Text;
                    sti.Dictionary.Variables["CustomerName"].Value = lblName.Text;
                    sti.Dictionary.Variables["CustPhone"].Value = lblPhoneNumber.Text;
                    sti.RegBusinessObject("ProductBO", productsList);
                    sti.Render();
                    sti.Show();
                    //For Print
                    // =>        sti.Print();
                }
                DialogResult rest = RtlMessageBox.Show("برای ادامه لطفا یک بار از فرم خارج شوید", "رفرش صفحه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rest == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
