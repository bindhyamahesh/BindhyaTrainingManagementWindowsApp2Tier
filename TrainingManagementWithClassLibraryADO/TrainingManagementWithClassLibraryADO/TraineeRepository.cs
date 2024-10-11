using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagementDomain;

namespace TrainingManagementWithClassLibraryADO
{
    public class TraineeRepository : ITraineeRepository
    {
        SQLHelperRepository sqlHelperRepository;
        public TraineeRepository(string connString)
        {
            sqlHelperRepository = new SQLHelperRepository(connString);
        }
        public List<Trainees> GetTrainees()
        {
            List<Trainees> trainees = new List<Trainees>();
            //string query = "select *from TraineesView";
            //DataTable dataTable= sqlHelperRepository.ExecuteQuery(query);
            //return dataTable;

            string spName = "spTrainees";
            SqlParameter[] parameters = {
                new SqlParameter("@Option", 's')
            };
            DataTable dataTable = sqlHelperRepository.ExecuteQueryWithStoredProcedure(spName);
            foreach (DataRow item in dataTable.Rows)
            {
                Trainees trainee = new Trainees()
                {

                    CollegeId = Convert.ToInt32(item["CollegeId"]),
                    BatchId = Convert.ToInt32(item["BatchId"]),
                    TraineeId = Convert.ToInt32(item["TraineeId"]),
                    TraineeName = item["TraineeName"].ToString(),
                    TraineeLocation = item["TraineeLocation"].ToString(),
                    Email = item["Email"].ToString(),
                    Phone = item["Phone"].ToString(),
                   // Discontinue = GetDiscontinueChar(item["Discontinue"].ToString()),
                    CollegeName = item["CollegeName"].ToString()

                };
                trainees.Add(trainee);
            }

            return trainees;
        }
        private char GetDiscontinueChar(object discontinueValue)
        {
            if (discontinueValue != DBNull.Value && discontinueValue != null)
            {
                string str = discontinueValue.ToString();
                if (str.Length == 1)
                {
                    return char.Parse(str);
                }
            }
            return default;
        }
        public void InsertEditDeleteTraineeDetails(Trainees trainee,char option)
        {
            //string insertQuery = "INSERT INTO Trainees (CollegeId, TraineeName) VALUES (@CollegeId, @TraineeeName)";
            //SqlParameter[] parameters = {
            //    new SqlParameter("@TraineeeName", trainee.TraineeName),
            //    new SqlParameter("@CollegeId", trainee.CollegeId)
            //};
            //sqlHelperRepository.ExecuteNonQuery(insertQuery, parameters);

            string spName = "spTrainees";
            SqlParameter[] parameters = {
                 new SqlParameter("@Option", option),
                new SqlParameter("@TraineeName", trainee.TraineeName),
                new SqlParameter("@TraineeLocation", trainee.TraineeLocation),
                new SqlParameter("@CollegeId", trainee.CollegeId),
                new SqlParameter("@Email", trainee.Email),
                new SqlParameter("@Phone", trainee.Phone),
                new SqlParameter("@Discontinue", trainee.Discontinue)

            };
            sqlHelperRepository.ExecuteNonQueryWithStoredProcedure(spName, parameters);
        }
    }
}
