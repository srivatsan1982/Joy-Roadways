using System;
using ComponentFactory.Krypton.Toolkit;
namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmCompanyMaster : KryptonForm
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
            this.MskTxtCmpMobPhone = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.TxtCmpExchngRate = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrSym = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCmpPrfx = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MskTxtCmpPinCd = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CmdFntAdd1 = new System.Windows.Forms.Button();
            this.CmdFntComp = new System.Windows.Forms.Button();
            this.TxtCmpBankNm = new System.Windows.Forms.TextBox();
            this.TxtCmpBankBrnch = new System.Windows.Forms.TextBox();
            this.TxtCmpBankAccnt = new System.Windows.Forms.TextBox();
            this.TxtCmpPANNo = new System.Windows.Forms.TextBox();
            this.TxtCmpTNGSTNo = new System.Windows.Forms.TextBox();
            this.TxtCmpTINNo = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrPaise = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrCd = new System.Windows.Forms.TextBox();
            this.TxtCmpEmail = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrName = new System.Windows.Forms.TextBox();
            this.MskTxtCmpPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtCmpFax = new System.Windows.Forms.TextBox();
            this.TxtCmpCity = new System.Windows.Forms.TextBox();
            this.TxtCmpAdd1 = new System.Windows.Forms.TextBox();
            this.TxtCmpAdd2 = new System.Windows.Forms.TextBox();
            this.TxtCmpAliasName = new System.Windows.Forms.TextBox();
            this.TxtCmpName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.FnCmpName = new System.Windows.Forms.FontDialog();
            this.FnCmpAdd1 = new System.Windows.Forms.FontDialog();
            this.Wind.SuspendLayout();
            this.WindGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wind
            // 
            this.Wind.Controls.Add(this.WindGrp);
            this.Wind.Location = new System.Drawing.Point(71, 35);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(525, 590);
            this.Wind.TabIndex = 0;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.MskTxtCmpMobPhone);
            this.WindGrp.Controls.Add(this.label21);
            this.WindGrp.Controls.Add(this.CmdClear);
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdSave);
            this.WindGrp.Controls.Add(this.TxtCmpExchngRate);
            this.WindGrp.Controls.Add(this.TxtCmpCurrSym);
            this.WindGrp.Controls.Add(this.label20);
            this.WindGrp.Controls.Add(this.label19);
            this.WindGrp.Controls.Add(this.TxtCmpPrfx);
            this.WindGrp.Controls.Add(this.label18);
            this.WindGrp.Controls.Add(this.MskTxtCmpPinCd);
            this.WindGrp.Controls.Add(this.label17);
            this.WindGrp.Controls.Add(this.CmdFntAdd1);
            this.WindGrp.Controls.Add(this.CmdFntComp);
            this.WindGrp.Controls.Add(this.TxtCmpBankNm);
            this.WindGrp.Controls.Add(this.TxtCmpBankBrnch);
            this.WindGrp.Controls.Add(this.TxtCmpBankAccnt);
            this.WindGrp.Controls.Add(this.TxtCmpPANNo);
            this.WindGrp.Controls.Add(this.TxtCmpTNGSTNo);
            this.WindGrp.Controls.Add(this.TxtCmpTINNo);
            this.WindGrp.Controls.Add(this.TxtCmpCurrPaise);
            this.WindGrp.Controls.Add(this.TxtCmpCurrCd);
            this.WindGrp.Controls.Add(this.TxtCmpEmail);
            this.WindGrp.Controls.Add(this.TxtCmpCurrName);
            this.WindGrp.Controls.Add(this.MskTxtCmpPhone);
            this.WindGrp.Controls.Add(this.TxtCmpFax);
            this.WindGrp.Controls.Add(this.TxtCmpCity);
            this.WindGrp.Controls.Add(this.TxtCmpAdd1);
            this.WindGrp.Controls.Add(this.TxtCmpAdd2);
            this.WindGrp.Controls.Add(this.TxtCmpAliasName);
            this.WindGrp.Controls.Add(this.TxtCmpName);
            this.WindGrp.Controls.Add(this.label16);
            this.WindGrp.Controls.Add(this.label15);
            this.WindGrp.Controls.Add(this.label14);
            this.WindGrp.Controls.Add(this.label13);
            this.WindGrp.Controls.Add(this.label12);
            this.WindGrp.Controls.Add(this.label11);
            this.WindGrp.Controls.Add(this.label10);
            this.WindGrp.Controls.Add(this.label9);
            this.WindGrp.Controls.Add(this.label8);
            this.WindGrp.Controls.Add(this.label7);
            this.WindGrp.Controls.Add(this.label6);
            this.WindGrp.Controls.Add(this.label5);
            this.WindGrp.Controls.Add(this.label4);
            this.WindGrp.Controls.Add(this.label3);
            this.WindGrp.Controls.Add(this.label2);
            this.WindGrp.Controls.Add(this.label1);
            this.WindGrp.Controls.Add(this.LblCompanyName);
            this.WindGrp.Location = new System.Drawing.Point(8, 2);
            this.WindGrp.Name = "WindGrp";
            this.WindGrp.Size = new System.Drawing.Size(510, 578);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Company Details";
            this.WindGrp.Paint += new System.Windows.Forms.PaintEventHandler(this.WindGrp_Paint);
            // 
            // MskTxtCmpMobPhone
            // 
            this.MskTxtCmpMobPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtCmpMobPhone.Location = new System.Drawing.Point(153, 195);
            this.MskTxtCmpMobPhone.Mask = "0000000000";
            this.MskTxtCmpMobPhone.Name = "MskTxtCmpMobPhone";
            this.MskTxtCmpMobPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtCmpMobPhone.TabIndex = 9;
            this.MskTxtCmpMobPhone.GotFocus += new System.EventHandler(this.MskTxtCmpMobPhone_GotFocus);
            this.MskTxtCmpMobPhone.LostFocus += new System.EventHandler(this.MskTxtCmpMobPhone_LostFocus);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 41;
            this.label21.Text = "Phone(Mob)";
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(191, 533);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(129, 36);
            this.CmdClear.TabIndex = 40;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(326, 533);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(129, 36);
            this.CmdCancel.TabIndex = 40;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(56, 533);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(129, 36);
            this.CmdSave.TabIndex = 39;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtCmpExchngRate
            // 
            this.TxtCmpExchngRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpExchngRate.Location = new System.Drawing.Point(376, 337);
            this.TxtCmpExchngRate.Name = "TxtCmpExchngRate";
            this.TxtCmpExchngRate.Size = new System.Drawing.Size(126, 21);
            this.TxtCmpExchngRate.TabIndex = 17;
            this.TxtCmpExchngRate.GotFocus += new System.EventHandler(this.TxtCmpExchngRate_GotFocus);
            this.TxtCmpExchngRate.LostFocus += new System.EventHandler(this.TxtCmpExchngRate_LostFocus);
            // 
            // TxtCmpCurrSym
            // 
            this.TxtCmpCurrSym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrSym.Location = new System.Drawing.Point(377, 308);
            this.TxtCmpCurrSym.Name = "TxtCmpCurrSym";
            this.TxtCmpCurrSym.Size = new System.Drawing.Size(125, 21);
            this.TxtCmpCurrSym.TabIndex = 15;
            this.TxtCmpCurrSym.GotFocus += new System.EventHandler(this.TxtCmpCurrSym_GotFocus);
            this.TxtCmpCurrSym.LostFocus += new System.EventHandler(this.TxtCmpCurrSym_LostFocus);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(309, 333);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 30);
            this.label20.TabIndex = 38;
            this.label20.Text = "Exchange \r\nRate";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(310, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 30);
            this.label19.TabIndex = 36;
            this.label19.Text = "Currency \r\nSymbol";
            // 
            // TxtCmpPrfx
            // 
            this.TxtCmpPrfx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpPrfx.Location = new System.Drawing.Point(379, 225);
            this.TxtCmpPrfx.Name = "TxtCmpPrfx";
            this.TxtCmpPrfx.Size = new System.Drawing.Size(123, 21);
            this.TxtCmpPrfx.TabIndex = 11;
            this.TxtCmpPrfx.GotFocus += new System.EventHandler(this.TxtCmpPrfx_GotFocus);
            this.TxtCmpPrfx.LostFocus += new System.EventHandler(this.TxtCmpPrfx_LostFocus);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(312, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 30);
            this.label18.TabIndex = 35;
            this.label18.Text = "Company \r\nPrefix";
            // 
            // MskTxtCmpPinCd
            // 
            this.MskTxtCmpPinCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtCmpPinCd.Location = new System.Drawing.Point(368, 136);
            this.MskTxtCmpPinCd.Mask = "000000";
            this.MskTxtCmpPinCd.Name = "MskTxtCmpPinCd";
            this.MskTxtCmpPinCd.Size = new System.Drawing.Size(134, 21);
            this.MskTxtCmpPinCd.TabIndex = 7;
            this.MskTxtCmpPinCd.GotFocus += new System.EventHandler(this.MskTxtCmpPinCd_GotFocus);
            this.MskTxtCmpPinCd.LostFocus += new System.EventHandler(this.MskTxtCmpPinCd_LostFocus);
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
            // CmdFntAdd1
            // 
            this.CmdFntAdd1.Location = new System.Drawing.Point(473, 81);
            this.CmdFntAdd1.Name = "CmdFntAdd1";
            this.CmdFntAdd1.Size = new System.Drawing.Size(29, 23);
            this.CmdFntAdd1.TabIndex = 4;
            this.CmdFntAdd1.Text = "A";
            this.CmdFntAdd1.UseVisualStyleBackColor = true;
            this.CmdFntAdd1.Click += new System.EventHandler(this.CmdFntAdd1_Click);
            // 
            // CmdFntComp
            // 
            this.CmdFntComp.Location = new System.Drawing.Point(473, 25);
            this.CmdFntComp.Name = "CmdFntComp";
            this.CmdFntComp.Size = new System.Drawing.Size(29, 23);
            this.CmdFntComp.TabIndex = 1;
            this.CmdFntComp.Text = "A";
            this.CmdFntComp.UseVisualStyleBackColor = true;
            this.CmdFntComp.Click += new System.EventHandler(this.CmdFntComp_Click);
            // 
            // TxtCmpBankNm
            // 
            this.TxtCmpBankNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpBankNm.Location = new System.Drawing.Point(153, 476);
            this.TxtCmpBankNm.Name = "TxtCmpBankNm";
            this.TxtCmpBankNm.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpBankNm.TabIndex = 22;
            this.TxtCmpBankNm.GotFocus += new System.EventHandler(this.TxtCmpBankNm_GotFocus);
            this.TxtCmpBankNm.LostFocus += new System.EventHandler(this.TxtCmpBankNm_LostFocus);
            // 
            // TxtCmpBankBrnch
            // 
            this.TxtCmpBankBrnch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpBankBrnch.Location = new System.Drawing.Point(153, 504);
            this.TxtCmpBankBrnch.Name = "TxtCmpBankBrnch";
            this.TxtCmpBankBrnch.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpBankBrnch.TabIndex = 23;
            this.TxtCmpBankBrnch.GotFocus += new System.EventHandler(this.TxtCmpBankBrnch_GotFocus);
            this.TxtCmpBankBrnch.LostFocus += new System.EventHandler(this.TxtCmpBankBrnch_LostFocus);
            // 
            // TxtCmpBankAccnt
            // 
            this.TxtCmpBankAccnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpBankAccnt.Location = new System.Drawing.Point(153, 448);
            this.TxtCmpBankAccnt.Name = "TxtCmpBankAccnt";
            this.TxtCmpBankAccnt.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpBankAccnt.TabIndex = 21;
            this.TxtCmpBankAccnt.GotFocus += new System.EventHandler(this.TxtCmpBankAccnt_GotFocus);
            this.TxtCmpBankAccnt.LostFocus += new System.EventHandler(this.TxtCmpBankAccnt_LostFocus);
            // 
            // TxtCmpPANNo
            // 
            this.TxtCmpPANNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpPANNo.Location = new System.Drawing.Point(153, 420);
            this.TxtCmpPANNo.Name = "TxtCmpPANNo";
            this.TxtCmpPANNo.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpPANNo.TabIndex = 20;
            this.TxtCmpPANNo.GotFocus += new System.EventHandler(this.TxtCmpPANNo_GotFocus);
            this.TxtCmpPANNo.LostFocus += new System.EventHandler(this.TxtCmpPANNo_LostFocus);
            // 
            // TxtCmpTNGSTNo
            // 
            this.TxtCmpTNGSTNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpTNGSTNo.Location = new System.Drawing.Point(153, 392);
            this.TxtCmpTNGSTNo.Name = "TxtCmpTNGSTNo";
            this.TxtCmpTNGSTNo.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpTNGSTNo.TabIndex = 19;
            this.TxtCmpTNGSTNo.GotFocus += new System.EventHandler(this.TxtCmpTNGSTNo_GotFocus);
            this.TxtCmpTNGSTNo.LostFocus += new System.EventHandler(this.TxtCmpTNGSTNo_LostFocus);
            // 
            // TxtCmpTINNo
            // 
            this.TxtCmpTINNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpTINNo.Location = new System.Drawing.Point(153, 364);
            this.TxtCmpTINNo.Name = "TxtCmpTINNo";
            this.TxtCmpTINNo.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpTINNo.TabIndex = 18;
            this.TxtCmpTINNo.GotFocus += new System.EventHandler(this.TxtCmpTINNo_GotFocus);
            this.TxtCmpTINNo.LostFocus += new System.EventHandler(this.TxtCmpTINNo_LostFocus);
            // 
            // TxtCmpCurrPaise
            // 
            this.TxtCmpCurrPaise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrPaise.Location = new System.Drawing.Point(153, 336);
            this.TxtCmpCurrPaise.Name = "TxtCmpCurrPaise";
            this.TxtCmpCurrPaise.Size = new System.Drawing.Size(155, 21);
            this.TxtCmpCurrPaise.TabIndex = 16;
            this.TxtCmpCurrPaise.GotFocus += new System.EventHandler(this.TxtCmpCurrPaise_GotFocus);
            this.TxtCmpCurrPaise.LostFocus += new System.EventHandler(this.TxtCmpCurrPaise_LostFocus);
            // 
            // TxtCmpCurrCd
            // 
            this.TxtCmpCurrCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrCd.Location = new System.Drawing.Point(153, 308);
            this.TxtCmpCurrCd.Name = "TxtCmpCurrCd";
            this.TxtCmpCurrCd.Size = new System.Drawing.Size(155, 21);
            this.TxtCmpCurrCd.TabIndex = 14;
            this.TxtCmpCurrCd.GotFocus += new System.EventHandler(this.TxtCmpCurrCd_GotFocus);
            this.TxtCmpCurrCd.LostFocus += new System.EventHandler(this.TxtCmpCurrCd_LostFocus);
            // 
            // TxtCmpEmail
            // 
            this.TxtCmpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpEmail.Location = new System.Drawing.Point(153, 252);
            this.TxtCmpEmail.Name = "TxtCmpEmail";
            this.TxtCmpEmail.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpEmail.TabIndex = 12;
            this.TxtCmpEmail.GotFocus += new System.EventHandler(this.TxtCmpEmail_GotFocus);
            this.TxtCmpEmail.LostFocus += new System.EventHandler(this.TxtCmpEmail_LostFocus);
            // 
            // TxtCmpCurrName
            // 
            this.TxtCmpCurrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrName.Location = new System.Drawing.Point(153, 280);
            this.TxtCmpCurrName.Name = "TxtCmpCurrName";
            this.TxtCmpCurrName.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpCurrName.TabIndex = 13;
            this.TxtCmpCurrName.GotFocus += new System.EventHandler(this.TxtCmpCurrName_GotFocus);
            this.TxtCmpCurrName.LostFocus += new System.EventHandler(this.TxtCmpCurrName_LostFocus);
            // 
            // MskTxtCmpPhone
            // 
            this.MskTxtCmpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtCmpPhone.Location = new System.Drawing.Point(153, 165);
            this.MskTxtCmpPhone.Mask = "000000000000000000";
            this.MskTxtCmpPhone.Name = "MskTxtCmpPhone";
            this.MskTxtCmpPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtCmpPhone.TabIndex = 8;
            this.MskTxtCmpPhone.GotFocus += new System.EventHandler(this.MskTxtCmpPhone_GotFocus);
            this.MskTxtCmpPhone.LostFocus += new System.EventHandler(this.MskTxtCmpPhone_LostFocus);
            // 
            // TxtCmpFax
            // 
            this.TxtCmpFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpFax.Location = new System.Drawing.Point(153, 224);
            this.TxtCmpFax.Name = "TxtCmpFax";
            this.TxtCmpFax.Size = new System.Drawing.Size(155, 21);
            this.TxtCmpFax.TabIndex = 10;
            this.TxtCmpFax.GotFocus += new System.EventHandler(this.TxtCmpFax_GotFocus);
            this.TxtCmpFax.LostFocus += new System.EventHandler(this.TxtCmpFax_LostFocus);
            // 
            // TxtCmpCity
            // 
            this.TxtCmpCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCity.Location = new System.Drawing.Point(153, 137);
            this.TxtCmpCity.Name = "TxtCmpCity";
            this.TxtCmpCity.Size = new System.Drawing.Size(155, 21);
            this.TxtCmpCity.TabIndex = 6;
            this.TxtCmpCity.GotFocus += new System.EventHandler(this.TxtCmpCity_GotFocus);
            this.TxtCmpCity.LostFocus += new System.EventHandler(this.TxtCmpCity_LostFocus);
            // 
            // TxtCmpAdd1
            // 
            this.TxtCmpAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpAdd1.Location = new System.Drawing.Point(153, 81);
            this.TxtCmpAdd1.Name = "TxtCmpAdd1";
            this.TxtCmpAdd1.Size = new System.Drawing.Size(317, 21);
            this.TxtCmpAdd1.TabIndex = 3;
            this.TxtCmpAdd1.GotFocus += new System.EventHandler(this.TxtCmpAdd1_GotFocus);
            this.TxtCmpAdd1.LostFocus += new System.EventHandler(this.TxtCmpAdd1_LostFocus);
            // 
            // TxtCmpAdd2
            // 
            this.TxtCmpAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpAdd2.Location = new System.Drawing.Point(153, 109);
            this.TxtCmpAdd2.Name = "TxtCmpAdd2";
            this.TxtCmpAdd2.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpAdd2.TabIndex = 5;
            this.TxtCmpAdd2.GotFocus += new System.EventHandler(this.TxtCmpAdd2_GotFocus);
            this.TxtCmpAdd2.LostFocus += new System.EventHandler(this.TxtCmpAdd2_LostFocus);
            // 
            // TxtCmpAliasName
            // 
            this.TxtCmpAliasName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpAliasName.Location = new System.Drawing.Point(153, 53);
            this.TxtCmpAliasName.Name = "TxtCmpAliasName";
            this.TxtCmpAliasName.Size = new System.Drawing.Size(349, 21);
            this.TxtCmpAliasName.TabIndex = 2;
            this.TxtCmpAliasName.GotFocus += new System.EventHandler(this.TxtCmpAliasName_GotFocus);
            this.TxtCmpAliasName.LostFocus += new System.EventHandler(this.TxtCmpAliasName_LostFocus);
            // 
            // TxtCmpName
            // 
            this.TxtCmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpName.Location = new System.Drawing.Point(153, 25);
            this.TxtCmpName.Name = "TxtCmpName";
            this.TxtCmpName.Size = new System.Drawing.Size(317, 21);
            this.TxtCmpName.TabIndex = 0;
            this.TxtCmpName.GotFocus += new System.EventHandler(this.TxtCmpName_GotFocus);
            this.TxtCmpName.LostFocus += new System.EventHandler(this.TxtCmpName_LostFocus);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Default Bank Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Default Bank Branch";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Default Bank Account";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "PAN No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "TNGST No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "TIN No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Currency Paise";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Currency Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Currency Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
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
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alias Name";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(9, 28);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(108, 15);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "Company Name";
            // 
            // FnCmpName
            // 
            this.FnCmpName.Tag = "COMPANY";
            // 
            // FnCmpAdd1
            // 
            this.FnCmpAdd1.Tag = "ADDRESS";
            // 
            // FrmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 740);
            this.ControlBox = false;
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmCompanyMaster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Manage Companies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmCompanyMaster_Activated);
            this.Load += new System.EventHandler(this.FrmCompanyMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompanyMaster_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCompanyMaster_KeyPress);
            this.Wind.ResumeLayout(false);
            this.WindGrp.ResumeLayout(false);
            this.WindGrp.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox WindGrp;
        private System.Windows.Forms.TextBox TxtCmpExchngRate;
        private System.Windows.Forms.TextBox TxtCmpCurrSym;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtCmpPrfx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox MskTxtCmpPinCd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button CmdFntAdd1;
        private System.Windows.Forms.Button CmdFntComp;
        private System.Windows.Forms.TextBox TxtCmpBankNm;
        private System.Windows.Forms.TextBox TxtCmpBankBrnch;
        private System.Windows.Forms.TextBox TxtCmpBankAccnt;
        private System.Windows.Forms.TextBox TxtCmpPANNo;
        private System.Windows.Forms.TextBox TxtCmpTNGSTNo;
        private System.Windows.Forms.TextBox TxtCmpTINNo;
        private System.Windows.Forms.TextBox TxtCmpCurrPaise;
        private System.Windows.Forms.TextBox TxtCmpCurrCd;
        private System.Windows.Forms.TextBox TxtCmpEmail;
        private System.Windows.Forms.TextBox TxtCmpCurrName;
        private System.Windows.Forms.MaskedTextBox MskTxtCmpPhone;
        private System.Windows.Forms.TextBox TxtCmpFax;
        private System.Windows.Forms.TextBox TxtCmpCity;
        private System.Windows.Forms.TextBox TxtCmpAdd1;
        private System.Windows.Forms.TextBox TxtCmpAdd2;
        private System.Windows.Forms.TextBox TxtCmpAliasName;
        private System.Windows.Forms.TextBox TxtCmpName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.FontDialog FnCmpName;
        private System.Windows.Forms.FontDialog FnCmpAdd1;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.MaskedTextBox MskTxtCmpMobPhone;
        private System.Windows.Forms.Label label21;

    }
}