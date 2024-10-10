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
    public partial class TraineesForm : Form
    {
        ITraineeRepository traineeRepository;
        public TraineesForm()
        {
            string conString = ConfigurationManager.AppSettings.Get("Con");
            InitializeComponent();
            traineeRepository = new TraineeRepository(conString);
        }

        private void TraineesForm_Load(object sender, EventArgs e)
        {
            traineesDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            List<Trainees> trainees= traineeRepository.GetTrainees();  
            traineesDataGrid.DataSource = trainees;
           

            traineesDataGrid.Columns["TraineeName"].Width = 150;
            traineesDataGrid.Columns["TraineeLocation"].Width = 200;
            traineesDataGrid.Columns["CollegeName"].Width = 150;
            traineesDataGrid.Columns["CollegeId"].Visible = false;
            traineesDataGrid.Columns["TraineeId"].Visible = false;
            traineesDataGrid.Columns["BatchId"].Visible = false;
            CustomizeDataGridHeader();
        }
        void CustomizeDataGridHeader()
        {
            traineesDataGrid.Columns["TraineeName"].HeaderText = "Trainee Name";
        }
    }
}
