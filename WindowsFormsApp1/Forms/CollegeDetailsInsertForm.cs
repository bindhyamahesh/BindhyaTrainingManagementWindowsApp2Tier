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
using TrainingManagementWithClassLibraryADO;
using TrainingManagementDomain;

namespace TrainingManagementProject.Forms
{
    public partial class CollegeDetailsInsertForm : Form
    {
        College collegeData = new College();
        CollegeDetailsRepository collegeDetailsRepository;
        public CollegeDetailsInsertForm()
        {
            InitializeComponent();
            collegeDetailsRepository = new CollegeDetailsRepository(ConfigurationManager.AppSettings.Get("Con"));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            collegeData.CollegeName = collegeNameTextbox.Text;
            collegeData.Location = locationTextbox.Text;
            collegeData.Remarks = remarksTextbox.Text;

           int inserted=  collegeDetailsRepository.InsertCollegeDetails(collegeData);
            if(inserted > 0) 
            MessageBox.Show("Inserted successfully.");
            else
                MessageBox.Show("Failed to insert.");
        }
    }
}
