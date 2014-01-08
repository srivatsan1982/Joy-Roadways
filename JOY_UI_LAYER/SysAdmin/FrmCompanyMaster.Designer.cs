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
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtCmpName = new System.Windows.Forms.TextBox();
            this.TxtCmpAliasName = new System.Windows.Forms.TextBox();
            this.TxtCmpAdd2 = new System.Windows.Forms.TextBox();
            this.TxtCmpAdd1 = new System.Windows.Forms.TextBox();
            this.TxtCmpCity = new System.Windows.Forms.TextBox();
            this.TxtCmpFax = new System.Windows.Forms.TextBox();
            this.TxtCmpPhone = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrName = new System.Windows.Forms.TextBox();
            this.TxtCmpEmail = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrCd = new System.Windows.Forms.TextBox();
            this.TxtCmpCurrPaise = new System.Windows.Forms.TextBox();
            this.TxtCmpTINNo = new System.Windows.Forms.TextBox();
            this.TxtCmpTNGSTNo = new System.Windows.Forms.TextBox();
            this.TxtCmpPANNo = new System.Windows.Forms.TextBox();
            this.TxtCmpBankAccnt = new System.Windows.Forms.TextBox();
            this.TxtCmpBankBrnch = new System.Windows.Forms.TextBox();
            this.TxtCmpBankNm = new System.Windows.Forms.TextBox();
            this.CmdFntComp = new System.Windows.Forms.Button();
            this.CmdFntAdd1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtCmpPinCd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WindGrp = new System.Windows.Forms.GroupBox();
            this.TxtCmpPrfx = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCmpCurrSym = new System.Windows.Forms.TextBox();
            this.TxtCmpExchngRate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FnCmpName = new System.Windows.Forms.FontDialog();
            this.FnCmpAdd1 = new System.Windows.Forms.FontDialog();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.Wind.SuspendLayout();
            this.WindGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wind
            // 
            this.Wind.Controls.Add(this.WindGrp);
            this.Wind.Location = new System.Drawing.Point(71, 35);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(525, 557);
            this.Wind.TabIndex = 0;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(9, 28);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(93, 15);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alias Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Currency Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Currency Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Currency Paise";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "TIN No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "TNGST No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "PAN No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Default Bank Account";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 476);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Default Bank Branch";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Default Bank Name";
            // 
            // TxtCmpName
            // 
            this.TxtCmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpName.Location = new System.Drawing.Point(132, 25);
            this.TxtCmpName.Name = "TxtCmpName";
            this.TxtCmpName.Size = new System.Drawing.Size(338, 23);
            this.TxtCmpName.TabIndex = 0;
            // 
            // TxtCmpAliasName
            // 
            this.TxtCmpAliasName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpAliasName.Location = new System.Drawing.Point(132, 53);
            this.TxtCmpAliasName.Name = "TxtCmpAliasName";
            this.TxtCmpAliasName.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpAliasName.TabIndex = 2;
            // 
            // TxtCmpAdd2
            // 
            this.TxtCmpAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpAdd2.Location = new System.Drawing.Point(132, 109);
            this.TxtCmpAdd2.Name = "TxtCmpAdd2";
            this.TxtCmpAdd2.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpAdd2.TabIndex = 5;
            // 
            // TxtCmpAdd1
            // 
            this.TxtCmpAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpAdd1.Location = new System.Drawing.Point(132, 81);
            this.TxtCmpAdd1.Name = "TxtCmpAdd1";
            this.TxtCmpAdd1.Size = new System.Drawing.Size(338, 23);
            this.TxtCmpAdd1.TabIndex = 3;
            // 
            // TxtCmpCity
            // 
            this.TxtCmpCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCity.Location = new System.Drawing.Point(132, 137);
            this.TxtCmpCity.Name = "TxtCmpCity";
            this.TxtCmpCity.Size = new System.Drawing.Size(176, 23);
            this.TxtCmpCity.TabIndex = 6;
            // 
            // TxtCmpFax
            // 
            this.TxtCmpFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpFax.Location = new System.Drawing.Point(132, 193);
            this.TxtCmpFax.Name = "TxtCmpFax";
            this.TxtCmpFax.Size = new System.Drawing.Size(176, 23);
            this.TxtCmpFax.TabIndex = 9;
            // 
            // TxtCmpPhone
            // 
            this.TxtCmpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpPhone.Location = new System.Drawing.Point(132, 165);
            this.TxtCmpPhone.Name = "TxtCmpPhone";
            this.TxtCmpPhone.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpPhone.TabIndex = 8;
            // 
            // TxtCmpCurrName
            // 
            this.TxtCmpCurrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrName.Location = new System.Drawing.Point(132, 249);
            this.TxtCmpCurrName.Name = "TxtCmpCurrName";
            this.TxtCmpCurrName.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpCurrName.TabIndex = 12;
            // 
            // TxtCmpEmail
            // 
            this.TxtCmpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpEmail.Location = new System.Drawing.Point(132, 221);
            this.TxtCmpEmail.Name = "TxtCmpEmail";
            this.TxtCmpEmail.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpEmail.TabIndex = 11;
            // 
            // TxtCmpCurrCd
            // 
            this.TxtCmpCurrCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrCd.Location = new System.Drawing.Point(132, 277);
            this.TxtCmpCurrCd.Name = "TxtCmpCurrCd";
            this.TxtCmpCurrCd.Size = new System.Drawing.Size(176, 23);
            this.TxtCmpCurrCd.TabIndex = 13;
            // 
            // TxtCmpCurrPaise
            // 
            this.TxtCmpCurrPaise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrPaise.Location = new System.Drawing.Point(132, 305);
            this.TxtCmpCurrPaise.Name = "TxtCmpCurrPaise";
            this.TxtCmpCurrPaise.Size = new System.Drawing.Size(176, 23);
            this.TxtCmpCurrPaise.TabIndex = 15;
            // 
            // TxtCmpTINNo
            // 
            this.TxtCmpTINNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpTINNo.Location = new System.Drawing.Point(132, 333);
            this.TxtCmpTINNo.Name = "TxtCmpTINNo";
            this.TxtCmpTINNo.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpTINNo.TabIndex = 17;
            // 
            // TxtCmpTNGSTNo
            // 
            this.TxtCmpTNGSTNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpTNGSTNo.Location = new System.Drawing.Point(132, 361);
            this.TxtCmpTNGSTNo.Name = "TxtCmpTNGSTNo";
            this.TxtCmpTNGSTNo.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpTNGSTNo.TabIndex = 18;
            // 
            // TxtCmpPANNo
            // 
            this.TxtCmpPANNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpPANNo.Location = new System.Drawing.Point(132, 389);
            this.TxtCmpPANNo.Name = "TxtCmpPANNo";
            this.TxtCmpPANNo.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpPANNo.TabIndex = 19;
            // 
            // TxtCmpBankAccnt
            // 
            this.TxtCmpBankAccnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpBankAccnt.Location = new System.Drawing.Point(132, 417);
            this.TxtCmpBankAccnt.Name = "TxtCmpBankAccnt";
            this.TxtCmpBankAccnt.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpBankAccnt.TabIndex = 20;
            // 
            // TxtCmpBankBrnch
            // 
            this.TxtCmpBankBrnch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpBankBrnch.Location = new System.Drawing.Point(132, 473);
            this.TxtCmpBankBrnch.Name = "TxtCmpBankBrnch";
            this.TxtCmpBankBrnch.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpBankBrnch.TabIndex = 22;
            // 
            // TxtCmpBankNm
            // 
            this.TxtCmpBankNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpBankNm.Location = new System.Drawing.Point(132, 445);
            this.TxtCmpBankNm.Name = "TxtCmpBankNm";
            this.TxtCmpBankNm.Size = new System.Drawing.Size(370, 23);
            this.TxtCmpBankNm.TabIndex = 21;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(318, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pincode";
            // 
            // TxtCmpPinCd
            // 
            this.TxtCmpPinCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpPinCd.Location = new System.Drawing.Point(368, 136);
            this.TxtCmpPinCd.Name = "TxtCmpPinCd";
            this.TxtCmpPinCd.Size = new System.Drawing.Size(134, 23);
            this.TxtCmpPinCd.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(312, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 30);
            this.label18.TabIndex = 35;
            this.label18.Text = "Company \r\nPrefix";
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.CmdClear);
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdSave);
            this.WindGrp.Controls.Add(this.TxtCmpExchngRate);
            this.WindGrp.Controls.Add(this.TxtCmpCurrSym);
            this.WindGrp.Controls.Add(this.label20);
            this.WindGrp.Controls.Add(this.label19);
            this.WindGrp.Controls.Add(this.TxtCmpPrfx);
            this.WindGrp.Controls.Add(this.label18);
            this.WindGrp.Controls.Add(this.TxtCmpPinCd);
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
            this.WindGrp.Controls.Add(this.TxtCmpPhone);
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
            this.WindGrp.Size = new System.Drawing.Size(510, 547);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Company Details";
            this.WindGrp.Paint += new System.Windows.Forms.PaintEventHandler(this.WindGrp_Paint);
            // 
            // TxtCmpPrfx
            // 
            this.TxtCmpPrfx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpPrfx.Location = new System.Drawing.Point(375, 194);
            this.TxtCmpPrfx.Name = "TxtCmpPrfx";
            this.TxtCmpPrfx.Size = new System.Drawing.Size(127, 23);
            this.TxtCmpPrfx.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(312, 272);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 30);
            this.label19.TabIndex = 36;
            this.label19.Text = "Currency \r\nSymbol";
            // 
            // TxtCmpCurrSym
            // 
            this.TxtCmpCurrSym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpCurrSym.Location = new System.Drawing.Point(375, 277);
            this.TxtCmpCurrSym.Name = "TxtCmpCurrSym";
            this.TxtCmpCurrSym.Size = new System.Drawing.Size(127, 23);
            this.TxtCmpCurrSym.TabIndex = 14;
            // 
            // TxtCmpExchngRate
            // 
            this.TxtCmpExchngRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCmpExchngRate.Location = new System.Drawing.Point(375, 306);
            this.TxtCmpExchngRate.Name = "TxtCmpExchngRate";
            this.TxtCmpExchngRate.Size = new System.Drawing.Size(127, 23);
            this.TxtCmpExchngRate.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(311, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 30);
            this.label20.TabIndex = 38;
            this.label20.Text = "Exchange \r\nRate";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(56, 502);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(129, 36);
            this.CmdSave.TabIndex = 39;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(326, 502);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(129, 36);
            this.CmdCancel.TabIndex = 40;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(191, 502);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(129, 36);
            this.CmdClear.TabIndex = 40;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // FrmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1359, 760);
            this.ControlBox = false;
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
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
        private System.Windows.Forms.TextBox TxtCmpPinCd;
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
        private System.Windows.Forms.TextBox TxtCmpPhone;
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

    }
}