using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppCreateTrainLines
{
    class HaalStationsOp
    {
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=treinen;Uid=root;Pwd=;");
        public DataTable Stations()
        {
            DataTable stations = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM stations";
                MySqlDataReader reader = command.ExecuteReader();
                stations.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return stations;
        }
        public DataTable HaalEenStationOp(string stad)
        {
            DataTable station = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM stations WHERE Stad = '" + stad + "'";
                MySqlDataReader reader = command.ExecuteReader();
                station.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return station;
        }
        public int CreateLine(int stationsnr, string spoor)
        {
            int lijnnummer = 0;
            try
            {
                _connection.Open();
                DataTable myLines = new DataTable();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO lijnen (S1, Sp1) VALUES ('"+ stationsnr +"', '" + spoor + "')";
                command.ExecuteNonQuery();

                MySqlCommand command2 = _connection.CreateCommand();
                command2.CommandText = "SELECT * FROM lijnen ORDER BY Lijnnummer DESC";
                MySqlDataReader reader = command2.ExecuteReader();
                myLines.Load(reader);

                lijnnummer = Convert.ToInt32(myLines.Rows[0]["Lijnnummer"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return lijnnummer;
        }
        public void UpdateSomething(TextBox myBox, int stopteller, int lijnnr, int tijd, string spoor)
        {
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();

                if (myBox.Name == "tbStad" || myBox.Name == "tbEindstation")
                {
                    _connection.Close();
                    DataTable station = HaalEenStationOp(myBox.Text);
                    _connection.Open();
                    int stationsnr = Int32.Parse(station.Rows[0]["Stationsnummer"].ToString());
                    command.CommandText = "UPDATE lijnen SET S" + stopteller + " = '" + stationsnr + "' WHERE Lijnnummer = '" + lijnnr + "'";
                    command.ExecuteNonQuery();
                }
                else if (myBox.Name == "tbAankomst" || myBox.Name == "tbEindAankomsttijd")
                {
                    command.CommandText = "UPDATE lijnen SET A" + stopteller + " = '" + tijd + "' WHERE Lijnnummer = '" + lijnnr + "'";
                    command.ExecuteNonQuery();
                }
                else if (myBox.Name == "tbVertrek")
                {
                    command.CommandText = "UPDATE lijnen SET V" + stopteller + " = '" + tijd + "' WHERE Lijnnummer = '" + lijnnr + "'";
                    command.ExecuteNonQuery();
                }
                else if (myBox.Name == "tbSpoor" || myBox.Name == "tbEindSpoor")
                {
                    command.CommandText = "UPDATE lijnen SET Sp" + stopteller + " = '" + spoor + "' WHERE Lijnnummer = '" + lijnnr + "'";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
