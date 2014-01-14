using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using JOY_BUS_LAYER.Utilities;

namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmLorryMaster : KryptonForm
    {
        public FrmLorryMaster()
        {
            InitializeComponent();
        }

        #region [Button Events]
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

        #region [Textbox Event]
        protected void TxtLryOwnrName_GotFocus(object sender, EventArgs e)
        {
            TxtLryOwnrName.SelectionLength = TxtLryOwnrName.Text.Length;
            TxtLryOwnrName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtLryOwnrName_LostFocus(object sender, EventArgs e)
        {
            TxtLryOwnrName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtLryNumber_GotFocus(object sender, EventArgs e)
        {
            TxtLryNumber.SelectionLength = TxtLryNumber.Text.Length;
            TxtLryNumber.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtLryNumber_LostFocus(object sender, EventArgs e)
        {
            TxtLryNumber.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtLryDesc_GotFocus(object sender, EventArgs e)
        {
            TxtLryDesc.SelectionLength = TxtLryDesc.Text.Length;
            TxtLryDesc.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtLryDesc_LostFocus(object sender, EventArgs e)
        {
            TxtLryDesc.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtLryName_GotFocus(object sender, EventArgs e)
        {
            TxtLryName.SelectionLength = TxtLryName.Text.Length;
            TxtLryName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtLryName_LostFocus(object sender, EventArgs e)
        {
            TxtLryName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        #endregion

        #region [Window Events]

        private void Wind_Paint(object sender, PaintEventArgs e)
        {
            ClsUtilities.PaintControl(Wind);
        }
        private void WindGrp_Paint(object sender, PaintEventArgs e)
        {
            ClsUtilities.PaintControl(Wind);
        }

        #endregion

        #region[Form Events]

        private void FrmLorryMaster_Load(object sender, EventArgs e)
        {

        }

        private void FrmLorryMaster_Activated(object sender, EventArgs e)
        {

        }

        private void FrmLorryMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }

        }

        private void FrmLorryMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion
    }
}
