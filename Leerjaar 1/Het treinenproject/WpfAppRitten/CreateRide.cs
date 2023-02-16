using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppRitten
{
    class CreateRide
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
        public DataTable HaalEenStationOp(int stadnr)
        {
            DataTable station = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM stations WHERE Stationsnummer = '" + stadnr + "'";
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

        public DataTable HaalEenStationOpString(string stad)
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

        public DataTable Lijnen()
        {
            DataTable lijnen = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM lijnen";
                MySqlDataReader reader = command.ExecuteReader();
                lijnen.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return lijnen;
        }

        public DataTable HaalEenLijnOp(int nummer)
        {
            DataTable lijnen = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM lijnen WHERE Lijnnummer = " + nummer;
                MySqlDataReader reader = command.ExecuteReader();
                lijnen.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return lijnen;
        }

        public void Createride(int lijnnummer, int begin, int eind, string tijd, string trein)
        {
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO ritten (Lijnnummer, Beginpunt, Eindpunt, Vertrektijd, Trein) VALUES (" + lijnnummer + ", " + begin +", " + eind + ", '" + tijd + "', '" + trein + "')";
                command.ExecuteNonQuery();
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
