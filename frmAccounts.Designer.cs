namespace AvistaBilling
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnAccountCount = new System.Windows.Forms.ToolStripLabel();
            this.bnAccountMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bnAccountMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnAccountPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnAccountMoveNext = new System.Windows.Forms.ToolStripButton();
            this.bnAccountMoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.frameAccount = new System.Windows.Forms.GroupBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.cbUtility = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.frameLocation = new System.Windows.Forms.GroupBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtSate = new System.Windows.Forms.TextBox();
            this.lblCityStateZip = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.frameMeter = new System.Windows.Forms.GroupBox();
            this.btnMeterNotSaved = new System.Windows.Forms.Button();
            this.cbMeterRateScheduleNumber = new System.Windows.Forms.ComboBox();
            this.lblRateScheduleNumber = new System.Windows.Forms.Label();
            this.cbMeterType = new System.Windows.Forms.ComboBox();
            this.btnNewSaveMeter = new System.Windows.Forms.Button();
            this.btnDeleteMeter = new System.Windows.Forms.Button();
            this.btnNewMeter = new System.Windows.Forms.Button();
            this.btnSaveMeter = new System.Windows.Forms.Button();
            this.meterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnMeterCount = new System.Windows.Forms.ToolStripLabel();
            this.bnMeterMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bnMeterMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bnMeterPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bnMeterMoveNext = new System.Windows.Forms.ToolStripButton();
            this.bnMeterMoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtMeterMultiplier = new System.Windows.Forms.TextBox();
            this.lblMeterMultiplier = new System.Windows.Forms.Label();
            this.lblMeterType = new System.Windows.Forms.Label();
            this.lblMeterNumber = new System.Windows.Forms.Label();
            this.txtMeterNumber = new System.Windows.Forms.TextBox();
            this.btnSaveNewAccount = new System.Windows.Forms.Button();
            this.txtSortKey = new System.Windows.Forms.TextBox();
            this.lblSortKey = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnAccountNotSaved = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.frameAccountButtons = new System.Windows.Forms.GroupBox();
            this.ckAccountSelected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).BeginInit();
            this.accountBindingNavigator.SuspendLayout();
            this.frameAccount.SuspendLayout();
            this.frameLocation.SuspendLayout();
            this.frameMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meterBindingNavigator)).BeginInit();
            this.meterBindingNavigator.SuspendLayout();
            this.frameAccountButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountBindingNavigator
            // 
            this.accountBindingNavigator.AddNewItem = null;
            this.accountBindingNavigator.CountItem = this.bnAccountCount;
            this.accountBindingNavigator.DeleteItem = null;
            this.accountBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnAccountMoveFirst,
            this.bnAccountMovePrevious,
            this.bindingNavigatorSeparator,
            this.bnAccountPosition,
            this.bnAccountCount,
            this.bindingNavigatorSeparator1,
            this.bnAccountMoveNext,
            this.bnAccountMoveLast,
            this.bindingNavigatorSeparator2});
            this.accountBindingNavigator.Location = new System.Drawing.Point(3, 20);
            this.accountBindingNavigator.MoveFirstItem = this.bnAccountMoveFirst;
            this.accountBindingNavigator.MoveLastItem = this.bnAccountMoveLast;
            this.accountBindingNavigator.MoveNextItem = this.bnAccountMoveNext;
            this.accountBindingNavigator.MovePreviousItem = this.bnAccountMovePrevious;
            this.accountBindingNavigator.Name = "accountBindingNavigator";
            this.accountBindingNavigator.PositionItem = this.bnAccountPosition;
            this.accountBindingNavigator.Size = new System.Drawing.Size(667, 27);
            this.accountBindingNavigator.TabIndex = 0;
            this.accountBindingNavigator.Text = "accountBindingNavigator";
            // 
            // bnAccountCount
            // 
            this.bnAccountCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAccountCount.Name = "bnAccountCount";
            this.bnAccountCount.Size = new System.Drawing.Size(45, 24);
            this.bnAccountCount.Text = "of {0}";
            this.bnAccountCount.ToolTipText = "Total number of items";
            // 
            // bnAccountMoveFirst
            // 
            this.bnAccountMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnAccountMoveFirst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAccountMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnAccountMoveFirst.Image")));
            this.bnAccountMoveFirst.Name = "bnAccountMoveFirst";
            this.bnAccountMoveFirst.RightToLeftAutoMirrorImage = true;
            this.bnAccountMoveFirst.Size = new System.Drawing.Size(23, 24);
            this.bnAccountMoveFirst.Text = "Move first";
            // 
            // bnAccountMovePrevious
            // 
            this.bnAccountMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnAccountMovePrevious.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAccountMovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("bnAccountMovePrevious.Image")));
            this.bnAccountMovePrevious.Name = "bnAccountMovePrevious";
            this.bnAccountMovePrevious.RightToLeftAutoMirrorImage = true;
            this.bnAccountMovePrevious.Size = new System.Drawing.Size(23, 24);
            this.bnAccountMovePrevious.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bnAccountPosition
            // 
            this.bnAccountPosition.AccessibleName = "Position";
            this.bnAccountPosition.AutoSize = false;
            this.bnAccountPosition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAccountPosition.Name = "bnAccountPosition";
            this.bnAccountPosition.Size = new System.Drawing.Size(50, 27);
            this.bnAccountPosition.Text = "0";
            this.bnAccountPosition.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bnAccountMoveNext
            // 
            this.bnAccountMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnAccountMoveNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAccountMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("bnAccountMoveNext.Image")));
            this.bnAccountMoveNext.Name = "bnAccountMoveNext";
            this.bnAccountMoveNext.RightToLeftAutoMirrorImage = true;
            this.bnAccountMoveNext.Size = new System.Drawing.Size(23, 24);
            this.bnAccountMoveNext.Text = "Move next";
            // 
            // bnAccountMoveLast
            // 
            this.bnAccountMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnAccountMoveLast.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAccountMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("bnAccountMoveLast.Image")));
            this.bnAccountMoveLast.Name = "bnAccountMoveLast";
            this.bnAccountMoveLast.RightToLeftAutoMirrorImage = true;
            this.bnAccountMoveLast.Size = new System.Drawing.Size(23, 24);
            this.bnAccountMoveLast.Text = "Move last";
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
            this.frameAccount.Controls.Add(this.lblAccountNumber);
            this.frameAccount.Controls.Add(this.cbUtility);
            this.frameAccount.Controls.Add(this.txtAccountNumber);
            this.frameAccount.Controls.Add(this.accountBindingNavigator);
            this.frameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameAccount.Location = new System.Drawing.Point(12, 9);
            this.frameAccount.Name = "frameAccount";
            this.frameAccount.Size = new System.Drawing.Size(673, 97);
            this.frameAccount.TabIndex = 1;
            this.frameAccount.TabStop = false;
            this.frameAccount.Text = "Account";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(28, 63);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(65, 18);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "Number:";
            // 
            // cbUtility
            // 
            this.cbUtility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUtility.FormattingEnabled = true;
            this.cbUtility.Location = new System.Drawing.Point(521, 59);
            this.cbUtility.Name = "cbUtility";
            this.cbUtility.Size = new System.Drawing.Size(146, 26);
            this.cbUtility.TabIndex = 1;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountNumber.Location = new System.Drawing.Point(132, 60);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(383, 24);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // frameLocation
            // 
            this.frameLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameLocation.Controls.Add(this.txtZipcode);
            this.frameLocation.Controls.Add(this.txtSate);
            this.frameLocation.Controls.Add(this.lblCityStateZip);
            this.frameLocation.Controls.Add(this.lblAddress2);
            this.frameLocation.Controls.Add(this.lblAddress1);
            this.frameLocation.Controls.Add(this.txtCity);
            this.frameLocation.Controls.Add(this.txtAddress2);
            this.frameLocation.Controls.Add(this.txtAddress1);
            this.frameLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameLocation.Location = new System.Drawing.Point(15, 112);
            this.frameLocation.Name = "frameLocation";
            this.frameLocation.Size = new System.Drawing.Size(673, 135);
            this.frameLocation.TabIndex = 2;
            this.frameLocation.TabStop = false;
            this.frameLocation.Text = "Location";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(357, 88);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(52, 24);
            this.txtZipcode.TabIndex = 3;
            // 
            // txtSate
            // 
            this.txtSate.Location = new System.Drawing.Point(415, 88);
            this.txtSate.Name = "txtSate";
            this.txtSate.Size = new System.Drawing.Size(108, 24);
            this.txtSate.TabIndex = 4;
            // 
            // lblCityStateZip
            // 
            this.lblCityStateZip.AutoSize = true;
            this.lblCityStateZip.Location = new System.Drawing.Point(28, 91);
            this.lblCityStateZip.Name = "lblCityStateZip";
            this.lblCityStateZip.Size = new System.Drawing.Size(103, 18);
            this.lblCityStateZip.TabIndex = 5;
            this.lblCityStateZip.Text = "City, State, Zip";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(28, 60);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(74, 18);
            this.lblAddress2.TabIndex = 4;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(28, 29);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(78, 18);
            this.lblAddress1.TabIndex = 3;
            this.lblAddress1.Text = "Address 1:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(132, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(219, 24);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress2.Location = new System.Drawing.Point(132, 57);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(535, 24);
            this.txtAddress2.TabIndex = 1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress1.Location = new System.Drawing.Point(132, 26);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(535, 24);
            this.txtAddress1.TabIndex = 0;
            // 
            // frameMeter
            // 
            this.frameMeter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameMeter.Controls.Add(this.btnMeterNotSaved);
            this.frameMeter.Controls.Add(this.cbMeterRateScheduleNumber);
            this.frameMeter.Controls.Add(this.lblRateScheduleNumber);
            this.frameMeter.Controls.Add(this.cbMeterType);
            this.frameMeter.Controls.Add(this.btnNewSaveMeter);
            this.frameMeter.Controls.Add(this.btnDeleteMeter);
            this.frameMeter.Controls.Add(this.btnNewMeter);
            this.frameMeter.Controls.Add(this.btnSaveMeter);
            this.frameMeter.Controls.Add(this.meterBindingNavigator);
            this.frameMeter.Controls.Add(this.txtMeterMultiplier);
            this.frameMeter.Controls.Add(this.lblMeterMultiplier);
            this.frameMeter.Controls.Add(this.lblMeterType);
            this.frameMeter.Controls.Add(this.lblMeterNumber);
            this.frameMeter.Controls.Add(this.txtMeterNumber);
            this.frameMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameMeter.Location = new System.Drawing.Point(12, 253);
            this.frameMeter.Name = "frameMeter";
            this.frameMeter.Size = new System.Drawing.Size(673, 199);
            this.frameMeter.TabIndex = 3;
            this.frameMeter.TabStop = false;
            this.frameMeter.Text = "Meter";
            // 
            // btnMeterNotSaved
            // 
            this.btnMeterNotSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeterNotSaved.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMeterNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeterNotSaved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMeterNotSaved.Location = new System.Drawing.Point(405, 23);
            this.btnMeterNotSaved.Name = "btnMeterNotSaved";
            this.btnMeterNotSaved.Size = new System.Drawing.Size(254, 39);
            this.btnMeterNotSaved.TabIndex = 19;
            this.btnMeterNotSaved.TabStop = false;
            this.btnMeterNotSaved.Text = "Meter Not Saved";
            this.btnMeterNotSaved.UseVisualStyleBackColor = false;
            this.btnMeterNotSaved.Visible = false;
            // 
            // cbMeterRateScheduleNumber
            // 
            this.cbMeterRateScheduleNumber.FormattingEnabled = true;
            this.cbMeterRateScheduleNumber.Location = new System.Drawing.Point(132, 154);
            this.cbMeterRateScheduleNumber.Name = "cbMeterRateScheduleNumber";
            this.cbMeterRateScheduleNumber.Size = new System.Drawing.Size(107, 26);
            this.cbMeterRateScheduleNumber.TabIndex = 18;
            // 
            // lblRateScheduleNumber
            // 
            this.lblRateScheduleNumber.AutoSize = true;
            this.lblRateScheduleNumber.Location = new System.Drawing.Point(37, 158);
            this.lblRateScheduleNumber.Name = "lblRateScheduleNumber";
            this.lblRateScheduleNumber.Size = new System.Drawing.Size(89, 18);
            this.lblRateScheduleNumber.TabIndex = 17;
            this.lblRateScheduleNumber.Text = "Rate Sched:";
            // 
            // cbMeterType
            // 
            this.cbMeterType.FormattingEnabled = true;
            this.cbMeterType.Location = new System.Drawing.Point(132, 61);
            this.cbMeterType.Name = "cbMeterType";
            this.cbMeterType.Size = new System.Drawing.Size(266, 26);
            this.cbMeterType.TabIndex = 16;
            // 
            // btnNewSaveMeter
            // 
            this.btnNewSaveMeter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewSaveMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSaveMeter.Location = new System.Drawing.Point(538, 122);
            this.btnNewSaveMeter.Name = "btnNewSaveMeter";
            this.btnNewSaveMeter.Size = new System.Drawing.Size(121, 51);
            this.btnNewSaveMeter.TabIndex = 12;
            this.btnNewSaveMeter.Text = "Save/New";
            this.btnNewSaveMeter.UseVisualStyleBackColor = true;
            this.btnNewSaveMeter.Click += new System.EventHandler(this.btnNewSaveMeter_Click);
            // 
            // btnDeleteMeter
            // 
            this.btnDeleteMeter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMeter.Location = new System.Drawing.Point(405, 65);
            this.btnDeleteMeter.Name = "btnDeleteMeter";
            this.btnDeleteMeter.Size = new System.Drawing.Size(121, 51);
            this.btnDeleteMeter.TabIndex = 15;
            this.btnDeleteMeter.Text = "Delete";
            this.btnDeleteMeter.UseVisualStyleBackColor = true;
            this.btnDeleteMeter.Click += new System.EventHandler(this.btnDeleteMeter_Click);
            // 
            // btnNewMeter
            // 
            this.btnNewMeter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMeter.Location = new System.Drawing.Point(538, 65);
            this.btnNewMeter.Name = "btnNewMeter";
            this.btnNewMeter.Size = new System.Drawing.Size(121, 51);
            this.btnNewMeter.TabIndex = 14;
            this.btnNewMeter.Text = "New";
            this.btnNewMeter.UseVisualStyleBackColor = true;
            this.btnNewMeter.Click += new System.EventHandler(this.btnNewMeter_Click);
            // 
            // btnSaveMeter
            // 
            this.btnSaveMeter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMeter.Location = new System.Drawing.Point(405, 122);
            this.btnSaveMeter.Name = "btnSaveMeter";
            this.btnSaveMeter.Size = new System.Drawing.Size(121, 51);
            this.btnSaveMeter.TabIndex = 13;
            this.btnSaveMeter.Text = "Save";
            this.btnSaveMeter.UseVisualStyleBackColor = true;
            this.btnSaveMeter.Click += new System.EventHandler(this.btnSaveMeter_Click);
            // 
            // meterBindingNavigator
            // 
            this.meterBindingNavigator.AddNewItem = null;
            this.meterBindingNavigator.CountItem = this.bnMeterCount;
            this.meterBindingNavigator.DeleteItem = null;
            this.meterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnMeterMoveFirst,
            this.bnMeterMovePrevious,
            this.bindingNavigatorSeparator3,
            this.bnMeterPosition,
            this.bnMeterCount,
            this.bindingNavigatorSeparator4,
            this.bnMeterMoveNext,
            this.bnMeterMoveLast,
            this.bindingNavigatorSeparator5});
            this.meterBindingNavigator.Location = new System.Drawing.Point(3, 20);
            this.meterBindingNavigator.MoveFirstItem = this.bnMeterMoveFirst;
            this.meterBindingNavigator.MoveLastItem = this.bnMeterMoveLast;
            this.meterBindingNavigator.MoveNextItem = this.bnMeterMoveNext;
            this.meterBindingNavigator.MovePreviousItem = this.bnMeterMovePrevious;
            this.meterBindingNavigator.Name = "meterBindingNavigator";
            this.meterBindingNavigator.PositionItem = this.bnMeterPosition;
            this.meterBindingNavigator.Size = new System.Drawing.Size(667, 27);
            this.meterBindingNavigator.TabIndex = 11;
            this.meterBindingNavigator.Text = "meterBindingNavigator";
            // 
            // bnMeterCount
            // 
            this.bnMeterCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMeterCount.Name = "bnMeterCount";
            this.bnMeterCount.Size = new System.Drawing.Size(45, 24);
            this.bnMeterCount.Text = "of {0}";
            this.bnMeterCount.ToolTipText = "Total number of items";
            // 
            // bnMeterMoveFirst
            // 
            this.bnMeterMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMeterMoveFirst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMeterMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnMeterMoveFirst.Image")));
            this.bnMeterMoveFirst.Name = "bnMeterMoveFirst";
            this.bnMeterMoveFirst.RightToLeftAutoMirrorImage = true;
            this.bnMeterMoveFirst.Size = new System.Drawing.Size(23, 24);
            this.bnMeterMoveFirst.Text = "Move first";
            // 
            // bnMeterMovePrevious
            // 
            this.bnMeterMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMeterMovePrevious.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMeterMovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("bnMeterMovePrevious.Image")));
            this.bnMeterMovePrevious.Name = "bnMeterMovePrevious";
            this.bnMeterMovePrevious.RightToLeftAutoMirrorImage = true;
            this.bnMeterMovePrevious.Size = new System.Drawing.Size(23, 24);
            this.bnMeterMovePrevious.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bnMeterPosition
            // 
            this.bnMeterPosition.AccessibleName = "Position";
            this.bnMeterPosition.AutoSize = false;
            this.bnMeterPosition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMeterPosition.Name = "bnMeterPosition";
            this.bnMeterPosition.Size = new System.Drawing.Size(50, 27);
            this.bnMeterPosition.Text = "0";
            this.bnMeterPosition.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bnMeterMoveNext
            // 
            this.bnMeterMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMeterMoveNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMeterMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("bnMeterMoveNext.Image")));
            this.bnMeterMoveNext.Name = "bnMeterMoveNext";
            this.bnMeterMoveNext.RightToLeftAutoMirrorImage = true;
            this.bnMeterMoveNext.Size = new System.Drawing.Size(23, 24);
            this.bnMeterMoveNext.Text = "Move next";
            // 
            // bnMeterMoveLast
            // 
            this.bnMeterMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMeterMoveLast.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMeterMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("bnMeterMoveLast.Image")));
            this.bnMeterMoveLast.Name = "bnMeterMoveLast";
            this.bnMeterMoveLast.RightToLeftAutoMirrorImage = true;
            this.bnMeterMoveLast.Size = new System.Drawing.Size(23, 24);
            this.bnMeterMoveLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // txtMeterMultiplier
            // 
            this.txtMeterMultiplier.Location = new System.Drawing.Point(132, 124);
            this.txtMeterMultiplier.Name = "txtMeterMultiplier";
            this.txtMeterMultiplier.Size = new System.Drawing.Size(266, 24);
            this.txtMeterMultiplier.TabIndex = 2;
            // 
            // lblMeterMultiplier
            // 
            this.lblMeterMultiplier.AutoSize = true;
            this.lblMeterMultiplier.Location = new System.Drawing.Point(37, 127);
            this.lblMeterMultiplier.Name = "lblMeterMultiplier";
            this.lblMeterMultiplier.Size = new System.Drawing.Size(70, 18);
            this.lblMeterMultiplier.TabIndex = 10;
            this.lblMeterMultiplier.Text = "Multiplier:";
            // 
            // lblMeterType
            // 
            this.lblMeterType.AutoSize = true;
            this.lblMeterType.Location = new System.Drawing.Point(37, 65);
            this.lblMeterType.Name = "lblMeterType";
            this.lblMeterType.Size = new System.Drawing.Size(44, 18);
            this.lblMeterType.TabIndex = 9;
            this.lblMeterType.Text = "Type:";
            // 
            // lblMeterNumber
            // 
            this.lblMeterNumber.AutoSize = true;
            this.lblMeterNumber.Location = new System.Drawing.Point(37, 96);
            this.lblMeterNumber.Name = "lblMeterNumber";
            this.lblMeterNumber.Size = new System.Drawing.Size(65, 18);
            this.lblMeterNumber.TabIndex = 7;
            this.lblMeterNumber.Text = "Number:";
            // 
            // txtMeterNumber
            // 
            this.txtMeterNumber.Location = new System.Drawing.Point(132, 93);
            this.txtMeterNumber.Name = "txtMeterNumber";
            this.txtMeterNumber.Size = new System.Drawing.Size(266, 24);
            this.txtMeterNumber.TabIndex = 1;
            // 
            // btnSaveNewAccount
            // 
            this.btnSaveNewAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewAccount.Location = new System.Drawing.Point(535, 118);
            this.btnSaveNewAccount.Name = "btnSaveNewAccount";
            this.btnSaveNewAccount.Size = new System.Drawing.Size(121, 51);
            this.btnSaveNewAccount.TabIndex = 0;
            this.btnSaveNewAccount.Text = "Save/New";
            this.btnSaveNewAccount.UseVisualStyleBackColor = true;
            this.btnSaveNewAccount.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // txtSortKey
            // 
            this.txtSortKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortKey.Location = new System.Drawing.Point(86, 22);
            this.txtSortKey.Name = "txtSortKey";
            this.txtSortKey.Size = new System.Drawing.Size(61, 24);
            this.txtSortKey.TabIndex = 18;
            this.txtSortKey.TabStop = false;
            // 
            // lblSortKey
            // 
            this.lblSortKey.AutoSize = true;
            this.lblSortKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortKey.Location = new System.Drawing.Point(10, 25);
            this.lblSortKey.Name = "lblSortKey";
            this.lblSortKey.Size = new System.Drawing.Size(69, 18);
            this.lblSortKey.TabIndex = 19;
            this.lblSortKey.Text = "Sort Key:";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(401, 61);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(121, 51);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.Location = new System.Drawing.Point(535, 61);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(121, 51);
            this.btnNewAccount.TabIndex = 2;
            this.btnNewAccount.Text = "New";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAccountNotSaved
            // 
            this.btnAccountNotSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountNotSaved.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAccountNotSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountNotSaved.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountNotSaved.Location = new System.Drawing.Point(401, 16);
            this.btnAccountNotSaved.Name = "btnAccountNotSaved";
            this.btnAccountNotSaved.Size = new System.Drawing.Size(255, 39);
            this.btnAccountNotSaved.TabIndex = 17;
            this.btnAccountNotSaved.TabStop = false;
            this.btnAccountNotSaved.Text = "Account Not Saved";
            this.btnAccountNotSaved.UseVisualStyleBackColor = false;
            this.btnAccountNotSaved.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(13, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 51);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAccount.Location = new System.Drawing.Point(401, 118);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(121, 51);
            this.btnSaveAccount.TabIndex = 1;
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frameAccountButtons
            // 
            this.frameAccountButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameAccountButtons.Controls.Add(this.ckAccountSelected);
            this.frameAccountButtons.Controls.Add(this.btnSaveNewAccount);
            this.frameAccountButtons.Controls.Add(this.btnCancel);
            this.frameAccountButtons.Controls.Add(this.txtSortKey);
            this.frameAccountButtons.Controls.Add(this.btnSaveAccount);
            this.frameAccountButtons.Controls.Add(this.lblSortKey);
            this.frameAccountButtons.Controls.Add(this.btnAccountNotSaved);
            this.frameAccountButtons.Controls.Add(this.btnDeleteAccount);
            this.frameAccountButtons.Controls.Add(this.btnNewAccount);
            this.frameAccountButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameAccountButtons.Location = new System.Drawing.Point(15, 458);
            this.frameAccountButtons.Name = "frameAccountButtons";
            this.frameAccountButtons.Size = new System.Drawing.Size(673, 185);
            this.frameAccountButtons.TabIndex = 13;
            this.frameAccountButtons.TabStop = false;
            this.frameAccountButtons.Text = "Account";
            // 
            // ckAccountSelected
            // 
            this.ckAccountSelected.AutoSize = true;
            this.ckAccountSelected.Location = new System.Drawing.Point(13, 61);
            this.ckAccountSelected.Name = "ckAccountSelected";
            this.ckAccountSelected.Size = new System.Drawing.Size(142, 22);
            this.ckAccountSelected.TabIndex = 20;
            this.ckAccountSelected.Text = "Account Selected";
            this.ckAccountSelected.UseVisualStyleBackColor = true;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 653);
            this.Controls.Add(this.frameAccountButtons);
            this.Controls.Add(this.frameMeter);
            this.Controls.Add(this.frameLocation);
            this.Controls.Add(this.frameAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccounts_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).EndInit();
            this.accountBindingNavigator.ResumeLayout(false);
            this.accountBindingNavigator.PerformLayout();
            this.frameAccount.ResumeLayout(false);
            this.frameAccount.PerformLayout();
            this.frameLocation.ResumeLayout(false);
            this.frameLocation.PerformLayout();
            this.frameMeter.ResumeLayout(false);
            this.frameMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meterBindingNavigator)).EndInit();
            this.meterBindingNavigator.ResumeLayout(false);
            this.meterBindingNavigator.PerformLayout();
            this.frameAccountButtons.ResumeLayout(false);
            this.frameAccountButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator accountBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bnAccountCount;
        private System.Windows.Forms.ToolStripButton bnAccountMoveFirst;
        private System.Windows.Forms.ToolStripButton bnAccountMovePrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnAccountPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnAccountMoveNext;
        private System.Windows.Forms.ToolStripButton bnAccountMoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox frameAccount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox frameLocation;
        private System.Windows.Forms.GroupBox frameMeter;
        private System.Windows.Forms.ComboBox cbUtility;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtSate;
        private System.Windows.Forms.Label lblCityStateZip;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtMeterMultiplier;
        private System.Windows.Forms.Label lblMeterMultiplier;
        private System.Windows.Forms.Label lblMeterType;
        private System.Windows.Forms.Label lblMeterNumber;
        private System.Windows.Forms.TextBox txtMeterNumber;
        private System.Windows.Forms.Button btnSaveNewAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.Button btnAccountNotSaved;
        private System.Windows.Forms.TextBox txtSortKey;
        private System.Windows.Forms.Label lblSortKey;
        private System.Windows.Forms.Button btnNewSaveMeter;
        private System.Windows.Forms.Button btnDeleteMeter;
        private System.Windows.Forms.Button btnNewMeter;
        private System.Windows.Forms.Button btnSaveMeter;
        private System.Windows.Forms.BindingNavigator meterBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bnMeterCount;
        private System.Windows.Forms.ToolStripButton bnMeterMoveFirst;
        private System.Windows.Forms.ToolStripButton bnMeterMovePrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bnMeterPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bnMeterMoveNext;
        private System.Windows.Forms.ToolStripButton bnMeterMoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.GroupBox frameAccountButtons;
        private System.Windows.Forms.ComboBox cbMeterType;
        private System.Windows.Forms.ComboBox cbMeterRateScheduleNumber;
        private System.Windows.Forms.Label lblRateScheduleNumber;
        private System.Windows.Forms.Button btnMeterNotSaved;
        private System.Windows.Forms.CheckBox ckAccountSelected;
    }
}