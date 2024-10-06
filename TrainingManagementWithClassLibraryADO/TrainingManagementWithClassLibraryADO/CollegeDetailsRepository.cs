using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrainingManagementWithClassLibraryADO.Models;
namespace TrainingManagementWithClassLibraryADO
{
    public class CollegeDetailsRepository
    {
        SQLHelperRepository sqlHelperRepository;
        public CollegeDetailsRepository(string connString) {
            sqlHelperRepository = new SQLHelperRepository(connString);
        }   
      
        public DataTable GetCollegeDetails()
        {
            string query = "SELECT * FROM Colleges";
            return sqlHelperRepository.ExecuteQuery(query);          
        }
        
        public DataTable GetCollegeDetailsByID(College collegeData)
        {
            string query = "SELECT * FROM Colleges WHERE CollegeId = @CollegeId";
            SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            return sqlHelperRepository.ExecuteQuery(query, parameters);
        }
       
        public void InsertCollegeDetails(College collegeData )
        {
            string insertQuery = "INSERT INTO Colleges (CollegeName, Location, Remarks) VALUES (@CollegeName, @Location, @Remarks)";
            SqlParameter[] parameters = {
                new SqlParameter("@CollegeName", collegeData.CollegeName),
                new SqlParameter("@Location", collegeData.Location),
                new SqlParameter("@Remarks", collegeData.Remarks)
            };
            sqlHelperRepository.ExecuteNonQuery(insertQuery, parameters);
        }
      
        public void EditCollegeDetailsByID(College collegeData)
        {
            string updateQuery = "UPDATE Colleges SET CollegeName = @CollegeName, Location = @Location, Remarks = @Remarks WHERE CollegeId = @CollegeId";
            SqlParameter[] parameters = {
                new SqlParameter("@CollegeName", collegeData.CollegeName),
                new SqlParameter("@Location", collegeData.Location),
                new SqlParameter("@Remarks", collegeData.Remarks),
                new SqlParameter("@CollegeId", collegeData.CollegeId)
            };
            sqlHelperRepository.ExecuteNonQuery(updateQuery, parameters);
        }
        public void DeleteCollegeByID(College collegeData)
        {
            string deleteQuery = "DELETE FROM Colleges WHERE CollegeId = @CollegeId";
            SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            sqlHelperRepository.ExecuteNonQuery(deleteQuery, parameters);
        }
    }
}
