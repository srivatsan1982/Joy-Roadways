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
    public partial class FrmBranchMaster : KryptonForm
    {
        #region [Constructor]
        public FrmBranchMaster()
        {
            InitializeComponent();
        }
        #endregion

        #region [Button Events]
        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (FunPubValidate())
            {
                FunPubSaveBranch();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtBrnchCode.Focus();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        
        #endregion

        #region[Form Events]

        private void FrmBranchMaster_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtBrnchCode.Focus();
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

        #region [Common Functions]

        public bool FunPubValidate()
        {
            if (TxtBrnchCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Branch Code", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBrnchCode.Focus();
                return false;
            }
            if (TxtBrnchName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Branch Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBrnchName.Focus();
                return false;
            }
            if (TxtBrnchCtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Branch Contact Person Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBrnchCtName.Focus();
                return false;
            }
            if (TxtBrnchAdd1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Address1", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBrnchAdd1.Focus();
                return false;
            }
            if (TxtBrnchCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the City", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBrnchCity.Focus();
                return false;
            }
            if (TxtBrnchCountry.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Country", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBrnchCountry.Focus();
                return false;
            }
            if (MskTxtBrnchMobPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Mobile Phone", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskTxtBrnchMobPhone.Focus();
                return false;
            }
            return true;
        }

        public void FunPubClearAll()
        {
            TxtBrnchAdd1.Clear();
            TxtBrnchAdd2.Clear();
            TxtBrnchCity.Clear();
            TxtBrnchCode.Clear();
            TxtBrnchCountry.Clear();
            TxtBrnchCtName.Clear();
            TxtBrnchName.Clear();
            MskTxtBrnchMobPhone.Clear();
            MskTxtBrnchPhone.Clear();
            MskTxtBrnchPinCd.Clear();
            ChkActive.Checked = true;
        }

        public void FunPubEnableDisable(bool STAT)
        {
            TxtBrnchAdd1.Enabled = STAT;
            TxtBrnchAdd2.Enabled = STAT;
            TxtBrnchCity.Enabled = STAT;
            TxtBrnchCode.Enabled = STAT;
            TxtBrnchCountry.Enabled = STAT;
            TxtBrnchCtName.Enabled = STAT;
            TxtBrnchName.Enabled = STAT;
            MskTxtBrnchMobPhone.Enabled = STAT;
            MskTxtBrnchPhone.Enabled = STAT;
            MskTxtBrnchPinCd.Enabled = STAT;
            ChkActive.Enabled = STAT;
        }
        
        public void FunPubSaveBranch()
        {
            int BranchID = 0;
            using (ClsBranchController objBranchControl = new ClsBranchController())
            {
                using (ClsBranchEntity objBranchEntity = new ClsBranchEntity())
                {
                    objBranchEntity.MODE = 1;
                    objBranchEntity.BRANCHCODE = TxtBrnchCode.Text.Trim();
                    objBranchEntity.BRANCHNAME = TxtBrnchName.Text.Trim();
                    objBranchEntity.BRANCHCONTACTNAME = TxtBrnchCtName.Text.Trim();
                    objBranchEntity.BRANCHADD1 = TxtBrnchAdd1.Text.Trim();
                    objBranchEntity.BRANCHADD2 = TxtBrnchAdd2.Text.Trim();
                    objBranchEntity.BRANCHCITY = TxtBrnchCity.Text.Trim();
                    objBranchEntity.BRANCHCOUNTRY = TxtBrnchCountry.Text.Trim();
                    objBranchEntity.BRANCHPHONE = MskTxtBrnchPhone.Text.Trim();
                    objBranchEntity.BRANCHMOBILEPHONE = MskTxtBrnchMobPhone.Text.Trim();
                    objBranchEntity.BRANCHPINCODE = MskTxtBrnchPinCd.Text.Trim();
                    objBranchEntity.ADDERID = 1;
                    objBranchEntity.MODIFIERID = 1;
                    objBranchEntity.BRANCHACTIVE  = Convert.ToBoolean(ChkActive.Checked);
                    objBranchEntity.COMPANYID = 1;
                    DataSet DSBranch = objBranchControl.FunPubBranchTransaction(objBranchEntity);
                    if ((DSBranch != null) && (DSBranch.Tables[0].Rows.Count > 0))
                    {
                        BranchID = Convert.ToInt32(DSBranch.Tables[0].Rows[0]["BRANCHID"].ToString());

                        if (MessageBox.Show("The Branch details have been inserted successfully. Would you like to add a new Branch?", "Joy Roadways Logistics Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            FunPubClearAll();
                            TxtBrnchCode.Focus();
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
