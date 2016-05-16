using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvistaBilling
{
    public partial class frmRateSchedule : Form
    {

        private BindingSource rateSchedulesBindingSource;
        //private BindingSource rateBlocksBindingSource;
        //private BindingSource demandRateBlocksBindingSource;
        private BindingList<string> mBlockTypes;

        public frmRateSchedule()
        {
            InitializeComponent();
            Load += new EventHandler(frmRateSchedule_Load);
        }

        private void frmRateSchedule_Load(object sender, EventArgs e)
        {
            BindingList<string> serviceTypes = new BindingList<string>();
            serviceTypes.Add(Meter.NAT_GAS);
            serviceTypes.Add(Meter.ELECTRIC);
            //serviceTypes.Add(Meter.DEMAND);
            cbServiceType.DataSource = serviceTypes;
            cbServiceType.SelectedIndex = 0;

            BindingList<string> utilities = new BindingList<string>();
            utilities.Add(Account.AVISTA);
            utilities.Add(Account.INLAND);
            utilities.Add(Account.KTU);
            cbUtility.DataSource = utilities;

            //cbUtility.SelectedIndex = 0;


            mBlockTypes = new BindingList<string>();
            mBlockTypes.Add(RateBlock.BLOCK_TYPE_FIRST);
            mBlockTypes.Add(RateBlock.BLOCK_TYPE_NEXT);
            mBlockTypes.Add(RateBlock.BLOCK_TYPE_OVER);

            //DataGridViewComboBoxColumn colEnergyRateBlockType = (DataGridViewComboBoxColumn)gvEnergyRateBlocks.Columns[1];
            //colEnergyRateBlockType.DataSource = mBlockTypes;
            //colEnergyRateBlockType.ValueType = typeof(string);

            //DataGridViewComboBoxColumn colDemandRateBlockType = (DataGridViewComboBoxColumn)gvDemandRateBlocks.Columns[1];
            //colDemandRateBlockType.DataSource = mBlockTypes;
            //colDemandRateBlockType.ValueType = typeof(string);

            

            rateSchedulesBindingSource = new BindingSource();
            rateSchedulesBindingSource.DataSource = frmMain.AppData.RateSchedules.Items;
            rateSchedulesBindingNavigator.BindingSource = rateSchedulesBindingSource;
            RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            populateDgvRateBlocks(currentRateSchedule);
            populateDgvDemandRateBlocks(currentRateSchedule);

            txtBasicCharge.DataBindings.Add("Text", rateSchedulesBindingSource, "BasicCharge");
            txtCityTaxRate.DataBindings.Add("Text", rateSchedulesBindingSource, "CityTaxRate");
            txtMinCharge.DataBindings.Add("Text", rateSchedulesBindingSource, "MinimumCharge");
            txtRateSchedule.DataBindings.Add("Text", rateSchedulesBindingSource, "ScheduleNumber");
            txtUtility.DataBindings.Add("Text", rateSchedulesBindingSource, "Utility");
            txtServiceType.DataBindings.Add("Text", rateSchedulesBindingSource, "TypeOfService");
            ckBoxHasDemandRates.DataBindings.Add("Checked", rateSchedulesBindingSource, "hasDemandRates");

            refreshRateScheduleForm();
            

            enableRateScheduleChangeEventHandlers();

            //refreshForm();
        }

        private void populateDgvRateBlocks(RateSchedule currentRateSchedule)
        {
            if (currentRateSchedule == null) { return; }
            BindingSource  rateBlocksBindingSource = new BindingSource();
            rateBlocksBindingSource.DataSource = currentRateSchedule.RateBlocks;
            dgvRateBlocks.DataSource = rateBlocksBindingSource;

            if (dgvRateBlocks.Columns.Count < 5)
            {
                DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                col.DataSource = mBlockTypes;
                col.ValueType = typeof(string);
                col.HeaderText = "Type";
                dgvRateBlocks.Columns.Insert(1, col);
            }
            if (currentRateSchedule.RateBlocks.Count == 0)
            {
                rateBlocksBindingSource.AddNew();
            }

            setDgvRateBlocksHeaders();
        }

        private void setDgvRateBlocksHeaders()
        {
            //TODO: 
        }

        private void populateDgvDemandRateBlocks(RateSchedule currentRateSchedule)
        {
            if (currentRateSchedule == null) {               
                dgvDemandRateBlocks.DataSource = null;
                return;
            }

            BindingSource demandRateBlocksBindingSource; 
            if (currentRateSchedule.hasDemandRates)
            {
                demandRateBlocksBindingSource = new BindingSource();
                
                demandRateBlocksBindingSource.DataSource = currentRateSchedule.DemandRateBlocks;
                dgvDemandRateBlocks.DataSource = demandRateBlocksBindingSource;

                if (dgvRateBlocks.Columns.Count < 5)
                {
                    DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                    col.DataSource = mBlockTypes;
                    col.ValueType = typeof(string);
                    col.HeaderText = "Type";
                    dgvDemandRateBlocks.Columns.Insert(1, col);
                }

                if (currentRateSchedule.DemandRateBlocks.Count == 0)
                {
                    demandRateBlocksBindingSource.AddNew();
                }
            }
            else
            {
                dgvDemandRateBlocks.DataSource = null;
                currentRateSchedule.DemandRateBlocks = new List<RateBlock>();
            }

            setDgvDemandRateBlocksHeaders();
        }

        private void setDgvDemandRateBlocksHeaders()
        {
           //TODO: 
        }

        private void refreshRateScheduleForm()
        {
            disableRateScheduleChangeEventHandlers();


            RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            if (currentRateSchedule == null)
            {
                string title = "Unable to Refresh Rate Schedule Form";
                string msg = "The current rate schedule is null!";
                MessageBox.Show(msg, title);
            }

            ckBoxHasDemandRates.Checked = currentRateSchedule.hasDemandRates;
            showDemandRateBlocks(ckBoxHasDemandRates.Checked);

            calEffectiveDate.SetDate(currentRateSchedule.EffectiveDate);

            populateDgvRateBlocks(currentRateSchedule);
            populateDgvDemandRateBlocks(currentRateSchedule);

            //RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            //if (currentRateSchedule != null)
            //{
            //    txtBasicCharge.Text = currentRateSchedule.BasicCharge.ToString();
            //    txtCityTaxRate.Text = (currentRateSchedule.CityTaxRate * 100).ToString();
            //    txtRateSchedule.Text = currentRateSchedule.ScheduleNumber.ToString();

            //    calEffectiveDate.SetDate(currentRateSchedule.EffectiveDate);

            //    fillDataGrid(dgvRateBlocks, currentRateSchedule.RateBlocks);
            //    fillDataGrid(dgvDemandRateBlocks, currentRateSchedule.DemandRateBlocks);

            //    int selectedIndex = cbServiceType.FindStringExact(currentRateSchedule.TypeOfService);
            //    cbServiceType.SelectedIndex = selectedIndex;

            //    selectedIndex = cbUtility.FindStringExact(currentRateSchedule.Utility);
            //    cbUtility.SelectedIndex = selectedIndex;

            //    ckBoxHasDemandRates.Checked = currentRateSchedule.DemandRateBlocks.Count > 0;

            //}
            enableRateScheduleChangeEventHandlers();
        }

        private void fillDataGrid(DataGridView grid, IList<RateBlock> blocks)
        {
            grid.Rows.Clear();
            foreach (RateBlock block in blocks)
            {
                try
                {
                    int rowId = grid.Rows.Add();
                    DataGridViewRow newRow = grid.Rows[rowId];
                    newRow.Cells[0].Value = block.RateBlockNumber.ToString();
                    newRow.Cells[1].Value = block.RateBlockType;
                    newRow.Cells[2].Value = block.RateBlockQuantity.ToString();
                    newRow.Cells[3].Value = block.Rate.ToString();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                    System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
                }

            }
        }

        private void saveCurrentRateSchedule()
        {
            RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            try
            {
                Double basicCharge;
                if (txtBasicCharge.Text.Equals(""))
                {
                    basicCharge = 0;
                }
                else
                {
                    basicCharge = Convert.ToDouble(txtBasicCharge.Text);
                }

                Double cityTaxRate;
                if (txtCityTaxRate.Text.Equals(""))
                {
                    cityTaxRate = 0;
                }
                else
                {
                    cityTaxRate = Convert.ToDouble(txtCityTaxRate.Text) / 100;
                }


                currentRateSchedule.RateBlocks.Clear();
                foreach (DataGridViewRow row in dgvRateBlocks.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        RateBlock rateBlock = new RateBlock();
                        string rateBlockNumber = row.Cells[0].Value.ToString();
                        if (rateBlockNumber.Equals(""))
                        {
                            rateBlockNumber = "0";
                        }
                        rateBlock.RateBlockNumber = Convert.ToInt32(rateBlockNumber);

                        string rateBlockTypeStr;
                        if (row.Cells[1].Value == null)
                        {
                            rateBlockTypeStr = "N/A";
                        }
                        else
                        {
                            rateBlockTypeStr = Convert.ToString((row.Cells[1] as DataGridViewComboBoxCell).FormattedValue.ToString());
                            if (rateBlockTypeStr.Equals(""))
                            {
                                rateBlockTypeStr = "N/A";
                            }
                        }
                        rateBlock.RateBlockType = rateBlockTypeStr;

                        string rateBlockQuantityStr = row.Cells[2].Value.ToString();
                        if (rateBlockQuantityStr.Equals(""))
                        {
                            rateBlockQuantityStr = "0";
                        }
                        rateBlock.RateBlockQuantity = Convert.ToDouble(rateBlockQuantityStr);


                        string rateBlockRateStr = row.Cells[3].Value.ToString();
                        if (rateBlockRateStr.Equals(""))
                        {
                            rateBlockRateStr = "0";
                        }
                        rateBlock.Rate = Convert.ToDouble(rateBlockRateStr);

                        currentRateSchedule.RateBlocks.Add(rateBlock);
                    }
                }

                currentRateSchedule.DemandRateBlocks.Clear();
                if (ckBoxHasDemandRates.Checked)
                {
                    foreach (DataGridViewRow row in dgvDemandRateBlocks.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            RateBlock rateBlock = new RateBlock();
                            string rateBlockNumber = row.Cells[0].Value.ToString();
                            if (rateBlockNumber.Equals(""))
                            {
                                rateBlockNumber = "0";
                            }
                            rateBlock.RateBlockNumber = Convert.ToInt32(rateBlockNumber);

                            string rateBlockTypeStr;
                            if (row.Cells[1].Value == null)
                            {
                                rateBlockTypeStr = "N/A";
                            }
                            else
                            {
                                rateBlockTypeStr = Convert.ToString((row.Cells[1] as DataGridViewComboBoxCell).FormattedValue.ToString());
                                if (rateBlockTypeStr.Equals(""))
                                {
                                    rateBlockTypeStr = "N/A";
                                }
                            }
                            rateBlock.RateBlockType = rateBlockTypeStr;

                            string rateBlockQuantityStr = row.Cells[2].Value.ToString();
                            if (rateBlockQuantityStr.Equals(""))
                            {
                                rateBlockQuantityStr = "0";
                            }
                            rateBlock.RateBlockQuantity = Convert.ToDouble(rateBlockQuantityStr);


                            string rateBlockRateStr = row.Cells[3].Value.ToString();
                            if (rateBlockRateStr.Equals(""))
                            {
                                rateBlockRateStr = "0";
                            }
                            rateBlock.Rate = Convert.ToDouble(rateBlockRateStr);

                            currentRateSchedule.DemandRateBlocks.Add(rateBlock);
                        }
                    }
                }

                currentRateSchedule.ScheduleNumber = Int32.Parse(txtRateSchedule.Text);
                currentRateSchedule.TypeOfService = cbServiceType.SelectedItem.ToString();
                currentRateSchedule.Utility = cbUtility.SelectedItem.ToString();
                currentRateSchedule.EffectiveDate = calEffectiveDate.SelectionRange.Start;
                currentRateSchedule.BasicCharge = basicCharge;
                currentRateSchedule.CityTaxRate = cityTaxRate;

                btnScheduleNotSaved.Visible = false;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
            }
        }

        private void showDemandRateBlocks(bool hasDemandRate)
        {
            frameDemandRateBlocks.Visible = hasDemandRate;
        }

        private void clearRateBlocks()
        {
            dgvRateBlocks.Rows.Clear();
            dgvDemandRateBlocks.Rows.Clear();

        }

        private void deleteSchedule()
        {
            int currentPosition = rateSchedulesBindingSource.Position;
            int newPosition = currentPosition - 1;
            if (rateSchedulesBindingSource.Count > 0)
            {
                RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
                rateSchedulesBindingSource.Remove(currentRateSchedule);
                if (newPosition < 0)
                {
                    if (rateSchedulesBindingSource.Count > 0)
                    {
                        newPosition = 0;
                    }
                    else
                    {
                        // There are no recods in the bindingSource
                        clearForm();
                        return;
                    }
                }

                rateSchedulesBindingSource.Position = newPosition;
                refreshRateScheduleForm();
            }
            else
            {
                // There are no recods in the bindingSource
                clearForm();
            }
        }

        private void clearForm()
        {
            disableRateScheduleChangeEventHandlers();

            txtBasicCharge.Text = "";
            txtCityTaxRate.Text = "";
            txtRateSchedule.Text = "";
            calEffectiveDate.SetDate(DateTime.Now);
            clearRateBlocks();
            cbServiceType.SelectedIndex = 0;
            cbUtility.SelectedIndex = 0;
            ckBoxHasDemandRates.Checked = false;

            enableRateScheduleChangeEventHandlers();
        }

        private void addNewRateSchedule()
        {
            RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            Int32 previousSchedule = 0;
            double previousBasicCharge = 0;
            double previousCityTaxRate = 0;
            DateTime previousEffectiveDate = DateTime.Now;
            string previousUtility = Account.AVISTA;
            string previousTypeOfService = Meter.NAT_GAS;
            List<RateBlock> previousEnergyRateBlocks = new List<RateBlock>();
            List<RateBlock> previousDemandRateBlocks = new List<RateBlock>();

            if (currentRateSchedule != null)
            {
                previousSchedule = currentRateSchedule.ScheduleNumber;
                previousBasicCharge = currentRateSchedule.BasicCharge;
                previousCityTaxRate = currentRateSchedule.CityTaxRate;
                previousEffectiveDate = currentRateSchedule.EffectiveDate;
                previousUtility = currentRateSchedule.Utility;
                previousTypeOfService = currentRateSchedule.TypeOfService;

                foreach (RateBlock rateBlock in currentRateSchedule.RateBlocks)
                {
                    RateBlock previousRateBlock = new RateBlock();
                    previousRateBlock.Rate = rateBlock.Rate;
                    previousRateBlock.RateBlockNumber = rateBlock.RateBlockNumber;
                    previousRateBlock.RateBlockQuantity = rateBlock.RateBlockQuantity;
                    previousRateBlock.RateBlockType = rateBlock.RateBlockType;
                    previousEnergyRateBlocks.Add(previousRateBlock);
                }

                foreach (RateBlock rateBlock in currentRateSchedule.DemandRateBlocks)
                {
                    RateBlock previousRateBlock = new RateBlock();
                    previousRateBlock.Rate = rateBlock.Rate;
                    previousRateBlock.RateBlockNumber = rateBlock.RateBlockNumber;
                    previousRateBlock.RateBlockQuantity = rateBlock.RateBlockQuantity;
                    previousRateBlock.RateBlockType = rateBlock.RateBlockType;
                    previousDemandRateBlocks.Add(previousRateBlock);
                }


            }

            clearRateBlocks();

            RateSchedule newRateSchedule = (RateSchedule)rateSchedulesBindingSource.AddNew();
            newRateSchedule.ScheduleNumber = previousSchedule;
            newRateSchedule.BasicCharge = previousBasicCharge;
            newRateSchedule.CityTaxRate = previousCityTaxRate;
            newRateSchedule.EffectiveDate = previousEffectiveDate;
            newRateSchedule.Utility = previousUtility;
            newRateSchedule.TypeOfService = previousTypeOfService;
            newRateSchedule.RateBlocks = previousEnergyRateBlocks;
            newRateSchedule.DemandRateBlocks = previousDemandRateBlocks;

            btnScheduleNotSaved.Visible = true;
            refreshRateScheduleForm();
        }

        #region Event Handlers

        private void enableRateScheduleChangeEventHandlers()
        {
            this.cbUtility.SelectedIndexChanged += new System.EventHandler(this.cbUtility_SelectedIndexChanged);
            this.cbServiceType.SelectedIndexChanged += new System.EventHandler(this.cbServiceType_SelectedIndexChanged);
            this.ckBoxHasDemandRates.CheckedChanged += new System.EventHandler(this.ckBoxHasDemandRates_CheckedChanged);

            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.refreshFormEvent);

            this.rateSchedulesBindingSource.CurrentChanged += new System.EventHandler(this.rateSchedulesBindingSource_CurrentChanged);
            this.calEffectiveDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEffectiveDate_DateChanged);

        }

        private void disableRateScheduleChangeEventHandlers()
        {
            this.cbUtility.SelectedIndexChanged -= new System.EventHandler(this.cbUtility_SelectedIndexChanged);
            this.cbServiceType.SelectedIndexChanged -= new System.EventHandler(this.cbServiceType_SelectedIndexChanged);
            this.ckBoxHasDemandRates.CheckedChanged -= new System.EventHandler(this.ckBoxHasDemandRates_CheckedChanged);

            this.bindingNavigatorMoveFirstItem.Click -= new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMovePreviousItem.Click -= new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveLastItem.Click -= new System.EventHandler(this.refreshFormEvent);
            this.bindingNavigatorMoveNextItem.Click -= new System.EventHandler(this.refreshFormEvent);

            this.rateSchedulesBindingSource.CurrentChanged -= new System.EventHandler(this.rateSchedulesBindingSource_CurrentChanged);
            this.calEffectiveDate.DateChanged -= new System.Windows.Forms.DateRangeEventHandler(this.calEffectiveDate_DateChanged);

        }

        private void refreshFormEvent(object sender, EventArgs e)
        {
            refreshRateScheduleForm();
        }

        private void dgvRateBlocks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Error: " + e.Exception.Message);
        }

        private void dgvDemandRateBlocks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Error: " + e.Exception.Message);
        }

        private void ckBoxHasDemandRates_CheckedChanged(object sender, EventArgs e)
        {
            RateSchedule curentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            if (curentRateSchedule != null)
            {
                curentRateSchedule.hasDemandRates = ckBoxHasDemandRates.Checked;
                showDemandRateBlocks(ckBoxHasDemandRates.Checked);
                populateDgvDemandRateBlocks(curentRateSchedule);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //addNewRateSchedule();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //deleteSchedule();
        }

        private void btnResetRateBlocks_Click(object sender, EventArgs e)
        {
            //clearRateBlocks();
            //btnScheduleNotSaved.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saveCurrentRateSchedule();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //    saveCurrentRateSchedule();
            //    addNewRateSchedule();
        }

        private void scheduleFieldChanged(object sender, EventArgs e)
        {
            //btnScheduleNotSaved.Visible = true;
        }

        private void cbUtility_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUtility.Text = cbUtility.SelectedItem.ToString();
        }

        private void txtUtility_TextChanged(object sender, EventArgs e)
        {
            this.cbUtility.SelectedValueChanged -= new System.EventHandler(this.cbUtility_SelectedIndexChanged);
            cbUtility.SelectedItem = txtUtility.Text;
            this.cbUtility.SelectedValueChanged += new System.EventHandler(this.cbUtility_SelectedIndexChanged);

        }

        private void cbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServiceType.Text = cbServiceType.SelectedItem.ToString();
            showHasDemandCheckBoox(txtServiceType.Text.Equals(Meter.ELECTRIC));
        }

        private void showHasDemandCheckBoox(bool isVisible)
        {
            ckBoxHasDemandRates.Visible = isVisible;
            //if (isVisible)
            //{
            //    ckBoxHasDemandRates.Checked = false;
            //    ckBoxHasDemandRates.Visible = false;
            //}
            //else
            //{
            //    ckBoxHasDemandRates.Visible = true;
            //}
        }

        private void txtServiceType_TextChanged(object sender, EventArgs e)
        {
            this.cbServiceType.SelectedValueChanged -= new System.EventHandler(this.cbServiceType_SelectedIndexChanged);
            cbServiceType.SelectedItem = txtServiceType.Text;
            showHasDemandCheckBoox(txtServiceType.Text.Equals(Meter.ELECTRIC));
            this.cbServiceType.SelectedIndexChanged += new System.EventHandler(this.cbServiceType_SelectedIndexChanged);

        }

        private void rateSchedulesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //this.calEffectiveDate.DateChanged -= new System.Windows.Forms.DateRangeEventHandler(this.calEffectiveDate_DateChanged);

            //RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            //calEffectiveDate.SetDate(currentRateSchedule.EffectiveDate);


            //populateDgvRateBlocks(currentRateSchedule);
            //populateDgvDemandRateBlocks(currentRateSchedule);

            //this.calEffectiveDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEffectiveDate_DateChanged);

        }

        private void calEffectiveDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            //RateSchedule currentRateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            //currentRateSchedule.EffectiveDate = calEffectiveDate.SelectionRange.Start;
        }



        //private void cbTypeOfService_SelectedValueChanged(object sender, EventArgs e)
        //{

        //}


        #endregion


        //private void cbUtility_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void lblUtility_Click(object sender, EventArgs e)
        //{

        //}

        //private void lblBasicCharge_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtBasicCharge_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
