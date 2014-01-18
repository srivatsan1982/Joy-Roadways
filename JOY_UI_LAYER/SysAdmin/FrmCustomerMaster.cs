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
            if (FunPubValidate())
            {
                FunPubSaveCustomer();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtCustCode.Focus();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();

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

        #endregion

        #region[Form Events]

        private void FrmCustomerMaster_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtCustCode.Focus();
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

        #region [Common Functions]

        public bool FunPubValidate()
        {
            if (TxtCustCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Customer Code", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCustCode.Focus();
                return false;
            }
            if (TxtCustFrName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the First Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCustFrName.Focus();
                return false;
            }
            if (TxtCustLnName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Last Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCustLnName.Focus();
                return false;
            }
            if (TxtCustAdd1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Address1", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCustAdd1.Focus();
                return false;
            }
            if (TxtCustCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the City", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCustCity.Focus();
                return false;
            }
            if (TxtCustCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Country", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCustCountry.Focus();
                return false;
            }
            if (MskTxtCustMobPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Mobile Phone", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTxtCustMobPhone.Focus();
                return false;
            }
            return true;
        }

        public void FunPubClearAll()
        {
            TxtCustAdd1.Clear();
            TxtCustAdd2.Clear();
            TxtCustCity.Clear();
            TxtCustCode.Clear();
            TxtCustCountry.Clear();
            TxtCustEmail.Clear();
            TxtCustFrName.Clear();
            TxtCustLnName.Clear();
            MskTxtCustMobPhone.Clear();
            MskTxtCustPhone.Clear();
            MskTxtCustPinCd.Clear();
            ChkActive.Checked = true;
        }

        public void FunPubEnableDisable(bool STAT)
        {
            TxtCustAdd1.Enabled = STAT;
            TxtCustAdd2.Enabled = STAT;
            TxtCustCity.Enabled = STAT;
            TxtCustCode.Enabled = STAT;
            TxtCustCountry.Enabled = STAT;
            TxtCustEmail.Enabled = STAT;
            TxtCustFrName.Enabled = STAT;
            TxtCustLnName.Enabled = STAT;
            MskTxtCustMobPhone.Enabled = STAT;
            MskTxtCustPhone.Enabled = STAT;
            MskTxtCustPinCd.Enabled = STAT;
            ChkActive.Enabled = STAT;
        }

        public void FunPubSaveCustomer()
        {
            int CustomerID = 0;
            using (ClsCustomerController objCustomerControl = new ClsCustomerController())
            {
                using (ClsCustomerEntity objCustomerEntity = new ClsCustomerEntity())
                {
                    objCustomerEntity.MODE = 1;
                    objCustomerEntity.CUSTCODE = TxtCustCode.Text.Trim();
                    objCustomerEntity.CUSTFIRSTNAME = TxtCustFrName.Text.Trim();
                    objCustomerEntity.CUSTLASTNAME = TxtCustLnName.Text.Trim();
                    objCustomerEntity.CUSTADD1 = TxtCustAdd1.Text.Trim();
                    objCustomerEntity.CUSTADD2 = TxtCustAdd2.Text.Trim();
                    objCustomerEntity.CUSTCITY = TxtCustCity.Text.Trim();
                    objCustomerEntity.CUSTCOUNTRY = TxtCustCountry.Text.Trim();
                    objCustomerEntity.CUSTEMAIL = TxtCustEmail.Text.Trim();
                    objCustomerEntity.CUSTPHONE = MskTxtCustPhone.Text.Trim();
                    objCustomerEntity.CUSTMOBPHONE = MskTxtCustMobPhone.Text.Trim();
                    objCustomerEntity.CUSTPINCODE = MskTxtCustPinCd.Text.Trim();
                    objCustomerEntity.ADDERID = 1;
                    objCustomerEntity.MODIFIERID = 1;
                    objCustomerEntity.CUSTACTIVE = Convert.ToBoolean(ChkActive.Checked);
                    objCustomerEntity.COMPANYID = 1;
                    DataSet DSCustomer = objCustomerControl.FunPubCustomerTransaction(objCustomerEntity);
                    if ((DSCustomer != null) && (DSCustomer.Tables[0].Rows.Count > 0))
                    {
                        CustomerID = Convert.ToInt32(DSCustomer.Tables[0].Rows[0]["CUSTOMERID"].ToString());

                        if (MessageBox.Show("The Customer details have been inserted successfully. Would you like to add a new Customer?", "Joy Roadways Logistics Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            FunPubClearAll();
                            TxtCustCode.Focus();
                        }
                        else
                        {
                            FunPubClearAll();
                            this.Close();
                        }
                    }
                }

            }
        }

        public void FunPubDisplay(int CmpID)
        {

        }

        #endregion
    }
}
