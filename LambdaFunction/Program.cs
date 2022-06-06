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
            
        }
    }
}