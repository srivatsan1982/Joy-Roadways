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
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipImage = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.Size = new System.Drawing.Size(1370, 138);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 6;
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
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Manage Companies";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = null;
            this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton1.Tag = null;
            this.ribbonButton1.Text = "test";
            this.ribbonButton1.ToolTip = null;
            this.ribbonButton1.ToolTipImage = null;
            this.ribbonButton1.ToolTipTitle = null;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonButton2);
            this.ribbonPanel2.Tag = null;
            this.ribbonPanel2.Text = "Manage Customers";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.AltKey = null;
            this.ribbonButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton2.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton2.Tag = null;
            this.ribbonButton2.Text = null;
            this.ribbonButton2.ToolTip = null;
            this.ribbonButton2.ToolTipImage = null;
            this.ribbonButton2.ToolTipTitle = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton3);
            this.ribbonPanel3.Tag = null;
            this.ribbonPanel3.Text = "Manage Vendors";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.AltKey = null;
            this.ribbonButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton3.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton3.Tag = null;
            this.ribbonButton3.Text = null;
            this.ribbonButton3.ToolTip = null;
            this.ribbonButton3.ToolTipImage = null;
            this.ribbonButton3.ToolTipTitle = null;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.ribbonButton4);
            this.ribbonPanel4.Tag = null;
            this.ribbonPanel4.Text = "Manage Banks";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.AltKey = null;
            this.ribbonButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton4.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton4.Tag = null;
            this.ribbonButton4.Text = null;
            this.ribbonButton4.ToolTip = null;
            this.ribbonButton4.ToolTipImage = null;
            this.ribbonButton4.ToolTipTitle = null;
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton5);
            this.ribbonPanel5.Tag = null;
            this.ribbonPanel5.Text = "Manage Menus";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.AltKey = null;
            this.ribbonButton5.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton5.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton5.Tag = null;
            this.ribbonButton5.Text = null;
            this.ribbonButton5.ToolTip = null;
            this.ribbonButton5.ToolTipImage = null;
            this.ribbonButton5.ToolTipTitle = null;
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.ribbonButton6);
            this.ribbonPanel6.Tag = null;
            this.ribbonPanel6.Text = "Manage Roles";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.AltKey = null;
            this.ribbonButton6.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton6.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton6.Tag = null;
            this.ribbonButton6.Text = null;
            this.ribbonButton6.ToolTip = null;
            this.ribbonButton6.ToolTipImage = null;
            this.ribbonButton6.ToolTipTitle = null;
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.ribbonButton7);
            this.ribbonPanel7.Tag = null;
            this.ribbonPanel7.Text = "Manage Users";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.AltKey = null;
            this.ribbonButton7.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton7.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton7.Tag = null;
            this.ribbonButton7.Text = null;
            this.ribbonButton7.ToolTip = null;
            this.ribbonButton7.ToolTipImage = null;
            this.ribbonButton7.ToolTipTitle = null;
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.ribbonButton8);
            this.ribbonPanel8.Tag = null;
            this.ribbonPanel8.Text = "Manage Vouchers";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.AltKey = null;
            this.ribbonButton8.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton8.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton8.Tag = null;
            this.ribbonButton8.Text = null;
            this.ribbonButton8.ToolTip = null;
            this.ribbonButton8.ToolTipImage = null;
            this.ribbonButton8.ToolTipTitle = null;
            // 
            // FrmMdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.ribbon1);
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
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton ribbonButton8;
    }
}