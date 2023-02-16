using ConsoleAppEindopdrachtDD2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfAppEindopdrachtDD2.Models
{
    internal class Database
    {
        #region Messages
        public static readonly string UNKNOWN = "Unknown";
        public static readonly string OK = "Ok";
        public static readonly string NOTFOUND = "not found";
        #endregion

        private readonly string connString = ConfigurationManager.ConnectionStrings["EindopdrachtDD2conn"].ConnectionString;
        public string CreateBioscoopuitje(BioscoopUitje bioscoopuitje)
        {
            if (bioscoopuitje == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateBioscoopuitje");
            }

            string methodResult = UNKNOWN;


            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = "INSERT INTO bioscoopuitjes (Naam, StartDatum, Doorstroom, BinnenEvent, Aanvangstijdstip, Duur, Film, Zaal, Stoel) " +
                        "VALUES (@naam, @startdatum, @doorstroom, @binnenevent, @aanvangstijdstip, @duur, @film, @zaal, @stoel)";
                    sql.Parameters.AddWithValue("@naam", bioscoopuitje.Naam);
                    sql.Parameters.AddWithValue("@startdatum", bioscoopuitje.StartDatum);
                    sql.Parameters.AddWithValue("@doorstroom", bioscoopuitje.Doorstroom);
                    sql.Parameters.AddWithValue("@binnenevent", bioscoopuitje.Binnenevent);
                    sql.Parameters.AddWithValue("@aanvangstijdstip", bioscoopuitje.AanvangsTijdstip);
                    sql.Parameters.AddWithValue("@duur", bioscoopuitje.Duur);
                    sql.Parameters.AddWithValue("@film", bioscoopuitje.Film);
                    sql.Parameters.AddWithValue("@zaal", bioscoopuitje.Zaal);
                    sql.Parameters.AddWithValue("@stoel", bioscoopuitje.Stoel);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = OK;
                    }
                    else
                    {
                        methodResult = $"Het bioscoopuitje {bioscoopuitje.Naam} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateBioscoopuitje));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return methodResult;
        }
        public string CreateMuseumuitje(MuseumUitje museumuitje)
        {
            if (museumuitje == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateMuseumuitje");
            }

            string methodResult = UNKNOWN;

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = "INSERT INTO museumuitjes (Naam, StartDatum, Doorstroom, BinnenEvent, Toegangsprijs) " +
                        "VALUES (@naam, @startdatum, @doorstroom, @binnenevent, @toegangsprijs)";
                    sql.Parameters.AddWithValue("@naam", museumuitje.Naam);
                    sql.Parameters.AddWithValue("@startdatum", museumuitje.StartDatum);
                    sql.Parameters.AddWithValue("@doorstroom", museumuitje.Doorstroom);
                    sql.Parameters.AddWithValue("@binnenevent", museumuitje.Binnenevent);
                    sql.Parameters.AddWithValue("@toegangsprijs", museumuitje.Toegangsprijs);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = OK;
                    }
                    else
                    {
                        methodResult = $"Het museumuitje {museumuitje.Naam} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateMuseumuitje));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return methodResult;
        }
        public string CreateBinnenwedstrijd(Binnenwedstrijd binnenwedstrijd)
        {
            if (binnenwedstrijd == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateBinnenwedstrijd");
            }

            string methodResult = UNKNOWN;

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = "INSERT INTO binnenwedstrijden (Naam, StartDatum, WedstrijdDuur, Doorstroom) " +
                        "VALUES (@naam, @startdatum, @wedstrijdduur, @doorstroom)";
                    sql.Parameters.AddWithValue("@naam", binnenwedstrijd.Naam);
                    sql.Parameters.AddWithValue("@startdatum", binnenwedstrijd.StartDatum);
                    sql.Parameters.AddWithValue("wedstrijdduur", binnenwedstrijd.WedstrijdDuur);
                    sql.Parameters.AddWithValue("@doorstroom", binnenwedstrijd.Doorstroom);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = OK;
                    }
                    else
                    {
                        methodResult = $"De binnenwedstrijd {binnenwedstrijd.Naam} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateBinnenwedstrijd));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return methodResult;
        }
        public string CreateBuitenwedstrijd(Buitenwedstrijd buitenwedstrijd)
        {
            if (buitenwedstrijd == null)
            {
                throw new ArgumentException("Ongeldig argument bij gebruik van CreateBuitenwedstrijd");
            }

            string methodResult = UNKNOWN;

            using (MySqlConnection conn = new(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand sql = conn.CreateCommand();
                    sql.CommandText = "INSERT INTO buitenwedstrijden (Naam, StartDatum, WedstrijdDuur, Doorstroom) " +
                        "VALUES (@naam, @startdatum, @wedstrijdduur, @doorstroom)";
                    sql.Parameters.AddWithValue("@naam", buitenwedstrijd.Naam);
                    sql.Parameters.AddWithValue("@startdatum", buitenwedstrijd.StartDatum);
                    sql.Parameters.AddWithValue("@wedstrijdduur", buitenwedstrijd.WedstrijdDuur);
                    sql.Parameters.AddWithValue("@doorstroom", buitenwedstrijd.Doorstroom);
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        methodResult = OK;
                    }
                    else
                    {
                        methodResult = $"De buitenwedstrijd {buitenwedstrijd.Naam} kon niet toegevoegd worden.";
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(nameof(CreateBuitenwedstrijd));
                    Console.Error.WriteLine(e.Message);
                    methodResult = e.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
            return methodResult;
        }
    }
}
