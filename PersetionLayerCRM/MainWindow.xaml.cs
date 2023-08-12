using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Media.Effects;
using BesinesEntitis;
using BisnessLagicLayer;
namespace PersetionLayerCRM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            frmLogin f = new frmLogin();
            InitializeComponent();
            OpenWinForme(f);
        }
        public User LoginInUser = new User();
        UserBLL UserBLL = new UserBLL();
        DashbordBLL DashbordBLL = new DashbordBLL();
        void OpenWinForme(Form f)
        {
            BlurEffect bme = new BlurEffect();
            this.Effect = bme;
            bme.Radius = 15;
            f.ShowDialog();
            Effect = null;
           
        }
        MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();
        public void RefreshPage()
        {
            txtUserName.Text = LoginInUser.UserName;
            txtname.Text = LoginInUser.Name;
            //For Remindercount
            txtReminderCount.Text = DashbordBLL.UserReminderCount(LoginInUser);
            //For CustomersCunt
            lblCutsomersCount.Text = DashbordBLL.CustomersCount();
            //For Invoice Count Date Daye
            lblSellCount.Text = DashbordBLL.SellsCount();
            int a = 0;
            foreach (var item in DashbordBLL.GetUserReminder(LoginInUser))
            {
                if(a < 7)
                {
                    //For UoseControl Reminder
                    UC_Reminder uC_Reminder = new UC_Reminder();
                    uC_Reminder.txtReminderTitle.Text = item.Title;
                    uC_Reminder.txtReminderInfo.Text = item.ReminderInfo;
                    // Add in Children
                    Grid.SetRow(uC_Reminder, 5 + a);
                    Grid.SetColumnSpan(uC_Reminder, 7);
                    MainGrid.Children.Add(uC_Reminder);
                    a++;
                }
            }
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void WrapPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Access Role
            if (UserBLL.Access(LoginInUser, "بخش مشتریان", 1))
            {
                //Open Form Customer
                FrmCustomer frm = new FrmCustomer();
                OpenWinForme(frm);
                RefreshPage();
            }
            else
            {
                m.MyShowDialg("محدودیت دسترسی", "شما اجاز ه ورود به این قسمت را ندارید", "", false, true);
            }
        }

        private void WrapPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            frmProductManagment frm = new frmProductManagment();
            OpenWinForme(frm);
            RefreshPage();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmListInvoice frm = new frmListInvoice();
            OpenWinForme(frm);
            RefreshPage();
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            frmActivitys frm = new frmActivitys();
            OpenWinForme(frm);
            RefreshPage();
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            frmReminders frm = new frmReminders();
            OpenWinForme(frm);
            RefreshPage();
        }

        private void TextBlock_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            frmSmsPanel frm = new frmSmsPanel();
            OpenWinForme(frm);
        }

        private void TextBlock_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            frmUser frm = new frmUser();
            OpenWinForme(frm);
            RefreshPage();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MsgBoxClass.MsgBox m = new MsgBoxClass.MsgBox();
            DialogResult dr = m.MyShowDialg("آیا میخواهید از سیستم خارج شوید؟", "خارج میشوید؟", "Do You Exit?", true, false);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TextBlock_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            frmSetting frm = new frmSetting();
            OpenWinForme(frm);
        }

        private void TextBlock_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            frmReport frm = new frmReport();
            OpenWinForme(frm);
        }
    }
}
