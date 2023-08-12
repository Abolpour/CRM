using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BesinesEntitis;
using BisnessLagicLayer;
using CRM_Utility;
using System.Globalization;
namespace PersetionLayerCRM
{
    public partial class frmProductManagment : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmProductManagment()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        ProductBLL bll=new ProductBLL();
        int SelectRow = 0;
        MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();


        void BindGrid()
        {
            DgvProuduct.DataSource = null;
            DgvProuduct.DataSource = bll.Read();
            DgvProuduct.Columns["ردیف"].Visible=false;
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            //Products Count
            lblProductsCount.Text = bll.ProductsCount();
        }
      
        bool CHEKed()
        {
            bool isvalid = true;
            if(txtName.Text == "")
            {
                MessageBox.Show("لطفا ابتدا نام محصول را وارد کنید");
                isvalid = false;
                txtName.Focus();
            }
            else if(txtPrice.Text =="")
            {
                MessageBox.Show("لطفا قیمت محصول خود را مشخص کنید");
                isvalid = false;
                txtPrice.Focus();
            }
            else if(txtStock.Text == "")
            {
                MessageBox.Show("لطفا موجود انبار  را مشخص کنید");
                isvalid = false;
                txtStock.Focus();
            }
            return isvalid;
        }

        private void frmProductManagment_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        
    
        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            DgvProuduct.DataSource = null;
            DgvProuduct.DataSource = bll.Serch(txtSerch.Text);
        }

        private void DgvProuduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            SelectRow = int.Parse(DgvProuduct.CurrentRow.Cells["ردیف"].Value.ToString());
        }

        private void Delete_TSMI_Click(object sender, EventArgs e)
        {
            DialogResult dr = m.MyShowDialg("حذف مشتری", "آیا مخواهید مشتری مورد نظر خورا از جدول پا کنید؟", "Do yo Delete Customer?", true, false);
            if (dr == DialogResult.Yes)
            {
                bll.Delete(SelectRow);
            }
            BindGrid();
        }

        private void Update_TSMI_Click(object sender, EventArgs e)
        {
            Product product=bll.ReadByid(SelectRow);
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text=product.Stock.ToString();
            btnInsert.ButtonText = "ویرایش اطلاعات";
        }

        #region Filter Page
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrice.Focus();
            }
        }
        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStock.Focus();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmProductManagment_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dr = MessageBox.Show("آیا میخواهید از قست مدیریت محصول  خارج شوید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            //Filtering => 3 . Mani In Text Box 
            if (txtPrice.Text.Length > 0)
            {
                txtPrice.TextChanged -= txtPrice_TextChanged;
                txtPrice.Text = txtPrice.Text.Replace(",", "");
                txtPrice.Text = String.Format("{0:N0}", long.Parse(txtPrice.Text));
                txtPrice.TextChanged += txtPrice_TextChanged;
                txtPrice.SelectionStart = txtPrice.Text.Length;
            }
        }
        #endregion
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (CHEKed())
            {
                Product p = new Product()
                {
                    Name = txtName.Text,
                    Price = Convert.ToDouble((txtPrice.Text)),
                    Stock = int.Parse(txtStock.Text),
                    RegDate = DateTime.Now
                };
                if (btnInsert.ButtonText == "ثبت اطلاعات")
                {
                    m.MyShowDialg("عملیات ثبت", bll.Create(p), "Create Successfuly...", false, false);
                }
                else
                {
                    m.MyShowDialg("عملیات ویرایش", bll.Update(p, SelectRow), "Update Successfuly...", false, false);
                    btnInsert.ButtonText = "ثبت اطلاعات";
                }
                BindGrid();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvProuduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
