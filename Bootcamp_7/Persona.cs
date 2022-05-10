using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_7
{
    class Persona
    {
        private string nombre;
        private int dni;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public Persona()
        {

        }

        public Persona(string n, int d)
        {
            Nombre = n;
            Dni = d;
        }
    }
}
