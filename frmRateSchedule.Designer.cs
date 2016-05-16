namespace AvistaBilling
{
    partial class frmRateSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRateSchedule));
            this.frameEnergyRateBlocks = new System.Windows.Forms.GroupBox();
            this.dgvRateBlocks = new System.Windows.Forms.DataGridView();
            this.lblRateSchedleNumber = new System.Windows.Forms.Label();
            this.lblCityTaxRate = new System.Windows.Forms.Label();
            this.txtRateSchedule = new System.Windows.Forms.TextBox();
            this.txtCityTaxRate = new System.Windows.Forms.TextBox();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.calEffectiveDate = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBasicCharge = new System.Windows.Forms.TextBox();
            this.lblBasicCharge = new System.Windows.Forms.Label();
            this.frameDemandRateBlocks = new System.Windows.Forms.GroupBox();
            this.dgvDemandRateBlocks = new System.Windows.Forms.DataGridView();
            this.ckBoxHasDemandRates = new System.Windows.Forms.CheckBox();
            this.cbUtility = new System.Windows.Forms.ComboBox();
            this.lblUtility = new System.Windows.Forms.Label();
            this.btnResetRateBlocks = new System.Windows.Forms.Button();
            this.rateSchedulesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnScheduleNotSaved = new System.Windows.Forms.Button();
            this.txtMinCharge = new System.Windows.Forms.TextBox();
            this.lblMinCharge = new System.Windows.Forms.Label();
            this.txtUtility = new System.Windows.Forms.TextBox();
            this.frameComboBoxValues = new System.Windows.Forms.GroupBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.frameEnergyRateBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateBlocks)).BeginInit();
            this.panel1.SuspendLayout();
            this.frameDemandRateBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandRateBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateSchedulesBindingNavigator)).BeginInit();
            this.rateSchedulesBindingNavigator.SuspendLayout();
            this.frameComboBoxValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // frameEnergyRateBlocks
            // 
            this.frameEnergyRateBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameEnergyRateBlocks.Controls.Add(this.dgvRateBlocks);
            this.frameEnergyRateBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameEnergyRateBlocks.Location = new System.Drawing.Point(40, 311);
            this.frameEnergyRateBlocks.Name = "frameEnergyRateBlocks";
            this.frameEnergyRateBlocks.Size = new System.Drawing.Size(688, 215);
            this.frameEnergyRateBlocks.TabIndex = 0;
            this.frameEnergyRateBlocks.TabStop = false;
            this.frameEnergyRateBlocks.Text = "Energy Rate Blocks:";
            // 
            // dgvRateBlocks
            // 
            this.dgvRateBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRateBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRateBlocks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvRateBlocks.Location = new System.Drawing.Point(3, 20);
            this.dgvRateBlocks.Name = "dgvRateBlocks";
            this.dgvRateBlocks.Size = new System.Drawing.Size(682, 192);
            this.dgvRateBlocks.TabIndex = 0;
            this.dgvRateBlocks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRateBlocks_DataError);
            // 
            // lblRateSchedleNumber
            // 
            this.lblRateSchedleNumber.AutoSize = true;
            this.lblRateSchedleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateSchedleNumber.Location = new System.Drawing.Point(40, 53);
            this.lblRateSchedleNumber.Name = "lblRateSchedleNumber";
            this.lblRateSchedleNumber.Size = new System.Drawing.Size(108, 18);
            this.lblRateSchedleNumber.TabIndex = 0;
            this.lblRateSchedleNumber.Text = "Rate Schedule:";
            // 
            // lblCityTaxRate
            // 
            this.lblCityTaxRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityTaxRate.AutoSize = true;
            this.lblCityTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityTaxRate.Location = new System.Drawing.Point(326, 152);
            this.lblCityTaxRate.Name = "lblCityTaxRate";
            this.lblCityTaxRate.Size = new System.Drawing.Size(100, 18);
            this.lblCityTaxRate.TabIndex = 1;
            this.lblCityTaxRate.Text = "City Tax Rate:";
            // 
            // txtRateSchedule
            // 
            this.txtRateSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateSchedule.Location = new System.Drawing.Point(154, 50);
            this.txtRateSchedule.Name = "txtRateSchedule";
            this.txtRateSchedule.Size = new System.Drawing.Size(117, 24);
            this.txtRateSchedule.TabIndex = 0;
            // 
            // txtCityTaxRate
            // 
            this.txtCityTaxRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCityTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityTaxRate.Location = new System.Drawing.Point(453, 150);
            this.txtCityTaxRate.Name = "txtCityTaxRate";
            this.txtCityTaxRate.Size = new System.Drawing.Size(113, 24);
            this.txtCityTaxRate.TabIndex = 4;
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.AutoSize = true;
            this.lblEffectiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveDate.Location = new System.Drawing.Point(40, 120);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(103, 18);
            this.lblEffectiveDate.TabIndex = 4;
            this.lblEffectiveDate.Text = "Effective Date:";
            // 
            // lblUnits
            // 
            this.lblUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(326, 53);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(114, 18);
            this.lblUnits.TabIndex = 6;
            this.lblUnits.Text = "Type of Service:";
            // 
            // cbServiceType
            // 
            this.cbServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(453, 49);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(113, 26);
            this.cbServiceType.TabIndex = 2;
            // 
            // calEffectiveDate
            // 
            this.calEffectiveDate.Location = new System.Drawing.Point(40, 137);
            this.calEffectiveDate.MaxSelectionCount = 1;
            this.calEffectiveDate.Name = "calEffectiveDate";
            this.calEffectiveDate.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSaveNew);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(40, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 84);
            this.panel1.TabIndex = 9;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNew.Location = new System.Drawing.Point(538, 17);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(121, 51);
            this.btnSaveNew.TabIndex = 4;
            this.btnSaveNew.Text = "Save/New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(157, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(284, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 51);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(31, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 51);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(411, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 51);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBasicCharge
            // 
            this.txtBasicCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBasicCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicCharge.Location = new System.Drawing.Point(453, 85);
            this.txtBasicCharge.Name = "txtBasicCharge";
            this.txtBasicCharge.Size = new System.Drawing.Size(113, 24);
            this.txtBasicCharge.TabIndex = 3;
            // 
            // lblBasicCharge
            // 
            this.lblBasicCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBasicCharge.AutoSize = true;
            this.lblBasicCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicCharge.Location = new System.Drawing.Point(326, 88);
            this.lblBasicCharge.Name = "lblBasicCharge";
            this.lblBasicCharge.Size = new System.Drawing.Size(101, 18);
            this.lblBasicCharge.TabIndex = 10;
            this.lblBasicCharge.Text = "Basic Charge:";
            // 
            // frameDemandRateBlocks
            // 
            this.frameDemandRateBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameDemandRateBlocks.Controls.Add(this.dgvDemandRateBlocks);
            this.frameDemandRateBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameDemandRateBlocks.Location = new System.Drawing.Point(40, 532);
            this.frameDemandRateBlocks.Name = "frameDemandRateBlocks";
            this.frameDemandRateBlocks.Size = new System.Drawing.Size(688, 215);
            this.frameDemandRateBlocks.TabIndex = 1;
            this.frameDemandRateBlocks.TabStop = false;
            this.frameDemandRateBlocks.Text = "Demand Rate Blocks:";
            // 
            // dgvDemandRateBlocks
            // 
            this.dgvDemandRateBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemandRateBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDemandRateBlocks.Location = new System.Drawing.Point(3, 20);
            this.dgvDemandRateBlocks.Name = "dgvDemandRateBlocks";
            this.dgvDemandRateBlocks.Size = new System.Drawing.Size(682, 192);
            this.dgvDemandRateBlocks.TabIndex = 0;
            this.dgvDemandRateBlocks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDemandRateBlocks_DataError);
            // 
            // ckBoxHasDemandRates
            // 
            this.ckBoxHasDemandRates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxHasDemandRates.AutoSize = true;
            this.ckBoxHasDemandRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBoxHasDemandRates.Location = new System.Drawing.Point(325, 201);
            this.ckBoxHasDemandRates.Name = "ckBoxHasDemandRates";
            this.ckBoxHasDemandRates.Size = new System.Drawing.Size(149, 22);
            this.ckBoxHasDemandRates.TabIndex = 5;
            this.ckBoxHasDemandRates.Text = "Has Demand Rate";
            this.ckBoxHasDemandRates.UseVisualStyleBackColor = true;
            // 
            // cbUtility
            // 
            this.cbUtility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUtility.FormattingEnabled = true;
            this.cbUtility.Location = new System.Drawing.Point(154, 84);
            this.cbUtility.Name = "cbUtility";
            this.cbUtility.Size = new System.Drawing.Size(118, 26);
            this.cbUtility.TabIndex = 1;
            // 
            // lblUtility
            // 
            this.lblUtility.AutoSize = true;
            this.lblUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtility.Location = new System.Drawing.Point(41, 88);
            this.lblUtility.Name = "lblUtility";
            this.lblUtility.Size = new System.Drawing.Size(47, 18);
            this.lblUtility.TabIndex = 13;
            this.lblUtility.Text = "Utility:";
            // 
            // btnResetRateBlocks
            // 
            this.btnResetRateBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetRateBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetRateBlocks.Location = new System.Drawing.Point(521, 266);
            this.btnResetRateBlocks.Name = "btnResetRateBlocks";
            this.btnResetRateBlocks.Size = new System.Drawing.Size(206, 39);
            this.btnResetRateBlocks.TabIndex = 14;
            this.btnResetRateBlocks.Text = "Reset Rate Blocks";
            this.btnResetRateBlocks.UseVisualStyleBackColor = true;
            this.btnResetRateBlocks.Click += new System.EventHandler(this.btnResetRateBlocks_Click);
            // 
            // rateSchedulesBindingNavigator
            // 
            this.rateSchedulesBindingNavigator.AddNewItem = this.bindingNavigatorCountItem;
            this.rateSchedulesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rateSchedulesBindingNavigator.DeleteItem = null;
            this.rateSchedulesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.rateSchedulesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rateSchedulesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rateSchedulesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rateSchedulesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rateSchedulesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rateSchedulesBindingNavigator.Name = "rateSchedulesBindingNavigator";
            this.rateSchedulesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rateSchedulesBindingNavigator.Size = new System.Drawing.Size(762, 27);
            this.rateSchedulesBindingNavigator.TabIndex = 15;
            this.rateSchedulesBindingNavigator.Text = "bnRateSchedules";
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
            // btnScheduleNotSaved
            // 
            this.btnScheduleNotSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScheduleNotSaved.BackColor = System.Drawing.Color.OrangeRed;
            this.btnScheduleNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleNotSaved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScheduleNotSaved.Location = new System.Drawing.Point(518, 221);
            this.btnScheduleNotSaved.Name = "btnScheduleNotSaved";
            this.btnScheduleNotSaved.Size = new System.Drawing.Size(206, 39);
            this.btnScheduleNotSaved.TabIndex = 16;
            this.btnScheduleNotSaved.Text = "Rate Schedule Not Saved";
            this.btnScheduleNotSaved.UseVisualStyleBackColor = false;
            this.btnScheduleNotSaved.Visible = false;
            // 
            // txtMinCharge
            // 
            this.txtMinCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinCharge.Location = new System.Drawing.Point(453, 117);
            this.txtMinCharge.Name = "txtMinCharge";
            this.txtMinCharge.Size = new System.Drawing.Size(113, 24);
            this.txtMinCharge.TabIndex = 17;
            // 
            // lblMinCharge
            // 
            this.lblMinCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinCharge.AutoSize = true;
            this.lblMinCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinCharge.Location = new System.Drawing.Point(326, 120);
            this.lblMinCharge.Name = "lblMinCharge";
            this.lblMinCharge.Size = new System.Drawing.Size(125, 18);
            this.lblMinCharge.TabIndex = 18;
            this.lblMinCharge.Text = "Minimum Charge:";
            // 
            // txtUtility
            // 
            this.txtUtility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtility.Location = new System.Drawing.Point(7, 23);
            this.txtUtility.Name = "txtUtility";
            this.txtUtility.Size = new System.Drawing.Size(123, 24);
            this.txtUtility.TabIndex = 19;
            this.txtUtility.TextChanged += new System.EventHandler(this.txtUtility_TextChanged);
            // 
            // frameComboBoxValues
            // 
            this.frameComboBoxValues.Controls.Add(this.txtServiceType);
            this.frameComboBoxValues.Controls.Add(this.txtUtility);
            this.frameComboBoxValues.Location = new System.Drawing.Point(604, 91);
            this.frameComboBoxValues.Name = "frameComboBoxValues";
            this.frameComboBoxValues.Size = new System.Drawing.Size(136, 110);
            this.frameComboBoxValues.TabIndex = 20;
            this.frameComboBoxValues.TabStop = false;
            this.frameComboBoxValues.Text = "Combo Box Values";
            // 
            // txtServiceType
            // 
            this.txtServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceType.Location = new System.Drawing.Point(7, 53);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(123, 24);
            this.txtServiceType.TabIndex = 20;
            this.txtServiceType.TextChanged += new System.EventHandler(this.txtServiceType_TextChanged);
            // 
            // frmRateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 869);
            this.Controls.Add(this.frameComboBoxValues);
            this.Controls.Add(this.txtMinCharge);
            this.Controls.Add(this.lblMinCharge);
            this.Controls.Add(this.btnScheduleNotSaved);
            this.Controls.Add(this.rateSchedulesBindingNavigator);
            this.Controls.Add(this.btnResetRateBlocks);
            this.Controls.Add(this.cbUtility);
            this.Controls.Add(this.lblUtility);
            this.Controls.Add(this.ckBoxHasDemandRates);
            this.Controls.Add(this.frameDemandRateBlocks);
            this.Controls.Add(this.txtBasicCharge);
            this.Controls.Add(this.lblBasicCharge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calEffectiveDate);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblEffectiveDate);
            this.Controls.Add(this.txtCityTaxRate);
            this.Controls.Add(this.frameEnergyRateBlocks);
            this.Controls.Add(this.txtRateSchedule);
            this.Controls.Add(this.lblRateSchedleNumber);
            this.Controls.Add(this.lblCityTaxRate);
            this.Name = "frmRateSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Schedules";
            this.frameEnergyRateBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRateBlocks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.frameDemandRateBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandRateBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateSchedulesBindingNavigator)).EndInit();
            this.rateSchedulesBindingNavigator.ResumeLayout(false);
            this.rateSchedulesBindingNavigator.PerformLayout();
            this.frameComboBoxValues.ResumeLayout(false);
            this.frameComboBoxValues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox frameEnergyRateBlocks;
        private System.Windows.Forms.DataGridView dgvRateBlocks;
        private System.Windows.Forms.Label lblRateSchedleNumber;
        private System.Windows.Forms.Label lblCityTaxRate;
        private System.Windows.Forms.TextBox txtRateSchedule;
        private System.Windows.Forms.TextBox txtCityTaxRate;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.MonthCalendar calEffectiveDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBasicCharge;
        private System.Windows.Forms.Label lblBasicCharge;
        private System.Windows.Forms.GroupBox frameDemandRateBlocks;
        private System.Windows.Forms.DataGridView dgvDemandRateBlocks;
        private System.Windows.Forms.CheckBox ckBoxHasDemandRates;
        private System.Windows.Forms.ComboBox cbUtility;
        private System.Windows.Forms.Label lblUtility;
        private System.Windows.Forms.Button btnResetRateBlocks;
        private System.Windows.Forms.BindingNavigator rateSchedulesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnScheduleNotSaved;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.TextBox txtMinCharge;
        private System.Windows.Forms.Label lblMinCharge;
        private System.Windows.Forms.TextBox txtUtility;
        private System.Windows.Forms.GroupBox frameComboBoxValues;
        private System.Windows.Forms.TextBox txtServiceType;
    }
}