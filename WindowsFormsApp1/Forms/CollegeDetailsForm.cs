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
    
    public partial class CollegeDetailsForm : Form
    {
        ICollegeDetailsRepository collegeDetailsRepository;
        public CollegeDetailsForm()
        {
            InitializeComponent();
            collegeDetailsRepository = new CollegeDetailsRepository(ConfigurationManager.AppSettings.Get("Con"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void CollegeDetailsForm_Load(object sender, EventArgs e)
        {
            collegeDetailsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
          
            List<College> colleges=new List<College>();
            //DataTable collegeDetailsdt = collegeDetailsRepository.GetCollegeDetails();
            colleges= collegeDetailsRepository.GetCollegeDetails();
            collegeDetailsDataGrid.DataSource = colleges;
            CustomizeDataGridHeader();
            collegeDetailsDataGrid.Columns["CollegeId"].Width = 100;
            collegeDetailsDataGrid.Columns[1].Width = 200;
            collegeDetailsDataGrid.Columns[2].Width = 250;
            collegeDetailsDataGrid.Columns[3].Width = 250;
            collegeDetailsDataGrid.Columns["CollegeId"].Visible=false;
        }
        void CustomizeDataGridHeader()
        {
            collegeDetailsDataGrid.Columns["CollegeName"].HeaderText = "College Name";
        }
    }
}
