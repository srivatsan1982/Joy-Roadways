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
using JOY_CONTROL_LAYER.SysAdmin;
using JOY_BUS_LAYER.SysAdmin;

namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmVendorMaster : KryptonForm
    {
        public FrmVendorMaster()
        {
            InitializeComponent();
        }

        #region [Button Events]

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (FunPubValidate() == true)
            {
                FunPubSaveVendor();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtVndCode.Focus();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region [Common Functions]

        public bool FunPubValidate()
        {
            if (TxtVndCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Vendor Code", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndCode.Focus();
                return false;
            }
            if (TxtVndName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Vendor Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndName.Focus();
                return false;
            }
            if (TxtVndAdd1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Address1", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndAdd1.Focus();
                return false;
            }
            if (TxtVndCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the City", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndCity.Focus();
                return false;
            }
            if (MskTxtVndPinCd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the PinCode", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTxtVndPinCd.Focus();
                return false;
            }
            if (TxtVndCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Country", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndCountry.Focus();
                return false;
            }
            if (MskTxtVndMobPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Mobile Phone", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTxtVndMobPhone.Focus();
                return false;
            }
            if (TxtVndEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Email Address", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndEmail.Focus();
                return false;
            }
            if (TxtVndTINNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Vendor TIN No", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndTINNo.Focus();
                return false;
            }
            if (TxtVndBankAccnt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank Account Number", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndBankAccnt.Focus();
                return false;
            }
            if (TxtVndBankNm.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndBankNm.Focus();
                return false;
            }
            if (TxtVndBankBrnch.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank Branch", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndBankBrnch.Focus();
                return false;
            }
            if (TxtVndIFSCCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank IFSC Code", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVndIFSCCode.Focus();
                return false;
            }

            return true;
        }
        public void FunPubClearAll()
        {
            TxtVndAdd1.Clear();
            TxtVndAdd2.Clear();
            TxtVndBankAccnt.Clear();
            TxtVndBankBrnch.Clear();
            TxtVndBankNm.Clear();
            TxtVndIFSCCode.Clear();
            TxtVndCode.Clear();
            TxtVndCity.Clear();
            TxtVndCountry.Clear();
            TxtVndEmail.Clear();
            TxtVndName.Clear();
            TxtVndTINNo.Clear();
            MskTxtVndPhone.Clear();
            MskTxtVndPinCd.Clear();
            MskTxtVndMobPhone.Clear();
            ChkActive.Checked = true;
        }
        public void FunPubEnableDisable(bool STAT)
        {
            TxtVndAdd1.Enabled = STAT;
            TxtVndAdd2.Enabled = STAT;
            TxtVndBankAccnt.Enabled = STAT;
            TxtVndBankBrnch.Enabled = STAT;
            TxtVndBankNm.Enabled = STAT;
            TxtVndCode.Enabled = STAT;
            TxtVndCity.Enabled = STAT;
            TxtVndCountry.Enabled = STAT;
            TxtVndEmail.Enabled = STAT;
            TxtVndName.Enabled = STAT;
            TxtVndTINNo.Enabled = STAT;
            MskTxtVndPhone.Enabled = STAT;
            MskTxtVndPinCd.Enabled = STAT;
            MskTxtVndMobPhone.Enabled = STAT;
            TxtVndIFSCCode.Enabled = STAT;
            ChkActive.Enabled = STAT;
        }
        public void FunPubSaveVendor()
        {
            int CompanyID = 0;
            using (ClsVendorController objVendorControl = new ClsVendorController())
            {
                using (ClsVendorEntity objVendorEntity = new ClsVendorEntity())
                {
                    objVendorEntity.MODE = 1;
                    objVendorEntity.VNDCODE = TxtVndCode.Text.Trim();
                    objVendorEntity.VNDNAME = TxtVndName.Text.Trim();
                    objVendorEntity.VNDADD1 = TxtVndAdd1.Text.Trim();
                    objVendorEntity.VNDADD2 = TxtVndAdd2.Text.Trim();
                    objVendorEntity.VNDBANKACCNO = TxtVndBankAccnt.Text.Trim();
                    objVendorEntity.VNDBANKBRANCH = TxtVndBankBrnch.Text.Trim();
                    objVendorEntity.VNDBANKNAME = TxtVndBankNm.Text.Trim();
                    objVendorEntity.VNDCITY = TxtVndCity.Text.Trim();
                    objVendorEntity.VNDCOUNTRY = TxtVndCountry.Text.Trim();
                    objVendorEntity.VNDEMAIL = TxtVndEmail.Text.Trim();
                    objVendorEntity.VNDIFSCODE = TxtVndIFSCCode.Text.Trim();
                    objVendorEntity.COMPANYID = 1;
                    objVendorEntity.VNDMOBPHONE = MskTxtVndMobPhone.Text.Trim();
                    objVendorEntity.VNDPHONE = MskTxtVndPhone.Text.Trim();
                    objVendorEntity.VNDPINCODE = MskTxtVndPinCd.Text.Trim();
                    objVendorEntity.VNDTINNO = TxtVndTINNo.Text.Trim();
                    objVendorEntity.ADDERID = 1;
                    objVendorEntity.MODIFIERID = 1;
                    objVendorEntity.VNDACTIVE = Convert.ToBoolean(ChkActive.Checked);
                    DataSet DSVendor = objVendorControl.FunPubVendorTransaction(objVendorEntity);
                    if ((DSVendor != null) && (DSVendor.Tables[0].Rows.Count > 0))
                    {
                        CompanyID = Convert.ToInt32(DSVendor.Tables[0].Rows[0]["VENDORID"].ToString());

                        if (MessageBox.Show("The Vendor details have been inserted successfully. Would you like to add a new Vendor?", "Joy Roadways Logistics Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            FunPubClearAll();
                            TxtVndCode.Focus();
                        }
                        else
                        {
                            FunPubClearAll();
                            TxtVndCode.Focus();
                        }
                    }
                }

            }
        }
        public void FunPubDisplay(int CmpID)
        {

        }

        #endregion

        #region [Window Events]
        private void Wind_Paint(object sender, PaintEventArgs e)
        {
            ClsUtilities.PaintControl(Wind);
        }
        #endregion

        #region [Textbox Events]
        protected void TxtVndCountry_GotFocus(object sender, EventArgs e)
        {
            TxtVndCountry.SelectionLength = TxtVndCountry.Text.Length;
            TxtVndCountry.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndCountry_LostFocus(object sender, EventArgs e)
        {
            TxtVndCountry.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void MskTxtVndMobPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtVndMobPhone.SelectionLength = MskTxtVndMobPhone.Text.Length;
            MskTxtVndMobPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtVndMobPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtVndMobPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void MskTxtVndPinCd_GotFocus(object sender, EventArgs e)
        {
            MskTxtVndPinCd.SelectionLength = MskTxtVndPinCd.Text.Length;
            MskTxtVndPinCd.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtVndPinCd_LostFocus(object sender, EventArgs e)
        {
            MskTxtVndPinCd.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndBankNm_GotFocus(object sender, EventArgs e)
        {
            TxtVndBankNm.SelectionLength = TxtVndBankNm.Text.Length;
            TxtVndBankNm.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndBankNm_LostFocus(object sender, EventArgs e)
        {
            TxtVndBankNm.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndBankBrnch_GotFocus(object sender, EventArgs e)
        {
            TxtVndBankBrnch.SelectionLength = TxtVndBankBrnch.Text.Length;
            TxtVndBankBrnch.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndBankBrnch_LostFocus(object sender, EventArgs e)
        {
            TxtVndBankBrnch.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndBankAccnt_GotFocus(object sender, EventArgs e)
        {
            TxtVndBankAccnt.SelectionLength = TxtVndBankAccnt.Text.Length;
            TxtVndBankAccnt.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndBankAccnt_LostFocus(object sender, EventArgs e)
        {
            TxtVndBankAccnt.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndTINNo_GotFocus(object sender, EventArgs e)
        {
            TxtVndTINNo.SelectionLength = TxtVndTINNo.Text.Length;
            TxtVndTINNo.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndTINNo_LostFocus(object sender, EventArgs e)
        {
            TxtVndTINNo.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndEmail_GotFocus(object sender, EventArgs e)
        {
            TxtVndEmail.SelectionLength = TxtVndEmail.Text.Length;
            TxtVndEmail.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndEmail_LostFocus(object sender, EventArgs e)
        {
            TxtVndEmail.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void MskTxtVndPhone_GotFocus(object sender, EventArgs e)
        {
            MskTxtVndPhone.SelectionLength = MskTxtVndPhone.Text.Length;
            MskTxtVndPhone.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void MskTxtVndPhone_LostFocus(object sender, EventArgs e)
        {
            MskTxtVndPhone.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndCity_GotFocus(object sender, EventArgs e)
        {
            TxtVndCity.SelectionLength = TxtVndCity.Text.Length;
            TxtVndCity.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndCity_LostFocus(object sender, EventArgs e)
        {
            TxtVndCity.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndAdd1_GotFocus(object sender, EventArgs e)
        {
            TxtVndAdd1.SelectionLength = TxtVndAdd1.Text.Length;
            TxtVndAdd1.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndAdd1_LostFocus(object sender, EventArgs e)
        {
            TxtVndAdd1.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndAdd2_GotFocus(object sender, EventArgs e)
        {
            TxtVndAdd2.SelectionLength = TxtVndAdd2.Text.Length;
            TxtVndAdd2.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndAdd2_LostFocus(object sender, EventArgs e)
        {
            TxtVndAdd2.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndName_GotFocus(object sender, EventArgs e)
        {
            TxtVndName.SelectionLength = TxtVndName.Text.Length;
            TxtVndName.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndName_LostFocus(object sender, EventArgs e)
        {
            TxtVndName.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndCode_GotFocus(object sender, EventArgs e)
        {
            TxtVndCode.SelectionLength = TxtVndCode.Text.Length;
            TxtVndCode.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndCode_LostFocus(object sender, EventArgs e)
        {
            TxtVndCode.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        protected void TxtVndIFSCCode_GotFocus(object sender, EventArgs e)
        {
            TxtVndIFSCCode.SelectionLength = TxtVndIFSCCode.Text.Length;
            TxtVndIFSCCode.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtVndIFSCCode_LostFocus(object sender, EventArgs e)
        {
            TxtVndIFSCCode.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        #endregion

        #region[Form Events]

        private void FrmVendorMaster_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            FunPubEnableDisable(true);
            TxtVndCode.Focus();
        }

        private void FrmVendorMaster_Activated(object sender, EventArgs e)
        {

        }

        private void FrmVendorMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }

        }

        private void FrmVendorMaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion
    }
}
