using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Создайте класс семейства People (люди), который
представляет собой семейство класса Person (лицо),
приведенного ниже. Доступ к элементам семейства должен быть
организован через строковый индексатор, являющийся именем лица,
КОТОрОе ИДенТИЧНО СВОЙСТВУ Person.Name:*/
namespace HW11
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person()
        {

        }
        /* перегрузка 
2. Расширьте класс Person из предыдущего упражнения,
перегрузив операторы >, <, >= и <= так, чтобы они
выполняли сравнение свойств Age экземпляров класса person.
    */
        public static bool operator >(Person p1, Person p2)
        {
            return (p1.Age > p2.Age);
        }
        public static bool operator <(Person p1, Person p2)
        {
            return !(p1.Age > p2.Age);
        }
        public static bool operator >=(Person p1,Person p2) 
        {
            return (p1.Age >= p2.Age);
        }
        public static bool operator <=(Person p1, Person p2)
        {
            return !(p1.Age >= p2.Age);
        }
        
    }
}
