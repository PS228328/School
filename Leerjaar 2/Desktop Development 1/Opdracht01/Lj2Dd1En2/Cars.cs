using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lj2Dd1En2
{
    internal class Cars
    {
        MySqlConnection _myConnection = new MySqlConnection("Server=localhost;Database=carsdb;Uid=root;Pwd=;");

        public DataTable GetAllCars()
        {
            _myConnection.Open();

            MySqlCommand command = _myConnection.CreateCommand();
            command.CommandText = "SELECT * FROM cars";
            DataTable cars = new DataTable();
            MySqlDataReader reader = command.ExecuteReader();
            cars.Load(reader);

            _myConnection.Close();
            return cars;
        }

        public void CreateCar(string merk, string jaar)
        {
            _myConnection.Open();

            MySqlCommand command = _myConnection.CreateCommand();
            command.CommandText = "INSERT INTO cars (make, yearOfIntroduction) VALUES (@make, @yearIntro)";
            command.Parameters.AddWithValue("@make", merk);
            command.Parameters.AddWithValue("@yearIntro", jaar);
            command.ExecuteNonQuery();

            _myConnection.Close();
        }

        public void DeleteCar(string id)
        {
            _myConnection.Open();

            MySqlCommand command = _myConnection.CreateCommand();
            command.CommandText = "DELETE FROM cars WHERE carId = @id";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _myConnection.Close();
        }

        public void UpdateCar(string merk, string jaar, string id)
        {
            _myConnection.Open();

            MySqlCommand command = _myConnection.CreateCommand();
            command.CommandText = "UPDATE cars SET make = @make, yearOfIntroduction = @yearIntro WHERE carId = @id";
            command.Parameters.AddWithValue("@make", merk);
            command.Parameters.AddWithValue("@yearIntro", jaar);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _myConnection.Close();
        }
    }
}
