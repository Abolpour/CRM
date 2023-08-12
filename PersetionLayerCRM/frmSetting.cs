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
    public partial class frmSetting : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmSetting()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        private void BindGrid()
        {
            dgvActivityCategory.DataSource = null;
            dgvActivityCategory.DataSource = bll.Read();
            dgvActivityCategory.Columns["ردیف"].Visible = false;
        }
        
        ActivityCategoryBLL bll = new ActivityCategoryBLL();
        frmMsgBox m=new frmMsgBox();    
        private void frmSetting_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void pbInsert_Click(object sender, EventArgs e)
        {
            ActivityCategory a = new ActivityCategory();
            a.CategoryName = txtCategoryNane.Text;
           MessageBox.Show(bll.Create(a));
            BindGrid();
        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
