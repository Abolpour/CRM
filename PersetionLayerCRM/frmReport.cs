using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using BesinesEntitis;
using BisnessLagicLayer;
namespace PersetionLayerCRM
{
    public partial class frmReport : Form
    {
        #region for design Form
        // Design Form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
            );   // Design Form
        #endregion
        public frmReport()
        {
            InitializeComponent();
            #region for design Form
            this.FormBorderStyle = FormBorderStyle.None;   // Design Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));   // Design Form
            #endregion
        }
        UserBLL ubll=new UserBLL();


        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if(RBListOldMonth.Checked)
            {
                StiReport sti =new StiReport();
                sti.Load(@"C:\Users\arman\Desktop\CRNFinalProject\DataAccessLayer\bin\Debug\ReportInvoicesListMonth.mrt");
                sti.Render();
                sti.Show();
            }
            else if(RBCustomerList.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"D:\CRNFinalProject\DataAccessLayer\bin\Debug\ReportCustomer.mrt");
                sti.Render();
                sti.Show();
            }
            else if(RBActivitys.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"C:\Users\arman\Desktop\CRNFinalProject\DataAccessLayer\bin\Debug\ReportActiviys.mrt");
                sti.Render();
                sti.Show();
            }
            else if(RbInvoicesOldWeek.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"C:\Users\arman\Desktop\CRNFinalProject\DataAccessLayer\bin\Debug\ReportInvocesOldWeek.mrt");
                sti.Render();
                sti.Show(); 
            }
            else if(RBListOldYear.Checked)
            {
                StiReport sti = new StiReport();
                sti.Load(@"C:\Users\arman\Desktop\CRNFinalProject\DataAccessLayer\bin\Debug\ReportInvocesOldYear.mrt");
                sti.Render();
                sti.Show();
            }
        }

      

        private void btnShowReportResultDisigning_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            if(RBSellsUser.Checked)
            {
                int x = 0;
                foreach (var item in ubll.ReadInvoicesList())
                {
                    foreach (var i in item.Invoices)
                    {
                        if(i.RegDate.Date > Convert.ToDateTime(txtStartDate.Text) && i.RegDate < Convert.ToDateTime(txtEndDate.Text))
                        {
                            x++;
                        }
                    }
                    chart1.Series["Series1"].Points.AddXY(item.Name, x);
                }
               
            }
        }
    }
}
