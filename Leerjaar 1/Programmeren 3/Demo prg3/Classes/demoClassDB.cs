using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Demo_prg3.Classes
{
    class demoClassDB
    {
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=northwind;Uid=root;Pwd=;");

        public DataTable GetNumber()
        {
            DataTable myDataTable = new DataTable();

            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT CompanyName, ContactName, ContactTitle FROM customers WHERE ContactTitle = 'Owner'";
                MySqlDataReader reader = command.ExecuteReader();
                myDataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return myDataTable;
        }
    }
}
