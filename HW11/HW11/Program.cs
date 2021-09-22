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
            Person person = new Person{Name = "toly",Age = 39};
            Person person2 = new Person{Name = "sasha",Age = 34};
            Person person3 = new Person{Name = "dima",Age = 32};
            Person person4 = new Person();
            person4.Name = "sergey";
            person4.Age = 42;

            People people = new People();
            people.Add("toly", person);
            people.Add("sasha", person2);
            people.Add("dima", person3);
            people.Add("serg", person4);
            Person result = people["serg"];
            Console.WriteLine(result.Name + result.Age);
            //foreach ( pers in people)
            //{
            //    Console.WriteLine($"{pers} ");
            //}

            // перегрзуки опер
            //people.GetPeople()


            //Console.WriteLine($"result true = {person > person2}");
            //Console.WriteLine($"result false = {person < person2}");
            //Console.WriteLine($"result true = {person >= person2}");
            //Console.WriteLine($"result false = {person <= person2}");
            Console.ReadLine();   
        }
    }

}
