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
    public partial class FrmLorryMaster : KryptonForm
    {
        public FrmLorryMaster()
        {
            InitializeComponent();
        }

        #region [Button Events]
        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (FunPubValidate())
            {
                FunPubSaveLorry();
            }
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

        #endregion

        #region[Form Events]

        private void FrmLorryMaster_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtLryName.Focus();
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

        #region [Common Functions]

        public bool FunPubValidate()
        {
            if (TxtLryName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Lorry Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLryName.Focus();
                return false;
            }
            if (TxtLryNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Lorry Number", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLryNumber.Focus();
                return false;
            }
            if (TxtLryOwnrName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Lorry Owner Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLryOwnrName.Focus();
                return false;
            }
            if (TxtLryDesc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Description", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLryDesc.Focus();
                return false;
            }
            return true;
        }

        public void FunPubClearAll()
        {
            TxtLryName.Clear();
            TxtLryNumber.Clear();
            TxtLryOwnrName.Clear();
            TxtLryDesc.Clear();
            ChkActive.Checked = true;
        }

        public void FunPubEnableDisable(bool STAT)
        {
            TxtLryName.Enabled = STAT;
            TxtLryNumber.Enabled = STAT;
            TxtLryOwnrName.Enabled = STAT;
            TxtLryDesc.Enabled = STAT;
            ChkActive.Enabled = STAT;
        }

        public void FunPubSaveLorry()
        {
            int LorryID = 0;
            using (ClsLorryController objLorryControl = new ClsLorryController())
            {
                using (ClsLorryEntity objLorryEntity = new ClsLorryEntity())
                {
                    objLorryEntity.MODE = 1;
                    objLorryEntity.LRYNAME = TxtLryName.Text.Trim();
                    objLorryEntity.LRYNUMBER = TxtLryNumber.Text.Trim();
                    objLorryEntity.LRYOWNER = 1;//To do TxtLryOwnrName.Text.Trim();
                    objLorryEntity.LRYDESC = TxtLryDesc.Text.Trim();
                    objLorryEntity.ADDERID = 1;
                    objLorryEntity.MODIFIERID = 1;
                    objLorryEntity.LORRYACTIVE = Convert.ToBoolean(ChkActive.Checked);
                    objLorryEntity.COMPANYID = 1;
                    DataSet DSLorry = objLorryControl.FunPubLorryTransaction(objLorryEntity);
                    if ((DSLorry != null) && (DSLorry.Tables[0].Rows.Count > 0))
                    {
                        LorryID = Convert.ToInt32(DSLorry.Tables[0].Rows[0]["LORRYID"].ToString());

                        if (MessageBox.Show("The Lorry details have been inserted successfully. Would you like to add a new Lorry?", "Joy Roadways Logistics Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            FunPubClearAll();
                            TxtLryName.Focus();
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
