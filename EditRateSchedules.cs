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
    public partial class EditRateSchedules : Form
    {

        private BindingSource rateSchedulesBindingSource;
        public EditRateSchedules()
        {
            InitializeComponent();

            rateSchedulesBindingSource = new BindingSource();
            BindingList<RateSchedule> bList = new BindingList<RateSchedule>(frmMain.AppData.RateSchedules.Items);
            rateSchedulesBindingSource.DataSource = bList;
            rateSchedulesBindingNavigator.BindingSource = rateSchedulesBindingSource;
            refreshForm();

        }

        private void refreshForm()
        {
            RateSchedule rateSchedule = (RateSchedule)rateSchedulesBindingSource.Current;
            txtRateSchedule.Text = rateSchedule.ScheduleNumber.ToString();
            txtBasicCharge.Text = rateSchedule.BasicCharge.ToString();
            txtCityTaxRate.Text = rateSchedule.CityTaxRate.ToString();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refreshForm();
            //string temp = "";
        }
    }
}
