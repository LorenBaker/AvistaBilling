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
    public partial class frmAccounts : Form
    {

        private BindingSource accountsBindingSource;
        private BindingSource metersListBindingSource;
        private BindingList<Meter> meterBindingList;
        private BindingSource rateScheduleNumbersBindingSource;
        //private BindingList<Int32> rateScheduleNumbersBindingList;

        public frmAccounts()
        {
            InitializeComponent();
            setupComboBoxes();

            accountsBindingSource = new BindingSource();
            BindingList<Account> bList = new BindingList<Account>(frmMain.AppData.Accounts.Items);
            accountsBindingSource.DataSource = bList;
            accountBindingNavigator.BindingSource = accountsBindingSource;

            enableAccountChangeEventHandlers();
            enableMeterChangeEventHandlers();

            refreshAccountForm();

        }

        private void refreshAccountForm()
        {
            disableAccountChangeEventHandlers();
            Account currentAccount = (Account)accountsBindingSource.Current;
            if (currentAccount != null)
            {
                txtAccountNumber.Text = currentAccount.Number;
                cbUtility.SelectedItem = currentAccount.Utiltiy;

                txtAddress1.Text = currentAccount.Location.Address1;
                txtAddress2.Text = currentAccount.Location.Address2;
                txtCity.Text = currentAccount.Location.City;
                txtSate.Text = currentAccount.Location.State;
                txtZipcode.Text = currentAccount.Location.Zip;

                metersListBindingSource = new BindingSource();
                meterBindingList = new BindingList<Meter>(currentAccount.Meters);
                metersListBindingSource.DataSource = meterBindingList;
                meterBindingNavigator.BindingSource = metersListBindingSource;
                Meter currentMeter = (Meter)metersListBindingSource.Current;
                refreshMeterForm();

                txtSortKey.Text = currentAccount.SortKey.ToString();
                ckAccountSelected.Checked = currentAccount.isSelected;

                enableAccountChangeEventHandlers();
            }
            else
            {
                newAccount();
            }
        }



        private void enableAccountChangeEventHandlers()
        {
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.accountFieldChanged);
            this.txtAddress1.TextChanged += new System.EventHandler(this.accountFieldChanged);
            this.txtAddress2.TextChanged += new System.EventHandler(this.accountFieldChanged);
            this.txtCity.TextChanged += new System.EventHandler(this.accountFieldChanged);

            this.txtSate.TextChanged += new System.EventHandler(this.accountFieldChanged);
            this.txtZipcode.TextChanged += new System.EventHandler(this.accountFieldChanged);
            this.txtSortKey.TextChanged += new System.EventHandler(this.accountFieldChanged);
            this.ckAccountSelected.CheckedChanged += new System.EventHandler(this.accountFieldChanged);


            this.cbUtility.SelectedIndexChanged += new System.EventHandler(this.accountFieldChanged);

            this.bnAccountMoveFirst.Click += new System.EventHandler(this.bnAccountRefreshForm);
            this.bnAccountMoveLast.Click += new System.EventHandler(this.bnAccountRefreshForm);
            this.bnAccountMoveNext.Click += new System.EventHandler(this.bnAccountRefreshForm);
            this.bnAccountMovePrevious.Click += new System.EventHandler(this.bnAccountRefreshForm);
        }

        private void disableAccountChangeEventHandlers()
        {
            this.txtAccountNumber.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtAddress1.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtAddress2.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtCity.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtMeterNumber.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtMeterMultiplier.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtSate.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtZipcode.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.txtSortKey.TextChanged -= new System.EventHandler(this.accountFieldChanged);
            this.ckAccountSelected.CheckedChanged -= new System.EventHandler(this.accountFieldChanged);

            this.cbUtility.SelectedIndexChanged -= new System.EventHandler(this.accountFieldChanged);

            this.bnAccountMoveFirst.Click -= new System.EventHandler(this.bnAccountRefreshForm);
            this.bnAccountMoveLast.Click -= new System.EventHandler(this.bnAccountRefreshForm);
            this.bnAccountMoveNext.Click -= new System.EventHandler(this.bnAccountRefreshForm);
            this.bnAccountMovePrevious.Click -= new System.EventHandler(this.bnAccountRefreshForm);
        }

        private void enableMeterChangeEventHandlers()
        {
            this.cbMeterType.SelectedIndexChanged += new System.EventHandler(this.meterFieldChanged);

            this.txtMeterNumber.TextChanged += new System.EventHandler(this.meterFieldChanged);
            this.txtMeterMultiplier.TextChanged += new System.EventHandler(this.meterFieldChanged);
            this.cbMeterRateScheduleNumber.SelectedIndexChanged += new System.EventHandler(this.meterFieldChanged);

            this.bnMeterMoveFirst.Click += new System.EventHandler(this.bnMeterRefreshForm);
            this.bnMeterMovePrevious.Click += new System.EventHandler(this.bnMeterRefreshForm);
            this.bnMeterMoveNext.Click += new System.EventHandler(this.bnMeterRefreshForm);
            this.bnMeterMoveLast.Click += new System.EventHandler(this.bnMeterRefreshForm);

        }

        private void disableMeterChangeEventHandlers()
        {
            this.cbMeterType.SelectedIndexChanged -= new System.EventHandler(this.meterFieldChanged);
            this.txtMeterNumber.TextChanged -= new System.EventHandler(this.meterFieldChanged);
            this.txtMeterMultiplier.TextChanged -= new System.EventHandler(this.meterFieldChanged);
            this.cbMeterRateScheduleNumber.SelectedIndexChanged -= new System.EventHandler(this.meterFieldChanged);

            this.bnMeterMoveFirst.Click -= new System.EventHandler(this.bnMeterRefreshForm);
            this.bnMeterMovePrevious.Click -= new System.EventHandler(this.bnMeterRefreshForm);
            this.bnMeterMoveNext.Click -= new System.EventHandler(this.bnMeterRefreshForm);
            this.bnMeterMoveLast.Click -= new System.EventHandler(this.bnMeterRefreshForm);

        }

        private void setupComboBoxes()
        {

            BindingList<string> utilities = new BindingList<string>();
            utilities.Add(Account.AVISTA);
            utilities.Add(Account.INLAND);
            utilities.Add(Account.KTU);
            cbUtility.DataSource = utilities;
            cbUtility.SelectedIndex = 0;

            BindingList<string> meterTypes = new BindingList<string>();
            meterTypes.Add(Meter.NAT_GAS);
            meterTypes.Add(Meter.ELECTRIC);
            meterTypes.Add(Meter.DEMAND);
            cbMeterType.DataSource = meterTypes;
            cbMeterType.SelectedIndex = 0;

            setupCbMeterRateScheduleNumber();

        }

        private void setupCbMeterRateScheduleNumber()
        {
            rateScheduleNumbersBindingSource = new BindingSource();
            BindingList<Int32> rateScheduleNumbersBindingList = new BindingList<Int32>(frmMain.AppData.RateScheduleNumbers);
            rateScheduleNumbersBindingSource.DataSource = rateScheduleNumbersBindingList;
            cbMeterRateScheduleNumber.DataSource = rateScheduleNumbersBindingSource;
        }

        private void newAccount()
        {
            //MessageBox.Show("newAccount clicked.", "Button Clicked");
            Account newAccount = (Account)accountsBindingSource.AddNew();

            newAccount.Number = "";
            newAccount.Utiltiy = Account.AVISTA;

            newAccount.Location.Address1 = "Northern Quest Casino";
            newAccount.Location.Address2 = "";
            newAccount.Location.City = "Airway Heights";
            newAccount.Location.State = "WA";
            newAccount.Location.Zip = "99001";
            newAccount.isSelected = true;

            newAccount.Meters = new List<Meter>();


            refreshAccountForm();

        }

        private void saveCurrentAccount()
        {
            //MessageBox.Show("saveAccount clicked.", "Button Clicked");
            Account currentAccount = (Account)accountsBindingSource.Current;
            if (currentAccount != null)
            {
                try
                {
                    currentAccount.Number = txtAccountNumber.Text;
                    currentAccount.Utiltiy = cbUtility.SelectedItem.ToString();

                    currentAccount.Location.Address1 = txtAddress1.Text;
                    currentAccount.Location.Address2 = txtAddress2.Text;
                    currentAccount.Location.City = txtCity.Text;
                    currentAccount.Location.State = txtSate.Text;
                    currentAccount.Location.Zip = txtZipcode.Text;

                    currentAccount.SortKey = Int32.Parse(txtSortKey.Text);
                    currentAccount.isSelected = ckAccountSelected.Checked;

                    btnAccountNotSaved.Visible = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error Type: " + ex.GetType().FullName);
                    System.Diagnostics.Debug.WriteLine("Error Message: " + ex.Message);
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error: Unable to save current account. Current account is null!");
            }

        }

        private void deleteCurrentAccount()
        {
            //MessageBox.Show("deleteAccount clicked.", "Button Clicked");
            int currentPosition = accountsBindingSource.Position;
            int newPosition = currentPosition - 1;
            if (accountsBindingSource.Count > 0)
            {
                Account currentAccount = (Account)accountsBindingSource.Current;
                accountsBindingSource.Remove(currentAccount);
                if (newPosition < 0)
                {
                    if (accountsBindingSource.Count > 0)
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

                accountsBindingSource.Position = newPosition;
                refreshAccountForm();
            }
            else
            {
                // There are no recods in the bindingSource
                clearForm();
            }
        }

        private void newMeter()
        {
            Meter newMeter = (Meter)metersListBindingSource.AddNew();
            newMeter.MeterType = Meter.NAT_GAS;
            newMeter.MeterNumber = "";
            newMeter.MeterMultiplier = 0;
            newMeter.RateScheduleNumber = 11;

            refreshMeterForm();
        }

        private void refreshMeterForm()
        {
            disableMeterChangeEventHandlers();

            Meter currentMeter = (Meter)metersListBindingSource.Current;
            if (currentMeter != null)
            {
                txtMeterNumber.Text = currentMeter.MeterNumber;
                cbMeterType.SelectedItem = currentMeter.MeterType;
                txtMeterMultiplier.Text = currentMeter.MeterMultiplier.ToString();
                cbMeterRateScheduleNumber.SelectedItem = currentMeter.RateScheduleNumber;
            }
            else
            {
                newMeter();
            }

            enableMeterChangeEventHandlers();
        }

        private void saveCurrentMeter()
        {
            Meter currentMeter = (Meter)metersListBindingSource.Current;
            if (currentMeter != null)
            {
                disableMeterChangeEventHandlers();

                currentMeter.MeterType = cbMeterType.SelectedItem.ToString();
                currentMeter.MeterNumber = txtMeterNumber.Text;
                currentMeter.MeterMultiplier = Double.Parse(txtMeterMultiplier.Text);
                Int32 meterRateScheduleNumber = Int32.Parse(cbMeterRateScheduleNumber.Text);
                currentMeter.RateScheduleNumber = meterRateScheduleNumber;

                Int32 rateScheuleNumbersCount = frmMain.AppData.RateScheduleNumbers.Count;
                frmMain.AppData.addMeterRateScheduleNumber(meterRateScheduleNumber);
                if (rateScheuleNumbersCount < frmMain.AppData.RateScheduleNumbers.Count)
                {
                    setupCbMeterRateScheduleNumber();
                }
                cbMeterRateScheduleNumber.SelectedItem = meterRateScheduleNumber;

                btnMeterNotSaved.Visible = false;
                enableMeterChangeEventHandlers();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error: Unable to save current meter. Current meter is null!");
            }
        }

        private void deleteCurrentMeter()
        {
            int currentPosition = metersListBindingSource.Position;
            int newPosition = currentPosition - 1;
            if (metersListBindingSource.Count > 0)
            {
                Meter currentMeter = (Meter)metersListBindingSource.Current;
                metersListBindingSource.Remove(currentMeter);
                if (newPosition < 0)
                {
                    if (metersListBindingSource.Count > 0)
                    {
                        newPosition = 0;
                    }
                    else
                    {
                        // There are no recods in the bindingSource
                        clearMeterForm();
                        return;
                    }
                }

                metersListBindingSource.Position = newPosition;
                refreshMeterForm();
            }
            else
            {
                // There are no recods in the bindingSource
                clearMeterForm();
            }
        }

        private void clearMeterForm()
        {
            disableMeterChangeEventHandlers();

            metersListBindingSource = new BindingSource();
            cbMeterType.SelectedIndex = 0;
            txtMeterNumber.Text = "";
            txtMeterMultiplier.Text = "";
            cbMeterRateScheduleNumber.SelectedIndex = 0;

            enableMeterChangeEventHandlers();
        }

        private void clearForm()
        {
            disableAccountChangeEventHandlers();


            txtAccountNumber.Text = "";
            cbUtility.SelectedIndex = 0;

            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtSate.Text = "";
            txtZipcode.Text = "";
            txtSortKey.Text = "";
            ckAccountSelected.Checked = true;

            clearMeterForm();

            enableAccountChangeEventHandlers();

        }



        #region Button Event Handlers
        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            saveCurrentAccount();
            newAccount();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newAccount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveCurrentAccount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCurrentAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accountFieldChanged(object sender, EventArgs e)
        {
            btnAccountNotSaved.Visible = true;
        }

        private void meterFieldChanged(object sender, EventArgs e)
        {
            btnMeterNotSaved.Visible = true;
        }



        private void bnAccountRefreshForm(object sender, EventArgs e)
        {
            refreshAccountForm();
        }

        private void bnMeterRefreshForm(object sender, EventArgs e)
        {
            refreshMeterForm();
        }

        //bnMeterRefreshForm

        private void frmAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.AppData.Accounts.sort();
        }

        private void btnSaveMeter_Click(object sender, EventArgs e)
        {
            saveCurrentMeter();
        }

        private void btnNewSaveMeter_Click(object sender, EventArgs e)
        {
            saveCurrentMeter();
            newMeter();
        }

        private void btnDeleteMeter_Click(object sender, EventArgs e)
        {
            deleteCurrentMeter();
        }

        private void btnNewMeter_Click(object sender, EventArgs e)
        {
            newMeter();
        }

        private void bindingNavigatorMoveFirstItem1_Click(object sender, EventArgs e)
        {
            metersListBindingSource.MoveFirst();
        }

        private void bindingNavigatorMovePreviousItem1_Click(object sender, EventArgs e)
        {
            metersListBindingSource.MovePrevious();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            metersListBindingSource.MoveNext();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            metersListBindingSource.MoveLast();
        }



        #endregion

        private void txtMeterNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
