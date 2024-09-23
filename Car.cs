using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConsole
{
    internal class Car
    {

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string License { get; set; }
        public string Date { get; set; }
        public Car(int id, string brand, string type, string license, string date)
        {
            Id = id;
            Brand = brand;
            Type = type;
            License = license;
            Date = date;
        }   
    }
}
