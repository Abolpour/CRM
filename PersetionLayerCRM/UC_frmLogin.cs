using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BesinesEntitis;
using BisnessLagicLayer;
using CRM_Utility;

namespace PersetionLayerCRM
{
    public partial class UC_frmLogin : UserControl
    {
        public UC_frmLogin()
        {
            InitializeComponent();
        }
        UserBLL ubll = new UserBLL();
        MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();
        User user = new User();
        DashbordBLL dashbord = new DashbordBLL();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            user = ubll.Login(txtUsername.Text, txtpassword.Text);
            if (user != null)
            {
                if (RtlMessageBox.Show("خوش آمدید", "برای ورود به نرم افزار روی تایید کلیک کنید", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MainWindow w = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
                    w.LoginInUser = user;
                    w.RefreshPage();
                    ((frmLogin)System.Windows.Forms.Application.OpenForms["frmLogin"]).Close();
                }
                else
                    txtpassword.Text = "";
                    txtUsername.Text = "";
            }
            else
            {
                m.MyShowDialg("اخطار", "نام کاربری یا رمز عبور اشباه است", "", false, true);
            }

        }


        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Click At Enter For Enter 
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.Focus();
                btnEnter_Click(null,null);
            }
        }
    }
}
