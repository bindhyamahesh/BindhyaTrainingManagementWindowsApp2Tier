using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagementDomain;
using TrainingManagementWithClassLibraryADO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainingManagementProject.Forms
{
    public partial class BatchEditDelete : Form
    {
        Batches batches = new Batches();
        BatchRepository batchRepository;
        public BatchEditDelete()
        {
            InitializeComponent();
            string conString = ConfigurationManager.AppSettings.Get("Con");
            batchRepository = new BatchRepository(conString);
        }
        void PopulateBatchComboBox()
        {
            Batches batche = new Batches();
            List<Batches> batches = batchRepository.GetBatchDetails(batche,"select");
            comboBoxBatchName.DataSource = batches;
            comboBoxBatchName.DisplayMember = "BatchName";
            comboBoxBatchName.ValueMember = "BatchId";
        }
        private void startDateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            startDateTextbox.Text = e.Start.ToShortDateString();
            startDateCalendar.Visible = !startDateCalendar.Visible;
        }

        private void endDateCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            endDateTextbox.Text = e.Start.ToShortDateString();
            endDateCalender.Visible = !endDateCalender.Visible;
        }

        private void tentativeEndDateCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            tentativeEndDateTextbox.Text = e.Start.ToShortDateString();
            tentativeEndDateCalender.Visible = !tentativeEndDateCalender.Visible;
        }

        private void tentativeEndDateTextbox_Click(object sender, EventArgs e)
        {
            tentativeEndDateCalender.Location = new System.Drawing.Point(tentativeEndDateTextbox.Left, tentativeEndDateTextbox.Bottom + 5);

            tentativeEndDateCalender.Visible = !tentativeEndDateCalender.Visible;
            if (tentativeEndDateCalender.Visible)
            {
                tentativeEndDateCalender.BringToFront();
            }
        }

        private void endDateTextbox_Click(object sender, EventArgs e)
        {
            endDateCalender.Location = new System.Drawing.Point(endDateTextbox.Left, endDateTextbox.Bottom + 5);

            endDateCalender.Visible = !endDateCalender.Visible;
            if (endDateCalender.Visible)
            {
                endDateCalender.BringToFront();
            }
        }

        private void startDateTextbox_Click(object sender, EventArgs e)
        {
            startDateCalendar.Location = new System.Drawing.Point(startDateTextbox.Left, startDateTextbox.Bottom + 5);

            startDateCalendar.Visible = !startDateCalendar.Visible;
            if (startDateCalendar.Visible)
            {
                startDateCalendar.BringToFront();
            }
        }

        private void BatchEditDelete_Load(object sender, EventArgs e)
        {
            PopulateBatchComboBox();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string batchID = comboBoxBatchName.SelectedValue.ToString();
            batches.BatchId=Convert.ToInt32(batchID);
            batches.BatchName = batchNameTextBox.Text;
            batches.StartDate = string.IsNullOrEmpty(startDateTextbox.Text) ? DateTime.MinValue : Convert.ToDateTime(startDateTextbox.Text);
            batches.EndDate = string.IsNullOrEmpty(endDateTextbox.Text) ? DateTime.MinValue : Convert.ToDateTime(endDateTextbox.Text);
            batches.TentativeEndDate = string.IsNullOrEmpty(tentativeEndDateTextbox.Text) ? DateTime.MinValue : Convert.ToDateTime(tentativeEndDateTextbox.Text);

            batches.Fees = string.IsNullOrEmpty(feesTextBox.Text) ? 0 : Convert.ToDouble(feesTextBox.Text);
            batches.FeesPaid = string.IsNullOrEmpty(feesPaidTextBox.Text) ? 0 : Convert.ToDouble(feesPaidTextBox.Text);
            batches.Duration = string.IsNullOrEmpty(durationTextbox.Text) ? 0 : Convert.ToDouble(durationTextbox.Text);
            batches.HoursTaken = string.IsNullOrEmpty(hoursTakentextBox.Text) ? 0 : Convert.ToDouble(hoursTakentextBox.Text);
            batches.Details = detailsTextbox.Text;
            batches.Remarks = remarksTextbox.Text;
            batchRepository.InsertEditDeleteBatchDetails(batches, "update");
            MessageBox.Show("Successfully Updated..");
            ClerControls();
        }

        private void GetBatcheDetailsByID()
        {
            batches = new Batches();
            string batchID = comboBoxBatchName.SelectedValue.ToString();
            batches.BatchId = Convert.ToInt32(batchID);;
          List<Batches> selectedBatch = batchRepository.GetBatchDetails(batches, "id");
            if (selectedBatch != null && selectedBatch.Count > 0)
            {
                batches = selectedBatch[0];
                batchNameTextBox.Text = batches.BatchName;
                startDateTextbox.Text = batches.StartDate.ToString();
                endDateTextbox.Text = batches.EndDate.ToString();
                tentativeEndDateTextbox.Text = batches.TentativeEndDate.ToString();
                feesTextBox.Text =  batches.Fees.ToString();
                feesPaidTextBox.Text = batches.FeesPaid.ToString();
                 durationTextbox.Text = batches.Duration.ToString();
                hoursTakentextBox.Text = batches.HoursTaken.ToString();
                remarksTextbox.Text = batches.Remarks;
                detailsTextbox.Text = batches.Details;
            }




            }

        private void comboBoxBatchName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBatcheDetailsByID();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Batches batch = new Batches();
                string batchID = comboBoxBatchName.SelectedValue.ToString();
                batches.BatchId = Convert.ToInt32(batchID);
                batchRepository.InsertEditDeleteBatchDetails(batches, "delete");
                MessageBox.Show("Successfully Deleted..");
                ClerControls();
            }
        }

        void ClerControls()
        {
            batchNameTextBox.Text = string.Empty;
            startDateTextbox.Text = string.Empty;
            endDateTextbox.Text = string.Empty;
            PopulateBatchComboBox();
            comboBoxBatchName.SelectedIndex = 0;
            tentativeEndDateTextbox.Text = string.Empty;
            feesTextBox.Text = string.Empty;
            feesPaidTextBox.Text = string.Empty;
            detailsTextbox.Text = string.Empty;
            remarksTextbox.Text = string.Empty;
            hoursTakentextBox.Text = string.Empty;
            durationTextbox.Text = string.Empty;
        }
    }
}
