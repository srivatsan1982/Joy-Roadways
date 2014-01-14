using System;
using ComponentFactory.Krypton.Toolkit;
namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmCustomerMaster : KryptonForm
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
            this.TxtCustEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCustLnName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtCustCountry = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.MskTxtCustMobPhone = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.MskTxtCustPinCd = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.MskTxtCustPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtCustCity = new System.Windows.Forms.TextBox();
            this.TxtCustAdd1 = new System.Windows.Forms.TextBox();
            this.TxtCustAdd2 = new System.Windows.Forms.TextBox();
            this.TxtCustFrName = new System.Windows.Forms.TextBox();
            this.TxtCustCode = new System.Windows.Forms.TextBox();
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
            this.Wind.Location = new System.Drawing.Point(141, 35);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(525, 398);
            this.Wind.TabIndex = 1;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.TxtCustEmail);
            this.WindGrp.Controls.Add(this.label6);
            this.WindGrp.Controls.Add(this.TxtCustLnName);
            this.WindGrp.Controls.Add(this.label22);
            this.WindGrp.Controls.Add(this.TxtCustCountry);
            this.WindGrp.Controls.Add(this.label23);
            this.WindGrp.Controls.Add(this.ChkActive);
            this.WindGrp.Controls.Add(this.MskTxtCustMobPhone);
            this.WindGrp.Controls.Add(this.label21);
            this.WindGrp.Controls.Add(this.CmdClear);
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdSave);
            this.WindGrp.Controls.Add(this.MskTxtCustPinCd);
            this.WindGrp.Controls.Add(this.label17);
            this.WindGrp.Controls.Add(this.MskTxtCustPhone);
            this.WindGrp.Controls.Add(this.TxtCustCity);
            this.WindGrp.Controls.Add(this.TxtCustAdd1);
            this.WindGrp.Controls.Add(this.TxtCustAdd2);
            this.WindGrp.Controls.Add(this.TxtCustFrName);
            this.WindGrp.Controls.Add(this.TxtCustCode);
            this.WindGrp.Controls.Add(this.label5);
            this.WindGrp.Controls.Add(this.label4);
            this.WindGrp.Controls.Add(this.label3);
            this.WindGrp.Controls.Add(this.label2);
            this.WindGrp.Controls.Add(this.label1);
            this.WindGrp.Controls.Add(this.LblCompanyName);
            this.WindGrp.Location = new System.Drawing.Point(8, 2);
            this.WindGrp.Name = "WindGrp";
            this.WindGrp.Size = new System.Drawing.Size(510, 386);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Customer Details";
            this.WindGrp.Paint += new System.Windows.Forms.PaintEventHandler(this.WindGrp_Paint);
            // 
            // TxtCustEmail
            // 
            this.TxtCustEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustEmail.Location = new System.Drawing.Point(153, 280);
            this.TxtCustEmail.Name = "TxtCustEmail";
            this.TxtCustEmail.Size = new System.Drawing.Size(349, 21);
            this.TxtCustEmail.TabIndex = 10;
            this.TxtCustEmail.GotFocus += new System.EventHandler(this.TxtCustEmail_GotFocus);
            this.TxtCustEmail.LostFocus += new System.EventHandler(this.TxtCustEmail_LostFocus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Email";
            // 
            // TxtCustLnName
            // 
            this.TxtCustLnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustLnName.Location = new System.Drawing.Point(153, 82);
            this.TxtCustLnName.Name = "TxtCustLnName";
            this.TxtCustLnName.Size = new System.Drawing.Size(349, 21);
            this.TxtCustLnName.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 15);
            this.label22.TabIndex = 44;
            this.label22.Text = "Last Name";
            // 
            // TxtCustCountry
            // 
            this.TxtCustCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustCountry.Location = new System.Drawing.Point(153, 196);
            this.TxtCustCountry.Name = "TxtCustCountry";
            this.TxtCustCountry.Size = new System.Drawing.Size(349, 21);
            this.TxtCustCountry.TabIndex = 7;
            this.TxtCustCountry.GotFocus += new System.EventHandler(this.TxtCustCountry_GotFocus);
            this.TxtCustCountry.LostFocus += new System.EventHandler(this.TxtCustCountry_LostFocus);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 199);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 15);
            this.label23.TabIndex = 43;
            this.label23.Text = "Country";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(153, 311);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(56, 17);
            this.ChkActive.TabIndex = 11;
            this.ChkActive.Text = "Active";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // MskTxtCustMobPhone
            // 
            this.MskTxtCustMobPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtCustMobPhone.Location = new System.Drawing.Point(153, 253);
            this.MskTxtCustMobPhone.Mask = "0000000000";
            this.MskTxtCustMobPhone.Name = "MskTxtCustMobPhone";
            this.MskTxtCustMobPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtCustMobPhone.TabIndex = 9;
            this.MskTxtCustMobPhone.GotFocus += new System.EventHandler(this.MskTxtCustMobPhone_GotFocus);
            this.MskTxtCustMobPhone.LostFocus += new System.EventHandler(this.MskTxtCustMobPhone_LostFocus);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 256);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 41;
            this.label21.Text = "Phone(Mob)";
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(191, 334);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(129, 36);
            this.CmdClear.TabIndex = 13;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(326, 334);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(129, 36);
            this.CmdCancel.TabIndex = 14;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(56, 334);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(129, 36);
            this.CmdSave.TabIndex = 12;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // MskTxtCustPinCd
            // 
            this.MskTxtCustPinCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtCustPinCd.Location = new System.Drawing.Point(368, 167);
            this.MskTxtCustPinCd.Mask = "000000";
            this.MskTxtCustPinCd.Name = "MskTxtCustPinCd";
            this.MskTxtCustPinCd.Size = new System.Drawing.Size(134, 21);
            this.MskTxtCustPinCd.TabIndex = 6;
            this.MskTxtCustPinCd.GotFocus += new System.EventHandler(this.MskTxtCustPinCd_GotFocus);
            this.MskTxtCustPinCd.LostFocus += new System.EventHandler(this.MskTxtCustPinCd_LostFocus);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pincode";
            // 
            // MskTxtCustPhone
            // 
            this.MskTxtCustPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MskTxtCustPhone.Location = new System.Drawing.Point(153, 223);
            this.MskTxtCustPhone.Mask = "000000000000000000";
            this.MskTxtCustPhone.Name = "MskTxtCustPhone";
            this.MskTxtCustPhone.Size = new System.Drawing.Size(349, 21);
            this.MskTxtCustPhone.TabIndex = 8;
            this.MskTxtCustPhone.GotFocus += new System.EventHandler(this.MskTxtCustPhone_GotFocus);
            this.MskTxtCustPhone.LostFocus += new System.EventHandler(this.MskTxtCustPhone_LostFocus);
            // 
            // TxtCustCity
            // 
            this.TxtCustCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustCity.Location = new System.Drawing.Point(153, 168);
            this.TxtCustCity.Name = "TxtCustCity";
            this.TxtCustCity.Size = new System.Drawing.Size(155, 21);
            this.TxtCustCity.TabIndex = 5;
            this.TxtCustCity.GotFocus += new System.EventHandler(this.TxtCustCity_GotFocus);
            this.TxtCustCity.LostFocus += new System.EventHandler(this.TxtCustCity_LostFocus);
            // 
            // TxtCustAdd1
            // 
            this.TxtCustAdd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustAdd1.Location = new System.Drawing.Point(153, 112);
            this.TxtCustAdd1.Name = "TxtCustAdd1";
            this.TxtCustAdd1.Size = new System.Drawing.Size(349, 21);
            this.TxtCustAdd1.TabIndex = 3;
            this.TxtCustAdd1.GotFocus += new System.EventHandler(this.TxtCustAdd1_GotFocus);
            this.TxtCustAdd1.LostFocus += new System.EventHandler(this.TxtCustAdd1_LostFocus);
            // 
            // TxtCustAdd2
            // 
            this.TxtCustAdd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustAdd2.Location = new System.Drawing.Point(153, 140);
            this.TxtCustAdd2.Name = "TxtCustAdd2";
            this.TxtCustAdd2.Size = new System.Drawing.Size(349, 21);
            this.TxtCustAdd2.TabIndex = 4;
            this.TxtCustAdd2.GotFocus += new System.EventHandler(this.TxtCustAdd2_GotFocus);
            this.TxtCustAdd2.LostFocus += new System.EventHandler(this.TxtCustAdd2_LostFocus);
            // 
            // TxtCustFrName
            // 
            this.TxtCustFrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustFrName.Location = new System.Drawing.Point(153, 53);
            this.TxtCustFrName.Name = "TxtCustFrName";
            this.TxtCustFrName.Size = new System.Drawing.Size(349, 21);
            this.TxtCustFrName.TabIndex = 1;
            this.TxtCustFrName.GotFocus += new System.EventHandler(this.TxtCustFrName_GotFocus);
            this.TxtCustFrName.LostFocus += new System.EventHandler(this.TxtCustFrName_LostFocus);
            // 
            // TxtCustCode
            // 
            this.TxtCustCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustCode.Location = new System.Drawing.Point(153, 24);
            this.TxtCustCode.Name = "TxtCustCode";
            this.TxtCustCode.Size = new System.Drawing.Size(155, 21);
            this.TxtCustCode.TabIndex = 0;
            this.TxtCustCode.GotFocus += new System.EventHandler(this.TxtCustCode_GotFocus);
            this.TxtCustCode.LostFocus += new System.EventHandler(this.TxtCustCode_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone(Off)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
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
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(9, 27);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(105, 15);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "Customer Code";
            // 
            // FrmCustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 833);
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCustomerMaster";
            this.ShowIcon = false;
            this.Text = "Customer Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmCustomerMaster_Activated);
            this.Load += new System.EventHandler(this.FrmCustomerMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCustomerMaster_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCustomerMaster_KeyPress);
            this.Wind.ResumeLayout(false);
            this.WindGrp.ResumeLayout(false);
            this.WindGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox WindGrp;
        private System.Windows.Forms.TextBox TxtCustCountry;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.MaskedTextBox MskTxtCustPinCd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox MskTxtCustPhone;
        private System.Windows.Forms.TextBox TxtCustCity;
        private System.Windows.Forms.TextBox TxtCustAdd1;
        private System.Windows.Forms.TextBox TxtCustAdd2;
        private System.Windows.Forms.TextBox TxtCustFrName;
        private System.Windows.Forms.TextBox TxtCustCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.TextBox TxtCustEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCustLnName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox MskTxtCustMobPhone;
    }
}