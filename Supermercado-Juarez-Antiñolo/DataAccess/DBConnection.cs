using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    internal class DBConnection
    {
        public static DBConnection GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnection();
                }
                return instance;
            }
        }
        private static DBConnection instance = null;

        private readonly SqlConnection _connection;

        private DBConnection()
        {
            _connection = new SqlConnection("Data Source =LocalHost; Initial Catalog =Supermercado-LUG; Integrated Security = True");
        }

        private void OpenConnection()
        {
            _connection.Open();
        }

        private void CloseConnection()
        {
            _connection.Close();
        }

        public DataTable Read(string sp, SqlParameter[] parameters)
        {
            OpenConnection();

            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            sqlDataAdapter.SelectCommand = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = sp
            };

            if (parameters != null)
            {
                sqlDataAdapter.SelectCommand.Parameters.Clear();
                sqlDataAdapter.SelectCommand.Parameters.AddRange(parameters);
            }

            sqlDataAdapter.SelectCommand.Connection = _connection;

            sqlDataAdapter.Fill(dataTable);

            CloseConnection();

            return dataTable;
        }

        public bool Write(string sp, SqlParameter[] sqlParameters)
        {
            if (sqlParameters.Length is 0) return false;

            int canInsert = -1;

            OpenConnection();
            SqlTransaction transaction = _connection.BeginTransaction();
            try
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = sp,
                    Connection = _connection,
                    Transaction = transaction
                };

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddRange(sqlParameters);


                canInsert = sqlCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }

            CloseConnection();
            return canInsert is -1 ? false : true;
        }

        public bool WriteXml(string sp, string nombreArchivo, SqlParameter[] parameters = null)
        {
            bool canCreate = false;
            try
            {
                OpenConnection();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand { Connection = _connection, CommandType = CommandType.StoredProcedure, CommandText = sp };
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.Clear();
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                adapter.Fill(ds);
                ds.WriteXml(@"C:\Users\lukit\source\repos\Supermercado-TP-LUG\Supermercado-Juarez-Antiñolo\ArchivosXml\ " + nombreArchivo);
                
                canCreate = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            CloseConnection();
            return canCreate;
        }
    }
}
