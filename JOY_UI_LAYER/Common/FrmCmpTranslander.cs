﻿#region [Namespaces]
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using JOY_UI_LAYER.SysAdmin;
using JOY_BUS_LAYER.SysAdmin;
using JOY_BUS_LAYER.Utilities;
using JOY_CONTROL_LAYER.SysAdmin;
#endregion

namespace JOY_UI_LAYER.Common
{
    public partial class FrmCmpTranslander : KryptonForm
    {
        #region [Constructor]
        public FrmCmpTranslander()
        {
            InitializeComponent();
        }
        #endregion

        #region [Form Events]
        private void FrmCmpTranslander_Load(object sender, EventArgs e)
        {
            FunPubClearAll();
            FunPubEnableDisable(true);
            ProgramModule.SETPOS(Wind, this);
            TxtStDate.Focus();
        }

        private void FrmCmpTranslander_Activated(object sender, EventArgs e)
        {

        }

        private void FrmCmpTranslander_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClsCommonVariables.KEY_ENTER)
            {
                this.SelectNextControl(ActiveControl, forward: true, tabStopOnly: true, nested: true, wrap: true);
            }
        }

        private void FrmCmpTranslander_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        
        #endregion

        #region [Textbox Events]

        void TxtName_GotFocus(object sender, EventArgs e)
        {
            TxtName.SelectionLength = TxtName.Text.Length;
            TxtName.BackColor = ClsCommonVariables.INFOCUS;
        }

        void TxtName_LostFocus(object sender, EventArgs e)
        {
            TxtName.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        void TxtStDate_GotFocus(object sender, EventArgs e)
        {
            TxtStDate.SelectionLength = TxtStDate.Text.Length;
            TxtStDate.BackColor = ClsCommonVariables.INFOCUS;
        }

        void TxtStDate_LostFocus(object sender, EventArgs e)
        {
            TxtStDate.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        void TxtFnDate_GotFocus(object sender, EventArgs e)
        {
            TxtFnDate.SelectionLength = TxtFnDate.Text.Length;
            TxtFnDate.BackColor = ClsCommonVariables.INFOCUS;
        }

        void TxtFnDate_LostFocus(object sender, EventArgs e)
        {
            TxtFnDate.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        void TxtCity_GotFocus(object sender, EventArgs e)
        {
            TxtCity.SelectionLength = TxtCity.Text.Length;
            TxtCity.BackColor = ClsCommonVariables.INFOCUS;
        }

        void TxtCity_LostFocus(object sender, EventArgs e)
        {
            TxtCity.BackColor = ClsCommonVariables.OUTFOCUS;
        }

        #endregion

        #region [Button Events]
        private void CmdSearch_Click(object sender, EventArgs e)
        {
            using (ClsCompanyEntity objCompEntity = new ClsCompanyEntity())
            {
                objCompEntity.ALLFIELDSTAT = 1;
                objCompEntity.COMPANYACTIVE =Convert.ToBoolean(ChkInActive.Checked);
                objCompEntity.COMPANYNAME = TxtName.Text.Trim();
                objCompEntity.COMPANYCITY = TxtCity.Text.Trim();
                objCompEntity.ADDEDDATE = Convert.ToDateTime(TxtStDate.Text.Trim());
                objCompEntity.MODIFIEDDATE = Convert.ToDateTime(TxtFnDate.Text.Trim());
                FunPubBindCompanyDetails(objCompEntity);
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            FunPubClearAll();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region [Common Functions]

        public void FunPubClearAll()
        {
            TxtCity.Clear();
            TxtFnDate.Clear();
            TxtName.Clear();
            TxtStDate.Clear();
            GridNav.BindingSource = null;
            DgvResult.DataSource = null;
            ChkInActive.Checked = true;
        }

        public void FunPubEnableDisable(bool STAT)
        {
            TxtCity.Enabled = STAT;
            TxtFnDate.Enabled = STAT;
            TxtName.Enabled = STAT;
            TxtStDate.Enabled = STAT;
        }

        public void FunPubBindCompanyDetails(ClsCompanyEntity objCompEntity)
        {
            using (ClsCompanyController objCompController = new ClsCompanyController())
            {
                DataTable DTCompany = objCompController.FunPubFetchCompany(objCompEntity);
                BindingSource bs = new BindingSource();
                bs.DataSource = DTCompany.DefaultView;
                GridNav.BindingSource = bs;
                DgvResult.DataSource = bs;
            }
        }
        #endregion

        #region [Binding Navigator Events]
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FrmCompanyMaster objFrmCompany = new FrmCompanyMaster();
            objFrmCompany.ShowDialog();
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [Panel Events]
        private void Wind_Paint(object sender, PaintEventArgs e)
        {
            ClsUtilities.PaintControl(Wind);
        } 
        #endregion

        #region [DataGridview Event]
        protected void DgvResult_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (this.DgvResult.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                if (e.Value ==null)
                {
                    e.Value = "Edit";
                    e.FormattingApplied = true;
                }
            }
        }
        protected void DgvResult_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (this.DgvResult.Columns[e.ColumnIndex].Name == "Edit")
            {

            }
        }

        #endregion


    }
}
