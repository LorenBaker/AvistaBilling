namespace AvistaBilling
{
    partial class EditRateSchedules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRateSchedules));
            this.btnResetRateBlocks = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDemandRateBlocks = new System.Windows.Forms.DataGridView();
            this.cbUtility = new System.Windows.Forms.ComboBox();
            this.lblUtility = new System.Windows.Forms.Label();
            this.ckBoxHasDemandRate = new System.Windows.Forms.CheckBox();
            this.lblBasicCharge = new System.Windows.Forms.Label();
            this.gvEnergyRateBlocks = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameDemandRateBlocks = new System.Windows.Forms.GroupBox();
            this.txtBasicCharge = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.cbTypeOfService = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.txtCityTaxRate = new System.Windows.Forms.TextBox();
            this.frameEnergyRateBlocks = new System.Windows.Forms.GroupBox();
            this.txtRateSchedule = new System.Windows.Forms.TextBox();
            this.lblRateSchedleNumber = new System.Windows.Forms.Label();
            this.lblCityTaxRate = new System.Windows.Forms.Label();
            this.rateSchedulesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.gvDemandRateBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEnergyRateBlocks)).BeginInit();
            this.frameDemandRateBlocks.SuspendLayout();
            this.frameEnergyRateBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateSchedulesBindingNavigator)).BeginInit();
            this.rateSchedulesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetRateBlocks
            // 
            this.btnResetRateBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetRateBlocks.Location = new System.Drawing.Point(500, 275);
            this.btnResetRateBlocks.Name = "btnResetRateBlocks";
            this.btnResetRateBlocks.Size = new System.Drawing.Size(206, 39);
            this.btnResetRateBlocks.TabIndex = 31;
            this.btnResetRateBlocks.Text = "Reset Rate Blocks";
            this.btnResetRateBlocks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Type";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // gvDemandRateBlocks
            // 
            this.gvDemandRateBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDemandRateBlocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gvDemandRateBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDemandRateBlocks.Location = new System.Drawing.Point(3, 16);
            this.gvDemandRateBlocks.Name = "gvDemandRateBlocks";
            this.gvDemandRateBlocks.Size = new System.Drawing.Size(555, 196);
            this.gvDemandRateBlocks.TabIndex = 0;
            // 
            // cbUtility
            // 
            this.cbUtility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUtility.FormattingEnabled = true;
            this.cbUtility.Location = new System.Drawing.Point(233, 90);
            this.cbUtility.Name = "cbUtility";
            this.cbUtility.Size = new System.Drawing.Size(209, 21);
            this.cbUtility.TabIndex = 19;
            // 
            // lblUtility
            // 
            this.lblUtility.AutoSize = true;
            this.lblUtility.Location = new System.Drawing.Point(147, 94);
            this.lblUtility.Name = "lblUtility";
            this.lblUtility.Size = new System.Drawing.Size(35, 13);
            this.lblUtility.TabIndex = 30;
            this.lblUtility.Text = "Utility:";
            // 
            // ckBoxHasDemandRate
            // 
            this.ckBoxHasDemandRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxHasDemandRate.AutoSize = true;
            this.ckBoxHasDemandRate.Location = new System.Drawing.Point(455, 168);
            this.ckBoxHasDemandRate.Name = "ckBoxHasDemandRate";
            this.ckBoxHasDemandRate.Size = new System.Drawing.Size(114, 17);
            this.ckBoxHasDemandRate.TabIndex = 25;
            this.ckBoxHasDemandRate.Text = "Has Demand Rate";
            this.ckBoxHasDemandRate.UseVisualStyleBackColor = true;
            // 
            // lblBasicCharge
            // 
            this.lblBasicCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBasicCharge.AutoSize = true;
            this.lblBasicCharge.Location = new System.Drawing.Point(455, 94);
            this.lblBasicCharge.Name = "lblBasicCharge";
            this.lblBasicCharge.Size = new System.Drawing.Size(73, 13);
            this.lblBasicCharge.TabIndex = 29;
            this.lblBasicCharge.Text = "Basic Charge:";
            // 
            // gvEnergyRateBlocks
            // 
            this.gvEnergyRateBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEnergyRateBlocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Type,
            this.Quantity,
            this.Rate});
            this.gvEnergyRateBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEnergyRateBlocks.Location = new System.Drawing.Point(3, 16);
            this.gvEnergyRateBlocks.Name = "gvEnergyRateBlocks";
            this.gvEnergyRateBlocks.Size = new System.Drawing.Size(555, 196);
            this.gvEnergyRateBlocks.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.Name = "Number";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // frameDemandRateBlocks
            // 
            this.frameDemandRateBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameDemandRateBlocks.Controls.Add(this.gvDemandRateBlocks);
            this.frameDemandRateBlocks.Location = new System.Drawing.Point(146, 541);
            this.frameDemandRateBlocks.Name = "frameDemandRateBlocks";
            this.frameDemandRateBlocks.Size = new System.Drawing.Size(561, 215);
            this.frameDemandRateBlocks.TabIndex = 20;
            this.frameDemandRateBlocks.TabStop = false;
            this.frameDemandRateBlocks.Text = "Demand Rate Blocks:";
            // 
            // txtBasicCharge
            // 
            this.txtBasicCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBasicCharge.Location = new System.Drawing.Point(543, 90);
            this.txtBasicCharge.Name = "txtBasicCharge";
            this.txtBasicCharge.Size = new System.Drawing.Size(163, 20);
            this.txtBasicCharge.TabIndex = 22;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(146, 146);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 26;
            // 
            // cbTypeOfService
            // 
            this.cbTypeOfService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypeOfService.FormattingEnabled = true;
            this.cbTypeOfService.Location = new System.Drawing.Point(543, 58);
            this.cbTypeOfService.Name = "cbTypeOfService";
            this.cbTypeOfService.Size = new System.Drawing.Size(164, 21);
            this.cbTypeOfService.TabIndex = 21;
            // 
            // lblUnits
            // 
            this.lblUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(455, 62);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(85, 13);
            this.lblUnits.TabIndex = 27;
            this.lblUnits.Text = "Type of Service:";
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.AutoSize = true;
            this.lblEffectiveDate.Location = new System.Drawing.Point(146, 129);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(78, 13);
            this.lblEffectiveDate.TabIndex = 24;
            this.lblEffectiveDate.Text = "Effective Date:";
            // 
            // txtCityTaxRate
            // 
            this.txtCityTaxRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCityTaxRate.Location = new System.Drawing.Point(543, 125);
            this.txtCityTaxRate.Name = "txtCityTaxRate";
            this.txtCityTaxRate.Size = new System.Drawing.Size(163, 20);
            this.txtCityTaxRate.TabIndex = 23;
            // 
            // frameEnergyRateBlocks
            // 
            this.frameEnergyRateBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameEnergyRateBlocks.Controls.Add(this.gvEnergyRateBlocks);
            this.frameEnergyRateBlocks.Location = new System.Drawing.Point(146, 320);
            this.frameEnergyRateBlocks.Name = "frameEnergyRateBlocks";
            this.frameEnergyRateBlocks.Size = new System.Drawing.Size(561, 215);
            this.frameEnergyRateBlocks.TabIndex = 16;
            this.frameEnergyRateBlocks.TabStop = false;
            this.frameEnergyRateBlocks.Text = "Energy Rate Blocks:";
            // 
            // txtRateSchedule
            // 
            this.txtRateSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRateSchedule.Location = new System.Drawing.Point(233, 58);
            this.txtRateSchedule.Name = "txtRateSchedule";
            this.txtRateSchedule.Size = new System.Drawing.Size(208, 20);
            this.txtRateSchedule.TabIndex = 15;
            // 
            // lblRateSchedleNumber
            // 
            this.lblRateSchedleNumber.AutoSize = true;
            this.lblRateSchedleNumber.Location = new System.Drawing.Point(146, 62);
            this.lblRateSchedleNumber.Name = "lblRateSchedleNumber";
            this.lblRateSchedleNumber.Size = new System.Drawing.Size(81, 13);
            this.lblRateSchedleNumber.TabIndex = 17;
            this.lblRateSchedleNumber.Text = "Rate Schedule:";
            // 
            // lblCityTaxRate
            // 
            this.lblCityTaxRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityTaxRate.AutoSize = true;
            this.lblCityTaxRate.Location = new System.Drawing.Point(455, 129);
            this.lblCityTaxRate.Name = "lblCityTaxRate";
            this.lblCityTaxRate.Size = new System.Drawing.Size(74, 13);
            this.lblCityTaxRate.TabIndex = 18;
            this.lblCityTaxRate.Text = "City Tax Rate:";
            // 
            // rateSchedulesBindingNavigator
            // 
            this.rateSchedulesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rateSchedulesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rateSchedulesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rateSchedulesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.rateSchedulesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rateSchedulesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rateSchedulesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rateSchedulesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rateSchedulesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rateSchedulesBindingNavigator.Name = "rateSchedulesBindingNavigator";
            this.rateSchedulesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rateSchedulesBindingNavigator.Size = new System.Drawing.Size(853, 25);
            this.rateSchedulesBindingNavigator.TabIndex = 32;
            this.rateSchedulesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // EditRateSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 1012);
            this.Controls.Add(this.rateSchedulesBindingNavigator);
            this.Controls.Add(this.btnResetRateBlocks);
            this.Controls.Add(this.cbUtility);
            this.Controls.Add(this.lblUtility);
            this.Controls.Add(this.ckBoxHasDemandRate);
            this.Controls.Add(this.lblBasicCharge);
            this.Controls.Add(this.frameDemandRateBlocks);
            this.Controls.Add(this.txtBasicCharge);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.cbTypeOfService);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblEffectiveDate);
            this.Controls.Add(this.txtCityTaxRate);
            this.Controls.Add(this.frameEnergyRateBlocks);
            this.Controls.Add(this.txtRateSchedule);
            this.Controls.Add(this.lblRateSchedleNumber);
            this.Controls.Add(this.lblCityTaxRate);
            this.Name = "EditRateSchedules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRateSchedules";
            ((System.ComponentModel.ISupportInitialize)(this.gvDemandRateBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEnergyRateBlocks)).EndInit();
            this.frameDemandRateBlocks.ResumeLayout(false);
            this.frameEnergyRateBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rateSchedulesBindingNavigator)).EndInit();
            this.rateSchedulesBindingNavigator.ResumeLayout(false);
            this.rateSchedulesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetRateBlocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView gvDemandRateBlocks;
        private System.Windows.Forms.ComboBox cbUtility;
        private System.Windows.Forms.Label lblUtility;
        private System.Windows.Forms.CheckBox ckBoxHasDemandRate;
        private System.Windows.Forms.Label lblBasicCharge;
        private System.Windows.Forms.DataGridView gvEnergyRateBlocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.GroupBox frameDemandRateBlocks;
        private System.Windows.Forms.TextBox txtBasicCharge;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ComboBox cbTypeOfService;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.TextBox txtCityTaxRate;
        private System.Windows.Forms.GroupBox frameEnergyRateBlocks;
        private System.Windows.Forms.TextBox txtRateSchedule;
        private System.Windows.Forms.Label lblRateSchedleNumber;
        private System.Windows.Forms.Label lblCityTaxRate;
        private System.Windows.Forms.BindingNavigator rateSchedulesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
    }
}