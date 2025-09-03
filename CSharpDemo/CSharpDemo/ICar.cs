using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    public interface ICar
    {
        string Name { get; }

        int Vin;

        string Manufacturer { get; }

        bool IsInsured;

        void Start();
    }
}
