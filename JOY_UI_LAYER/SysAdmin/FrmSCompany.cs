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
    public partial class FrmSCompany : KryptonForm
    {
        public FrmSCompany()
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
        protected void ddlCompany_GotFocus(object sender, System.EventArgs e)
        {
            SendKeys.SendWait("(%{DOWN})");
        }
        #endregion

        #region [Button Events]

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            ProgramModule.CMPID = Convert.ToInt32((CboCompany.SelectedItem as LstItemData).Value);
            ProgramModule.COMPANY_NAME = CboCompany.Text.Trim().ToUpper();
            ProgramModule.objFrmMdiMain.Text = "Joy Roadways Transport Application - " + ProgramModule.COMPANY_NAME;
            this.Close();
        }

        #endregion

        #region [Common Functions]

        private void FunPubLoadCompanies()
        {
            CboCompany.Enabled = false;
            using (ClsCompanyController objCompanyControl = new ClsCompanyController())
            {
                using (ClsCompanyEntity objcompanyEntity = new ClsCompanyEntity())
                {
                    objcompanyEntity.COMPANYACTIVE = Convert.ToBoolean(false);
                    objcompanyEntity.ALLFIELDSTAT =Convert.ToInt32(false);
                    DataTable DTCompany = objCompanyControl.FunPubFetchCompany(objcompanyEntity);
                    if (DTCompany.Rows.Count > 0)
                    {
                        CboCompany.Items.Clear();
                        for (int i = 0; i < DTCompany.Rows.Count; i++)
                        {
                            CboCompany.Items.Add(new LstItemData(DTCompany.Rows[i]["CMPID"], DTCompany.Rows[i]["CMPNAME"].ToString()));
                        }
                        if (CboCompany.Items.Count != 0)
                            CboCompany.SelectedIndex = 0;
                    }
                }
            }
            CboCompany.Enabled = true;

        }

        #endregion

        #region [Form Events]

        private void FrmSCompany_Activated(object sender, EventArgs e)
        {
            CboCompany.Focus();
            if (CboCompany.Items.Count == 1)
            {
                CmdOk_Click(this, new EventArgs());
            }
        }

        private void FrmSCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }
        }

        private void FrmSCompany_Load(object sender, EventArgs e)
        {
            FunPubLoadCompanies();
        } 

        #endregion
    }
}
