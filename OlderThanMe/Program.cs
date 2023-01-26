// See https://aka.ms/new-console-template for more information
using OlderThanMe;

Person person = new Person("Michele", 30);
Person p1 = new Person("Samuel", 24);
Person p2 = new Person("Joel", 36);
Person p3 = new Person("Lily", 30);

Person.CompareAge(person, p1);
Person.CompareAge(person, p2);
Person.CompareAge(person, p3);
Console.WriteLine("The end");
