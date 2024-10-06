using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingManagementWithClassLibraryADO
{
    public class SQLHelperRepository
    {
        private SqlConnection connection;
        private readonly string connectionString;

        public SQLHelperRepository(string conneString)
        {
            connectionString = conneString;
            connection = new SqlConnection(connectionString);
        }

       
        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public DataTable ExecuteQueryWithStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure; 

                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public int ExecuteNonQueryWithStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }


    }
}
