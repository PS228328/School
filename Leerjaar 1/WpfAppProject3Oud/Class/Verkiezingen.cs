using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppProject3.Class
{
    class Verkiezingen
    {
        MySqlConnection _myconnection = new MySqlConnection("Server=localhost;Database=verkiezingenprj3;Uid=root;Pwd=;");

        /*Deze class heeft een vaste structuur voor elk window.
        Eerst komen 5 eventHandlers voor de partijen-window, in de volgorde: Haal ze allemaal op, haal alleen degene op met
        het ingevulde zoekwoord. Daarna komt de delete, daarna de update, en tot slot de create.

        Daarna zul je dit nog eens tegenkomen voor de thema-window, en tot slot voor de standpunten-window
        */

        public DataTable HaalAllePartijenOp()
        {
            DataTable partijen = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM partij"; //Haal alles op
                MySqlDataReader reader = command.ExecuteReader();
                partijen.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return partijen;
        }

        public DataTable HaalPartijenOpMetZoekwoord(string zoekop, string zoekwoord)
        {
            //Deze werkt hetzelfde als de eventhandler hierboven
            //maar hier worden alleen de partijen opgehaald met het zoekwoord

            DataTable partijen = new DataTable();

            //De string zoekop is hetgeen waarop gezocht moet worden
            //(dit kan de naam, adres, postcode etc. zijn, afhankelijk wat de gebruiker selecteert)

            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM partij WHERE " + zoekop + " like CONCAT('%', @zoekwoord, '%')"; 
                command.Parameters.AddWithValue("@zoekop", zoekop);
                command.Parameters.AddWithValue("@zoekwoord", "%" + zoekwoord + "%");

                MySqlDataReader reader = command.ExecuteReader();
                partijen.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return partijen;
        }

        public void DeleteEenPartij(int id)
        {
            try
            {
                _myconnection.Open();

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM partij WHERE partij_id = @id"; //Haal de partij weg met het meegegeven id
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                MessageBox.Show("De partij is verwijderd!");
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

        public void WijzigEenPartij(int id, string naam, string adres, string postcode, string gemeente, string email, string telefoonnr)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "UPDATE partij SET naam = @naam, adres = @adres, postcode = @postcode, gemeente = @gemeente, emailadres = @email, telefoonnummer = @tel WHERE partij_id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@naam", naam);
                command.Parameters.AddWithValue("@adres", adres);
                command.Parameters.AddWithValue("@postcode", postcode);
                command.Parameters.AddWithValue("@gemeente", gemeente);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@tel", telefoonnr); //Alles word hier gewijzigd met degene van het meegegeven id
                command.ExecuteNonQuery();
                MessageBox.Show("De partij is gewijzigd!");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void CreatePartij(string naam, string adres, string postcode, string gemeente, string email, string telefoonnr)
        {
            //Maak een nieuwe partij aan, het id is auto-increment
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "INSERT INTO partij (naam, adres, postcode, gemeente, emailadres, telefoonnummer) VALUES (@naam, @adres, @postcode, @gemeente, @email, @tel)";
                command.Parameters.AddWithValue("@naam", naam);
                command.Parameters.AddWithValue("@adres", adres);
                command.Parameters.AddWithValue("@postcode", postcode);
                command.Parameters.AddWithValue("@gemeente", gemeente);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@tel", telefoonnr);
                command.ExecuteNonQuery();
                MessageBox.Show("De partij is aangemaakt! Je word doorgestuurd naar de standpunten");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        //Dit waren 5 eventhandlers voor de partijen, de aankomende 5 doen hetzelfde, maar dan voor de themas

        public DataTable HaalAlleThemasOp()
        {
            DataTable themas = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM thema"; //Haal alles op
                MySqlDataReader reader = command.ExecuteReader();
                themas.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return themas;
        }

        public DataTable HaalThemasOpMetZoekwoord(string zoekwoord)
        {
            DataTable themas = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM thema WHERE thema like CONCAT('%', @zoekwoord, '%')";
                command.Parameters.AddWithValue("@zoekwoord", "%" + zoekwoord + "%");
                //Haal alles op met de zoekfunctie
                MySqlDataReader reader = command.ExecuteReader();
                themas.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return themas;
        }

        public void DeleteEenThema(int id)
        {
            try
            {
                _myconnection.Open();

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM thema WHERE thema_id = @id"; //Haal het thema weg met het meegegeven id
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Het thema inclusief standpunten met dit thema is verwijderd!");
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

        public void WijzigEenThema(string thema, int id)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "UPDATE thema SET thema = @thema WHERE thema_id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@thema", thema); //Alles word hier gewijzigd
                command.ExecuteNonQuery();
                MessageBox.Show("Het thema is gewijzigd!");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void CreateThema(string naam)
        {
            //Maak een nieuw thema aan
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "INSERT INTO thema (thema) VALUES (@naam)";
                command.Parameters.AddWithValue("@naam", naam);
                command.ExecuteNonQuery();
                MessageBox.Show("Het thema is aangemaakt!");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        //De volgende 5 zijn voor de standpunten

        public DataTable HaalAlleStandpuntenOp()
        {
            DataTable standpunten = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT s.standpunt_id, t.thema, s.standpunt FROM standpunt s INNER JOIN thema t ON s.thema_id = t.thema_id"; //Haal alles op met inner join zodat er inplaats van een thema_id een thema komt te staan
                MySqlDataReader reader = command.ExecuteReader();
                standpunten.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return standpunten;
        }

        public DataTable HaalAlleStandpuntenOp2()
        {
            DataTable standpunten = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM standpunt";
                MySqlDataReader reader = command.ExecuteReader();
                standpunten.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return standpunten;
        }

        public DataTable HaalStandpuntOpMetZoekwoord(string zoekwoord)
        {
            DataTable standpunten = new DataTable();
            try
            {
                // command.CommandText = "SELECT * FROM thema WHERE thema like CONCAT('%', @zoekwoord, '%')";
                // command.Parameters.AddWithValue("@zoekwoord", "%" + zoekwoord + "%");
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT s.standpunt_id, t.thema, s.standpunt FROM standpunt s INNER JOIN thema t ON s.thema_id = t.thema_id WHERE t.thema = @zoekwoord"; //Haal alles op met de zoekfunctie
                command.Parameters.AddWithValue("@zoekwoord", zoekwoord);
                MySqlDataReader reader = command.ExecuteReader();
                standpunten.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return standpunten;
        }

        public void DeleteEenStandpunt(int id)
        {
            try
            {
                _myconnection.Open();

                MySqlCommand command2 = _myconnection.CreateCommand();
                command2.CommandText = "DELETE FROM partij_standpunt WHERE standpunt_id = @id"; //Haal het standpunt weg met het meegegeven id
                command2.Parameters.AddWithValue("@id", id);
                command2.ExecuteNonQuery();

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM standpunt WHERE standpunt_id = @id"; //Haal het standpunt weg met het meegegeven id
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                MessageBox.Show("Het standpunt is verwijderd!");
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

        public void WijzigEenStandpunt(int id, int thema, string standpunt)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "UPDATE standpunt SET thema_id = @thema, standpunt = @standpunt WHERE standpunt_id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@standpunt", standpunt);
                command.Parameters.AddWithValue("@thema", thema); //Alles word hier gewijzigd
                command.ExecuteNonQuery();
                MessageBox.Show("Het standpunt en thema zijn gewijzigd!");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void CreateStandpunt(int themaid, string standpunt)
        {
            //Maak een nieuw standpunt aan
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "INSERT INTO standpunt (thema_id, standpunt) VALUES (@id, @standpunt)";
                command.Parameters.AddWithValue("@id", themaid);
                command.Parameters.AddWithValue("@standpunt", standpunt);
                command.ExecuteNonQuery();
                MessageBox.Show("Het standpunt is aangemaakt! Je word doorgestuurd naar de pagina waar partijen aan kunnen geven of ze het hiermee eens zijn of niet");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public DataTable HaalAlleStemmenOp()
        {
            DataTable stem = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM stem";
                MySqlDataReader reader = command.ExecuteReader();
                stem.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
            return stem;
        }

        //We moeten het ID ophalen van een aangemaakte partij, omdat deze partij bij ieder standpunt dingen aan moet geven
        public DataTable HaalIDvanEenPartijOp(string idPartij)
        {
            DataTable id = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT partij_id FROM partij WHERE partij_id = @id";
                command.Parameters.AddWithValue("@id", idPartij);
                MySqlDataReader reader = command.ExecuteReader();
                id.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. Mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }

            return id;
        }

        public DataTable HaalIDvanEenStandpuntOp(string idPartij)
        {
            DataTable id = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT standpunt_id FROM standpunt WHERE standpunt_id = @id";
                command.Parameters.AddWithValue("@id", idPartij);
                MySqlDataReader reader = command.ExecuteReader();
                id.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. Mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }

            return id;
        }

        public DataTable HaalPartijStandpuntOp()
        {
            DataTable themas = new DataTable();
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "SELECT * FROM partij_standpunt"; //Haal alles op
                MySqlDataReader reader = command.ExecuteReader();
                themas.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _myconnection.Close();
            }
            return themas;
        }

        public void AddMeningVanPartij(string standpuntid, string partijid, string mening)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "INSERT INTO partij_standpunt (standpunt_id, partij_id, mening) VALUES (@stid, @ptid, @mening)";
                command.Parameters.AddWithValue("@stid", standpuntid);
                command.Parameters.AddWithValue("@ptid", partijid);
                command.Parameters.AddWithValue("@mening", mening);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database. mogelijk heb je ergens een ongeldige waarde ingevuld");
            }
            finally
            {
                _myconnection.Close();
            }
        }

        public void VerwijderStandpuntVanEenThema(string id)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM partij_standpunt WHERE standpunt_id = @id";
                command.Parameters.AddWithValue("@id", id);
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

        public void VerwijderStandpuntVanStemmen(string id)
        {
            try
            {
                _myconnection.Open();
                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM stem WHERE standpunt_id = @id";
                command.Parameters.AddWithValue("@id", id);
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

        public void VerwijderStandpuntMetThema(int id)
        {
            try
            {
                _myconnection.Open();

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM standpunt WHERE thema_id = @id"; //Haal het standpunt weg met het meegegeven id
                command.Parameters.AddWithValue("@id", id);
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

        public void VerwijderPartijUitStandpunt(int id)
        {
            try
            {
                _myconnection.Open();

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM partij_standpunt WHERE partij_id = @id"; //Haal de partij weg met het meegegeven id
                command.Parameters.AddWithValue("@id", id);
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

        public void VerwijderPartijUitVerkiezing(int id)
        {
            try
            {
                _myconnection.Open();

                MySqlCommand command = _myconnection.CreateCommand();
                command.CommandText = "DELETE FROM partij_verkiezing WHERE partij_id = @id"; //Haal de partij weg met het meegegeven id
                command.Parameters.AddWithValue("@id", id);
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
    }
}
