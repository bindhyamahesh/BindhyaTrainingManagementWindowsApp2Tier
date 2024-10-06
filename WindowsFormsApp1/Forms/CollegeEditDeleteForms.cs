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
using TrainingManagementWithClassLibraryADO.Models;

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
            DataTable collegedetailsByIDdt = collegeDetailsRepository.GetCollegeDetailsByID(collegeData);
            if (collegedetailsByIDdt.Rows.Count > 0)
            {
                DataRow row = collegedetailsByIDdt.Rows[0];
                collegeNameTextbox.Text = row["CollegeName"].ToString();
                remarksTextbox.Text = row["Remarks"].ToString();
                locationTextbox.Text = row["Location"].ToString();

            }
        }
        void PopulateCollegeCombo()
        {

            collegeNameCombobox.DataSource = collegeDetailsRepository.GetCollegeDetails();
            collegeNameCombobox.DisplayMember = "CollegeName";
            collegeNameCombobox.ValueMember = "CollegeID";
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

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
