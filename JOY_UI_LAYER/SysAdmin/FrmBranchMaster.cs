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
    public partial class FrmBranchMaster : KryptonForm
    {
        public FrmBranchMaster()
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
        protected void TxtBrnchCountry_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchCountry.SelectionLength = TxtBrnchCountry.Text.Length;
            TxtBrnchCountry.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchCountry_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchCountry.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void MskTxtBrnchMobPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtBrnchMobPhone.SelectionLength = MskTxtBrnchMobPhone.Text.Length;
            MskTxtBrnchMobPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtBrnchMobPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtBrnchMobPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void MskTxtBrnchPinCd_GotFocus(object sender, EventArgs e)
        {
            MskTxtBrnchPinCd.SelectionLength = MskTxtBrnchPinCd.Text.Length;
            MskTxtBrnchPinCd.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtBrnchPinCd_LostFocus(object sender, EventArgs e)
        {
            MskTxtBrnchPinCd.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void MskTxtBrnchPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtBrnchPhone.SelectionLength = MskTxtBrnchPhone.Text.Length;
            MskTxtBrnchPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtBrnchPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtBrnchPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtBrnchCity_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchCity.SelectionLength = TxtBrnchCity.Text.Length;
            TxtBrnchCity.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchCity_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchCity.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtBrnchAdd1_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchAdd1.SelectionLength = TxtBrnchAdd1.Text.Length;
            TxtBrnchAdd1.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchAdd1_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchAdd1.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtBrnchAdd2_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchAdd2.SelectionLength = TxtBrnchAdd2.Text.Length;
            TxtBrnchAdd2.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchAdd2_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchAdd2.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtBrnchName_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchName.SelectionLength = TxtBrnchName.Text.Length;
            TxtBrnchName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchName_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtBrnchCode_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchCode.SelectionLength = TxtBrnchCode.Text.Length;
            TxtBrnchCode.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchCode_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchCode.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtBrnchCtName_GotFocus(object sender, EventArgs e)
        {
            TxtBrnchCtName.SelectionLength = TxtBrnchCtName.Text.Length;
            TxtBrnchCtName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtBrnchCtName_LostFocus(object sender, EventArgs e)
        {
            TxtBrnchCtName.BackColor = ClsCommonVariables.OUTFOCUS;
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

        private void FrmBranchMaster_Load(object sender, EventArgs e)
        {

        }

        private void FrmBranchMaster_Activated(object sender, EventArgs e)
        {

        }

        private void FrmBranchMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }

        }

        private void FrmBranchMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion
    }
}
