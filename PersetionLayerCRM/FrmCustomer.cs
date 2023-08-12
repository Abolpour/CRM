using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BesinesEntitis;
using BisnessLagicLayer;
using CRM_Utility;
namespace PersetionLayerCRM
{
    public partial class FrmCustomer : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public FrmCustomer()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();
        CustomerBLL bll = new CustomerBLL();
        UserBLL UserBLL = new UserBLL();
        DashbordBLL dashbord = new DashbordBLL();


        private void BindGrid()
        {
            DgvCustomer.DataSource = null;
            DgvCustomer.DataSource = bll.Read();
            DgvCustomer.Columns["ردیف"].Visible = false;
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            //Count Customers
            lblCountCustomer.Text = dashbord.CustomersCount();
        }

        bool Cheked()
        {
            bool isvalid = true;
            if (txtName.Text == "")
            {
                RtlMessageBox.Show("لطفا نام خود را وارد کنید");
                txtName.Focus();
                isvalid = false;
            }
            else if (txtPhoneNumber.Text == "")
            {
                RtlMessageBox.Show("لطفا شماره تماس خود را وارد کنید");
                txtPhoneNumber.Focus();
                isvalid = false;
            }
            else if (txtPhoneNumber.Text.Length > 11 || txtPhoneNumber.Text.Length < 11)
            {
                m.MyShowDialg("مورد اشتباه", "شماره مشتری وارد شده صحیح نمیباشد تعداد کارکترها کم است", "", false, false);
                isvalid = false;
            }
            return isvalid;
        }


        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        //index=> For select ChekBox Serching
        int index;
        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            if (CBNameAndFamily.Checked)
            {
                index = 1;
            }
            else if (CBPhoneNumber.Checked)
            {
                index = 2;
            }
            else if ((!CBNameAndFamily.Checked && !CBPhoneNumber.Checked) || CBNameAndFamily.Checked && CBPhoneNumber.Checked)
            {
                index = 0;
            }
            DgvCustomer.DataSource = null;
            DgvCustomer.DataSource = bll.Serch(txtSerch.Text, index);
        }
        // => id DataGrid Select
        int idRow = 0;
        private void DgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            idRow = int.Parse(DgvCustomer.Rows[DgvCustomer.CurrentRow.Index].Cells["ردیف"].Value.ToString());
        }

        private void Update_TSMI_Click(object sender, EventArgs e)
        {
            Customer c = bll.ReadByid(idRow);
            txtName.Text = c.Name;
            txtPhoneNumber.Text = c.Phone;
            btnInsert.ButtonText = "ویرایش اطلاعات";
        }

        private void Delete_TSMI_Click(object sender, EventArgs e)
        {
            DialogResult dr = m.MyShowDialg("حذف مشتری", "آیا مخواهید مشتری مورد نظر خورا از جدول پا کنید؟", "Do yo Delete Customer?", true, false);
            if (dr == DialogResult.Yes)
            {
                bll.Delete(idRow);
            }
            BindGrid();
        }
        #region FilterTextBox Page
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhoneNumber.Focus();
            }
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInsert.Focus();
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void FrmCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dr = RtlMessageBox.Show("آیا میخواهید از قست مشتری ها خارج شوید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        #endregion
        private void btnInsert_Click(object sender, EventArgs e)
        {
            MainWindow w = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();

            // Text Box Cheked
            if (Cheked())
            {
                // Fill Customers
                Customer customer = new Customer()
                {
                    Name = txtName.Text,
                    Phone = txtPhoneNumber.Text,
                    RegDate = DateTime.Now
                };
                if (btnInsert.ButtonText == "ثبت اطلاعات")
                {
                    //Access Role
                    if (UserBLL.Access(w.LoginInUser, "بخش مشتریان", 2))
                    {
                        m.MyShowDialg("عملیات ثبت", bll.Create(customer), "Create Successfuly...", false, false);
                    }
                    else
                    {
                        m.MyShowDialg("محدودیت دسترسی", "شما اجاز ه ثبت کاربر را ندارید", "", false, true);
                    }
                }
                else
                {
                    if (UserBLL.Access(w.LoginInUser, "بخش مشتریان", 3))
                    {
                        m.MyShowDialg("عملیات ویرایش", bll.Update(customer, idRow), "Update Successfuly...", false, false);
                        btnInsert.ButtonText = "ثبت اطلاعات";
                    }
                    else
                    {
                        m.MyShowDialg("محدودیت دسترسی", "شما اجاز ه ویرایش کاربر را ندارید", "", false, true);
                    }
                }
                //Refreshing
                BindGrid();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
