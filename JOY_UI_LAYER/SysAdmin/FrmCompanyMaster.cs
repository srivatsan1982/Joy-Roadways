#region [Namespaces]
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JOY_BUS_LAYER.Utilities;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic;
#endregion

namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmCompanyMaster : KryptonForm
    {
        #region [Constructor]
        public FrmCompanyMaster()
        {
            InitializeComponent();
        }
        #endregion

        #region [Button Events]
        private void CmdFntComp_Click(object sender, EventArgs e)
        {

        }

        private void CmdFntAdd1_Click(object sender, EventArgs e)
        {

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

        }

        private void CmdClear_Click(object sender, EventArgs e)
        {

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [Common Functions]

       
        #endregion

        #region [Window Events]

        private void Wind_Paint(object sender, PaintEventArgs e)
        {
            using (ClsUtilities util = new ClsUtilities())
            {
                util.PaintControl(Wind);
            }
        }
        private void WindGrp_Paint(object sender, PaintEventArgs e)
        {
            using (ClsUtilities util = new ClsUtilities())
            {
                util.PaintControl(Wind);
            }
        }

        #endregion

        #region [Textbox Events]
        #endregion

        #region[Form Events]

        private void FrmCompanyMaster_Load(object sender, EventArgs e)
        {

        }

        private void FrmCompanyMaster_Activated(object sender, EventArgs e)
        {

        }

        private void FrmCompanyMaster_KeyDown(object sender, KeyEventArgs e)
        {
            using (ClsUtilities util = new ClsUtilities())
            {
                if (util.Validatekeys(e.KeyCode,this.ActiveControl)!=false)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void FrmCompanyMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            char res;
            using (ClsUtilities util = new ClsUtilities())
            {
                if (util.ValidateCharacter(e.KeyChar, out res) != ' ')
                {
                    e.KeyChar = res;
                }
            }
        }

        #endregion


    }
}
