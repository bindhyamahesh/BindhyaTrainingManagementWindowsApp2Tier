using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainingmanagement.Forms;

namespace TrainingManagementProject.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void CloseOtherChildForms()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void collegeInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void collegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void collegeInsertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void collegeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            CollegeDetailsForm collegeDetailsForm = new CollegeDetailsForm();
            collegeDetailsForm.MdiParent = this;
            collegeDetailsForm.Show();
        }

        private void collegeInsertToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            CollegeDetailsInsertForm collegedetailsinsertform = new CollegeDetailsInsertForm();
            collegedetailsinsertform.MdiParent = this;
            collegedetailsinsertform.Show();
        }

        private void collegeEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            CollegeEditDeleteForms collegeEditDeleteForms = new CollegeEditDeleteForms();
            collegeEditDeleteForms.MdiParent = this;
            collegeEditDeleteForms.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            TraineesForm traineeDetailsForm = new TraineesForm();
            traineeDetailsForm.MdiParent = this;
            traineeDetailsForm.Show();
        }

        private void batchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            BatchDetailsForm batchdetailsform = new BatchDetailsForm();
            batchdetailsform.MdiParent = this;
            batchdetailsform.Show();
        }

        private void batchEditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            BatchInsertForm batchDetailsForm = new BatchInsertForm();
            batchDetailsForm.MdiParent = this;
            batchDetailsForm.Show();
        }

        private void traineeInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            TraineesInsertForm traineesInsertForm = new TraineesInsertForm();
            traineesInsertForm.MdiParent = this;
            traineesInsertForm.Show();
        }

        private void traineeEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOtherChildForms();
            TraineeEditDeleteForm traineesInsertForm = new TraineeEditDeleteForm();
            traineesInsertForm.MdiParent = this;
            traineesInsertForm.Show();
        }
    }
}
