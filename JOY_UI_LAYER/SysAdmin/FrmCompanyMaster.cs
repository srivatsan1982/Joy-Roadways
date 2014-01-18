#region [Namespaces]
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using JOY_BUS_LAYER.SysAdmin;
using JOY_BUS_LAYER.Utilities;
using JOY_CONTROL_LAYER.SysAdmin;
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
            if (FunPubValidate()==true)
            {
                FunpubSaveCompany();    
            }
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

        private void CmdBrowseLogo_Click(object sender, EventArgs e)
        {
            if (FldCompanyLogo.ShowDialog()== DialogResult.OK)
            {
                TxtCmpLogoPath.Text = FldCompanyLogo.FileName;
            }
        }
        #endregion

        #region [Common Functions]

        public bool FunPubValidate()
        {
            if (TxtCmpName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Company Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpName.Focus();
                return false;
            }
            if (TxtCmpAdd1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Address1", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpAdd1.Focus();
                return false;
            }
            if (TxtCmpCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the City", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpCity.Focus();
                return false;
            }
            if (MskTxtCmpPinCd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the PinCode", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTxtCmpPinCd.Focus();
                return false;
            }
            if (TxtCmpCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Country", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpCountry.Focus();
                return false;
            }
            if (MskTxtCmpMobPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Mobile Phone", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTxtCmpMobPhone.Focus();
                return false;
            }
            if (TxtCmpPrfx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Company Prefix", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpPrfx.Focus();
                return false;
            }
            if (TxtCmpEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Email Address", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpEmail.Focus();
                return false;
            }
            if (TxtCmpCurrName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Currency Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpCurrName.Focus();
                return false;
            }
            if (TxtCmpCurrCd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Currrency Code", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpCurrCd.Focus();
                return false;
            }
            if (TxtCmpCurrSym.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Currency Symbol", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpCurrSym.Focus();
                return false;
            }
            if (TxtCmpCurrPaise.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Currency paise", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpCurrPaise.Focus();
                return false;
            }
            if (TxtCmpTINNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Company TIN No", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpTINNo.Focus();
                return false;
            }
            if (TxtCmpTNGSTNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Company TNGST No", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpTNGSTNo.Focus();
                return false;
            }
            if (TxtCmpBankAccnt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank Account Number", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpBankAccnt.Focus();
                return false;
            }
            if (TxtCmpBankNm.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpBankNm.Focus();
                return false;
            }
            if (TxtCmpBankBrnch.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank Branch", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpBankBrnch.Focus();
                return false;
            }
            if (TxtCmpIFSCCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Bank IFSC Code", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpIFSCCode.Focus();
                return false;
            }
            if (TxtCmpLogoPath.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the path for the Company Logo", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCmpLogoPath.Focus();
                return false;
            }
            if (FnCompany == null)
            {
                MessageBox.Show("Select the Font for Company", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmdFntComp.Focus();
                return false;
            }
            if (FnAddress == null)
            {
                MessageBox.Show("Select the Font for Address", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmdFntAdd1.Focus();
                return false;
            }
            return true;
        }
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
            ChkActive.Checked = true;
            FnAddress = null;
            FnCompany = null;
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
        public void FunpubSaveCompany()
        {
            int CompanyID=0;
            using (ClsCompanyController objCompanyControl = new ClsCompanyController())
            {
                using (ClsCompanyEntity objcompanyEntity = new ClsCompanyEntity())
                {
                    objcompanyEntity.MODE = 1;
                    objcompanyEntity.COMPANYNAME = TxtCmpName.Text.Trim();
                    objcompanyEntity.COMPANYALIAS = TxtCmpAliasName.Text.Trim();
                    objcompanyEntity.COMPANYADD1 = TxtCmpAdd1.Text.Trim();
                    objcompanyEntity.COMPANYADD2 = TxtCmpAdd2.Text.Trim();
                    objcompanyEntity.COMPANYBANKACCOUNT = TxtCmpBankAccnt.Text.Trim();
                    objcompanyEntity.COMPANYBANKBRANCH = TxtCmpBankBrnch.Text.Trim();
                    objcompanyEntity.COMPANYBANKIFSC = TxtCmpIFSCCode.Text.Trim();
                    objcompanyEntity.COMPANYBANKNAME = TxtCmpBankNm.Text.Trim();
                    objcompanyEntity.COMPANYCITY = TxtCmpCity.Text.Trim();
                    objcompanyEntity.COMPANYCOUNTRY = TxtCmpCountry.Text.Trim();
                    objcompanyEntity.COMPANYCURRCODE = TxtCmpCurrCd.Text.Trim();
                    string Exchange = TxtCmpExchngRate.Text == "" ? "0" : TxtCmpExchngRate.Text;
                    objcompanyEntity.COMPANYCURREXCHGRATE = Convert.ToDecimal(Exchange);
                    objcompanyEntity.COMPANYCURRNAME = TxtCmpCurrCd.Text.Trim();
                    objcompanyEntity.COMPANYCURRPAISE = TxtCmpCurrPaise.Text.Trim();
                    objcompanyEntity.COMPANYCURRSYM = TxtCmpCurrSym.Text.Trim();
                    objcompanyEntity.COMPANYEMAIL = TxtCmpEmail.Text.Trim();
                    objcompanyEntity.COMPANYFAX = TxtCmpFax.Text.Trim();
                    objcompanyEntity.COMPANYID = 0;
                    objcompanyEntity.COMPANYLOGO = TxtCmpLogoPath.Text.Trim();
                    objcompanyEntity.COMPANYMOBPHONE = MskTxtCmpMobPhone.Text.Trim();
                    objcompanyEntity.COMPANYPANNO = TxtCmpPANNo.Text.Trim();
                    objcompanyEntity.COMPANYPHONE = MskTxtCmpPhone.Text.Trim();
                    objcompanyEntity.COMPANYPIN = MskTxtCmpPinCd.Text.Trim();
                    objcompanyEntity.COMPANYPRFX = TxtCmpPrfx.Text.Trim();
                    objcompanyEntity.COMPANYTINNO = TxtCmpTINNo.Text.Trim();
                    objcompanyEntity.COMPANYTNGSTNO = TxtCmpTNGSTNo.Text.Trim();
                    objcompanyEntity.CMPADD1FONTNAME = FnAddress.OriginalFontName;
                    objcompanyEntity.CMPADD1FONTSIZE = FnAddress.Size;
                    objcompanyEntity.CMPADD1FONTSTYLE = FnAddress.Style.ToString();
                    objcompanyEntity.CMPFONTNAME = FnCompany.OriginalFontName;
                    objcompanyEntity.CMPFONTSIZE = FnCompany.Size;
                    objcompanyEntity.CMPFONTSTYLE = FnCompany.Style.ToString();
                    objcompanyEntity.ADDERID = 1;
                    objcompanyEntity.MODIFIERID = 1;
                    objcompanyEntity.COMPANYACTIVE = Convert.ToBoolean(ChkActive.Checked);
                    DataSet DSCompany= objCompanyControl.FunPubCompanyTransaction(objcompanyEntity);
                    if ((DSCompany!=null)&&(DSCompany.Tables[0].Rows.Count>0))
                    {
                        CompanyID = Convert.ToInt32(DSCompany.Tables[0].Rows[0]["CMPID"].ToString());

                        if (MessageBox.Show("The Company details have been inserted successfully. Would you like to add a new Company?", "Joy Roadways Logistics Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            FunPubClearAll();
                            TxtCmpName.Focus();
                        }
                        else
                        {
                            FunPubClearAll();
                            TxtCmpName.Focus();
                        }
                    }
                }
                
            }
        }
        public void FunPubDisplay(int CmpID)
        {
            using (ClsCompanyController objCompController = new ClsCompanyController())
            {
                using (ClsCompanyEntity objCompEntity = new ClsCompanyEntity())
                {
                    objCompEntity.COMPANYID = CmpID;
                    DataTable DTCompany= objCompController.FunPubFetchCompany(objCompEntity);
                    TxtCmpName.Text = DTCompany.Rows[0]["CMPNAME"].ToString();
                    TxtCmpAliasName.Text = DTCompany.Rows[0]["CMPALIASNAME"].ToString();
                    TxtCmpLogoPath.Text = DTCompany.Rows[0]["CMPLOGO"].ToString();
                    TxtCmpAdd1.Text = DTCompany.Rows[0]["CMPADD1"].ToString();
                    TxtCmpAdd2.Text = DTCompany.Rows[0]["CMPADD2"].ToString();
                    TxtCmpCity.Text = DTCompany.Rows[0]["CMPCITY"].ToString();
                    MskTxtCmpPinCd.Text = DTCompany.Rows[0]["CMPPINCODE"].ToString();
                    TxtCmpCountry.Text = DTCompany.Rows[0]["CMPCOUNTRY"].ToString();
                    TxtCmpEmail.Text = DTCompany.Rows[0]["CMPEMAIL"].ToString();
                    MskTxtCmpPhone.Text = DTCompany.Rows[0]["CMPPHONE"].ToString();
                    MskTxtCmpMobPhone.Text = DTCompany.Rows[0]["CMPMOBPHONE"].ToString();
                    TxtCmpFax.Text = DTCompany.Rows[0]["CMPFAX"].ToString();
                    TxtCmpTINNo.Text = DTCompany.Rows[0]["CMPTINNO"].ToString();
                    TxtCmpTNGSTNo.Text = DTCompany.Rows[0]["CMPTNGSTNO"].ToString();
                    TxtCmpPANNo.Text = DTCompany.Rows[0]["CMPPANNO"].ToString();
                    TxtCmpBankNm.Text = DTCompany.Rows[0]["CMPBANKNAME"].ToString();
                    TxtCmpBankBrnch.Text = DTCompany.Rows[0]["CMPBANKBRANCH"].ToString();
                    TxtCmpBankAccnt.Text = DTCompany.Rows[0]["CMPBANKACCNO"].ToString();
                    TxtCmpIFSCCode.Text = DTCompany.Rows[0]["CMPBANKIFSCODE"].ToString();
                    //todo
                    //FnCompany = new System.Drawing.Font(DTCompany.Rows[0]["CMPFNAME"].ToString(), Convert.ToDecimal(DTCompany.Rows[0]["CMPFSIZE"].ToString()), DTCompany.Rows[0]["CMPFSTYLE"].ToString());
                    //TxtCmpName.Text = DTCompany.Rows[0]["CMPADD1FNAME"].ToString();
                    //TxtCmpName.Text = DTCompany.Rows[0]["CMPADD1FSIZE"].ToString();
                    //TxtCmpName.Text = DTCompany.Rows[0]["CMPADD1FSTYLE"].ToString();

                    TxtCmpCurrName.Text = DTCompany.Rows[0]["CMPCURRNAME"].ToString();
                    TxtCmpCurrCd.Text = DTCompany.Rows[0]["CMPCURRCODE"].ToString();
                    TxtCmpCurrSym.Text = DTCompany.Rows[0]["CMPCURRSYM"].ToString();
                    TxtCmpCurrPaise.Text = DTCompany.Rows[0]["CMPCURRPAISE"].ToString();
                    TxtCmpExchngRate.Text = DTCompany.Rows[0]["CMPCURREXCHNG"].ToString();
                    ChkActive.Checked =Convert.ToBoolean(DTCompany.Rows[0]["ACTIVE"].ToString());
                    TxtCmpPrfx.Text = DTCompany.Rows[0]["CMPPRFX"].ToString();
                }
            }
        }
        public void FunPubSetFonts(FontDialog FnDlg)
        {
            switch (FnDlg.Tag.ToString())
            {
                case "COMPANY":
                    FnCompany = FnCmpName.ShowDialog() == DialogResult.OK ? new Font(FnCmpName.Font.FontFamily.Name, FnCmpName.Font.Size, FnCmpName.Font.Style) : null;
                    break;
                case "ADDRESS":
                    FnAddress = FnCmpAdd1.ShowDialog() == DialogResult.OK ? new Font(FnCmpAdd1.Font.FontFamily.Name, FnCmpAdd1.Font.Size, FnCmpAdd1.Font.Style) : null;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region [Window Events]

        private void Wind_Paint(object sender, PaintEventArgs e)
        {
                ClsUtilities.PaintControl(Wind);
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
        protected void TxtCmpCountry_GotFocus(object sender, EventArgs e)
        {
            TxtCmpCountry.SelectionLength = TxtCmpCountry.Text.Length;
            TxtCmpCountry.BackColor = ClsCommonVariables.INFOCUS;
        }
        protected void TxtCmpCountry_LostFocus(object sender, EventArgs e)
        {
            TxtCmpCountry.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        #endregion

        #region[Form Events]

        private void FrmCompanyMaster_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            FunPubEnableDisable(true);
            TxtCmpName.Focus();
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
