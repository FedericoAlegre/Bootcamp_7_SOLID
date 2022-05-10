using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_7
{
    class ContraladorPersona: IComer, ICaminar
    {
        public Persona p = new Persona();

        public override string ToString()
        {
            return $"Nombre: {p.Nombre}\nDNI: {p.Dni}";
        }

        public void Comer()
        {
            Console.WriteLine("Esta comiendo");
        }
        public void Caminar()
        {
            Console.WriteLine("Caminando");
        }

    }
}
