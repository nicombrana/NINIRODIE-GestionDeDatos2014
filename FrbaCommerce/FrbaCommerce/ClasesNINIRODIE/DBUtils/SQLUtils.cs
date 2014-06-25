using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FrbaCommerce.ClasesNINIRODIE.DBUtils
{
    public class SQLUtils
    {
        private static SqlConnection connection = new SqlConnection("server=.\\SQLSERVER2008; user=gd; password=gd2014; database=gd1c2014;");

        public static DataRowCollection EjecutarConsultaSimple(String selectQuery, String table)
        {
            SqlCommand command = RealizarQuery(selectQuery);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet, table);
            connection.Close();
            return dataSet.Tables[table].Rows;
        }

        private static SqlCommand RealizarQuery(String selectQuery)
        {
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            return command;
        }

        public static void EjecutarConsultaConEfectoDeLado(String insertQuery)
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
