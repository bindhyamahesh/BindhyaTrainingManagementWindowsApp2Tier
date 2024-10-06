using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementWithClassLibraryADO
{
    
    public class BatchRepository
    {
        SQLHelperRepository sqlHelperRepository;
        public BatchRepository(string connString)
        {
            sqlHelperRepository = new SQLHelperRepository(connString);
        }

        public DataTable GetBatchDetails()
        {
            string query = "SELECT * FROM Batches";
            return sqlHelperRepository.ExecuteQuery(query);
        }
    }
}
