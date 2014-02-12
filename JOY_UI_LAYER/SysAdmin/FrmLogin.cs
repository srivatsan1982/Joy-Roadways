using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JOY_BUS_LAYER.Utilities;
using JOY_CONTROL_LAYER.SysAdmin;
using JOY_BUS_LAYER.SysAdmin;
namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmLogin : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region[Form Events]

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            TxtUserName.Focus();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }

        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        #endregion

        #region [Common Functions]

        public bool FunPubValidate()
        {
            if (TxtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the User Name", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUserName.Focus();
                return false;
            }
            if (TxtPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter the Password", "Joy Roadways Logistics Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPwd.Focus();
                return false;
            }
            return true;
        }
        public void FunPubClearAll()
        {
            TxtUserName.Clear();
            TxtPwd.Clear();
        }
        public void FunPubEnableDisable(bool STAT)
        {
            TxtUserName.Enabled = STAT;
            TxtPwd.Enabled = STAT;
        }
        public bool FunPubCheckLogin()
        {
            return false;
        }
        #endregion

        #region [Textbox Events]
        protected void TxtUserName_LostFocus(object sender, System.EventArgs e)
        {
            TxtUserName.SelectionLength = TxtUserName.Text.Length;
            TxtUserName.BackColor = ClsCommonVariables.INFOCUS;
        }

        protected void TxtUserName_GotFocus(object sender, System.EventArgs e)
        {
            TxtUserName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        protected void TxtPwd_LostFocus(object sender, System.EventArgs e)
        {
            TxtPwd.SelectionLength = TxtPwd.Text.Length;
            TxtPwd.BackColor = ClsCommonVariables.INFOCUS;
        }

        protected void TxtPwd_GotFocus(object sender, System.EventArgs e)
        {
            TxtPwd.BackColor = ClsCommonVariables.OUTFOCUS;
        }
        #endregion

        #region [Button Events]
        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            using (ClsUserController objCompanyControl = new ClsUserController())
             {
                 using (ClsUserEntity objcompanyEntity = new ClsUserEntity())
                 {
                     objcompanyEntity.ALLFIELDSTAT = 1;
                     objcompanyEntity.USERCODE = TxtUserName.Text.Trim();
                     objcompanyEntity.USERPWD = TxtPwd.Text.Trim();
                     DataTable DTUser = objCompanyControl.FunPubFetchUserDetails(objcompanyEntity);
                     if ((DTUser !=null) &&(DTUser.Rows.Count>0))
                     {
                         ProgramModule.Uid = Convert.ToInt32(DTUser.Rows[0]["USERID"].ToString());
                         ProgramModule.USRNAME = DTUser.Rows[0]["USERFIRSTNAME"].ToString();
                         this.Close();
                     }
                 }
             }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

    }
}
