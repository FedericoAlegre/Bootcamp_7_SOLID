using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_7
{
    class Pez: IComer, INadar
    {
        private string especie;

        public string Especie
        {
            get
            {
                return especie;
            }
            set
            {              
                especie = value;
            }
        }

        public void Comer()
        {
            Console.WriteLine("Esta comiendo");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }
    }
}
