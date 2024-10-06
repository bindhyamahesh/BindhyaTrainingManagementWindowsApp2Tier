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
using System.Data.SqlClient;
using TrainingManagementWithClassLibraryADO;
using TrainingManagementWithClassLibraryADO.Models;

namespace TrainingManagementProject.Forms
{
    public partial class TraineesInsertForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("Con"));
        CollegeDetailsRepository collegeDetailsRepository;
        TraineeRepository traineeRepository;
        public TraineesInsertForm()
        {
            InitializeComponent();
            string conString = ConfigurationManager.AppSettings.Get("Con");
            collegeDetailsRepository = new CollegeDetailsRepository(conString);
            traineeRepository=new TraineeRepository(conString);
        }

        private void TraineesInsertForm_Load(object sender, EventArgs e)
        {
            collegesComboBox.DataSource = collegeDetailsRepository.GetCollegeDetails();
            collegesComboBox.DisplayMember = "CollegeName";
            collegesComboBox.ValueMember = "CollegeId";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*   string query = "insert into  Trainees ( CollegeId,TraineeName) values (@CollegeId,@TraineeName)";
               sqlConnection.Open();
               SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
               sqlCommand.Parameters.AddWithValue("@CollegeId", collegesComboBox.SelectedValue);
               sqlCommand.Parameters.AddWithValue("@TraineeName", traineeNameTextBox.Text);
               sqlCommand.ExecuteNonQuery();
               sqlConnection.Close();*/
            Trainee trainee = new Trainee();
            trainee.CollegeId= Convert.ToInt32(collegesComboBox.SelectedValue);
            trainee.TraineeName = traineeNameTextBox.Text;
           traineeRepository.InsertTraineeDetails(trainee);
            MessageBox.Show("Records Saved.");
        }
    }
}
