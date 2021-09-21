using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Add(new Person("pop", 21));
            people.Add(new Person("lol2",24));

             Console.WriteLine($"{people[0].Name}, {people[1].Name}");
           
            // перегрзуки опер
            Person oper = new Person("PET",30);
            Person oper2 = new Person("Telo", 35);
            Console.WriteLine($"result false = {oper > oper2}");
            Console.WriteLine($"result true = {oper < oper2}");
            Console.WriteLine($"result false = {oper >= oper2}");
            Console.WriteLine($"result true = {oper <= oper2}");
            Console.ReadLine();
            
        }
        
            
    }

}
