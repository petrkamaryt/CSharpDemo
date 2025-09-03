using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    public class Car : ICar
    {
        public Car(string manufacturer)
        {
            this.manufacturer = manufacturer;
            CarCounter++;
        }

        public static int CarCounter;

        public string Name { get; }

        public string Manufacturer { get => manufacturer; }

        public int Vin;

        public string Color;

        public bool IsInsured;

        private string manufacturer;

        public bool Start()
        {
            DoSomething();
            return true;
        }

        private void DoSomething()
        {
            //bla bla....
        }

        public static bool DoSomethingElse()
        {
            //bla bla
            return true;
        }
    }
}
