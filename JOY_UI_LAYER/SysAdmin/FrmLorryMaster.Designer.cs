using System;
using ComponentFactory.Krypton.Toolkit;
namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmLorryMaster : KryptonForm
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
            this.TxtLryOwnrName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.TxtLryNumber = new System.Windows.Forms.TextBox();
            this.TxtLryDesc = new System.Windows.Forms.TextBox();
            this.TxtLryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Wind.SuspendLayout();
            this.WindGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wind
            // 
            this.Wind.Controls.Add(this.WindGrp);
            this.Wind.Location = new System.Drawing.Point(78, 71);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(525, 322);
            this.Wind.TabIndex = 2;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.TxtLryOwnrName);
            this.WindGrp.Controls.Add(this.label6);
            this.WindGrp.Controls.Add(this.ChkActive);
            this.WindGrp.Controls.Add(this.CmdClear);
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdSave);
            this.WindGrp.Controls.Add(this.TxtLryNumber);
            this.WindGrp.Controls.Add(this.TxtLryDesc);
            this.WindGrp.Controls.Add(this.TxtLryName);
            this.WindGrp.Controls.Add(this.label3);
            this.WindGrp.Controls.Add(this.label2);
            this.WindGrp.Controls.Add(this.label1);
            this.WindGrp.Location = new System.Drawing.Point(8, 2);
            this.WindGrp.Name = "WindGrp";
            this.WindGrp.Size = new System.Drawing.Size(510, 312);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Lorry Details";
            // 
            // TxtLryOwnrName
            // 
            this.TxtLryOwnrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLryOwnrName.Location = new System.Drawing.Point(153, 55);
            this.TxtLryOwnrName.Name = "TxtLryOwnrName";
            this.TxtLryOwnrName.Size = new System.Drawing.Size(349, 21);
            this.TxtLryOwnrName.TabIndex = 1;
            this.TxtLryOwnrName.GotFocus += new System.EventHandler(this.TxtLryOwnrName_GotFocus);
            this.TxtLryOwnrName.LostFocus += new System.EventHandler(this.TxtLryOwnrName_LostFocus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Lorry Owner Name";
            // 
            // ChkActive
            // 
            this.ChkActive.Location = new System.Drawing.Point(153, 239);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(66, 18);
            this.ChkActive.TabIndex = 4;
            this.ChkActive.Text = "Active";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(191, 263);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(129, 36);
            this.CmdClear.TabIndex = 6;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(326, 263);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(129, 36);
            this.CmdCancel.TabIndex = 7;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(56, 263);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(129, 36);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtLryNumber
            // 
            this.TxtLryNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLryNumber.Location = new System.Drawing.Point(153, 86);
            this.TxtLryNumber.Name = "TxtLryNumber";
            this.TxtLryNumber.Size = new System.Drawing.Size(349, 21);
            this.TxtLryNumber.TabIndex = 2;
            this.TxtLryNumber.GotFocus += new System.EventHandler(this.TxtLryNumber_GotFocus);
            this.TxtLryNumber.LostFocus += new System.EventHandler(this.TxtLryNumber_LostFocus);
            // 
            // TxtLryDesc
            // 
            this.TxtLryDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLryDesc.Location = new System.Drawing.Point(153, 118);
            this.TxtLryDesc.Multiline = true;
            this.TxtLryDesc.Name = "TxtLryDesc";
            this.TxtLryDesc.Size = new System.Drawing.Size(349, 110);
            this.TxtLryDesc.TabIndex = 3;
            this.TxtLryDesc.GotFocus += new System.EventHandler(this.TxtLryDesc_GotFocus);
            this.TxtLryDesc.LostFocus += new System.EventHandler(this.TxtLryDesc_LostFocus);
            // 
            // TxtLryName
            // 
            this.TxtLryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLryName.Location = new System.Drawing.Point(153, 26);
            this.TxtLryName.Name = "TxtLryName";
            this.TxtLryName.Size = new System.Drawing.Size(349, 21);
            this.TxtLryName.TabIndex = 0;
            this.TxtLryName.GotFocus += new System.EventHandler(this.TxtLryName_GotFocus);
            this.TxtLryName.LostFocus += new System.EventHandler(this.TxtLryName_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lorry Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lorry Name";
            // 
            // FrmLorryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 724);
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLorryMaster";
            this.Text = "Lorry Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmLorryMaster_Activated);
            this.Load += new System.EventHandler(this.FrmLorryMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLorryMaster_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLorryMaster_KeyPress);
            this.Wind.ResumeLayout(false);
            this.WindGrp.ResumeLayout(false);
            this.WindGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox WindGrp;
        private System.Windows.Forms.TextBox TxtLryOwnrName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox TxtLryNumber;
        private System.Windows.Forms.TextBox TxtLryDesc;
        private System.Windows.Forms.TextBox TxtLryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}