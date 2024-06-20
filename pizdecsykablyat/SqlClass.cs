using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizdecsykablyat
{
    internal class SqlClass
    {
        public SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KBH6SHR\\SQLEXPRESS;Initial Catalog=skyf;Integrated Security=True;Encrypt=False");

        public DataTable Commands(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");

            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
