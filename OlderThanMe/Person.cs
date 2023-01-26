using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlderThanMe
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name= name;
            Age= age;
        }

        public static void CompareAge(Person person1, Person person2)
        {
            if (person1.Age > person2.Age) { Console.WriteLine(person2.Name + " is younger than me"); }
            else if (person1.Age < person2.Age) { Console.WriteLine(person2.Name + " is older than me"); }
            else if (person1.Age == person2.Age) { Console.WriteLine(person2.Name + " is the same age as me"); }
            else { Console.WriteLine("Not working"); };
        }
    }
}
