using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppTreinenProject
{
    class HaalOp
    {
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=treinen;Uid=root;Pwd=;");
        public DataTable HaalStationsOp()
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
        public int HaalEenStationOp(string stad)
        {
            DataTable station = new DataTable();
            int stationsnummer = 0;
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM stations WHERE Stad = '" + stad + "'";
                MySqlDataReader reader = command.ExecuteReader();
                station.Load(reader);

                stationsnummer = Convert.ToInt32(station.Rows[0]["Stationsnummer"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return stationsnummer;
        }

        public string HaalEenStationOp2(string stadsnummer)
        {
            DataTable station = new DataTable();
            string stationnaam = "";
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM stations WHERE Stationsnummer = '" + stadsnummer + "'";
                MySqlDataReader reader = command.ExecuteReader();
                station.Load(reader);

                stationnaam = station.Rows[0]["Stad"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
            return stationnaam;
        }

        public DataTable HaalAlleLijnenOp()
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

        public DataTable HaalEenLijnOp(string lijnnummer)
        {
            DataTable lijnen = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM lijnen WHERE Lijnnummer = " + lijnnummer;
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

        public DataTable HaalRittenVanEenLijnOp(string lijnnummer)
        {
            DataTable ritten = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM ritten WHERE Lijnnummer = '" + lijnnummer + "'";
                MySqlDataReader reader = command.ExecuteReader();
                ritten.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return ritten;
        }

        public DataTable HaalAlleRittenOp()
        {
            DataTable ritten = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM ritten";
                MySqlDataReader reader = command.ExecuteReader();
                ritten.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return ritten;
        }

        public DataTable HaalEenRitOp(int nummer)
        {
            DataTable rit = new DataTable();
            try
            {
                _connection.Open();

                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM ritten WHERE Ritnummer = " + nummer;
                MySqlDataReader reader = command.ExecuteReader();
                rit.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return rit;
        }
    }

}
