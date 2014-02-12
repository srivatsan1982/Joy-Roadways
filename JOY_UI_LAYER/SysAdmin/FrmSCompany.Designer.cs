namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmSCompany : ComponentFactory.Krypton.Toolkit.KryptonForm
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
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdOk = new System.Windows.Forms.Button();
            this.CboCompany = new System.Windows.Forms.ComboBox();
            this.Wind.SuspendLayout();
            this.WindGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wind
            // 
            this.Wind.Controls.Add(this.WindGrp);
            this.Wind.Location = new System.Drawing.Point(2, 6);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(427, 101);
            this.Wind.TabIndex = 0;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // WindGrp
            // 
            this.WindGrp.Controls.Add(this.CmdCancel);
            this.WindGrp.Controls.Add(this.CmdOk);
            this.WindGrp.Controls.Add(this.CboCompany);
            this.WindGrp.Location = new System.Drawing.Point(7, 3);
            this.WindGrp.Name = "WindGrp";
            this.WindGrp.Size = new System.Drawing.Size(413, 90);
            this.WindGrp.TabIndex = 0;
            this.WindGrp.TabStop = false;
            this.WindGrp.Text = "Select a Company";
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(210, 59);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 2;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdOk
            // 
            this.CmdOk.Location = new System.Drawing.Point(128, 59);
            this.CmdOk.Name = "CmdOk";
            this.CmdOk.Size = new System.Drawing.Size(75, 23);
            this.CmdOk.TabIndex = 1;
            this.CmdOk.Text = "&Ok";
            this.CmdOk.UseVisualStyleBackColor = true;
            this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
            // 
            // CboCompany
            // 
            this.CboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCompany.FormattingEnabled = true;
            this.CboCompany.Location = new System.Drawing.Point(6, 31);
            this.CboCompany.Name = "CboCompany";
            this.CboCompany.Size = new System.Drawing.Size(401, 23);
            this.CboCompany.TabIndex = 0;
            this.CboCompany.GotFocus += new System.EventHandler(this.ddlCompany_GotFocus);
            // 
            // FrmSCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 113);
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Company";
            this.Activated += new System.EventHandler(this.FrmSCompany_Activated);
            this.Load += new System.EventHandler(this.FrmSCompany_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSCompany_KeyDown);
            this.Wind.ResumeLayout(false);
            this.WindGrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox WindGrp;
        private System.Windows.Forms.ComboBox CboCompany;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdOk;
    }
}