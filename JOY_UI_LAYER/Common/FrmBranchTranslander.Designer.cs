using System;
using ComponentFactory.Krypton.Toolkit;
namespace JOY_UI_LAYER.Common
{
    partial class FrmBranchTranslander : KryptonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchTranslander));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Wind = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.WinGrpInp = new System.Windows.Forms.GroupBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFnDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtStDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkInActive = new System.Windows.Forms.CheckBox();
            this.ChkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CmdEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dtBranchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRNCHCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRNCHNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHCONTACTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHADD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHADD2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRNCHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wind.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNav)).BeginInit();
            this.GridNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.WinGrpInp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBranchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Wind
            // 
            this.Wind.Controls.Add(this.groupBox2);
            this.Wind.Controls.Add(this.WinGrpInp);
            this.Wind.Location = new System.Drawing.Point(50, 49);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(721, 561);
            this.Wind.TabIndex = 0;
            this.Wind.Paint += new System.Windows.Forms.PaintEventHandler(this.Wind_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridNav);
            this.groupBox2.Controls.Add(this.DgvResult);
            this.groupBox2.Location = new System.Drawing.Point(6, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ResultSet";
            // 
            // GridNav
            // 
            this.GridNav.AddNewItem = null;
            this.GridNav.BindingSource = this.dtBranchBindingSource;
            this.GridNav.CountItem = this.bindingNavigatorCountItem;
            this.GridNav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.GridNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GridNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.GridNav.Location = new System.Drawing.Point(3, 378);
            this.GridNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.GridNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.GridNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.GridNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.GridNav.Name = "GridNav";
            this.GridNav.PositionItem = this.bindingNavigatorPositionItem;
            this.GridNav.Size = new System.Drawing.Size(703, 25);
            this.GridNav.TabIndex = 1;
            this.GridNav.Text = "Navigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DgvResult
            // 
            this.DgvResult.AutoGenerateColumns = false;
            this.DgvResult.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChkSelect,
            this.bRNCHCODEDataGridViewTextBoxColumn,
            this.bRNCHNAMEDataGridViewTextBoxColumn,
            this.bRANCHCONTACTNAMEDataGridViewTextBoxColumn,
            this.bRANCHADD1DataGridViewTextBoxColumn,
            this.bRANCHADD2DataGridViewTextBoxColumn,
            this.bRANCHCITYDataGridViewTextBoxColumn,
            this.bRANCHPHONEDataGridViewTextBoxColumn,
            this.CmdEdit,
            this.bRNCHIDDataGridViewTextBoxColumn});
            this.DgvResult.DataSource = this.dtBranchBindingSource;
            this.DgvResult.EnableHeadersVisualStyles = false;
            this.DgvResult.Location = new System.Drawing.Point(12, 21);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowHeadersVisible = false;
            this.DgvResult.Size = new System.Drawing.Size(691, 355);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellContentClick);
            this.DgvResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResult_CellFormatting);
            // 
            // WinGrpInp
            // 
            this.WinGrpInp.Controls.Add(this.ChkInActive);
            this.WinGrpInp.Controls.Add(this.CmdCancel);
            this.WinGrpInp.Controls.Add(this.CmdClear);
            this.WinGrpInp.Controls.Add(this.CmdSearch);
            this.WinGrpInp.Controls.Add(this.TxtName);
            this.WinGrpInp.Controls.Add(this.label3);
            this.WinGrpInp.Controls.Add(this.TxtCode);
            this.WinGrpInp.Controls.Add(this.label4);
            this.WinGrpInp.Controls.Add(this.TxtFnDate);
            this.WinGrpInp.Controls.Add(this.label2);
            this.WinGrpInp.Controls.Add(this.TxtStDate);
            this.WinGrpInp.Controls.Add(this.label1);
            this.WinGrpInp.Location = new System.Drawing.Point(6, 2);
            this.WinGrpInp.Name = "WinGrpInp";
            this.WinGrpInp.Size = new System.Drawing.Size(709, 137);
            this.WinGrpInp.TabIndex = 0;
            this.WinGrpInp.TabStop = false;
            this.WinGrpInp.Text = "Input Criteria";
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(395, 103);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 6;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(316, 103);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(75, 23);
            this.CmdClear.TabIndex = 5;
            this.CmdClear.Text = "C&lear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(239, 103);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(75, 23);
            this.CmdSearch.TabIndex = 4;
            this.CmdSearch.Text = "&Search";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Location = new System.Drawing.Point(432, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(256, 21);
            this.TxtName.TabIndex = 3;
            this.TxtName.GotFocus += new System.EventHandler(this.TxtCity_GotFocus);
            this.TxtName.LostFocus += new System.EventHandler(this.TxtCity_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // TxtCode
            // 
            this.TxtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCode.Location = new System.Drawing.Point(104, 49);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(257, 21);
            this.TxtCode.TabIndex = 2;
            this.TxtCode.GotFocus += new System.EventHandler(this.TxtName_GotFocus);
            this.TxtCode.LostFocus += new System.EventHandler(this.TxtName_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code";
            // 
            // TxtFnDate
            // 
            this.TxtFnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFnDate.Location = new System.Drawing.Point(432, 20);
            this.TxtFnDate.Mask = "00/00/0000";
            this.TxtFnDate.Name = "TxtFnDate";
            this.TxtFnDate.Size = new System.Drawing.Size(100, 21);
            this.TxtFnDate.TabIndex = 1;
            this.TxtFnDate.ValidatingType = typeof(System.DateTime);
            this.TxtFnDate.GotFocus += new System.EventHandler(this.TxtFnDate_GotFocus);
            this.TxtFnDate.LostFocus += new System.EventHandler(this.TxtFnDate_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            // 
            // TxtStDate
            // 
            this.TxtStDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStDate.Location = new System.Drawing.Point(104, 20);
            this.TxtStDate.Mask = "00/00/0000";
            this.TxtStDate.Name = "TxtStDate";
            this.TxtStDate.Size = new System.Drawing.Size(100, 21);
            this.TxtStDate.TabIndex = 0;
            this.TxtStDate.ValidatingType = typeof(System.DateTime);
            this.TxtStDate.GotFocus += new System.EventHandler(this.TxtStDate_GotFocus);
            this.TxtStDate.LostFocus += new System.EventHandler(this.TxtStDate_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // ChkInActive
            // 
            this.ChkInActive.AutoSize = true;
            this.ChkInActive.Checked = true;
            this.ChkInActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkInActive.Location = new System.Drawing.Point(104, 78);
            this.ChkInActive.Name = "ChkInActive";
            this.ChkInActive.Size = new System.Drawing.Size(81, 19);
            this.ChkInActive.TabIndex = 7;
            this.ChkInActive.Text = "Show All";
            this.ChkInActive.UseVisualStyleBackColor = true;
            // 
            // ChkSelect
            // 
            this.ChkSelect.HeaderText = "";
            this.ChkSelect.Name = "ChkSelect";
            this.ChkSelect.Width = 25;
            // 
            // CmdEdit
            // 
            this.CmdEdit.HeaderText = "Edit";
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Text = "Edit";
            // 
            // dtBranchBindingSource
            // 
            this.dtBranchBindingSource.DataMember = "DTBranch";
            this.dtBranchBindingSource.DataSource = typeof(JOY_BUS_LAYER.DataSets.DSCommon);
            // 
            // bRNCHCODEDataGridViewTextBoxColumn
            // 
            this.bRNCHCODEDataGridViewTextBoxColumn.DataPropertyName = "BRNCHCODE";
            this.bRNCHCODEDataGridViewTextBoxColumn.HeaderText = "Code";
            this.bRNCHCODEDataGridViewTextBoxColumn.Name = "bRNCHCODEDataGridViewTextBoxColumn";
            this.bRNCHCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRNCHNAMEDataGridViewTextBoxColumn
            // 
            this.bRNCHNAMEDataGridViewTextBoxColumn.DataPropertyName = "BRNCHNAME";
            this.bRNCHNAMEDataGridViewTextBoxColumn.HeaderText = "Branch Name";
            this.bRNCHNAMEDataGridViewTextBoxColumn.Name = "bRNCHNAMEDataGridViewTextBoxColumn";
            this.bRNCHNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHCONTACTNAMEDataGridViewTextBoxColumn
            // 
            this.bRANCHCONTACTNAMEDataGridViewTextBoxColumn.DataPropertyName = "BRANCHCONTACTNAME";
            this.bRANCHCONTACTNAMEDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.bRANCHCONTACTNAMEDataGridViewTextBoxColumn.Name = "bRANCHCONTACTNAMEDataGridViewTextBoxColumn";
            this.bRANCHCONTACTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHADD1DataGridViewTextBoxColumn
            // 
            this.bRANCHADD1DataGridViewTextBoxColumn.DataPropertyName = "BRANCHADD1";
            this.bRANCHADD1DataGridViewTextBoxColumn.HeaderText = "Address 1";
            this.bRANCHADD1DataGridViewTextBoxColumn.Name = "bRANCHADD1DataGridViewTextBoxColumn";
            this.bRANCHADD1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHADD2DataGridViewTextBoxColumn
            // 
            this.bRANCHADD2DataGridViewTextBoxColumn.DataPropertyName = "BRANCHADD2";
            this.bRANCHADD2DataGridViewTextBoxColumn.HeaderText = "Address 2";
            this.bRANCHADD2DataGridViewTextBoxColumn.Name = "bRANCHADD2DataGridViewTextBoxColumn";
            this.bRANCHADD2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHCITYDataGridViewTextBoxColumn
            // 
            this.bRANCHCITYDataGridViewTextBoxColumn.DataPropertyName = "BRANCHCITY";
            this.bRANCHCITYDataGridViewTextBoxColumn.HeaderText = "City";
            this.bRANCHCITYDataGridViewTextBoxColumn.Name = "bRANCHCITYDataGridViewTextBoxColumn";
            this.bRANCHCITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHPHONEDataGridViewTextBoxColumn
            // 
            this.bRANCHPHONEDataGridViewTextBoxColumn.DataPropertyName = "BRANCHPHONE";
            this.bRANCHPHONEDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.bRANCHPHONEDataGridViewTextBoxColumn.Name = "bRANCHPHONEDataGridViewTextBoxColumn";
            this.bRANCHPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRNCHIDDataGridViewTextBoxColumn
            // 
            this.bRNCHIDDataGridViewTextBoxColumn.DataPropertyName = "BRNCHID";
            this.bRNCHIDDataGridViewTextBoxColumn.HeaderText = "BRNCHID";
            this.bRNCHIDDataGridViewTextBoxColumn.Name = "bRNCHIDDataGridViewTextBoxColumn";
            this.bRNCHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmBranchTranslander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 938);
            this.Controls.Add(this.Wind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBranchTranslander";
            this.Text = "Search Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmCmpTranslander_Activated);
            this.Load += new System.EventHandler(this.FrmCmpTranslander_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCmpTranslander_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCmpTranslander_KeyPress);
            this.Wind.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNav)).EndInit();
            this.GridNav.ResumeLayout(false);
            this.GridNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.WinGrpInp.ResumeLayout(false);
            this.WinGrpInp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBranchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel Wind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox WinGrpInp;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtFnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtStDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.BindingNavigator GridNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource dtBranchBindingSource;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.CheckBox ChkInActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRNCHCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRNCHNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHCONTACTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHADD1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHADD2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn CmdEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRNCHIDDataGridViewTextBoxColumn;
    }
}