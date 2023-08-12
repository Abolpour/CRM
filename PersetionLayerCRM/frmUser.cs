using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BesinesEntitis;
using BisnessLagicLayer;
namespace PersetionLayerCRM
{
    public partial class frmUser : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmUser()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        int id;

        private void ShowCb()
        {
            //For ComboBox Fill Title User Group
            txtgroupusers_cb.DataSource = userGroupBll.ListReadUGTitle();
            txtgroupusers_cb.DisplayMember = "Title";
        }

        public void Clear()
        {
            foreach (var item in GBAddCustomer.Controls)
            {
                if (item.GetType().ToString() == "DevComponents.DotNetBar.Controls.TextBoxX")
                {
                    (item as TextBox).Clear();
                }
            }
        }

        void ClearCb()
        {
            cbSlectAll.Checked = false;
            cbSelectAllAddInformations.Checked = false;
            cbSelectAllUpdate.Checked = false;
            cbSelectallDelete.Checked = false;
            txtNameUserGroup.Text = "";
        }

        private void BindGrid()
        {
            DgvUser.DataSource = null;
            DgvUser.DataSource = bll.Read();
            DgvUser.Columns["ردیف"].Visible = false;
            Clear();
            PBImage.Image = Properties.Resources.User;
           
        }

        UserAccessRole FillAccessRole(string Section, bool CanEnter, bool CanCreate, bool CanUpdate, bool CanDelete)
        {
            UserAccessRole role = new UserAccessRole();
            role.Section = Section;
            role.CanEnter = CanEnter;
            role.CanCreate = CanCreate;
            role.CanUpdate = CanUpdate;
            role.CanDelete = CanDelete;
            return role;

        }

        /// ///////////////////////
        UserBLL bll = new UserBLL();
        //Open file For Selectd Pic
        OpenFileDialog openFileDialog = new OpenFileDialog();

        //Selectd Pic
        Image Pic;
        /// ///////////////////////
        /// 
        UserGroupBll userGroupBll = new UserGroupBll();
        /// ///////////////////////

        MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();
        /// ///////////////////////

        UserGroup userGroup = new UserGroup();

       


        string SavePic(string UserName)
        {
            //Run NewFolder Pic + Selectd Target => @\UserPisc\
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\UserPisc\";
            // If Status => true وجو داشت عکسی
            if (!Directory.Exists(path))
            {
                // If NotFolder is  Create NewFolder And Is Address Path
                Directory.CreateDirectory(path);
            }
            string PicName = UserName + ".JPG";
            try
            {
                string PicPath = openFileDialog.FileName;
                File.Copy(PicPath, path + PicName, true);
            }
            catch (Exception e)
            {
                MessageBox.Show("سیستم قادر به ذخیره عکس نمی باشد" + e.Message);
            }
            return path + PicName;
        }


        private void btnCreateGroupUsers_Click(object sender, EventArgs e)
        {
            userGroup.Title = txtNameUserGroup.Text;
            //For Customer
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionCustomer.Text, cbCustomer_Request.Checked, cbCustomerAddInformation.Checked, cbCustomerUpdateInformation.Checked, cbCustomerDeleteInformation.Checked));
            //For Products
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionProduct.Text, cbProduct_Request.Checked, cbProductAddInformation.Checked, cbProductUpdate.Checked, cbProductDelete.Checked));
            //For Invoice 
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionInvoice.Text, cbInvoice_Request.Checked, cbInvoiceAdd.Checked, cbInvoiceUpdate.Checked, cbInvoiceDelete.Checked));
            //For Activitys
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionActivitys.Text, cbActivity_Request.Checked, cbActivityAdd.Checked, cbActivityUpdate.Checked, cbActivityDelete.Checked));
            //For Reminder
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionReminder.Text, cbReminder_Requst.Checked, cbReminderAdd.Checked, cbReminderUpdate.Checked, cbReminderDelete.Checked));
            //For Users
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionUser.Text, cbUsers_Requste.Checked, cbUsersAdd.Checked, cbUsersUpdate.Checked, cbUsersDelete.Checked));
            //For Sms
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionSms.Text, cbSms_Requset.Checked, cbSmsAdd.Checked, cbSmsUpdate.Checked, cbSmsDelete.Checked));
            //For Reports
            userGroup.UserAccessRoles.Add(FillAccessRole(SectionReport.Text, cbReports_Requst.Checked, cbReportsAdd.Checked, cbReportsUpdate.Checked, cbReportsDelete.Checked));
            //For Setting
            userGroup.UserAccessRoles.Add(FillAccessRole(Sectionsetting.Text, cbSetting_Requset.Checked, cbSettingAdd.Checked, cbSettingUpdate.Checked, cbSettingDelete.Checked));
            m.MyShowDialg("نتیجه ثبت اطلاعات", userGroupBll.Create(userGroup), "", false, false);
            ClearCb();
        }


        private void PBImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG(*.JPG)|*.JPG";
            openFileDialog.Title = "تصویر کاربر را انتخاب کنید";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pic = Image.FromFile(openFileDialog.FileName);
                PBImage.Image = Pic;
                PBImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void PBinsert_Click(object sender, EventArgs e)
        {
            
            User u = new User();
            u.Name = txtName.Text;
            u.UserName = txtUserName.Text;
            userGroup = userGroupBll.ReadBySingelTitle(txtgroupusers_cb.Text);
            if (txtPassword.Text == txtPasswordCheked.Text)
            {
                u.Password = txtPasswordCheked.Text;
            }
            else
            {
                MessageBox.Show("کلمه عبور با تکرار وارد شدی آن صحیح نیست");
            }
            u.RegDate = DateTime.Now;
            if (lblInsert.Text == "ثبت اطلاعات")
            {
                u.Picture = SavePic(txtUserName.Text);
                MessageBox.Show(bll.Create(u, userGroup));
            }
            else
            {
                u.Picture = SavePic(txtUserName.Text);
                MessageBox.Show(bll.Update(u, id));
                lblInsert.Text = "ثبت اطلاعات";
            }
            BindGrid();
        }


        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            id = int.Parse(DgvUser.CurrentRow.Cells["ردیف"].Value.ToString());
        }


        private void frmUser_Load(object sender, EventArgs e)
        {
            ShowCb();
            BindGrid();
        }


        private void UpdateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            User us = bll.ReadById(id);
            txtName.Text = us.Name;
            txtUserName.Text = us.UserName;
            PBImage.Image = Image.FromFile(us.Picture);
            lblInsert.Text = "ویرایش اطلاعات";
        }


        private void DeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا میخواهید این مشتری از لیست شما حذف بشود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                bll.Delete(id);
            }
            BindGrid();
        }


        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbSlectAll_CheckedChanged(object sender, EventArgs e)
        {
            //For SelectAll Requst Enter
            if (cbSlectAll.Checked)
            {
                cbCustomer_Request.Checked = true;
                cbActivity_Request.Checked = true;
                cbProduct_Request.Checked = true;
                cbInvoice_Request.Checked = true;
                cbReminder_Requst.Checked = true;
                cbUsers_Requste.Checked = true;
                cbSms_Requset.Checked = true;
                cbReminder_Requst.Checked = true;
                cbSetting_Requset.Checked = true;
                cbReports_Requst.Checked = true;
            }
            else
            {
                cbCustomer_Request.Checked = false;
                cbActivity_Request.Checked = false;
                cbProduct_Request.Checked = false;
                cbInvoice_Request.Checked = false;
                cbReminder_Requst.Checked = false;
                cbUsers_Requste.Checked = false;
                cbSms_Requset.Checked = false;
                cbReminder_Requst.Checked = false;
                cbSetting_Requset.Checked = false;
                cbReports_Requst.Checked = false;
            }
        }


        private void cbSelectAllAddInformations_CheckedChanged(object sender, EventArgs e)
        {
            //For SelectAll Add Informations
            if (cbSelectAllAddInformations.Checked)
            {
                cbCustomerAddInformation.Checked = true;
                cbProductAddInformation.Checked = true;
                cbSettingAdd.Checked = true;
                cbSmsAdd.Checked = true;
                cbUsersAdd.Checked = true;
                cbActivityAdd.Checked = true;
                cbReminderAdd.Checked = true;
                cbUsersAdd.Checked = true;
                cbReportsAdd.Checked = true;
                cbInvoiceAdd.Checked = true;
            }
            else
            {
                cbCustomerAddInformation.Checked = false;
                cbProductAddInformation.Checked = false;
                cbSettingAdd.Checked = false;
                cbSmsAdd.Checked = false;
                cbUsersAdd.Checked = false;
                cbActivityAdd.Checked = false;
                cbReminderAdd.Checked = false;
                cbUsersAdd.Checked = false;
                cbReportsAdd.Checked = false;
                cbInvoiceAdd.Checked = false;
            }
        }


        private void cbSelectAllUpdate_CheckedChanged(object sender, EventArgs e)
        {
            //For SelectAll Update Informations
            if (cbSelectAllUpdate.Checked)
            {
                cbCustomerUpdateInformation.Checked = true;
                cbProductUpdate.Checked = true;
                cbSettingUpdate.Checked = true;
                cbSmsUpdate.Checked = true;
                cbUsersUpdate.Checked = true;
                cbActivityUpdate.Checked = true;
                cbReminderUpdate.Checked = true;
                cbReportsUpdate.Checked = true;
                cbInvoiceUpdate.Checked = true;
            }
            else
            {
                cbCustomerUpdateInformation.Checked = false;
                cbProductUpdate.Checked = false;
                cbSettingUpdate.Checked = false;
                cbSmsUpdate.Checked = false;
                cbUsersUpdate.Checked = false;
                cbActivityUpdate.Checked = false;
                cbReminderUpdate.Checked = false;
                cbReportsUpdate.Checked = false;
                cbInvoiceUpdate.Checked = false;
            }
        }


        private void cbSelectallDelete_CheckedChanged(object sender, EventArgs e)
        {
            //For SelectAll Delete Informatios
            if (cbSelectallDelete.Checked)
            {
                cbCustomerDeleteInformation.Checked = true;
                cbProductDelete.Checked = true;
                cbSettingDelete.Checked = true;
                cbSmsDelete.Checked = true;
                cbUsersDelete.Checked = true;
                cbActivityDelete.Checked = true;
                cbReminderDelete.Checked = true;
                cbReportsDelete.Checked = true;
                cbInvoiceDelete.Checked = true;
            }
            else
            {
                cbCustomerDeleteInformation.Checked = false;
                cbProductDelete.Checked = false;
                cbSettingDelete.Checked = false;
                cbSmsDelete.Checked = false;
                cbUsersDelete.Checked = false;
                cbActivityDelete.Checked = false;
                cbReminderDelete.Checked = false;
                cbReportsDelete.Checked = false;
                cbInvoiceDelete.Checked = false;
            }
        }


        private void SelectAllcb_CheckedChanged(object sender, EventArgs e)
        {
            //Select ALL CheckBoxs
            if (SelectAllcb.Checked)
            {
                cbSlectAll.Checked = true;
                cbSelectAllAddInformations.Checked = true;
                cbSelectAllUpdate.Checked = true;
                cbSelectallDelete.Checked = true;
            }
            else
            {
                cbSlectAll.Checked = false;
                cbSelectAllAddInformations.Checked = false;
                cbSelectAllUpdate.Checked = false;
                cbSelectallDelete.Checked = false;
            }
        }
    }
}
