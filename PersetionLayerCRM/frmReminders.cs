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
    public partial class frmReminders : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmReminders()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        ReminderBLL Rbll = new ReminderBLL();
        UserBLL Ubll = new UserBLL();
        User u = new User();
        private void BindGrid()
        {
            dgvReminder.DataSource = null;
            dgvReminder.DataSource = Rbll.Read();
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReminders_Load(object sender, EventArgs e)
        {
            //For Source Names Is TxtUser => Name
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            foreach (var item in Ubll.ReadUserNamesList())
            {
                names.Add(item);
            }
            txtSerchUser_Name.AutoCompleteCustomSource = names;
            BindGrid();
        }

        private void PBInsertUserName_Click(object sender, EventArgs e)
        {
            txtSerchUser_Name.Enabled = false;
            u = Ubll.ReadByName(txtSerchUser_Name.Text);
        }

        private void PBInsert_Click(object sender, EventArgs e)
        {
            Reminder r = new Reminder();
            r.Title = txtTitile.Text;
            r.ReminderInfo = txtReminderInfo.Text;
            r.RegDate = DateTime.Now;
            r.ReminderDate = dateTimeInput1.Value.Date;
            r.Users = u;
            MessageBox.Show(Rbll.Create(r, u));
            BindGrid();
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

