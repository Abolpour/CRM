using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PersetionLayerCRM.MsgBoxClass
{
    public class MsgBox
    {

        public DialogResult MyShowDialg(string title,string FaInfo,string EnInfo,bool buttons,bool type)
        {
            frmMsgBox m = new frmMsgBox();
            m.lblTitleMassageSample.Text = title;
            m.lblErrorPerstion.Text = FaInfo;
            m.lblErrorEnglish.Text = EnInfo;
            if(buttons)
            {
                m.btnClose.Text = "خیر";
                
            }
            else
            {
                m.btnYes.Visible = false;
            }
            if(type)
            {
                m.BackColor = Color.FromArgb(242, 69, 29);
                m.PBMsg.Image = Properties.Resources.Error;
            }
            m.ShowDialog();
            return m.DialogResult;
        }

    }
}
