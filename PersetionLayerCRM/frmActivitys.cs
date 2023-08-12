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
namespace PersetionLayerCRM
{
    public partial class frmActivitys : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmActivitys()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        private void BindGrid()
        {
            dgvActivty.DataSource = null;
            dgvActivty.DataSource = ABll.Read();
            dgvActivty.Columns["ردیف"].Visible = false;
        }
        Customer customer = new Customer();
        CustomerBLL CBll = new CustomerBLL();
        /// //////////////////////
        User user = new User();
        UserBLL UBll = new UserBLL();
        /// //////////////////////
        ActivityCategory activityCategory = new ActivityCategory();
        ActivityCategoryBLL AcBll = new ActivityCategoryBLL();
        /// //////////////////////
        ActivityBLL ABll = new ActivityBLL();
        /// //////////////////////
        ReminderBLL Rbll =new ReminderBLL();
        /// ///////////////////////
        int idRow;
        
        MsgBoxClass.MsgBox m =new MsgBoxClass.MsgBox();
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActivitys_Load(object sender, EventArgs e)
        {
            ///=> Phone Number For Customer In frmActivitys
            AutoCompleteStringCollection phone = new AutoCompleteStringCollection();
            foreach (var item in CBll.ReadPhoneNumbers())
            {
                phone.Add(item);
            }
            txtPhoneNumberSerching.AutoCompleteCustomSource = phone;
            ///
            /// UserName For User In frmActivitys
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            foreach (var item in UBll.ReadUserNamesList())
            {
                names.Add(item);
            }
            txtNameUserSerching.AutoCompleteCustomSource = names;
            ///
            /// CateGoryname For ActiviyCategory In frmActivitys
            AutoCompleteStringCollection Acnames =new AutoCompleteStringCollection();
            foreach (var item in AcBll.ActivityCategoryReadUserNamesList())
            {
                Acnames.Add(item);
            }
            txtNameAc.AutoCompleteCustomSource= Acnames;
            ///
            BindGrid();
        }

        private void pbInsertCustomer_Click(object sender, EventArgs e)
        {
            customer = CBll.ReadByName(txtPhoneNumberSerching.Text);
            txtPhoneNumberSerching.Enabled = false;
        }

        private void pbInsertUser_Click(object sender, EventArgs e)
        {
            user = UBll.ReadByName(txtNameUserSerching.Text);
            txtNameUserSerching.Enabled=false; 
        }

        private void pbInsertActivitys_Click(object sender, EventArgs e)
        {
            activityCategory=AcBll.ReadByName(txtNameAc.Text);
            txtNameAc.Enabled=false;
        }

        private void pbInsert_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Title=txtTitleActivitys.Text;
            activity.Info=txtDescripstion.Text;
            activity.RegDate=DateTime.Now;
            m.MyShowDialg("", ABll.Create(activity, user, customer, activityCategory), "", false, false);
            if(cbActivity.Checked)
            {
                Reminder reminder = new Reminder();
                reminder.Title = txtNameAc.Text;
                reminder.ReminderInfo=txtDescripstion.Text;
                reminder.RegDate = DateTime.Now;
                reminder.ReminderDate = txtDateTimeActivitys.Value.Date;
                m.MyShowDialg("",Rbll.Create(r:reminder,u:user),"",false,false);
            }
            BindGrid();
        }

        private void dgvActivty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRow=int.Parse(dgvActivty.CurrentRow.Cells["ردیف"].Value.ToString());
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void DeleteCMS_Click(object sender, EventArgs e)
        {
            // => CMS contextmenustrip Delete
            m.MyShowDialg("",ABll.Delete(id:idRow),"",false,false);
            BindGrid();
        }

        private void showDescriptions_Click(object sender, EventArgs e)
        {
            // => CMS contextmenustrip Show Info
            m.MyShowDialg("",ABll.ReadByInfo(idRow),"",false,false);
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
