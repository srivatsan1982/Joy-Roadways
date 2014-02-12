using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using JOY_BUS_LAYER.Utilities;

namespace JOY_UI_LAYER.Common
{
    public partial class FrmMdiMain : KryptonForm
    {
        #region [Common Variables]
        public int Uid = 0;

        #endregion
        public FrmMdiMain()
        {
            InitializeComponent();
        }

        private void FrmMdiMain_Load(object sender, EventArgs e)
        {

        }

        private void rbtnCompanies_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramModule.REP = "CMP";
                ProgramModule.CurFrmNo = 0;
                if (ProgramModule.FrmNo > 1)
                {
                    ProgramModule.SAVED = true;
                    ProgramModule.FindFrm("FrmCmpTranslander", ProgramModule.REP);
                    if (!ProgramModule.SAVED)
                    {
                        return;
                    }

                }
                if (ProgramModule.CurFrmNo == 0)
                {
                    ProgramModule.SAVED = false;
                    Array.Resize(ref ProgramModule.ShwFrm, ProgramModule.FrmNo + 1);
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm = new FrmCmpTranslander();
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].frmTag = ProgramModule.REP;
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm.MdiParent = this;
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm.BringToFront();
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm.Show();
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].FrmName = "FrmCmpTranslander";
                    ProgramModule.FrmNo = ProgramModule.FrmNo + 1;
                }
                else
                {
                    ProgramModule.ShwFrm[ProgramModule.CurFrmNo].ObjFrm.BringToFront();
                    ProgramModule.ShwFrm[ProgramModule.CurFrmNo].ObjFrm.Show();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            ProgramModule.ActiveChildForm = this.ActiveMdiChild;
            ProgramModule.ActiveChildForm.Text = "Search Companies";
        }

        private void rbtnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramModule.REP = "CUST";
                ProgramModule.CurFrmNo = 0;
                if (ProgramModule.FrmNo > 1)
                {
                    ProgramModule.SAVED = true;
                    ProgramModule.FindFrm("FrmCustTranslander.cs", ProgramModule.REP);
                    if (!ProgramModule.SAVED)
                    {
                        return;
                    }

                }
                if (ProgramModule.CurFrmNo == 0)
                {
                    ProgramModule.SAVED = false;
                    Array.Resize(ref ProgramModule.ShwFrm, ProgramModule.FrmNo + 1);
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm = new FrmCustTranslander();
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].frmTag = ProgramModule.REP;
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm.MdiParent = this;
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm.BringToFront();
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].ObjFrm.Show();
                    ProgramModule.ShwFrm[ProgramModule.FrmNo].FrmName = "FrmCustTranslander.cs";
                    ProgramModule.FrmNo = ProgramModule.FrmNo + 1;
                }
                else
                {
                    ProgramModule.ShwFrm[ProgramModule.CurFrmNo].ObjFrm.BringToFront();
                    ProgramModule.ShwFrm[ProgramModule.CurFrmNo].ObjFrm.Show();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            ProgramModule.ActiveChildForm = this.ActiveMdiChild;
            ProgramModule.ActiveChildForm.Text = "Search Customers";
        }

        private void rbtnVendors_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnBanks_Click(object sender, EventArgs e)
        {

        }

        private void rbtnMenus_Click(object sender, EventArgs e)
        {

        }

        private void rbtnRoles_Click(object sender, EventArgs e)
        {

        }

        private void rbtnUsers_Click(object sender, EventArgs e)
        {

        }

        private void rbtnVouchers_Click(object sender, EventArgs e)
        {

        }
    }
}
