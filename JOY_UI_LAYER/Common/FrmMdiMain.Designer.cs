using System;
using ComponentFactory.Krypton.Toolkit;

namespace JOY_UI_LAYER.Common
{
    partial class FrmMdiMain : KryptonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMdiMain));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.rbMainMenu = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbtnCompanies = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbtnCustomers = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbtnVendors = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rbtnBanks = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rbtnMenus = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.rbtnRoles = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.rbtnUsers = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.rbtnVouchers = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // rbMainMenu
            // 
            this.rbMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMainMenu.Location = new System.Drawing.Point(0, 0);
            this.rbMainMenu.Minimized = false;
            this.rbMainMenu.Name = "rbMainMenu";
            // 
            // 
            // 
            this.rbMainMenu.OrbDropDown.BorderRoundness = 8;
            this.rbMainMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbMainMenu.OrbDropDown.Name = "";
            this.rbMainMenu.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.rbMainMenu.OrbDropDown.TabIndex = 0;
            this.rbMainMenu.OrbImage = null;
            // 
            // 
            // 
            this.rbMainMenu.QuickAcessToolbar.AltKey = null;
            this.rbMainMenu.QuickAcessToolbar.Image = null;
            this.rbMainMenu.QuickAcessToolbar.Tag = null;
            this.rbMainMenu.QuickAcessToolbar.Text = null;
            this.rbMainMenu.QuickAcessToolbar.ToolTip = null;
            this.rbMainMenu.QuickAcessToolbar.ToolTipImage = null;
            this.rbMainMenu.QuickAcessToolbar.ToolTipTitle = null;
            this.rbMainMenu.Size = new System.Drawing.Size(1370, 138);
            this.rbMainMenu.TabIndex = 1;
            this.rbMainMenu.Tabs.Add(this.ribbonTab1);
            this.rbMainMenu.TabSpacing = 6;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Panels.Add(this.ribbonPanel6);
            this.ribbonTab1.Panels.Add(this.ribbonPanel7);
            this.ribbonTab1.Panels.Add(this.ribbonPanel8);
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "System Admin";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbtnCompanies);
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Manage Companies";
            // 
            // rbtnCompanies
            // 
            this.rbtnCompanies.AltKey = null;
            this.rbtnCompanies.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnCompanies.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnCompanies.Image = ((System.Drawing.Image)(resources.GetObject("rbtnCompanies.Image")));
            this.rbtnCompanies.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCompanies.SmallImage")));
            this.rbtnCompanies.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnCompanies.Tag = null;
            this.rbtnCompanies.Text = "test";
            this.rbtnCompanies.ToolTip = null;
            this.rbtnCompanies.ToolTipImage = null;
            this.rbtnCompanies.ToolTipTitle = null;
            this.rbtnCompanies.Click += new System.EventHandler(this.rbtnCompanies_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbtnCustomers);
            this.ribbonPanel2.Tag = null;
            this.ribbonPanel2.Text = "Manage Customers";
            // 
            // rbtnCustomers
            // 
            this.rbtnCustomers.AltKey = null;
            this.rbtnCustomers.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnCustomers.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("rbtnCustomers.Image")));
            this.rbtnCustomers.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCustomers.SmallImage")));
            this.rbtnCustomers.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnCustomers.Tag = null;
            this.rbtnCustomers.Text = null;
            this.rbtnCustomers.ToolTip = null;
            this.rbtnCustomers.ToolTipImage = null;
            this.rbtnCustomers.ToolTipTitle = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbtnVendors);
            this.ribbonPanel3.Tag = null;
            this.ribbonPanel3.Text = "Manage Vendors";
            // 
            // rbtnVendors
            // 
            this.rbtnVendors.AltKey = null;
            this.rbtnVendors.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnVendors.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnVendors.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVendors.Image")));
            this.rbtnVendors.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnVendors.SmallImage")));
            this.rbtnVendors.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnVendors.Tag = null;
            this.rbtnVendors.Text = null;
            this.rbtnVendors.ToolTip = null;
            this.rbtnVendors.ToolTipImage = null;
            this.rbtnVendors.ToolTipTitle = null;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rbtnBanks);
            this.ribbonPanel4.Tag = null;
            this.ribbonPanel4.Text = "Manage Banks";
            // 
            // rbtnBanks
            // 
            this.rbtnBanks.AltKey = null;
            this.rbtnBanks.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnBanks.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnBanks.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBanks.Image")));
            this.rbtnBanks.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnBanks.SmallImage")));
            this.rbtnBanks.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnBanks.Tag = null;
            this.rbtnBanks.Text = null;
            this.rbtnBanks.ToolTip = null;
            this.rbtnBanks.ToolTipImage = null;
            this.rbtnBanks.ToolTipTitle = null;
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.rbtnMenus);
            this.ribbonPanel5.Tag = null;
            this.ribbonPanel5.Text = "Manage Menus";
            // 
            // rbtnMenus
            // 
            this.rbtnMenus.AltKey = null;
            this.rbtnMenus.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnMenus.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnMenus.Image = ((System.Drawing.Image)(resources.GetObject("rbtnMenus.Image")));
            this.rbtnMenus.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnMenus.SmallImage")));
            this.rbtnMenus.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnMenus.Tag = null;
            this.rbtnMenus.Text = null;
            this.rbtnMenus.ToolTip = null;
            this.rbtnMenus.ToolTipImage = null;
            this.rbtnMenus.ToolTipTitle = null;
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.rbtnRoles);
            this.ribbonPanel6.Tag = null;
            this.ribbonPanel6.Text = "Manage Roles";
            // 
            // rbtnRoles
            // 
            this.rbtnRoles.AltKey = null;
            this.rbtnRoles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnRoles.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnRoles.Image = ((System.Drawing.Image)(resources.GetObject("rbtnRoles.Image")));
            this.rbtnRoles.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRoles.SmallImage")));
            this.rbtnRoles.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnRoles.Tag = null;
            this.rbtnRoles.Text = null;
            this.rbtnRoles.ToolTip = null;
            this.rbtnRoles.ToolTipImage = null;
            this.rbtnRoles.ToolTipTitle = null;
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.rbtnUsers);
            this.ribbonPanel7.Tag = null;
            this.ribbonPanel7.Text = "Manage Users";
            // 
            // rbtnUsers
            // 
            this.rbtnUsers.AltKey = null;
            this.rbtnUsers.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnUsers.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnUsers.Image = ((System.Drawing.Image)(resources.GetObject("rbtnUsers.Image")));
            this.rbtnUsers.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnUsers.SmallImage")));
            this.rbtnUsers.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnUsers.Tag = null;
            this.rbtnUsers.Text = null;
            this.rbtnUsers.ToolTip = null;
            this.rbtnUsers.ToolTipImage = null;
            this.rbtnUsers.ToolTipTitle = null;
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.rbtnVouchers);
            this.ribbonPanel8.Tag = null;
            this.ribbonPanel8.Text = "Manage Vouchers";
            // 
            // rbtnVouchers
            // 
            this.rbtnVouchers.AltKey = null;
            this.rbtnVouchers.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtnVouchers.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtnVouchers.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVouchers.Image")));
            this.rbtnVouchers.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnVouchers.SmallImage")));
            this.rbtnVouchers.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtnVouchers.Tag = null;
            this.rbtnVouchers.Text = null;
            this.rbtnVouchers.ToolTip = null;
            this.rbtnVouchers.ToolTipImage = null;
            this.rbtnVouchers.ToolTipTitle = null;
            // 
            // FrmMdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.rbMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMdiMain";
            this.Text = "Joy Roadways Logistics Application";
            this.Load += new System.EventHandler(this.FrmMdiMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Ribbon rbMainMenu;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton rbtnCompanies;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton rbtnCustomers;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton rbtnVendors;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton rbtnBanks;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton rbtnMenus;
        private System.Windows.Forms.RibbonButton rbtnRoles;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton rbtnUsers;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton rbtnVouchers;
    }
}