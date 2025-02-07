using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string FavoriteColor { get; set; }

        public Person(string name, int age, string favoriteColor)
        {
            Name = name;
            Age = age;
            FavoriteColor = favoriteColor;
        }
    }

    public class Tools
    {
        public static void Greet(Person person)
        {
            Console.WriteLine($"Hi, my name is {person.Name}, I am {person.Age} years old, and my favorite color is {person.FavoriteColor}.");
        }
    }
}
