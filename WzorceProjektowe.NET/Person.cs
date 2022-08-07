using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.NET
{
    class Person
    {
        //Pola
        public string Name;


        public Person( string Name)
        {
            this.Name = Name;
        }


        public void SayHi()
        {
            Console.WriteLine("Cześć, nazwym się: " + this.Name);
        }

    }
}
