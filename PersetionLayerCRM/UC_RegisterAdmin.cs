using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;
using BesinesEntitis;
using BisnessLagicLayer;
using CRM_Utility;
using System.IO;

namespace PersetionLayerCRM
{
    public partial class UC_RegisterAdmin : UserControl
    {
        public UC_RegisterAdmin()
        {
            InitializeComponent();
        }
        MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();
        Timer t1 = new Timer();
        //For Animations Login Forms
        void Swithchpanels()
        {
            t1.Enabled = true;
            t1.Interval = 15;
            t1.Tick += Timer_Tick;
            t1.Start();
        }
        //Open file For Selectd Pic
        OpenFileDialog openFileDialog = new OpenFileDialog();
        //Selectd Pic
        Image Pic;
        // // // // // // // //
        UserBLL ubll=new UserBLL();
        // // // // // // // //
        UserGroupBll ugbll = new UserGroupBll();
        // // // // // // // //
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

        void CreateAdminGroup()
        {
            UserGroup userGroup = new UserGroup();
            userGroup.Title = "مدیریت";
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش مشتریان", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش کالاها", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش فاکتورها", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش فعالیت ها", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش یادآورها", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش کاربران", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("پنل پیامکی", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش گزارشات", true, true, true, true));
            userGroup.UserAccessRoles.Add(FillAccessRole("بخش تنظیمات", true, true, true, true));
            ugbll.Create(userGroup);
        }

        int y = 211;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PLicense.Location.Y < 517)
            {
                y = y + 10;
                PLicense.Location = new Point(0, y);
            }
            else
            {
                t1.Stop();
                PRegister.Visible = true;
            }
        }
        /// ///////////////////
        private void UC_RegisterAdmin_Load(object sender, EventArgs e)
        {
            //For Code LicenceKey
            txtRegisterId.Text = ComputerInfo.GetComputerId();
        }

        private void btntnLicenceKey_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtRegisterId.Text);
            string productKey = txtLicenceCopy.Text;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Personal accounting";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }

                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    m.MyShowDialg("تبریک", "نرم افزار با موفقیت فعال شد", "", false, false);
                    Swithchpanels();
                }
            }
            else
            {
                m.MyShowDialg("اخطار", "لایسنس وارد شده صحیح نمی باشد", "", false, true);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            User u = new User();
             CreateAdminGroup();
            u.UserName = txtUserName.Text;
            u.Name = txtName.Text;
            if(txtPassword.Text == txtChekedPassword.Text)
            {
                u.Password = txtPassword.Text;
            }
            else
            {
                m.MyShowDialg("اخطار", "کلمه عبور و تکرار آن با یک دیگر همخوانی ندارند", "", false, true);
            }
            u.RegDate = DateTime.Now;
            u.Picture=SavePic(txtPassword.Text);
            m.MyShowDialg("موفقیت", ubll.Create(u,ugbll.ReadBySingelTitle("مدیریت")), "",false , false);
            this.Visible = false;
            ((frmLogin)Application.OpenForms["frmLogin"]).LoginFormLoad();
        }

        private void brnPic_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG(*.JPG)|*.JPG";
            openFileDialog.Title = "تصویر کاربر را انتخاب کنید";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pic = Image.FromFile(openFileDialog.FileName);
              
            }
        }
    }
}
