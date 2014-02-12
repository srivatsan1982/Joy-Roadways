using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using JOY_BUS_LAYER.Utilities;
using JOY_CONTROL_LAYER.SysAdmin;
using JOY_BUS_LAYER.SysAdmin;

namespace JOY_UI_LAYER.SysAdmin
{
    public partial class FrmSBranch : KryptonForm
    {
        public FrmSBranch()
        {
            InitializeComponent();
        }

        #region [Wind Events]
        private void Wind_Paint(object sender, PaintEventArgs e)
        {
            ClsUtilities.PaintControl(Wind);
        }
        #endregion

        #region [Dropdown Events]
        protected void CboBranch_GotFocus(object sender, System.EventArgs e)
        {
            SendKeys.Send("(%{DOWN})");
        }
        #endregion

        #region [Button Events]

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            ProgramModule.CMPID = Convert.ToInt32((CboBranch.SelectedItem as LstItemData).Value);
            ProgramModule.COMPANY_NAME = CboBranch.Text.Trim().ToUpper();
            ProgramModule.objFrmMdiMain.Text = "Easy Billing - " + ProgramModule.COMPANY_NAME;
            this.Close();
        }

        #endregion

        #region [Common Functions]

        private void FunPubLoadBranches()
        {
            CboBranch.Enabled = false;
            using (ClsCompanyController objCompanyControl = new ClsCompanyController())
            {
                using (ClsCompanyEntity objcompanyEntity = new ClsCompanyEntity())
                {
                    DataTable DTCompany = objCompanyControl.FunPubFetchCompany(objcompanyEntity);
                    if (DTCompany.Rows.Count > 0)
                    {
                        CboBranch.Items.Clear();
                        for (int i = 0; i < DTCompany.Rows.Count - 1; i++)
                        {
                            CboBranch.Items.Add(new LstItemData(DTCompany.Rows[i]["CMPID"], DTCompany.Rows[i]["CNAME"].ToString()));
                        }
                        if (CboBranch.Items.Count != 0)
                            CboBranch.SelectedIndex = 0;
                    }
                }
            }
            CboBranch.Enabled = true;

        }

        #endregion

        #region [Form Events]

        private void FrmSBranch_Activated(object sender, EventArgs e)
        {
            CboBranch.Focus();
            if (CboBranch.Items.Count == 1)
            {
                CmdOk_Click(this, new EventArgs());
            }
        }

        private void FrmSBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }
        }

        private void FrmSBranch_Load(object sender, EventArgs e)
        {
            FunPubLoadBranches();
        } 

        #endregion
    }
}
