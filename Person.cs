using System;
using System.Collections.Generic;

namespace cSharpIntermediate
{
    public class Person
    {
        public string Name;
        public int Id;
        public List<string> Orders;

        public Person()
        {
            this.Orders = new List<string>();
        }

        public Person(int id) : this()
        {
            this.Id = id;
        }
        public void Introduce(string to)
        {
            
            Console.WriteLine($"HI {to} I am {Name}");
            //Hi Test
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
}
