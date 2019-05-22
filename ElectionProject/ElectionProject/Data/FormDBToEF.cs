using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionProject.Data
{
    public static class FormDBToEF
    {
        //public DataTable getInfoFromDB(string tableTame, string connectionString)
        public static DataTable getInfoFromDB()
        {
            var connectionString = "Host=localhost;Port=5432;Database=Election;Username=postgres;Password=123";
              // var selectAllInfo = $"Select * from {tableTame}";
              var selectAllInfo = "Select * from Election";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(selectAllInfo, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        var readedData = reader.GetSchemaTable();
                        return readedData;
                    }

                }
            }

            return new DataTable();
        }
    }
}
