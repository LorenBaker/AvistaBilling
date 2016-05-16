using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvistaBilling
{
    public partial class frmInvoices : Form
    {
        // dataGridView column numbers

        //private Invoice currentInvoice;
        private BindingSource invoicesBindingSource;
        private BindingSource meterReadingsBindingSource;
        private Account currentAccount;
        //private RateSchedule currentRateSchedule;

        //private Account mCurrentAccount;

        public frmInvoices()
        {
            InitializeComponent();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            setupAccountsComboBox();

            invoicesBindingSource = new BindingSource();
            invoicesBindingSource.DataSource = frmMain.AppData.Invoices.Items;
            invoiceBindingNavigatior.BindingSource = invoicesBindingSource;

            dgvMeterReadings.CellFormatting +=
           new System.Windows.Forms.DataGridViewCellFormattingEventHandler(
           this.dgvMeterReadings_CellFormatting);

            txtInvoice.SelectionTabs = new int[] { 100, 200, 300, 400, 500, 600, 700 };

            refreshInvoiceForm();
        }

        private void setupAccountsComboBox()
        {
            cbAccount.DataSource = frmMain.AppData.Accounts.Items;
            cbAccount.SelectedIndex = 0;
        }

        private void newInvoice()
        {
            try
            {
                currentAccount = (Account)cbAccount.SelectedItem;
                Invoice currentInvoice = (Invoice)invoicesBindingSource.AddNew();
                foreach (Meter meter in currentAccount.Meters)
                {
                    MeterReadingItem item = new MeterReadingItem();
                    item.ServiceType = meter.MeterType;
                    item.MeterNumber = meter.MeterNumber;
                    item.RateScheduleNumber = meter.RateScheduleNumber;
                    item.MeterMultiplier = meter.MeterMultiplier;
                    currentInvoice.MeterReadingItems.Add(item);
                }
                populateDataGridView(currentInvoice);

                // get the previous meter readings
                Invoice previousInvoice = findPreviousInvoice(currentAccount);
                if (previousInvoice != null)
                {
                    calInvoiceDate.SetDate(previousInvoice.BillingDate);
                    calReadDate.SetDate(previousInvoice.ReadDate);
                    currentInvoice.PreviousReadDate = previousInvoice.ReadDate;
                    foreach (DataGridViewRow row in dgvMeterReadings.Rows)
                    {
                        string serviceType = row.Cells[MeterReadingItem.SERVICE_TYPE].ToString();
                        MeterReadingItem previousItem = currentInvoice.MeterReadingItems.First(o => o.ServiceType.Equals(serviceType));
                        if (previousItem != null)
                        {
                            row.Cells[MeterReadingItem.PREVIOUS_READING].Value = previousItem.CurrentReading;
                        }
                    }

                    ckTotalChargesMatch.Checked = false;
                    ckWrongRateSchedule.Checked = false;
                }
                else
                {
                    // there is no previous invoice
                    calInvoiceDate.SetDate(DateTime.Now);
                    calReadDate.SetDate(DateTime.Now);

                    foreach (DataGridViewRow row in dgvMeterReadings.Rows)
                    {
                        row.Cells[MeterReadingItem.PREVIOUS_READING].Value = 0;
                    }

                    ckTotalChargesMatch.Checked = false;
                    ckWrongRateSchedule.Checked = false;

                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
            }
        }

        private void populateDataGridView(Invoice currentInvoice)
        {
            if (currentInvoice != null)
            {
                meterReadingsBindingSource = new BindingSource();
                meterReadingsBindingSource.DataSource = currentInvoice.MeterReadingItems;
                dgvMeterReadings.DataSource = meterReadingsBindingSource;
                setDgvMeterReadingsHeaders();
                setColumnWidth(MeterReadingItem.SERVICE_TYPE, 25);
                leftJustifyColumn(MeterReadingItem.SERVICE_TYPE);
                setColumnWidth(MeterReadingItem.METER_NUMBER, 25);
                leftJustifyColumn(MeterReadingItem.METER_NUMBER);
                setColumnWidth(MeterReadingItem.RATE_SCHEDULE, 35);
                hideColumn(MeterReadingItem.RATE_SCHEDULE_UUID);
            }
        }

        private void hideColumn(int columnNumber)
        {
            dgvMeterReadings.Columns[columnNumber].Visible = false;
        }

        private void leftJustifyColumn(int columnNumber)
        {
            this.dgvMeterReadings.Columns[columnNumber].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvMeterReadings.Columns[columnNumber].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void setColumnWidth(int columnNumber, int padding)
        {
            DataGridViewColumn column = dgvMeterReadings.Columns[columnNumber];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            int colWidth = column.Width;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colWidth += padding;

            dgvMeterReadings.Columns[columnNumber].Width = colWidth;

        }

        private Invoice findPreviousInvoice(Account currentAccount)
        {
            Invoice foundInvoice = null;
            // returns a sorted list of Invoices with the most recent first
            List<Invoice> allAccountInvoices = findAllInvoices(currentAccount);
            if (allAccountInvoices.Count > 0)
            {
                foundInvoice = allAccountInvoices[0];
            }

            return foundInvoice;
        }

        private List<Invoice> findAllInvoices(Account currentAccount)
        {
            List<Invoice> sortedAccountInvoices = new List<Invoice>();
            Guid soughtAccountUuid = currentAccount.Uuid;
            try
            {
                List<Invoice> allAccountInvoices = (frmMain.AppData.Invoices.Items.Where((Invoice x) => x.AccountUuid == soughtAccountUuid)).ToList();
                sortedAccountInvoices = allAccountInvoices.OrderByDescending(o => o.BillingDate).ToList();
            }
            catch (Exception ex)
            {
                // No invoice found
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
            }

            return sortedAccountInvoices;
        }

        private void setDgvMeterReadingsHeaders()
        {
            dgvMeterReadings.Columns[MeterReadingItem.SERVICE_TYPE].HeaderText = "Service Type";
            dgvMeterReadings.Columns[MeterReadingItem.METER_NUMBER].HeaderText = "Meter";
            dgvMeterReadings.Columns[MeterReadingItem.RATE_SCHEDULE].HeaderText = "Rate Sch";
            dgvMeterReadings.Columns[MeterReadingItem.PREVIOUS_READING].HeaderText = "Previous";
            dgvMeterReadings.Columns[MeterReadingItem.CURRENT_READING].HeaderText = "Current";
            dgvMeterReadings.Columns[MeterReadingItem.MULTIPLIER].HeaderText = "Multiplier";
            dgvMeterReadings.Columns[MeterReadingItem.USAGE].HeaderText = "Usage";
            dgvMeterReadings.Columns[MeterReadingItem.CITY_TAX].HeaderText = "Tax";
            dgvMeterReadings.Columns[MeterReadingItem.AMOUNT].HeaderText = "Amount";
            dgvMeterReadings.Columns[MeterReadingItem.RATE_SCHEDULE_UUID].HeaderText = "Rate Sch Uuid";
        }

        private void saveInvoice()
        {
            Invoice currentInvoice = (Invoice)invoicesBindingSource.Current;
            if (currentInvoice == null)
            {
                string title = "Unable to Save Invoice";
                string msg = "The current invoice is null!";
                MessageBox.Show(msg, title);
                return;
            }

            currentInvoice.BillingDate = calInvoiceDate.SelectionRange.Start;
            currentInvoice.ReadDate = calReadDate.SelectionRange.Start;
            currentInvoice.SetDaysInServiceMonth();
            if (currentAccount != null)
            {
                currentInvoice.AccountUuid = currentAccount.Uuid;
            }

            //TODO: Verify that the MeterReadingItems are being saved when data is entered into their respective cells.

            currentInvoice.TotalChargesMatch = ckTotalChargesMatch.Checked;
            currentInvoice.WrongRateSchedule = ckWrongRateSchedule.Checked;

        }

        #region Invoice Calculations
        private void calcuateInvoice()
        {
            StringBuilder sb = calculateMeterAmounts();
            calculateTotals();
            Invoice currentInvoice = (Invoice)invoicesBindingSource.Current;
            string grandTotal = "Grand Total this Account = " + currentInvoice.TotalAmount.ToString("C2", CultureInfo.CurrentCulture) + "\n\n";
            sb.Insert(0, grandTotal);
            txtInvoice.Text = sb.ToString();
        }

        private StringBuilder calculateMeterAmounts()
        {
            StringBuilder sb = new StringBuilder();
            List<ChargeDetail> chargeDetails = new List<ChargeDetail>();
            foreach (DataGridViewRow row in dgvMeterReadings.Rows)
            {
                string meterNumber = "";
                if (row.Cells[MeterReadingItem.METER_NUMBER].Value != null)
                    meterNumber = row.Cells[MeterReadingItem.METER_NUMBER].Value.ToString();

                double currentReading = -1;
                if (row.Cells[MeterReadingItem.CURRENT_READING].Value != null)
                    double.TryParse(row.Cells[MeterReadingItem.CURRENT_READING].Value.ToString(), out currentReading);

                double previousReading = -1;
                if (row.Cells[MeterReadingItem.PREVIOUS_READING].Value != null)
                    double.TryParse(row.Cells[MeterReadingItem.PREVIOUS_READING].Value.ToString(), out previousReading);

                double meterMultiplier = -1;
                if (row.Cells[MeterReadingItem.MULTIPLIER].Value != null)
                    double.TryParse(row.Cells[MeterReadingItem.MULTIPLIER].Value.ToString(), out meterMultiplier);

                int rateScheduleNumber = -1;
                if (row.Cells[MeterReadingItem.RATE_SCHEDULE].Value != null)
                    int.TryParse(row.Cells[MeterReadingItem.RATE_SCHEDULE].Value.ToString(), out rateScheduleNumber);

                string serviceType = "";
                if (row.Cells[MeterReadingItem.SERVICE_TYPE].Value != null)
                    serviceType = row.Cells[MeterReadingItem.SERVICE_TYPE].Value.ToString();

                if (currentReading > -1 && previousReading > -1 && meterMultiplier > -1 && rateScheduleNumber > -1 && !serviceType.Equals(""))
                {
                    double usage = -1;
                    if (serviceType.Equals(Meter.NAT_GAS) || serviceType.Equals(Meter.ELECTRIC))
                    {
                        usage = currentReading - previousReading;
                        if (usage > 0)
                        {
                            usage = Math.Round(usage * meterMultiplier, 0);
                            row.Cells[MeterReadingItem.USAGE].Value = usage;
                        }
                        else
                        {
                            string title = "Unable to Calculate Usage";
                            string msg = "Meter " + meterNumber + "'s previous reading is greater than its current reading!";
                            MessageBox.Show(msg, title);
                            continue;
                        }
                    }
                    else
                    {
                        // Demand meter
                        if (currentReading > 0)
                        {
                            usage = Math.Round(currentReading * meterMultiplier, 0);
                            row.Cells[MeterReadingItem.USAGE].Value = usage;
                        }
                        else
                        {
                            string title = "Unable to Calculate Usage";
                            string msg = "Demand Meter " + meterNumber + "'s current reading not greater than zero.";
                            MessageBox.Show(msg, title);
                            continue;
                        }
                    }

                    DateTime invoiceDate = calInvoiceDate.SelectionRange.Start;
                    if (invoiceDate < new DateTime(2000, 1, 1))
                    {
                        string title = "Unable to Calculate Charges";
                        string msg = "Invoice date " + invoiceDate.ToShortDateString() + " is not valid!";
                        MessageBox.Show(msg, title);

                    }
                    RateSchedule rateSchedule = findRateSchedule(rateScheduleNumber, calInvoiceDate.SelectionRange.Start);
                    if (rateSchedule != null)
                    {
                        row.Cells[MeterReadingItem.RATE_SCHEDULE_UUID].Value = rateSchedule.Uuid;
                        ChargeSummary chargeSummary = calculateCharges(meterNumber, serviceType, rateSchedule, usage, sb);
                        row.Cells[MeterReadingItem.CITY_TAX].Value = chargeSummary.CityTax;
                        row.Cells[MeterReadingItem.AMOUNT].Value = chargeSummary.TotalAmount;
                    }
                    else
                    {
                        string title = "Unable to Calculate Charges";
                        string msg = "Unable to find the rate schedule number " + rateScheduleNumber + " associated with meter " + meterNumber + ".";
                        MessageBox.Show(msg, title);
                        continue;
                    }
                }
            }

            return sb;
        }

        private RateSchedule findRateSchedule(int scheduleNumber, DateTime invoiceDate)
        {
            RateSchedule rateSchedule = null;
            try
            {
                List<RateSchedule> rateSchedules = (frmMain.AppData.RateSchedules.Items.Where((RateSchedule x) => x.ScheduleNumber == scheduleNumber)).ToList();
                List<RateSchedule> sortedRateSchedules = rateSchedules.OrderByDescending(o => o.EffectiveDate).ToList();
                rateSchedule = sortedRateSchedules.Find((RateSchedule x) => invoiceDate > x.EffectiveDate);
            }
            catch (Exception ex)
            {
                // No rate schedule found
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);

            }

            return rateSchedule;
        }

        private ChargeSummary calculateCharges(string meterNumber, string serviceType, RateSchedule rateSchedule, double usage, StringBuilder sb)
        {
            const string strLongLine = "___________________________________________________________________________________________________________";
            //const string strShortLine = "___________";

            ChargeSummary summary = new ChargeSummary();

            List<double> rateBlockUseageList;
            if (serviceType.Equals(Meter.DEMAND))
            {
                rateBlockUseageList = getRateBlockUseage(rateSchedule.DemandRateBlocks, usage);

            }
            else
            {
                rateBlockUseageList = getRateBlockUseage(rateSchedule.RateBlocks, usage);
            }
            int rateBlockIndex = 0;
            List<ChargeDetail> chargeDetails = new List<ChargeDetail>();
            bool skipBasicCharge = false;
            double totalAmount = rateSchedule.BasicCharge;
            string units = "";
            if (serviceType.Equals(Meter.NAT_GAS))
                units = " Therms";
            if (serviceType.Equals(Meter.ELECTRIC))
            {
                units = " kWh";
                if (rateSchedule.hasDemandRates)
                {
                    totalAmount = 0;
                    skipBasicCharge = true;
                }
            }
            if (serviceType.Equals(Meter.DEMAND))
                units = " kW";

            foreach (double quantity in rateBlockUseageList)
            {
                ChargeDetail detail = new ChargeDetail();
                detail.Quantity = Math.Round(quantity, 0);

                RateBlock rateBlock = rateSchedule.RateBlocks[rateBlockIndex];
                if (serviceType.Equals(Meter.DEMAND))
                {
                    rateBlock = rateSchedule.DemandRateBlocks[rateBlockIndex];
                }
                double amount = Math.Round(rateBlock.Rate * quantity, 2);
                detail.Amount = amount;
                totalAmount += amount;

                detail.Description = "Usage " + rateBlock.RateBlockType + " " + rateBlock.RateBlockQuantity + units;
                detail.Units = units;
                detail.Rate = rateBlock.Rate;

                chargeDetails.Add(detail);
                rateBlockIndex++;
            }

            double cityTaxRate = rateSchedule.CityTaxRate;
            if (serviceType.Equals(Meter.ELECTRIC) || serviceType.Equals(Meter.DEMAND))
            {
                cityTaxRate = cityTaxRate - 0.0002;
            }
            double cityTax = Math.Round(totalAmount * cityTaxRate, 2);
            totalAmount += cityTax;
            summary.CityTax = cityTax;
            summary.TotalAmount = totalAmount;

            bool isElectricServie = false;
            sb.AppendLine(strLongLine).AppendLine();
            string meterDescription = "";
            if (serviceType.Equals(Meter.NAT_GAS))
                meterDescription = "Natural Gas Meter Number: " + meterNumber;
            if (serviceType.Equals(Meter.ELECTRIC))
            {
                meterDescription = "Electric Meter Number: " + meterNumber;
                isElectricServie = true;
            }
            if (serviceType.Equals(Meter.DEMAND))
                meterDescription = "Demand Meter Number: " + meterNumber;
            sb.AppendLine(meterDescription);
            foreach (ChargeDetail detail in chargeDetails)
            {
                sb.Append(detail.Description).Append("\t");
                sb.Append(detail.Quantity.ToString("N0", CultureInfo.InvariantCulture)).Append("\t");
                sb.Append(detail.Units).Append("  X  ").Append("\t");
                sb.Append(detail.Rate.ToString("F5", CultureInfo.InvariantCulture)).Append("\t");
                sb.Append(detail.Amount.ToString("C2", CultureInfo.CurrentCulture));
                sb.AppendLine();
            }
            if (!isElectricServie || !skipBasicCharge)
            {
                sb.Append("Basic Rate").Append("\t").Append("\t").Append("\t").Append("\t").Append("\t").Append(rateSchedule.BasicCharge.ToString("C2", CultureInfo.CurrentCulture)).AppendLine();
            }
            sb.Append("City Tax (").Append(cityTaxRate.ToString("P2", CultureInfo.InvariantCulture)).Append(")").Append("\t").Append("\t").Append("\t").Append("\t").Append(cityTax.ToString("C2", CultureInfo.CurrentCulture)).AppendLine();
            sb.Append("\t").Append("\t").Append("\t").Append("\t").Append("\t").Append("Current Charges:").Append("\t").Append(totalAmount.ToString("C2", CultureInfo.CurrentCulture));
            sb.AppendLine().AppendLine();

            return summary;
        }

        private List<double> getRateBlockUseage(IList<RateBlock> rateBlocks, double usage)
        {
            List<double> rateBlockUseageList = new List<double>();
            Int32 currentRateBlockNumber = 0;
            double usageRemainder = 0;

            foreach (RateBlock rateblock in rateBlocks)
            {
                currentRateBlockNumber++;
                if (currentRateBlockNumber == rateBlocks.Count)
                {
                    // This is the last rate block                    
                    rateBlockUseageList.Add(usage);
                }
                else
                {
                    usageRemainder = usage - rateblock.RateBlockQuantity;
                    if (usageRemainder > 0)
                    {
                        rateBlockUseageList.Add(rateblock.RateBlockQuantity);
                        usage = usageRemainder;
                    }
                    else
                    {
                        rateBlockUseageList.Add(usage);
                        // we're done
                        break;
                    }
                }
            }
            return rateBlockUseageList;
        }

        private void calculateTotals()
        {
            Invoice currentInvoice = (Invoice)invoicesBindingSource.Current;

            //double totalAmount = 0;
            double totalAmount = 0;
            double totalCityTax = 0;
            double totalTherms = 0;
            double totalEnergy = 0;
            double totalDemand = 0;

            if (currentInvoice == null)
            {
                return;
            }
            foreach (DataGridViewRow row in dgvMeterReadings.Rows)
            {

                double usuageAmount = 0;
                if (row.Cells[MeterReadingItem.USAGE].Value != null)
                    double.TryParse(row.Cells[MeterReadingItem.AMOUNT].Value.ToString(), out usuageAmount);
                totalAmount += usuageAmount;

                double cityTax = 0;
                if (row.Cells[MeterReadingItem.USAGE].Value != null)
                    double.TryParse(row.Cells[MeterReadingItem.CITY_TAX].Value.ToString(), out cityTax);
                totalCityTax += cityTax;

                double usage = 0;
                if (row.Cells[MeterReadingItem.USAGE].Value != null)
                    double.TryParse(row.Cells[MeterReadingItem.USAGE].Value.ToString(), out usage);

                if (row.Cells[MeterReadingItem.SERVICE_TYPE].Value.Equals(Meter.NAT_GAS))
                {
                    totalTherms += usage;
                }
                if (row.Cells[MeterReadingItem.SERVICE_TYPE].Value.Equals(Meter.ELECTRIC))
                {
                    totalEnergy += usage;
                }
                if (row.Cells[MeterReadingItem.SERVICE_TYPE].Value.Equals(Meter.DEMAND))
                {
                    totalDemand += usage;
                }
            }
            currentInvoice.TotalKWH_Energy = totalEnergy;
            currentInvoice.TotalKW_Demand = totalDemand;
            currentInvoice.TotalTherms_NatGas = totalTherms;
            currentInvoice.TotalUsageCharges = totalAmount-totalCityTax;
            currentInvoice.TotalCityTax = totalCityTax;
            currentInvoice.TotalAmount = totalAmount;

        }

        #endregion

        private void deleteInvoice()
        {
            throw new NotImplementedException();
        }

        private void refreshInvoiceForm()
        {
            disableInvioceChangeEventHandlers();

            Invoice currentInvoice = (Invoice)invoicesBindingSource.Current;
            if (currentInvoice == null)
            {
                string title = "Unable to Refresh Invoice Form";
                string msg = "The current invoice is null!";
                MessageBox.Show(msg, title);
            }
            populateDataGridView(currentInvoice);

            //List<Account> accountList = (List<Account>)cbAccount.DataSource;
            //Account selectedAccount = accountList.Find((Account x) => x.Uuid.Equals(currentInvoice.AccountUuid));
            //cbAccount.SelectedItem = selectedAccount;

            calReadDate.SetDate(currentInvoice.ReadDate);
            calInvoiceDate.SetDate(currentInvoice.BillingDate);

            ckTotalChargesMatch.Checked = currentInvoice.TotalChargesMatch;
            ckWrongRateSchedule.Checked = currentInvoice.WrongRateSchedule;

            calcuateInvoice();

            enableInvoiceChangeEventHandlers();
        }


        #region Event Handlers
        private void enableInvoiceChangeEventHandlers()
        {
            this.cbAccount.SelectedIndexChanged += new System.EventHandler(this.cbAccount_SelectedIndexChanged);
            this.btnCalculateInvoice.Click += new System.EventHandler(this.btnCalculateInvoice_Click);
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click_1);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);

            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.refreshFormEvent);

            this.calReadDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calReadDate_DateChanged);
            this.calInvoiceDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calInvoiceDate_DateChanged);

            this.ckTotalChargesMatch.CheckedChanged += new System.EventHandler(this.ckTotalChargesMatch_CheckedChanged);
            this.ckWrongRateSchedule.CheckedChanged += new System.EventHandler(this.ckWrongRateSchedule_CheckedChanged);
        }

        private void disableInvioceChangeEventHandlers()
        {
            this.cbAccount.SelectedIndexChanged -= new System.EventHandler(this.cbAccount_SelectedIndexChanged);
            this.btnCalculateInvoice.Click -= new System.EventHandler(this.btnCalculateInvoice_Click);
            this.btnSaveNew.Click -= new System.EventHandler(this.btnSaveNew_Click_1);
            this.btnDelete.Click -= new System.EventHandler(this.btnDelete_Click_1);
            this.btnNew.Click -= new System.EventHandler(this.btnNew_Click_1);
            this.btnCancel.Click -= new System.EventHandler(this.btnCancel_Click_1);
            this.btnSave.Click -= new System.EventHandler(this.btnSave_Click_1);

            this.bindingNavigatorMoveFirstItem.Click -= new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMovePreviousItem.Click -= new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveNextItem.Click -= new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveLastItem.Click -= new System.EventHandler(this.refreshFormEvent);

            this.calReadDate.DateChanged -= new System.Windows.Forms.DateRangeEventHandler(this.calReadDate_DateChanged);
            this.calInvoiceDate.DateChanged -= new System.Windows.Forms.DateRangeEventHandler(this.calInvoiceDate_DateChanged);

            this.ckTotalChargesMatch.CheckedChanged -= new System.EventHandler(this.ckTotalChargesMatch_CheckedChanged);
            this.ckWrongRateSchedule.CheckedChanged -= new System.EventHandler(this.ckWrongRateSchedule_CheckedChanged);

        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshInvoiceForm();
            txtInvoice.Text = "";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            deleteInvoice();
        }


        private void btnNew_Click_1(object sender, EventArgs e)
        {
            newInvoice();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            saveInvoice();
        }



        private void btnSaveNew_Click_1(object sender, EventArgs e)
        {
            saveInvoice();
            newInvoice();
        }

        private void btnCalculateInvoice_Click(object sender, EventArgs e)
        {
            calcuateInvoice();
        }

        private void refreshFormEvent(object sender, EventArgs e)
        {
            refreshInvoiceForm();
        }

        private void calReadDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Do nothing
        }

        private void calInvoiceDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Do nothing
        }

        private void ckWrongRateSchedule_CheckedChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void ckTotalChargesMatch_CheckedChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        // Changes how cells are displayed depending on their columns and values.
        private void dgvMeterReadings_CellFormatting(object sender,
            System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            //const int SERVICE_TYPE = 0;
            //const int METER_NUMBER = 1;
            const int RATE_SCHEDULE = 2;
            const int PREVIOUS_READING = 3;
            const int CURRENT_READING = 4;
            const int MULTIPLIER = 5;
            const int USAGE = 6;
            const int CITY_TAX = 7;
            const int AMOUNT = 8;
            //const int RATE_SCHEDULE_UUID = 9;

            // Ensure that the value is a double

            double dgvCellValue = -1;
            double.TryParse(e.Value.ToString(), out dgvCellValue);
            if (dgvCellValue == -1)
            {
                // Failed to find a double
                return;
            }

            switch (e.ColumnIndex)
            {
                case RATE_SCHEDULE:
                case PREVIOUS_READING:
                case CURRENT_READING:
                    if (dgvCellValue < 1000)
                    {
                        // Do nothing
                    }
                    else
                    {
                        e.Value = dgvCellValue.ToString("N0", CultureInfo.InvariantCulture);
                    }
                    break;

                case USAGE:
                    e.Value = dgvCellValue.ToString("N0", CultureInfo.InvariantCulture);
                    break;

                case MULTIPLIER:
                    if (dgvCellValue < 10)
                    {
                        e.Value = dgvCellValue.ToString("F3", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        e.Value = dgvCellValue.ToString("F0", CultureInfo.InvariantCulture);
                    }

                    break;

                case CITY_TAX:
                case AMOUNT:
                    e.Value = dgvCellValue.ToString("C2", CultureInfo.CurrentCulture);
                    break;

            }

        }

        #endregion


    }
}
