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
            try
            {
                string storedProcedureName = "spColleges";
                SqlParameter[] parameters = { new SqlParameter("@Option", 's') };
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
            }
            catch (Exception ex)
            {
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

        public int InsertCollegeDetails(College collegeData)
        {
            int inserted = 0;
            //string storedProcedureName = "CollegeInsert";
            //SqlParameter[] parameters = {
            //    new SqlParameter("@CollegeName", collegeData.CollegeName),
            //    new SqlParameter("@Location", collegeData.Location),
            //    new SqlParameter("@Remarks", collegeData.Remarks)
            //};
            try
            {
                string storedProcedureName = "spColleges";
                SqlParameter[] parameters = {
                 new SqlParameter("@Option", 'i'),
                new SqlParameter("@CollegeName", collegeData.CollegeName),
                new SqlParameter("@Location", collegeData.Location),
                new SqlParameter("@Remarks", collegeData.Remarks)
            };
                sqlHelperRepository.ExecuteNonQueryWithStoredProcedure(storedProcedureName, parameters);
            }
            catch (Exception ex)
            {
                inserted = 0;
            }
            return inserted;
        }

        public void EditCollegeDetailsByID(College collegeData)
        {
            try
            {
                //string spName = "CollegeUpdate";
                //SqlParameter[] parameters = {
                //    new SqlParameter("@CollegeName", collegeData.CollegeName),
                //    new SqlParameter("@Location", collegeData.Location),
                //    new SqlParameter("@Remarks", collegeData.Remarks),
                //    new SqlParameter("@CollegeId", collegeData.CollegeId)
                //};
                string storedProcedureName = "spColleges";
                SqlParameter[] parameters = {
                 new SqlParameter("@Option", 'u'),
                new SqlParameter("@CollegeName", collegeData.CollegeName),
                new SqlParameter("@Location", collegeData.Location),
                new SqlParameter("@Remarks", collegeData.Remarks),
                 new SqlParameter("@CollegeId", collegeData.CollegeId)
            };
                sqlHelperRepository.ExecuteNonQueryWithStoredProcedure(storedProcedureName, parameters);
            }
            catch (Exception ex)
            {
            }

        }
        public void DeleteCollegeByID(College collegeData)
        {
            //string deleteQuery = "DELETE FROM Colleges WHERE CollegeId = @CollegeId";
            //SqlParameter[] parameters = { new SqlParameter("@CollegeId", collegeData.CollegeId) };
            //sqlHelperRepository.ExecuteNonQuery(deleteQuery, parameters);

            string spName = "spColleges";
            SqlParameter[] parameters = { new SqlParameter("@Option", 'd'), 
                                          new SqlParameter("@CollegeId", collegeData.CollegeId) };
            sqlHelperRepository.ExecuteQueryWithStoredProcedure(spName, parameters);

        }
    }
}
