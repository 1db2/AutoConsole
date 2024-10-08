﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConsole
{
    internal class Program
    {
        public static List<Car> carList = new List<Car>();

        static Connection conn = new Connection();

        public static void feladat1()
        {
            conn.connection.Open();

            string sql = "SELECT * FROM `cars`";
            MySqlCommand cmd = new MySqlCommand(sql, conn.connection);

            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            do
            {
                Car car = new Car(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
                carList.Add(car);
            } while (dr.Read());
            

            conn.connection.Close();
        }
        static void Main(string[] args)
        {
            feladat1();
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Type}, {car.Brand}");

            }
        }
    }
}
