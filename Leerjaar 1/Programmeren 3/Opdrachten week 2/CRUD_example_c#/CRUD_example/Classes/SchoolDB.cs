using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRUD_example.Classes
{
    class SchoolDB
    {
        #region fields
        MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=school;Uid=root;Pwd=;");
        #endregion

        #region methods/functions

        public DataTable SelectStudents()
        {
            DataTable result = new DataTable();
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM student;";
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een probleem met de database");
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public DataTable ZoekStudents(string Zoekterm, string searchWord)
        {
            DataTable result = new DataTable();

            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                if (searchWord == "Voornaam")
                {
                    command.CommandText = "SELECT * FROM student where voornaam like '%" + Zoekterm + "%'";
                }
                else if(searchWord == "Achternaam")
                {
                    command.CommandText = "SELECT * FROM student where achternaam like '%" + Zoekterm + "%'";
                }
                else if(searchWord == "Klas")
                {
                    command.CommandText = "SELECT * FROM student where klas like '%" + Zoekterm + "%'";
                }
                else
                {
                    command.CommandText = "SELECT * FROM student where id = " + Zoekterm;
                }
                MySqlDataReader reader = command.ExecuteReader();
                result.Load(reader);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

            public bool InsertStudent(string firstName, string preposition, string lastName, string classValue)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "INSERT INTO `student` (`id`, `voornaam`, `tussenvoegsel`, `achternaam`, `klas`) VALUES (NULL, @firstName, @preposition, @lastName, @class) ";
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@preposition", preposition);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@class", classValue);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        public bool UpdateStudent(string id, string firstName, string preposition, string lastName,string classValue)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE `student` SET `voornaam` = @firstName, `tussenvoegsel` = @preposition, `achternaam` = @lastName, `klas` = @class WHERE `student`.`id` = @id; ";
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@preposition", preposition);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@class", classValue);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                succes = true;
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        public bool DeleteStudent(string id)
        {
            bool succes = false;
            try
            {
                _connection.Open();
                MySqlCommand command = _connection.CreateCommand();
                command.CommandText = "DELETE FROM `student` WHERE `student`.`id` = @id;";
                command.Parameters.AddWithValue("@id", id);
                int nrOfRowsAffected = command.ExecuteNonQuery();
                succes = (nrOfRowsAffected != 0);
            }
            catch (Exception)
            {
                //Problem with the database
            }
            finally
            {
                _connection.Close();
            }
            return succes;
        }

        #endregion
    }
}