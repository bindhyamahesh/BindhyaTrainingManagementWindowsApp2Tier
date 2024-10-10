using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagementDomain;

namespace TrainingManagementWithClassLibraryADO
{

    public class BatchRepository : IBatchRepository
    {
        SQLHelperRepository sqlHelperRepository;
        public BatchRepository(string connString)
        {
            sqlHelperRepository = new SQLHelperRepository(connString);
        }
        private DateTime ParseDate(object dateValue)
        {
            if (dateValue != DBNull.Value && dateValue != null)
            {
                DateTime parsedDate;
                string dateString = dateValue.ToString();
                if (DateTime.TryParse(dateString, out parsedDate))
                {
                    return parsedDate;
                }
                else
                {
                    return default;
                }
            }
            return default;
        }
        public List<Batches> GetBatchDetails()
        {
            List<Batches> batches = new List<Batches>();
            string spQuery = "GetBatchDetails";
            DataTable batchesDataTable = sqlHelperRepository.ExecuteQueryWithStoredProcedure(spQuery);
            foreach (DataRow item in batchesDataTable.Rows)
            {
                Batches batch = new Batches()
                {
                    BatchId = Convert.ToInt32(item["BatchId"]),
                    BatchName = item["BatchName"].ToString(),
                    TentativeEndDate = item["TentativeEndDate"]!= DBNull.Value? Convert.ToDateTime(item["TentativeEndDate"]):default(DateTime),
                    StartDate = item["StartDate"]!=DBNull.Value? Convert.ToDateTime(item["StartDate"]):default(DateTime),
                    EndDate = item["EndDate"]!=DBNull.Value? Convert.ToDateTime((item["EndDate"])):default(DateTime),
                    Fees =item["Fees"]!=DBNull.Value? Convert.ToDouble(item["Fees"]):0.0,
                    FeesPaid = item["FeesPaid"] != DBNull.Value ? Convert.ToDouble(item["FeesPaid"]):0.0,
                    Duration = item["Duration"]!=DBNull.Value? Convert.ToDouble(item["Duration"]):0.0,
                    HoursTaken = item["HoursTaken"]!=DBNull.Value ? Convert.ToDouble(item["HoursTaken"]):0.0,
                    Status = item["BatchName"].ToString(),
                    Details = item["Details"].ToString(),
                    Remarks = item["Remarks"].ToString()
                };
                batches.Add(batch);
            }
            return batches;
            //string query = "SELECT * FROM Batches";
            //return sqlHelperRepository.ExecuteQuery(query);
        }
    }
}
