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
            Person person = new Person();
            person.Name = "toly";
            person.Age = 39;
            People people = new People();
            people.Add("toly", person);
            Person result = people["toly"];
            Console.WriteLine(result.Name);
            
            
            

            // перегрзуки опер
            
            //Person person2 = new Person();
            //person2.Name = "sasha";
            //person2.Age = 34;
            //Console.WriteLine($"result true = {person > person2}");
            //Console.WriteLine($"result false = {person < person2}");
            //Console.WriteLine($"result true = {person >= person2}");
            //Console.WriteLine($"result false = {person <= person2}");
            Console.ReadLine();   
        }
    }

}
