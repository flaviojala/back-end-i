using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Car : Vehicle, IAction
    {
        public string Category { get; set; }
        public int Speed { get ; set; }

        public Car(int id, string name, string manufacturer, string category) : base(id, name, manufacturer)
        {
            Category = category;
        }

        public override string GetVehicleDetais()
        {
            return $@"Nome do Modelo: {Name}
Fabricante: {Manufacturer}
Categoria: {Category}";
        }

        public string GetVehicleType()
        {
            return "Veículo Terreste";
        }

        public void MoveVehicle(int speed)
        {
            Console.WriteLine($"Veículo se movendo a uma velocidade de {speed} KM/H");
        }

    }
}
