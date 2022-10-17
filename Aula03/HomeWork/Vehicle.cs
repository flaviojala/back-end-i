using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer  { get; set; }

        public Vehicle(int id, string name, string manufacturer)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
        }

        public virtual string GetVehicleDetais()
        {
            return $@"Nome do Modelo: {Name}
Fabricante: {Manufacturer}";
        }


    }
}
