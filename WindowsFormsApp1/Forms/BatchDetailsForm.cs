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
namespace Trainingmanagement.Forms
{
    public partial class BatchDetailsForm : Form
    {
        IBatchRepository batchRepository;
        public BatchDetailsForm()
        {
            InitializeComponent();
            string conString = ConfigurationManager.AppSettings.Get("Con");
            batchRepository = new BatchRepository(conString);
        }

        private void BatchDetailsForm_Load(object sender, EventArgs e)
        {
            batchDetailsDatagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            Batches batch = new Batches();
            List<Batches> batches = batchRepository.GetBatchDetails(batch,"select");
            batchDetailsDatagrid.DataSource = batches;
            CustomizeDataGridHeader();
        }
        void CustomizeDataGridHeader()
        {
            batchDetailsDatagrid.Columns["BatchId"].Visible = false;

            batchDetailsDatagrid.Columns["BatchName"].HeaderText = "Batch Name";
            batchDetailsDatagrid.Columns["BatchName"].Width = 120;
            batchDetailsDatagrid.Columns["StartDate"].Width = 70;
            batchDetailsDatagrid.Columns["TentativeEndDate"].Width = 70;
            batchDetailsDatagrid.Columns["EndDate"].Width = 75;
            batchDetailsDatagrid.Columns["Fees"].Width = 75;
            batchDetailsDatagrid.Columns["FeesPaid"].Width = 75;
            batchDetailsDatagrid.Columns["Duration"].Width = 75;
            batchDetailsDatagrid.Columns["Details"].Width = 200;
            batchDetailsDatagrid.Columns["Remarks"].Width = 200; 

        }

        private void batchDetailsDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
