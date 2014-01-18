using System;
using ComponentFactory.Krypton.Toolkit;
namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmVendorMaster : KryptonForm
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
            this.TxtVndIFSCCode = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtVndCountry = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.MskTxtVndMobPhone = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.MskTxtVndPinCd = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtVndBankNm = new System.Windows.Forms.TextBox();
            this.TxtVndBankBrnch = new System.Windows.Forms.TextBox();
            this.TxtVndBankAccnt = new System.Windows.Forms.TextBox();
            this.TxtVndTINNo = new System.Windows.Forms.TextBox();
            this.TxtVndEmail = new System.Windows.Forms.TextBox();
            this.MskTxtVndPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtVndCity = new System.Windows.Forms.TextBox();
            this.TxtVndAdd1 = new System.Windows.Forms.TextBox();
            this.TxtVndAdd2 = new System.Windows.Forms.TextBox();
            this.TxtVndName = new System.Windows.Forms.TextBox();
            this.TxtVndCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.Wind.Location = new System.Drawing.Point(27, 35);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(525, 480);
            this.Wind.TabIndex = 1;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.TxtVndIFSCCode);
            this.WindGrp.Controls.Add(this.label24);
            this.WindGrp.Controls.Add(this.TxtVndCountry);
            this.WindGrp.Controls.Add(this.label23);
            this.WindGrp.Controls.Add(this.ChkActive);
            this.WindGrp.Controls.Add(this.MskTxtVndMobPhone);
            this.WindGrp.Controls.Add(this.label21);
            this.WindGrp.Controls.Add(this.CmdClear);
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdSave);
            this.WindGrp.Controls.Add(this.MskTxtVndPinCd);
            this.WindGrp.Controls.Add(this.label17);
            this.WindGrp.Controls.Add(this.TxtVndBankNm);
            this.WindGrp.Controls.Add(this.TxtVndBankBrnch);
            this.WindGrp.Controls.Add(this.TxtVndBankAccnt);
            this.WindGrp.Controls.Add(this.TxtVndTINNo);
            this.WindGrp.Controls.Add(this.TxtVndEmail);
            this.WindGrp.Controls.Add(this.MskTxtVndPhone);
            this.WindGrp.Controls.Add(this.TxtVndCity);
            this.WindGrp.Controls.Add(this.TxtVndAdd1);
            this.WindGrp.Controls.Add(this.TxtVndAdd2);
            this.WindGrp.Controls.Add(this.TxtVndName);
            this.WindGrp.Controls.Add(this.TxtVndCode);
            this.WindGrp.Controls.Add(this.label16);
            this.WindGrp.Controls.Add(this.label15);
            this.WindGrp.Controls.Add(this.label14);
            this.WindGrp.Controls.Add(this.label11);
            this.WindGrp.Controls.Add(this.label7);
            this.WindGrp.Controls.Add(this.label5);
            this.WindGrp.Controls.Add(this.label4);
            this.WindGrp.Controls.Add(this.label3);
            this.WindGrp.Controls.Add(this.label2);
            this.WindGrp.Controls.Add(this.label1);
            this.WindGrp.Controls.Add(this.LblCompanyName);
            this.WindGrp.Location = new System.Drawing.Point(8, 2);
            this.WindGrp.Name = "WindGrp";
            this.WindGrp.Size = new System.Drawing.Size(510, 468);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Vendor Details";
            // 
            // TxtVndIFSCCode
            // 
            this.TxtVndIFSCCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndIFSCCode.Location = new System.Drawing.Point(379, 369);
            this.TxtVndIFSCCode.Name = "TxtVndIFSCCode";
            this.TxtVndIFSCCode.Size = new System.Drawing.Size(123, 21);
            this.TxtVndIFSCCode.TabIndex = 14;
            this.TxtVndIFSCCode.GotFocus += new System.EventHandler(this.TxtVndIFSCCode_GotFocus);
            this.TxtVndIFSCCode.LostFocus += new System.EventHandler(this.TxtVndIFSCCode_LostFocus);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(309, 370);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 15);
            this.label24.TabIndex = 1;
            this.label24.Text = "IFSC Code";
            // 
            // TxtVndCountry
            // 
            this.TxtVndCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndCountry.Location = new System.Drawing.Point(153, 165);
            this.TxtVndCountry.Name = "TxtVndCountry";
            this.TxtVndCountry.Size = new System.Drawing.Size(349, 21);
            this.TxtVndCountry.TabIndex = 6;
            this.TxtVndCountry.GotFocus += new System.EventHandler(this.TxtVndCountry_GotFocus);
            this.TxtVndCountry.LostFocus += new System.EventHandler(this.TxtVndCountry_LostFocus);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 15);
            this.label23.TabIndex = 43;
            this.label23.Text = "Country";
            // 
            // ChkActive
            // 
            this.ChkActive.Location = new System.Drawing.Point(153, 397);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(71, 19);
            this.ChkActive.TabIndex = 15;
            this.ChkActive.Text = "Active";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // MskTxtVndMobPhone
            // 
            this.MskTxtVndMobPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtVndMobPhone.Location = new System.Drawing.Point(153, 222);
            this.MskTxtVndMobPhone.Mask = "0000000000";
            this.MskTxtVndMobPhone.Name = "MskTxtVndMobPhone";
            this.MskTxtVndMobPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtVndMobPhone.TabIndex = 8;
            this.MskTxtVndMobPhone.GotFocus += new System.EventHandler(this.MskTxtVndMobPhone_GotFocus);
            this.MskTxtVndMobPhone.LostFocus += new System.EventHandler(this.MskTxtVndMobPhone_LostFocus);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 225);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 41;
            this.label21.Text = "Phone(Mob)";
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(191, 421);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(129, 36);
            this.CmdClear.TabIndex = 17;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(326, 421);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(129, 36);
            this.CmdCancel.TabIndex = 18;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(56, 421);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(129, 36);
            this.CmdSave.TabIndex = 16;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // MskTxtVndPinCd
            // 
            this.MskTxtVndPinCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtVndPinCd.Location = new System.Drawing.Point(368, 136);
            this.MskTxtVndPinCd.Mask = "000000";
            this.MskTxtVndPinCd.Name = "MskTxtVndPinCd";
            this.MskTxtVndPinCd.Size = new System.Drawing.Size(134, 21);
            this.MskTxtVndPinCd.TabIndex = 5;
            this.MskTxtVndPinCd.GotFocus += new System.EventHandler(this.MskTxtVndPinCd_GotFocus);
            this.MskTxtVndPinCd.LostFocus += new System.EventHandler(this.MskTxtVndPinCd_LostFocus);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pincode";
            // 
            // TxtVndBankNm
            // 
            this.TxtVndBankNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndBankNm.Location = new System.Drawing.Point(153, 339);
            this.TxtVndBankNm.Name = "TxtVndBankNm";
            this.TxtVndBankNm.Size = new System.Drawing.Size(349, 21);
            this.TxtVndBankNm.TabIndex = 12;
            this.TxtVndBankNm.GotFocus += new System.EventHandler(this.TxtVndBankNm_GotFocus);
            this.TxtVndBankNm.LostFocus += new System.EventHandler(this.TxtVndBankNm_LostFocus);
            // 
            // TxtVndBankBrnch
            // 
            this.TxtVndBankBrnch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndBankBrnch.Location = new System.Drawing.Point(153, 367);
            this.TxtVndBankBrnch.Name = "TxtVndBankBrnch";
            this.TxtVndBankBrnch.Size = new System.Drawing.Size(155, 21);
            this.TxtVndBankBrnch.TabIndex = 13;
            this.TxtVndBankBrnch.GotFocus += new System.EventHandler(this.TxtVndBankBrnch_GotFocus);
            this.TxtVndBankBrnch.LostFocus += new System.EventHandler(this.TxtVndBankBrnch_LostFocus);
            // 
            // TxtVndBankAccnt
            // 
            this.TxtVndBankAccnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndBankAccnt.Location = new System.Drawing.Point(153, 311);
            this.TxtVndBankAccnt.Name = "TxtVndBankAccnt";
            this.TxtVndBankAccnt.Size = new System.Drawing.Size(349, 21);
            this.TxtVndBankAccnt.TabIndex = 11;
            this.TxtVndBankAccnt.GotFocus += new System.EventHandler(this.TxtVndBankAccnt_GotFocus);
            this.TxtVndBankAccnt.LostFocus += new System.EventHandler(this.TxtVndBankAccnt_LostFocus);
            // 
            // TxtVndTINNo
            // 
            this.TxtVndTINNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndTINNo.Location = new System.Drawing.Point(153, 281);
            this.TxtVndTINNo.Name = "TxtVndTINNo";
            this.TxtVndTINNo.Size = new System.Drawing.Size(349, 21);
            this.TxtVndTINNo.TabIndex = 10;
            this.TxtVndTINNo.GotFocus += new System.EventHandler(this.TxtVndTINNo_GotFocus);
            this.TxtVndTINNo.LostFocus += new System.EventHandler(this.TxtVndTINNo_LostFocus);
            // 
            // TxtVndEmail
            // 
            this.TxtVndEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndEmail.Location = new System.Drawing.Point(153, 251);
            this.TxtVndEmail.Name = "TxtVndEmail";
            this.TxtVndEmail.Size = new System.Drawing.Size(349, 21);
            this.TxtVndEmail.TabIndex = 9;
            this.TxtVndEmail.GotFocus += new System.EventHandler(this.TxtVndEmail_GotFocus);
            this.TxtVndEmail.LostFocus += new System.EventHandler(this.TxtVndEmail_LostFocus);
            // 
            // MskTxtVndPhone
            // 
            this.MskTxtVndPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtVndPhone.Location = new System.Drawing.Point(153, 192);
            this.MskTxtVndPhone.Mask = "000000000000000000";
            this.MskTxtVndPhone.Name = "MskTxtVndPhone";
            this.MskTxtVndPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtVndPhone.TabIndex = 7;
            this.MskTxtVndPhone.GotFocus += new System.EventHandler(this.MskTxtVndPhone_GotFocus);
            this.MskTxtVndPhone.LostFocus += new System.EventHandler(this.MskTxtVndPhone_LostFocus);
            // 
            // TxtVndCity
            // 
            this.TxtVndCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndCity.Location = new System.Drawing.Point(153, 137);
            this.TxtVndCity.Name = "TxtVndCity";
            this.TxtVndCity.Size = new System.Drawing.Size(155, 21);
            this.TxtVndCity.TabIndex = 4;
            this.TxtVndCity.GotFocus += new System.EventHandler(this.TxtVndCity_GotFocus);
            this.TxtVndCity.LostFocus += new System.EventHandler(this.TxtVndCity_LostFocus);
            // 
            // TxtVndAdd1
            // 
            this.TxtVndAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndAdd1.Location = new System.Drawing.Point(153, 81);
            this.TxtVndAdd1.Name = "TxtVndAdd1";
            this.TxtVndAdd1.Size = new System.Drawing.Size(349, 21);
            this.TxtVndAdd1.TabIndex = 2;
            this.TxtVndAdd1.GotFocus += new System.EventHandler(this.TxtVndAdd1_GotFocus);
            this.TxtVndAdd1.LostFocus += new System.EventHandler(this.TxtVndAdd1_LostFocus);
            // 
            // TxtVndAdd2
            // 
            this.TxtVndAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndAdd2.Location = new System.Drawing.Point(153, 109);
            this.TxtVndAdd2.Name = "TxtVndAdd2";
            this.TxtVndAdd2.Size = new System.Drawing.Size(349, 21);
            this.TxtVndAdd2.TabIndex = 3;
            this.TxtVndAdd2.GotFocus += new System.EventHandler(this.TxtVndAdd2_GotFocus);
            this.TxtVndAdd2.LostFocus += new System.EventHandler(this.TxtVndAdd2_LostFocus);
            // 
            // TxtVndName
            // 
            this.TxtVndName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndName.Location = new System.Drawing.Point(153, 53);
            this.TxtVndName.Name = "TxtVndName";
            this.TxtVndName.Size = new System.Drawing.Size(349, 21);
            this.TxtVndName.TabIndex = 1;
            this.TxtVndName.GotFocus += new System.EventHandler(this.TxtVndName_GotFocus);
            this.TxtVndName.LostFocus += new System.EventHandler(this.TxtVndName_LostFocus);
            // 
            // TxtVndCode
            // 
            this.TxtVndCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVndCode.Location = new System.Drawing.Point(153, 25);
            this.TxtVndCode.Name = "TxtVndCode";
            this.TxtVndCode.Size = new System.Drawing.Size(155, 21);
            this.TxtVndCode.TabIndex = 0;
            this.TxtVndCode.GotFocus += new System.EventHandler(this.TxtVndCode_GotFocus);
            this.TxtVndCode.LostFocus += new System.EventHandler(this.TxtVndCode_LostFocus);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Default Bank Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Default Bank Branch";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Default Bank Account";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "TIN No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone(Off)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
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
            this.label1.Text = "Vendor Name";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(9, 28);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(89, 15);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "Vendor Code";
            // 
            // FrmVendorMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 722);
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVendorMaster";
            this.Text = "Vendor Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmVendorMaster_Activated);
            this.Load += new System.EventHandler(this.FrmVendorMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVendorMaster_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmVendorMaster_KeyPress);
            this.Wind.ResumeLayout(false);
            this.WindGrp.ResumeLayout(false);
            this.WindGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox WindGrp;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TxtVndCountry;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.MaskedTextBox MskTxtVndMobPhone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.MaskedTextBox MskTxtVndPinCd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtVndBankNm;
        private System.Windows.Forms.TextBox TxtVndBankBrnch;
        private System.Windows.Forms.TextBox TxtVndBankAccnt;
        private System.Windows.Forms.TextBox TxtVndTINNo;
        private System.Windows.Forms.TextBox TxtVndEmail;
        private System.Windows.Forms.MaskedTextBox MskTxtVndPhone;
        private System.Windows.Forms.TextBox TxtVndCity;
        private System.Windows.Forms.TextBox TxtVndAdd1;
        private System.Windows.Forms.TextBox TxtVndAdd2;
        private System.Windows.Forms.TextBox TxtVndName;
        private System.Windows.Forms.TextBox TxtVndCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.TextBox TxtVndIFSCCode;
    }
}