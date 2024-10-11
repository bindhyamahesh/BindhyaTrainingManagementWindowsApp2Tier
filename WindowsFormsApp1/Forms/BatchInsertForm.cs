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

namespace TrainingManagementProject.Forms
{
    public partial class BatchInsertForm : Form
    {
        Batches batches=new Batches();
        IBatchRepository batchRepository;
        public BatchInsertForm()
        {
            InitializeComponent();
            batchRepository = new BatchRepository(ConfigurationManager.AppSettings.Get("Con"));
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

        private void startDateCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //startDateCalendar.Location = new System.Drawing.Point(startDateTextbox.Right, startDateTextbox.Right);

            startDateTextbox.Text = e.Start.ToShortDateString();
            startDateCalendar.Visible = !startDateCalendar.Visible;
        }

        private void startDateTextbox_TextChanged(object sender, EventArgs e)
        {

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

        private void endDateCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            endDateTextbox.Text = e.Start.ToShortDateString();
            endDateCalender.Visible = !endDateCalender.Visible;
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

        private void tentativeEndDateCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            tentativeEndDateTextbox.Text = e.Start.ToShortDateString();
            tentativeEndDateCalender.Visible = !tentativeEndDateCalender.Visible;
        }

        private void batchNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            batches.BatchName=batchNameTextBox.Text;
            batches.StartDate = string.IsNullOrEmpty(startDateTextbox.Text) ? DateTime.MinValue : Convert.ToDateTime(startDateTextbox.Text);
            batches.EndDate = string.IsNullOrEmpty(endDateTextbox.Text)?DateTime.MinValue : Convert.ToDateTime(endDateTextbox.Text);
            batches.TentativeEndDate = string.IsNullOrEmpty(tentativeEndDateTextbox.Text) ? DateTime.MinValue : Convert.ToDateTime(tentativeEndDateTextbox.Text);
            
            batches.Fees= string.IsNullOrEmpty(feesTextBox.Text) ? 0: Convert.ToDouble(feesTextBox.Text);
            batches.FeesPaid = string.IsNullOrEmpty(feesPaidTextBox.Text) ? 0 : Convert.ToDouble(feesPaidTextBox.Text);
            batches.Duration = string.IsNullOrEmpty(durationTextbox.Text) ? 0 : Convert.ToDouble(durationTextbox.Text);
            batches.HoursTaken = string.IsNullOrEmpty(hoursTakentextBox.Text) ? 0 : Convert.ToDouble(hoursTakentextBox.Text);
            batches.Details = detailsTextbox.Text;
            batches.Remarks = remarksTextbox.Text;
            batchRepository.InsertEditDeleteBatchDetails(batches,"insert");
            MessageBox.Show("Successfully inserted.");
            
        }
    }
}
