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
using System.Windows.Forms;
#endregion

namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmCompanyMaster : KryptonForm
    {
        #region [Common Variables]
        private Font FnCompany;
        private Font FnAddress;
        #endregion[Common Variables]

        #region [Constructor]
        public FrmCompanyMaster()
        {
            InitializeComponent();
        }
        #endregion

        #region [Button Events]
        private void CmdFntComp_Click(object sender, EventArgs e)
        {
            FunPubSetFonts(FnCmpName);
        }

        private void CmdFntAdd1_Click(object sender, EventArgs e)
        {
            FunPubSetFonts(FnCmpAdd1);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtCmpName.Focus();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region [Common Functions]
        public void FunPubClearAll()
        {
            TxtCmpAdd1.Clear();
            TxtCmpAdd2.Clear();
            TxtCmpAliasName.Clear();
            TxtCmpBankAccnt.Clear();
            TxtCmpBankBrnch.Clear();
            TxtCmpBankNm.Clear();
            TxtCmpCity.Clear();
            TxtCmpCurrCd.Clear();
            TxtCmpCurrName.Clear();
            TxtCmpCurrPaise.Clear();
            TxtCmpCurrSym.Clear();
            TxtCmpEmail.Clear();
            TxtCmpExchngRate.Clear();
            TxtCmpFax.Clear();
            TxtCmpName.Clear();
            TxtCmpPANNo.Clear();
            MskTxtCmpPhone.Clear();
            MskTxtCmpPinCd.Clear();
            MskTxtCmpMobPhone.Clear();
            TxtCmpPrfx.Clear();
            TxtCmpTINNo.Clear();
            TxtCmpTNGSTNo.Clear();
        }
        public void FunPubEnableDisable(bool STAT)
        {
            TxtCmpAdd1.Enabled = STAT;
            TxtCmpAdd2.Enabled = STAT;
            TxtCmpAliasName.Enabled = STAT;
            TxtCmpBankAccnt.Enabled = STAT;
            TxtCmpBankBrnch.Enabled = STAT;
            TxtCmpBankNm.Enabled = STAT;
            TxtCmpCity.Enabled = STAT;
            TxtCmpCurrCd.Enabled = STAT;
            TxtCmpCurrName.Enabled = STAT;
            TxtCmpCurrPaise.Enabled = STAT;
            TxtCmpCurrSym.Enabled = STAT;
            TxtCmpEmail.Enabled = STAT;
            TxtCmpExchngRate.Enabled = STAT;
            TxtCmpFax.Enabled = STAT;
            TxtCmpName.Enabled = STAT;
            TxtCmpPANNo.Enabled = STAT;
            MskTxtCmpPhone.Enabled = STAT;
            MskTxtCmpPinCd.Enabled = STAT;
            MskTxtCmpMobPhone.Enabled = STAT;
            TxtCmpPrfx.Enabled = STAT;
            TxtCmpTINNo.Enabled = STAT;
            TxtCmpTNGSTNo.Enabled = STAT;
        }
        public void FunPubDisplay(int CmpID)
        {

        }
        public void FunPubSetFonts(FontDialog FnDlg)
        {
            switch (FnDlg.Tag.ToString())
            {
                case "COMPANY":
                    FnCompany = FnCmpName.ShowDialog() == DialogResult.OK ? new Font(FnCmpName.Font.FontFamily.Name, FnCmpName.Font.Size, FnCmpName.Font.Style) : null;
                    break;
                case "ADDRESS":
                    FnAddress = FnCmpName.ShowDialog() == DialogResult.OK ? new Font(FnCmpAdd1.Font.FontFamily.Name, FnCmpAdd1.Font.Size, FnCmpAdd1.Font.Style) : null;
                    break;
                default:
                    break;
            }
        }
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
        protected void TxtCmpName_GotFocus(object sender, EventArgs e)
        {
            TxtCmpName.SelectionLength = TxtCmpName.Text.Length;
            TxtCmpName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpName_LostFocus(object sender, EventArgs e)
        {
            TxtCmpName.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpAdd1_GotFocus(object sender, EventArgs e)
        {
            TxtCmpAdd1.SelectionLength = TxtCmpAdd1.Text.Length;
            TxtCmpAdd1.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpAdd1_LostFocus(object sender, EventArgs e)
        {
            TxtCmpAdd1.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpAdd2_GotFocus(object sender, EventArgs e)
        {
            TxtCmpAdd2.SelectionLength = TxtCmpAdd2.Text.Length;
            TxtCmpAdd2.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpAdd2_LostFocus(object sender, EventArgs e)
        {
            TxtCmpAdd2.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpAliasName_GotFocus(object sender, EventArgs e)
        {
            TxtCmpAliasName.SelectionLength = TxtCmpAliasName.Text.Length;
            TxtCmpAliasName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpAliasName_LostFocus(object sender, EventArgs e)
        {
            TxtCmpAliasName.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpBankAccnt_GotFocus(object sender, EventArgs e)
        {
            TxtCmpBankAccnt.SelectionLength = TxtCmpBankAccnt.Text.Length;
            TxtCmpBankAccnt.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpBankAccnt_LostFocus(object sender, EventArgs e)
        {
            TxtCmpBankAccnt.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpBankBrnch_GotFocus(object sender, EventArgs e)
        {
            TxtCmpBankBrnch.SelectionLength = TxtCmpBankBrnch.Text.Length;
            TxtCmpBankBrnch.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpBankBrnch_LostFocus(object sender, EventArgs e)
        {
            TxtCmpBankBrnch.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpBankNm_GotFocus(object sender, EventArgs e)
        {
            TxtCmpBankNm.SelectionLength = TxtCmpBankNm.Text.Length;
            TxtCmpBankNm.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpBankNm_LostFocus(object sender, EventArgs e)
        {
            TxtCmpBankNm.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpCity_GotFocus(object sender, EventArgs e)
        {
            TxtCmpCity.SelectionLength = TxtCmpCity.Text.Length;
            TxtCmpCity.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpCity_LostFocus(object sender, EventArgs e)
        {
            TxtCmpCity.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpCurrCd_GotFocus(object sender, EventArgs e)
        {
            TxtCmpCurrCd.SelectionLength = TxtCmpCurrCd.Text.Length;
            TxtCmpCurrCd.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpCurrCd_LostFocus(object sender, EventArgs e)
        {
            TxtCmpCurrCd.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpCurrName_GotFocus(object sender, EventArgs e)
        {
            TxtCmpCurrName.SelectionLength = TxtCmpCurrName.Text.Length;
            TxtCmpCurrName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpCurrName_LostFocus(object sender, EventArgs e)
        {
            TxtCmpCurrName.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpCurrPaise_GotFocus(object sender, EventArgs e)
        {
            TxtCmpCurrPaise.SelectionLength = TxtCmpCurrPaise.Text.Length;
            TxtCmpCurrPaise.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpCurrPaise_LostFocus(object sender, EventArgs e)
        {
            TxtCmpCurrPaise.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpCurrSym_GotFocus(object sender, EventArgs e)
        {
            TxtCmpCurrSym.SelectionLength = TxtCmpCurrSym.Text.Length;
            TxtCmpCurrSym.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpCurrSym_LostFocus(object sender, EventArgs e)
        {
            TxtCmpCurrSym.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpEmail_GotFocus(object sender, EventArgs e)
        {
            TxtCmpEmail.SelectionLength = TxtCmpEmail.Text.Length;
            TxtCmpEmail.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpEmail_LostFocus(object sender, EventArgs e)
        {
            TxtCmpEmail.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpExchngRate_GotFocus(object sender, EventArgs e)
        {
            TxtCmpExchngRate.SelectionLength = TxtCmpExchngRate.Text.Length;
            TxtCmpExchngRate.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpExchngRate_LostFocus(object sender, EventArgs e)
        {
            TxtCmpExchngRate.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpFax_GotFocus(object sender, EventArgs e)
        {
            TxtCmpFax.SelectionLength = TxtCmpFax.Text.Length;
            TxtCmpFax.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpFax_LostFocus(object sender, EventArgs e)
        {
            TxtCmpFax.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpPANNo_GotFocus(object sender, EventArgs e)
        {
            TxtCmpPANNo.SelectionLength = TxtCmpPANNo.Text.Length;
            TxtCmpPANNo.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpPANNo_LostFocus(object sender, EventArgs e)
        {
            TxtCmpPANNo.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void MskTxtCmpPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtCmpPhone.SelectionLength = MskTxtCmpPhone.Text.Length;
            MskTxtCmpPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtCmpPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtCmpPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void MskTxtCmpPinCd_GotFocus(object sender, EventArgs e)
        {
            MskTxtCmpPinCd.SelectionLength = MskTxtCmpPinCd.Text.Length;
            MskTxtCmpPinCd.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtCmpPinCd_LostFocus(object sender, EventArgs e)
        {
            MskTxtCmpPinCd.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpPrfx_GotFocus(object sender, EventArgs e)
        {
            TxtCmpPrfx.SelectionLength = TxtCmpPrfx.Text.Length;
            TxtCmpPrfx.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpPrfx_LostFocus(object sender, EventArgs e)
        {
            TxtCmpPrfx.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpTINNo_GotFocus(object sender, EventArgs e)
        {
            TxtCmpTINNo.SelectionLength = TxtCmpTINNo.Text.Length;
            TxtCmpTINNo.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpTINNo_LostFocus(object sender, EventArgs e)
        {
            TxtCmpTINNo.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtCmpTNGSTNo_GotFocus(object sender, EventArgs e)
        {
            TxtCmpTNGSTNo.SelectionLength = TxtCmpTNGSTNo.Text.Length;
            TxtCmpTNGSTNo.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpTNGSTNo_LostFocus(object sender, EventArgs e)
        {
            TxtCmpTNGSTNo.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void MskTxtCmpMobPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtCmpMobPhone.SelectionLength = MskTxtCmpMobPhone.Text.Length;
            MskTxtCmpMobPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtCmpMobPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtCmpMobPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }
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
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }

        }

        private void FrmCompanyMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion


    }
}
