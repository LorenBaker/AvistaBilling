namespace AvistaBilling
{
    partial class frmInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceBindingNavigatior = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.frameAccount = new System.Windows.Forms.GroupBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.btnInvoiceNotSaved = new System.Windows.Forms.Button();
            this.btnCalculateInvoice = new System.Windows.Forms.Button();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblReadDate = new System.Windows.Forms.Label();
            this.calInvoiceDate = new System.Windows.Forms.MonthCalendar();
            this.calReadDate = new System.Windows.Forms.MonthCalendar();
            this.frameMeterReadings = new System.Windows.Forms.GroupBox();
            this.dgvMeterReadings = new System.Windows.Forms.DataGridView();
            this.frameInvoice = new System.Windows.Forms.GroupBox();
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.txtInvoice = new System.Windows.Forms.RichTextBox();
            this.frameButtons = new System.Windows.Forms.GroupBox();
            this.ckWrongRateSchedule = new System.Windows.Forms.CheckBox();
            this.ckTotalChargesMatch = new System.Windows.Forms.CheckBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigatior)).BeginInit();
            this.invoiceBindingNavigatior.SuspendLayout();
            this.frameAccount.SuspendLayout();
            this.frameMeterReadings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterReadings)).BeginInit();
            this.frameInvoice.SuspendLayout();
            this.panelInvoice.SuspendLayout();
            this.frameButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceBindingNavigatior
            // 
            this.invoiceBindingNavigatior.AddNewItem = null;
            this.invoiceBindingNavigatior.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigatior.DeleteItem = null;
            this.invoiceBindingNavigatior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.invoiceBindingNavigatior.Location = new System.Drawing.Point(0, 0);
            this.invoiceBindingNavigatior.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigatior.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigatior.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigatior.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigatior.Name = "invoiceBindingNavigatior";
            this.invoiceBindingNavigatior.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigatior.Size = new System.Drawing.Size(1120, 27);
            this.invoiceBindingNavigatior.TabIndex = 0;
            this.invoiceBindingNavigatior.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // frameAccount
            // 
            this.frameAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameAccount.Controls.Add(this.cbAccount);
            this.frameAccount.Controls.Add(this.btnInvoiceNotSaved);
            this.frameAccount.Controls.Add(this.btnCalculateInvoice);
            this.frameAccount.Controls.Add(this.lblInvoiceDate);
            this.frameAccount.Controls.Add(this.lblReadDate);
            this.frameAccount.Controls.Add(this.calInvoiceDate);
            this.frameAccount.Controls.Add(this.calReadDate);
            this.frameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameAccount.Location = new System.Drawing.Point(12, 53);
            this.frameAccount.Name = "frameAccount";
            this.frameAccount.Size = new System.Drawing.Size(1096, 285);
            this.frameAccount.TabIndex = 1;
            this.frameAccount.TabStop = false;
            this.frameAccount.Text = "Account";
            // 
            // cbAccount
            // 
            this.cbAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(3, 20);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(1090, 26);
            this.cbAccount.TabIndex = 1;
            // 
            // btnInvoiceNotSaved
            // 
            this.btnInvoiceNotSaved.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInvoiceNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceNotSaved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoiceNotSaved.Location = new System.Drawing.Point(790, 105);
            this.btnInvoiceNotSaved.Name = "btnInvoiceNotSaved";
            this.btnInvoiceNotSaved.Size = new System.Drawing.Size(221, 39);
            this.btnInvoiceNotSaved.TabIndex = 17;
            this.btnInvoiceNotSaved.Text = "Invoice Not Saved";
            this.btnInvoiceNotSaved.UseVisualStyleBackColor = false;
            this.btnInvoiceNotSaved.Visible = false;
            // 
            // btnCalculateInvoice
            // 
            this.btnCalculateInvoice.Location = new System.Drawing.Point(790, 203);
            this.btnCalculateInvoice.Name = "btnCalculateInvoice";
            this.btnCalculateInvoice.Size = new System.Drawing.Size(221, 64);
            this.btnCalculateInvoice.TabIndex = 6;
            this.btnCalculateInvoice.Text = "Calculate Invoice";
            this.btnCalculateInvoice.UseVisualStyleBackColor = true;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(351, 82);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(89, 18);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblReadDate
            // 
            this.lblReadDate.AutoSize = true;
            this.lblReadDate.Location = new System.Drawing.Point(99, 82);
            this.lblReadDate.Name = "lblReadDate";
            this.lblReadDate.Size = new System.Drawing.Size(78, 18);
            this.lblReadDate.TabIndex = 3;
            this.lblReadDate.Text = "Read Date";
            // 
            // calInvoiceDate
            // 
            this.calInvoiceDate.Location = new System.Drawing.Point(282, 105);
            this.calInvoiceDate.MaxSelectionCount = 1;
            this.calInvoiceDate.Name = "calInvoiceDate";
            this.calInvoiceDate.TabIndex = 2;
            // 
            // calReadDate
            // 
            this.calReadDate.Location = new System.Drawing.Point(25, 105);
            this.calReadDate.MaxSelectionCount = 1;
            this.calReadDate.Name = "calReadDate";
            this.calReadDate.TabIndex = 1;
            // 
            // frameMeterReadings
            // 
            this.frameMeterReadings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameMeterReadings.Controls.Add(this.dgvMeterReadings);
            this.frameMeterReadings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameMeterReadings.Location = new System.Drawing.Point(12, 344);
            this.frameMeterReadings.Name = "frameMeterReadings";
            this.frameMeterReadings.Size = new System.Drawing.Size(1096, 198);
            this.frameMeterReadings.TabIndex = 2;
            this.frameMeterReadings.TabStop = false;
            this.frameMeterReadings.Text = "Meter Readings";
            // 
            // dgvMeterReadings
            // 
            this.dgvMeterReadings.AllowUserToAddRows = false;
            this.dgvMeterReadings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeterReadings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeterReadings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeterReadings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMeterReadings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeterReadings.Location = new System.Drawing.Point(3, 20);
            this.dgvMeterReadings.Name = "dgvMeterReadings";
            this.dgvMeterReadings.Size = new System.Drawing.Size(1090, 175);
            this.dgvMeterReadings.TabIndex = 0;
            // 
            // frameInvoice
            // 
            this.frameInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameInvoice.Controls.Add(this.panelInvoice);
            this.frameInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameInvoice.Location = new System.Drawing.Point(9, 548);
            this.frameInvoice.Name = "frameInvoice";
            this.frameInvoice.Size = new System.Drawing.Size(1096, 244);
            this.frameInvoice.TabIndex = 2;
            this.frameInvoice.TabStop = false;
            this.frameInvoice.Text = "Invoice Detail";
            // 
            // panelInvoice
            // 
            this.panelInvoice.BackColor = System.Drawing.SystemColors.Window;
            this.panelInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInvoice.Controls.Add(this.txtInvoice);
            this.panelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoice.Location = new System.Drawing.Point(3, 20);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.Padding = new System.Windows.Forms.Padding(4);
            this.panelInvoice.Size = new System.Drawing.Size(1090, 221);
            this.panelInvoice.TabIndex = 0;
            // 
            // txtInvoice
            // 
            this.txtInvoice.AcceptsTab = true;
            this.txtInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoice.Location = new System.Drawing.Point(4, 4);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(1078, 209);
            this.txtInvoice.TabIndex = 0;
            this.txtInvoice.Text = "";
            // 
            // frameButtons
            // 
            this.frameButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameButtons.Controls.Add(this.ckWrongRateSchedule);
            this.frameButtons.Controls.Add(this.ckTotalChargesMatch);
            this.frameButtons.Controls.Add(this.btnSaveNew);
            this.frameButtons.Controls.Add(this.btnDelete);
            this.frameButtons.Controls.Add(this.btnNew);
            this.frameButtons.Controls.Add(this.btnCancel);
            this.frameButtons.Controls.Add(this.btnSave);
            this.frameButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameButtons.Location = new System.Drawing.Point(12, 798);
            this.frameButtons.Name = "frameButtons";
            this.frameButtons.Size = new System.Drawing.Size(1093, 133);
            this.frameButtons.TabIndex = 11;
            this.frameButtons.TabStop = false;
            // 
            // ckWrongRateSchedule
            // 
            this.ckWrongRateSchedule.AutoSize = true;
            this.ckWrongRateSchedule.Location = new System.Drawing.Point(230, 23);
            this.ckWrongRateSchedule.Name = "ckWrongRateSchedule";
            this.ckWrongRateSchedule.Size = new System.Drawing.Size(172, 22);
            this.ckWrongRateSchedule.TabIndex = 11;
            this.ckWrongRateSchedule.Text = "Wrong Rate Schedule";
            this.ckWrongRateSchedule.UseVisualStyleBackColor = true;
            // 
            // ckTotalChargesMatch
            // 
            this.ckTotalChargesMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckTotalChargesMatch.AutoSize = true;
            this.ckTotalChargesMatch.Location = new System.Drawing.Point(698, 23);
            this.ckTotalChargesMatch.Name = "ckTotalChargesMatch";
            this.ckTotalChargesMatch.Size = new System.Drawing.Size(165, 22);
            this.ckTotalChargesMatch.TabIndex = 10;
            this.ckTotalChargesMatch.Text = "Total Charges Match";
            this.ckTotalChargesMatch.UseVisualStyleBackColor = true;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNew.Location = new System.Drawing.Point(739, 62);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(121, 51);
            this.btnSaveNew.TabIndex = 9;
            this.btnSaveNew.Text = "Save/New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(358, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 51);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(485, 62);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 51);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(232, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 51);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(612, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 51);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 939);
            this.Controls.Add(this.frameButtons);
            this.Controls.Add(this.frameInvoice);
            this.Controls.Add(this.frameMeterReadings);
            this.Controls.Add(this.frameAccount);
            this.Controls.Add(this.invoiceBindingNavigatior);
            this.Name = "frmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoices";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigatior)).EndInit();
            this.invoiceBindingNavigatior.ResumeLayout(false);
            this.invoiceBindingNavigatior.PerformLayout();
            this.frameAccount.ResumeLayout(false);
            this.frameAccount.PerformLayout();
            this.frameMeterReadings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterReadings)).EndInit();
            this.frameInvoice.ResumeLayout(false);
            this.panelInvoice.ResumeLayout(false);
            this.frameButtons.ResumeLayout(false);
            this.frameButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator invoiceBindingNavigatior;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox frameAccount;
        private System.Windows.Forms.Button btnCalculateInvoice;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblReadDate;
        private System.Windows.Forms.MonthCalendar calInvoiceDate;
        private System.Windows.Forms.MonthCalendar calReadDate;
        private System.Windows.Forms.GroupBox frameMeterReadings;
        private System.Windows.Forms.DataGridView dgvMeterReadings;
        private System.Windows.Forms.GroupBox frameInvoice;
        private System.Windows.Forms.Panel panelInvoice;
        private System.Windows.Forms.RichTextBox txtInvoice;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.Button btnInvoiceNotSaved;
        private System.Windows.Forms.GroupBox frameButtons;
        private System.Windows.Forms.CheckBox ckTotalChargesMatch;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckWrongRateSchedule;
    }
}