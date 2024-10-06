using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingManagementProject.Forms
{
    public partial class BatchInsertForm : Form
    {
        public BatchInsertForm()
        {
            InitializeComponent();
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
    }
}
