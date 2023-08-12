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
using BesinesEntitis;
namespace PersetionLayerCRM
{
    public partial class frmLogin : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        private void PBBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        Timer t3 = new Timer();
        UC_RegisterAdmin registerAdmin = new UC_RegisterAdmin();
        UC_frmLogin U_frmLogin = new UC_frmLogin();
        UserBLL UserBLL = new UserBLL();
        public void LoginFormLoad()
        {
            t3.Enabled = true;
            t3.Interval = 30;
            t3.Tick += Timer3_Tike;
            t3.Start();
        }
        bool _IsRegisterd;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            t1.Enabled = true;
            t1.Interval = 15;
            t1.Tick += Timer_Tike;
            t1.Start();
            lblLoad.Visible = true;
            this.Controls.Add(registerAdmin);
            this.Controls["UC_RegisterAdmin"].Location = new Point(233, 547);
            this.Controls.Add(U_frmLogin);
            this.Controls["UC_frmLogin"].Location = new Point(233, 547);
        }
        private void Timer_Tike(object sender, EventArgs e)
        {
            if (progressBarX1.Value >= 100)
            {
                lblLoad.Visible = false;

                t1.Stop();
                progressBarX1.Visible = false;
                lblWelcome.Visible = true;
                t2.Interval = 1;
                t2.Tick += Timer2_Tike;
                t2.Start();
            }
            else if (progressBarX1.Value == 45)
            {
                _IsRegisterd = UserBLL.IsRegister();
                progressBarX1.Value++;
            }
            else
            {
                progressBarX1.Value++;
            }
        }
        int y = 214;
        int y2 = 8;
        int y3 = 8;
        private void Timer2_Tike(object sender, EventArgs e)
        {
            if (lblWelcome.Location.Y >= 45)
            {
                y = y - 15;
                y2 = y2 - -8;
                lblWelcome.Location = new Point(340, y);
                if (_IsRegisterd)
                {
                    this.Controls["UC_frmLogin"].Location = new Point(233, y);
                }
                else
                {
                    this.Controls["UC_RegisterAdmin"].Location = new Point(273, y2);
                }
            }
            else
            {
                t2.Stop();
                PBack.Visible = true;
            }
        }
        private void Timer3_Tike(object sender, EventArgs e)
        {
            if(this.Controls["UC_frmLogin"].Location.Y >= 100)
            {
                y3 = y3 - 15;
                this.Controls["UC_frmLogin"].Location = new Point(233, y);
            }
            else
            {
                t3.Stop();
            }
        }
    }
}
