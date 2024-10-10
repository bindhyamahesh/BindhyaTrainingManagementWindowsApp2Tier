using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//using TrainingManagementWithClassLibraryADO.Models;
using System.Collections;
using TrainingManagementDomain;
namespace TrainingManagementWithClassLibraryADO
{
    public class CollegeDetailsRepository : ICollegeDetailsRepository
    {
        SQLHelperRepository sqlHelperRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connString"></param>
        public CollegeDetailsRepository(string connString)
        {
            sqlHelperRepository = new SQLHelperRepository(connString);
        }


        public List<College> GetCollegeDetails()
        {
            List<College> colleges = new List<College>();
            string storedProcedureName = "GetCollegeDetails";
            // string query = "SELECT * FROM Colleges";
            //return sqlHelperRepository.ExecuteQuery(query);          
            DataTable collegeDataTable = sqlHelperRepository.ExecuteQueryWithStoredProcedure(storedProcedureName);
            foreach (DataRow item in collegeDataTable.Rows)
            {
                College college = new College()

                {
                    CollegeId = Convert.ToInt32(item["CollegeId"]),
                    CollegeName = item["CollegeName"].ToString(),
                    Location = item["Location"].ToString(),
                    Remarks = item["Remarks"].ToString()


                };
                colleges.Add(college);
            }
            return colleges;
        }

        public College GetCollegeDetailsByID(College collegeData)
        {

            // string query = "SELECT * FROM Colleges WHERE CollegeId = @CollegeId";
            // SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            //return sqlHelperRepository.ExecuteQuery(query, parameters);

            string spName = "GetCollegeDetailsById";
            SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            DataTable dtCollege = sqlHelperRepository.ExecuteQueryWithStoredProcedure(spName, parameters);
            DataRow item = dtCollege.Rows[0];
            College selectedcollege = new College()
            {
                CollegeId = Convert.ToInt32(item["CollegeId"]),
                CollegeName = item["CollegeName"].ToString(),
                Location = item["Location"].ToString(),
                Remarks = item["Remarks"].ToString()
            };

            return selectedcollege;
        }

        public void InsertCollegeDetails(College collegeData)
        {
            //string insertQuery = "INSERT INTO Colleges (CollegeName, Location, Remarks) VALUES (@CollegeName, @Location, @Remarks)";
            //SqlParameter[] parameters = {
            //    new SqlParameter("@CollegeName", collegeData.CollegeName),
            //    new SqlParameter("@Location", collegeData. ),
            //    new SqlParameter("@Remarks", collegeData.Remarks)
            //};
            //sqlHelperRepository.ExecuteNonQuery(insertQuery, parameters);
            string storedProcedureName = "CollegeInsert";
            SqlParameter[] parameters = {
                new SqlParameter("@CollegeName", collegeData.CollegeName),
                new SqlParameter("@Location", collegeData.Location),
                new SqlParameter("@Remarks", collegeData.Remarks)
            };
            sqlHelperRepository.ExecuteNonQueryWithStoredProcedure(storedProcedureName, parameters);
        }

        public void EditCollegeDetailsByID(College collegeData)
        {
            //string updateQuery = "UPDATE Colleges SET CollegeName = @CollegeName, Location = @Location, Remarks = @Remarks WHERE CollegeId = @CollegeId";
            //SqlParameter[] parameters = {
            //    new SqlParameter("@CollegeName", collegeData.CollegeName),
            //    new SqlParameter("@Location", collegeData.Location),
            //    new SqlParameter("@Remarks", collegeData.Remarks),
            //    new SqlParameter("@CollegeId", collegeData.CollegeId)
            //};
            //sqlHelperRepository.ExecuteNonQuery(updateQuery, parameters);

            string spName = "CollegeUpdate";
            SqlParameter[] parameters = {
                new SqlParameter("@CollegeName", collegeData.CollegeName),
                new SqlParameter("@Location", collegeData.Location),
                new SqlParameter("@Remarks", collegeData.Remarks),
                new SqlParameter("@CollegeId", collegeData.CollegeId)
            };
            sqlHelperRepository.ExecuteQueryWithStoredProcedure(spName, parameters);

        }
        public void DeleteCollegeByID(College collegeData)
        {
            //string deleteQuery = "DELETE FROM Colleges WHERE CollegeId = @CollegeId";
            //SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            //sqlHelperRepository.ExecuteNonQuery(deleteQuery, parameters);

            string spName = "CollegeDeleteByID";
            SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            sqlHelperRepository.ExecuteQueryWithStoredProcedure(spName, parameters);

        }
    }
}
