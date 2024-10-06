using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagementWithClassLibraryADO.Models;

namespace TrainingManagementWithClassLibraryADO
{
    public class TraineeRepository
    {
        SQLHelperRepository sqlHelperRepository;
        public TraineeRepository(string connString)
        {
            sqlHelperRepository = new SQLHelperRepository(connString);
        }
        public DataTable GetTrainees()
        {
            string query = "select *from TraineesView";
            DataTable dataTable= sqlHelperRepository.ExecuteQuery(query);
            return dataTable;
        }
        public void InsertTraineeDetails(Trainee trainee)
        {
            string insertQuery = "INSERT INTO Trainees (CollegeId, TraineeName) VALUES (@CollegeId, @TraineeeName)";
            SqlParameter[] parameters = {
                new SqlParameter("@TraineeeName", trainee.TraineeName),
                new SqlParameter("@CollegeId", trainee.CollegeId)
            };
            sqlHelperRepository.ExecuteNonQuery(insertQuery, parameters);
        }
    }
}
