using System;

namespace WzorceProjektowe.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jan");

            person.SayHi();
            //Console.WriteLine(person.Name);

            Console.ReadLine();
        }
    }
}
