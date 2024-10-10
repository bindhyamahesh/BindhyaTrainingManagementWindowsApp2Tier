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

    public partial class CollegeEditDeleteForms : Form
    {
        College collegeData;
        int selectedCollegeID = 0;
        CollegeDetailsRepository collegeDetailsRepository;
        public CollegeEditDeleteForms()
        {
            InitializeComponent();
            collegeDetailsRepository = new CollegeDetailsRepository(ConfigurationManager.AppSettings.Get("Con"));
        }

        private void CollegeEditDeleteForms_Load(object sender, EventArgs e)
        {
            PopulateCollegeCombo();
        }
       private void GetCollegeDetailsByID(int collegeID)
        {
            collegeData = new College();
            collegeData.CollegeId=collegeID;
            College selectedCollege = collegeDetailsRepository.GetCollegeDetailsByID(collegeData);
            

                collegeNameTextbox.Text = selectedCollege.CollegeName;
                remarksTextbox.Text = selectedCollege.Remarks;
                locationTextbox.Text = selectedCollege.Location;

            
        }
        void PopulateCollegeCombo()
        {

            collegeNameCombobox.DataSource = collegeDetailsRepository.GetCollegeDetails();
            collegeNameCombobox.DisplayMember = "CollegeName";
            collegeNameCombobox.ValueMember = "CollegeId";
        }

        private void collegeNameCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                string collegeID = comboBox.SelectedValue.ToString();
                selectedCollegeID = Convert.ToInt32(collegeID);
                GetCollegeDetailsByID(Convert.ToInt32(collegeID));
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedCollegeID > 0)
            {
                collegeData.CollegeId = selectedCollegeID;
                collegeData.CollegeName = collegeNameTextbox.Text;
                collegeData.Location = locationTextbox.Text;
                collegeData.Remarks = remarksTextbox.Text;

                collegeDetailsRepository.EditCollegeDetailsByID(collegeData);
                MessageBox.Show("Updated Successfully");
                ClearControls();
            }
        }
        void ClearControls()
        {
            collegeNameTextbox.Text = string.Empty;
            locationTextbox.Text = string.Empty;
            remarksTextbox.Text = string.Empty;
            PopulateCollegeCombo();
            collegeNameCombobox.SelectedIndex = 0;
            selectedCollegeID = 0;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                 "Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (selectedCollegeID > 0)
                {
                    collegeData.CollegeId = selectedCollegeID;
                    collegeDetailsRepository.DeleteCollegeByID(collegeData);
                    MessageBox.Show("Deleted Successfully");
                    ClearControls();
                }
            }
        }
    }
}
