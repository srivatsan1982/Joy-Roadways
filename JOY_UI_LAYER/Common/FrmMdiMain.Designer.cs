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
            this.rbMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            this.rbMainMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.rbMainMenu.Size = new System.Drawing.Size(1284, 138);
            this.rbMainMenu.TabIndex = 1;
            this.rbMainMenu.Tabs.Add(this.ribbonTab1);
            this.rbMainMenu.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.rbMainMenu.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
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
            this.ribbonTab1.Text = "System Admin";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbtnCompanies);
            this.ribbonPanel1.Text = "Manage Companies";
            // 
            // rbtnCompanies
            // 
            this.rbtnCompanies.Image = ((System.Drawing.Image)(resources.GetObject("rbtnCompanies.Image")));
            this.rbtnCompanies.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCompanies.SmallImage")));
            this.rbtnCompanies.Text = "";
            this.rbtnCompanies.Click += new System.EventHandler(this.rbtnCompanies_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbtnCustomers);
            this.ribbonPanel2.Text = "Manage Customers";
            // 
            // rbtnCustomers
            // 
            this.rbtnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("rbtnCustomers.Image")));
            this.rbtnCustomers.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCustomers.SmallImage")));
            this.rbtnCustomers.Click += new System.EventHandler(this.rbtnCustomers_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbtnVendors);
            this.ribbonPanel3.Text = "Manage Vendors";
            // 
            // rbtnVendors
            // 
            this.rbtnVendors.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVendors.Image")));
            this.rbtnVendors.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnVendors.SmallImage")));
            this.rbtnVendors.Click += new System.EventHandler(this.rbtnVendors_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rbtnBanks);
            this.ribbonPanel4.Text = "Manage Banks";
            // 
            // rbtnBanks
            // 
            this.rbtnBanks.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBanks.Image")));
            this.rbtnBanks.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnBanks.SmallImage")));
            this.rbtnBanks.Click += new System.EventHandler(this.rbtnBanks_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.rbtnMenus);
            this.ribbonPanel5.Text = "Manage Menus";
            // 
            // rbtnMenus
            // 
            this.rbtnMenus.Image = ((System.Drawing.Image)(resources.GetObject("rbtnMenus.Image")));
            this.rbtnMenus.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnMenus.SmallImage")));
            this.rbtnMenus.Click += new System.EventHandler(this.rbtnMenus_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.rbtnRoles);
            this.ribbonPanel6.Text = "Manage Roles";
            // 
            // rbtnRoles
            // 
            this.rbtnRoles.Image = ((System.Drawing.Image)(resources.GetObject("rbtnRoles.Image")));
            this.rbtnRoles.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRoles.SmallImage")));
            this.rbtnRoles.Click += new System.EventHandler(this.rbtnRoles_Click);
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.rbtnUsers);
            this.ribbonPanel7.Text = "Manage Users";
            // 
            // rbtnUsers
            // 
            this.rbtnUsers.Image = ((System.Drawing.Image)(resources.GetObject("rbtnUsers.Image")));
            this.rbtnUsers.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnUsers.SmallImage")));
            this.rbtnUsers.Click += new System.EventHandler(this.rbtnUsers_Click);
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.rbtnVouchers);
            this.ribbonPanel8.Text = "Manage Vouchers";
            // 
            // rbtnVouchers
            // 
            this.rbtnVouchers.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVouchers.Image")));
            this.rbtnVouchers.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnVouchers.SmallImage")));
            this.rbtnVouchers.Click += new System.EventHandler(this.rbtnVouchers_Click);
            // 
            // FrmMdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 750);
            this.Controls.Add(this.rbMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMdiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joy Roadways Logistics Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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