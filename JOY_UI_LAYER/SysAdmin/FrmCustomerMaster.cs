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
    public partial class FrmCustomerMaster : KryptonForm
    {
        #region [Constructor]
        public FrmCustomerMaster()
        {
            InitializeComponent();
        } 
        #endregion

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
        protected void TxtCustCountry_GotFocus(object sender, EventArgs e)
        {
            TxtCustCountry.SelectionLength = TxtCustCountry.Text.Length;
            TxtCustCountry.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustCountry_LostFocus(object sender, EventArgs e)
        {
            TxtCustCountry.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void MskTxtCustPinCd_GotFocus(object sender, EventArgs e)
        {
            MskTxtCustPinCd.SelectionLength = MskTxtCustPinCd.Text.Length;
            MskTxtCustPinCd.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtCustPinCd_LostFocus(object sender, EventArgs e)
        {
            MskTxtCustPinCd.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void MskTxtCustPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtCustPhone.SelectionLength = MskTxtCustPhone.Text.Length;
            MskTxtCustPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtCustPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtCustPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustCity_GotFocus(object sender, EventArgs e)
        {
            TxtCustCity.SelectionLength = TxtCustCity.Text.Length;
            TxtCustCity.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustCity_LostFocus(object sender, EventArgs e)
        {
            TxtCustCity.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustAdd1_GotFocus(object sender, EventArgs e)
        {
            TxtCustAdd1.SelectionLength = TxtCustAdd1.Text.Length;
            TxtCustAdd1.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustAdd1_LostFocus(object sender, EventArgs e)
        {
            TxtCustAdd1.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustAdd2_GotFocus(object sender, EventArgs e)
        {
            TxtCustAdd2.SelectionLength = TxtCustAdd2.Text.Length;
            TxtCustAdd2.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustAdd2_LostFocus(object sender, EventArgs e)
        {
            TxtCustAdd2.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustFrName_GotFocus(object sender, EventArgs e)
        {
            TxtCustFrName.SelectionLength = TxtCustFrName.Text.Length;
            TxtCustFrName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustFrName_LostFocus(object sender, EventArgs e)
        {
            TxtCustFrName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustCode_GotFocus(object sender, EventArgs e)
        {
            TxtCustCode.SelectionLength = TxtCustCode.Text.Length;
            TxtCustCode.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustCode_LostFocus(object sender, EventArgs e)
        {
            TxtCustCode.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustLnName_GotFocus(object sender, EventArgs e)
        {
            TxtCustLnName.SelectionLength = TxtCustLnName.Text.Length;
            TxtCustLnName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustLnName_LostFocus(object sender, EventArgs e)
        {
            TxtCustLnName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void MskTxtCustMobPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtCustMobPhone.SelectionLength = MskTxtCustMobPhone.Text.Length;
            MskTxtCustMobPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtCustMobPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtCustMobPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtCustEmail_GotFocus(object sender, EventArgs e)
        {
            TxtCustEmail.SelectionLength = TxtCustEmail.Text.Length;
            TxtCustEmail.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCustEmail_LostFocus(object sender, EventArgs e)
        {
            TxtCustEmail.BackColor = ClsCommonVariables.OUTFOCUS;
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

        private void FrmCustomerMaster_Load(object sender, EventArgs e)
        {

        }

        private void FrmCustomerMaster_Activated(object sender, EventArgs e)
        {

        }

        private void FrmCustomerMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }

        }

        private void FrmCustomerMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        #endregion
    }
}
