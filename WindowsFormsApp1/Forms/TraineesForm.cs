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

namespace TrainingManagementProject.Forms
{
    public partial class TraineesForm : Form
    {
        TraineeRepository traineeRepository;
        public TraineesForm()
        {
            string conString = ConfigurationManager.AppSettings.Get("Con");
            InitializeComponent();
            traineeRepository = new TraineeRepository(conString);
        }

        private void TraineesForm_Load(object sender, EventArgs e)
        {
            DataTable dtTrainees= traineeRepository.GetTrainees();  
            traineesDataGrid.DataSource = dtTrainees;
        }
    }
}
