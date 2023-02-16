using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppTake5_
{
    class csTake5
    {
        MySqlConnection _myconnection = new MySqlConnection("Server=localhost;Database=take5;Uid=root;Pwd=;");

        public bool NewGameOrResume()
        {
            bool startorresume;
            DataTable gip = new DataTable();

            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM gameinprogress"; //Haal alles op
                MySqlDataReader reader = command.ExecuteReader();
                gip.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }

            if (gip.Rows[0]["Progress"].ToString() == "0")
            {
                startorresume = false;
            }
            else
            {
                startorresume = true;
            }

            return startorresume;
        }

        public DataTable haalAlleKaartenOp()
        {
            DataTable kaarten = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM kaarten";
                MySqlDataReader reader = command.ExecuteReader();
                kaarten.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return kaarten;
        }

        public void UpdateProgress(string result)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                if (result == "1")
                {
                    command.CommandText = "UPDATE `gameinprogress` SET `Progress`= 0";
                    MySqlCommand command2 = _myconnection.CreateCommand();
                    command2.CommandText = "DELETE FROM kaarten";
                    command2.ExecuteNonQuery();

                    MySqlCommand command3 = _myconnection.CreateCommand();
                    command3.CommandText = "DELETE FROM kaartstatistieken";
                    command3.ExecuteNonQuery();

                    MySqlCommand command4 = _myconnection.CreateCommand();
                    command4.CommandText = "UPDATE tafel SET Kaart1 = NULL, Kaart2 = NULL, Kaart3 = NULL, Kaart4 = NULL, Kaart5 = NULL, Kaart6 = NULL";
                    command4.ExecuteNonQuery();
                }
                else
                {
                    command.CommandText = "UPDATE `gameinprogress` SET `Progress`= 1";
                }
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void GenerateCards(int cardNR)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "INSERT INTO kaarten (kaartnummer) VALUES (@cardNR)";
                command.Parameters.AddWithValue("@cardNR", cardNR);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void CreatePlayer(int playerNR)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "INSERT INTO kaartstatistieken (Speler, Strafpunten) VALUES (@playerNR, 0)";
                command.Parameters.AddWithValue("@playerNR", playerNR);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void GiveCardToPlayer(int cardNR, int playerNR, string cardTake5)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "UPDATE kaartstatistieken SET Kaart" + cardNR + " = @cardTake5 WHERE Speler = @playerNR";
                command.Parameters.AddWithValue("@playerNR", playerNR);
                command.Parameters.AddWithValue("@cardTake5", cardTake5);
                command.ExecuteNonQuery();

                MySqlCommand command2 = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM kaarten WHERE Kaartnummer = @cardTakeS";
                command.Parameters.AddWithValue("@cardTakeS", cardTake5);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void kaartenOpTafel(int kaart, int id)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "UPDATE tafel SET kaart1 = @cardNR WHERE Rijnummer = @id";
                command.Parameters.AddWithValue("@cardNR", kaart);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                MySqlCommand command2 = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM kaarten WHERE Kaartnummer = @cardTakeS";
                command.Parameters.AddWithValue("@cardTakeS", kaart);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public DataTable haalSpeelgegevensOpVanEenSpeler(int player)
        {
            DataTable speelgegevens = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM kaartstatistieken WHERE Speler = @player";
                command.Parameters.AddWithValue("@player", player);
                MySqlDataReader reader = command.ExecuteReader();
                speelgegevens.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return speelgegevens;
        }

        public int UpdateKaarten(int spelersnr, int kaart)
        {
            int cijfer = 0;
            DataTable table = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command2 = _myconnection.CreateCommand();
                command2.CommandText = "SELECT Kaart" + kaart + " FROM kaartstatistieken WHERE Speler = @player";
                command2.Parameters.AddWithValue("@player", spelersnr);
                MySqlDataReader reader = command2.ExecuteReader();
                table.Load(reader);

                cijfer = Int32.Parse(table.Rows[0]["Kaart" + kaart].ToString());

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "UPDATE kaartstatistieken SET Kaart" + kaart + " = NULL WHERE Speler = @player";
                command.Parameters.AddWithValue("@player", spelersnr);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return cijfer;
        }
    }
}
