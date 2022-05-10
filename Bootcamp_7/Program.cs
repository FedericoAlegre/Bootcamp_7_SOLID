using System;

namespace Bootcamp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("·Bootcamp 7·");
            Persona person = new Persona("fede", 44460199);
            ContraladorPersona cP = new ContraladorPersona();
            cP.p = person;
            
            Console.WriteLine(person.ToString());
            Console.WriteLine(cP.ToString());            
        }
    }
}
