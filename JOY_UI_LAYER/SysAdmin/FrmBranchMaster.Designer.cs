using System;
using ComponentFactory.Krypton.Toolkit;
namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmBranchMaster : KryptonForm
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
            this.Wind = new System.Windows.Forms.Panel();
            this.WindGrp = new System.Windows.Forms.GroupBox();
            this.TxtBrnchCtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBrnchCountry = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.MskTxtBrnchMobPhone = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.MskTxtBrnchPinCd = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.MskTxtBrnchPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtBrnchCity = new System.Windows.Forms.TextBox();
            this.TxtBrnchAdd1 = new System.Windows.Forms.TextBox();
            this.TxtBrnchAdd2 = new System.Windows.Forms.TextBox();
            this.TxtBrnchName = new System.Windows.Forms.TextBox();
            this.TxtBrnchCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.Wind.SuspendLayout();
            this.WindGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wind
            // 
            this.Wind.Controls.Add(this.WindGrp);
            this.Wind.Location = new System.Drawing.Point(121, 43);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(525, 362);
            this.Wind.TabIndex = 1;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.TxtBrnchCtName);
            this.WindGrp.Controls.Add(this.label6);
            this.WindGrp.Controls.Add(this.TxtBrnchCountry);
            this.WindGrp.Controls.Add(this.label23);
            this.WindGrp.Controls.Add(this.ChkActive);
            this.WindGrp.Controls.Add(this.MskTxtBrnchMobPhone);
            this.WindGrp.Controls.Add(this.label21);
            this.WindGrp.Controls.Add(this.CmdClear);
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdSave);
            this.WindGrp.Controls.Add(this.MskTxtBrnchPinCd);
            this.WindGrp.Controls.Add(this.label17);
            this.WindGrp.Controls.Add(this.MskTxtBrnchPhone);
            this.WindGrp.Controls.Add(this.TxtBrnchCity);
            this.WindGrp.Controls.Add(this.TxtBrnchAdd1);
            this.WindGrp.Controls.Add(this.TxtBrnchAdd2);
            this.WindGrp.Controls.Add(this.TxtBrnchName);
            this.WindGrp.Controls.Add(this.TxtBrnchCode);
            this.WindGrp.Controls.Add(this.label5);
            this.WindGrp.Controls.Add(this.label4);
            this.WindGrp.Controls.Add(this.label3);
            this.WindGrp.Controls.Add(this.label2);
            this.WindGrp.Controls.Add(this.label1);
            this.WindGrp.Controls.Add(this.LblCompanyName);
            this.WindGrp.Location = new System.Drawing.Point(8, 2);
            this.WindGrp.Name = "WindGrp";
            this.WindGrp.Size = new System.Drawing.Size(510, 352);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Branch Details";
            this.WindGrp.Paint += new System.Windows.Forms.PaintEventHandler(this.WindGrp_Paint);
            // 
            // TxtBrnchCtName
            // 
            this.TxtBrnchCtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchCtName.Location = new System.Drawing.Point(153, 82);
            this.TxtBrnchCtName.Name = "TxtBrnchCtName";
            this.TxtBrnchCtName.Size = new System.Drawing.Size(349, 21);
            this.TxtBrnchCtName.TabIndex = 2;
            this.TxtBrnchCtName.GotFocus += new System.EventHandler(this.TxtBrnchCtName_GotFocus);
            this.TxtBrnchCtName.LostFocus += new System.EventHandler(this.TxtBrnchCtName_LostFocus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Branch Contact Name";
            // 
            // TxtBrnchCountry
            // 
            this.TxtBrnchCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchCountry.Location = new System.Drawing.Point(153, 197);
            this.TxtBrnchCountry.Name = "TxtBrnchCountry";
            this.TxtBrnchCountry.Size = new System.Drawing.Size(349, 21);
            this.TxtBrnchCountry.TabIndex = 7;
            this.TxtBrnchCountry.GotFocus += new System.EventHandler(this.TxtBrnchCountry_GotFocus);
            this.TxtBrnchCountry.LostFocus += new System.EventHandler(this.TxtBrnchCountry_LostFocus);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 200);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 15);
            this.label23.TabIndex = 43;
            this.label23.Text = "Country";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(153, 283);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(56, 17);
            this.ChkActive.TabIndex = 28;
            this.ChkActive.Text = "Active";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // MskTxtBrnchMobPhone
            // 
            this.MskTxtBrnchMobPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtBrnchMobPhone.Location = new System.Drawing.Point(153, 254);
            this.MskTxtBrnchMobPhone.Mask = "0000000000";
            this.MskTxtBrnchMobPhone.Name = "MskTxtBrnchMobPhone";
            this.MskTxtBrnchMobPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtBrnchMobPhone.TabIndex = 9;
            this.MskTxtBrnchMobPhone.GotFocus += new System.EventHandler(this.MskTxtBrnchMobPhone_GotFocus);
            this.MskTxtBrnchMobPhone.LostFocus += new System.EventHandler(this.MskTxtBrnchMobPhone_LostFocus);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 41;
            this.label21.Text = "Phone(Mob)";
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(191, 307);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(129, 36);
            this.CmdClear.TabIndex = 30;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(326, 307);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(129, 36);
            this.CmdCancel.TabIndex = 31;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(56, 307);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(129, 36);
            this.CmdSave.TabIndex = 29;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // MskTxtBrnchPinCd
            // 
            this.MskTxtBrnchPinCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtBrnchPinCd.Location = new System.Drawing.Point(368, 168);
            this.MskTxtBrnchPinCd.Mask = "000000";
            this.MskTxtBrnchPinCd.Name = "MskTxtBrnchPinCd";
            this.MskTxtBrnchPinCd.Size = new System.Drawing.Size(134, 21);
            this.MskTxtBrnchPinCd.TabIndex = 6;
            this.MskTxtBrnchPinCd.GotFocus += new System.EventHandler(this.MskTxtBrnchPinCd_GotFocus);
            this.MskTxtBrnchPinCd.LostFocus += new System.EventHandler(this.MskTxtBrnchPinCd_LostFocus);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pincode";
            // 
            // MskTxtBrnchPhone
            // 
            this.MskTxtBrnchPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtBrnchPhone.Location = new System.Drawing.Point(153, 224);
            this.MskTxtBrnchPhone.Mask = "000000000000000000";
            this.MskTxtBrnchPhone.Name = "MskTxtBrnchPhone";
            this.MskTxtBrnchPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtBrnchPhone.TabIndex = 8;
            this.MskTxtBrnchPhone.GotFocus += new System.EventHandler(this.MskTxtBrnchPhone_GotFocus);
            this.MskTxtBrnchPhone.LostFocus += new System.EventHandler(this.MskTxtBrnchPhone_LostFocus);
            // 
            // TxtBrnchCity
            // 
            this.TxtBrnchCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchCity.Location = new System.Drawing.Point(153, 169);
            this.TxtBrnchCity.Name = "TxtBrnchCity";
            this.TxtBrnchCity.Size = new System.Drawing.Size(155, 21);
            this.TxtBrnchCity.TabIndex = 5;
            this.TxtBrnchCity.GotFocus += new System.EventHandler(this.TxtBrnchCity_GotFocus);
            this.TxtBrnchCity.LostFocus += new System.EventHandler(this.TxtBrnchCity_LostFocus);
            // 
            // TxtBrnchAdd1
            // 
            this.TxtBrnchAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchAdd1.Location = new System.Drawing.Point(153, 113);
            this.TxtBrnchAdd1.Name = "TxtBrnchAdd1";
            this.TxtBrnchAdd1.Size = new System.Drawing.Size(317, 21);
            this.TxtBrnchAdd1.TabIndex = 3;
            this.TxtBrnchAdd1.GotFocus += new System.EventHandler(this.TxtBrnchAdd1_GotFocus);
            this.TxtBrnchAdd1.LostFocus += new System.EventHandler(this.TxtBrnchAdd1_LostFocus);
            // 
            // TxtBrnchAdd2
            // 
            this.TxtBrnchAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchAdd2.Location = new System.Drawing.Point(153, 141);
            this.TxtBrnchAdd2.Name = "TxtBrnchAdd2";
            this.TxtBrnchAdd2.Size = new System.Drawing.Size(349, 21);
            this.TxtBrnchAdd2.TabIndex = 4;
            this.TxtBrnchAdd2.GotFocus += new System.EventHandler(this.TxtBrnchAdd2_GotFocus);
            this.TxtBrnchAdd2.LostFocus += new System.EventHandler(this.TxtBrnchAdd2_LostFocus);
            // 
            // TxtBrnchName
            // 
            this.TxtBrnchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchName.Location = new System.Drawing.Point(153, 53);
            this.TxtBrnchName.Name = "TxtBrnchName";
            this.TxtBrnchName.Size = new System.Drawing.Size(349, 21);
            this.TxtBrnchName.TabIndex = 1;
            this.TxtBrnchName.GotFocus += new System.EventHandler(this.TxtBrnchName_GotFocus);
            this.TxtBrnchName.LostFocus += new System.EventHandler(this.TxtBrnchName_LostFocus);
            // 
            // TxtBrnchCode
            // 
            this.TxtBrnchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBrnchCode.Location = new System.Drawing.Point(153, 25);
            this.TxtBrnchCode.Name = "TxtBrnchCode";
            this.TxtBrnchCode.Size = new System.Drawing.Size(155, 21);
            this.TxtBrnchCode.TabIndex = 0;
            this.TxtBrnchCode.GotFocus += new System.EventHandler(this.TxtBrnchCode_GotFocus);
            this.TxtBrnchCode.LostFocus += new System.EventHandler(this.TxtBrnchCode_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone(Off)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Name";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(9, 28);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(89, 15);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "Branch Code";
            // 
            // FrmBranchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 724);
            this.ControlBox = false;
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBranchMaster";
            this.Text = "Branch Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmBranchMaster_Activated);
            this.Load += new System.EventHandler(this.FrmBranchMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBranchMaster_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmBranchMaster_KeyPress);
            this.Wind.ResumeLayout(false);
            this.WindGrp.ResumeLayout(false);
            this.WindGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox WindGrp;
        private System.Windows.Forms.TextBox TxtBrnchCtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBrnchCountry;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.MaskedTextBox MskTxtBrnchMobPhone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.MaskedTextBox MskTxtBrnchPinCd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox MskTxtBrnchPhone;
        private System.Windows.Forms.TextBox TxtBrnchCity;
        private System.Windows.Forms.TextBox TxtBrnchAdd1;
        private System.Windows.Forms.TextBox TxtBrnchAdd2;
        private System.Windows.Forms.TextBox TxtBrnchName;
        private System.Windows.Forms.TextBox TxtBrnchCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCompanyName;
    }
}