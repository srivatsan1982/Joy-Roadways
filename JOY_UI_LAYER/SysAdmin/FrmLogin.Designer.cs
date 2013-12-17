namespace JOY_UI_LAYER.SysAdmin
{
    partial class FrmLogin : ComponentFactory.Krypton.Toolkit.KryptonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSubmit = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PicLogin = new System.Windows.Forms.PictureBox();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(394, 136);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(120, 27);
            this.CmdCancel.TabIndex = 3;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdSubmit
            // 
            this.CmdSubmit.Location = new System.Drawing.Point(268, 136);
            this.CmdSubmit.Name = "CmdSubmit";
            this.CmdSubmit.Size = new System.Drawing.Size(120, 27);
            this.CmdSubmit.TabIndex = 2;
            this.CmdSubmit.Text = "&Submit";
            this.CmdSubmit.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(178, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 15);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Password";
            // 
            // TxtPwd
            // 
            this.TxtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPwd.Location = new System.Drawing.Point(254, 96);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(260, 23);
            this.TxtPwd.TabIndex = 1;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserName.Location = new System.Drawing.Point(254, 56);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(260, 23);
            this.TxtUserName.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(178, 58);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 15);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Login";
            // 
            // PicLogin
            // 
            this.PicLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicLogin.ErrorImage = null;
            this.PicLogin.Image = ((System.Drawing.Image)(resources.GetObject("PicLogin.Image")));
            this.PicLogin.InitialImage = null;
            this.PicLogin.Location = new System.Drawing.Point(22, 24);
            this.PicLogin.Name = "PicLogin";
            this.PicLogin.Size = new System.Drawing.Size(149, 147);
            this.PicLogin.TabIndex = 7;
            this.PicLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 194);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSubmit);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PicLogin);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Inventory Management System";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdSubmit;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtPwd;
        internal System.Windows.Forms.TextBox TxtUserName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PicLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}