using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> PeopleList = new List<Person>();
            PeopleList.Add(new Person(20, "hansraj", "munbai(MH)", 17));
            PeopleList.Add(new Person(40, "Yogesh", "Pune(MH)", 21));
            PeopleList.Add(new Person(60, "Rushikesh", "Valsad(GJ)", 61));
            PeopleList.Add(new Person(51, "prashant", "Panji(Goa)", 71));
            PeopleList.Add(new Person(40, "Rahul", "bhopal(MP)", 58));
            
            //Uc2
            foreach (Person p in PeopleList.FindAll(e => (e.age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + p.name + " Age: " + p.age);
            }

            //uc3
            Console.WriteLine("*******************************");
            Console.WriteLine("Retrive all record the list for age 13 to 18");
            foreach (Person p in PeopleList.FindAll(e => (e.age >=13 && e.age <=18)).ToList())
            {
                Console.WriteLine("Name:"+p.name);
            }
            //uc4
            Console.WriteLine("*******************************");
            Console.WriteLine("Retrieve average age in the list:");
            double Average = PeopleList.Average(e => e.age);
            Console.WriteLine("Average Age is: " + Average);
        }
    }
}