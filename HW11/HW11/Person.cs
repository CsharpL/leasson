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
КОТОрОе ИДенТИЧНО СВОЙСТВУ Person.Name:
2. Расширьте класс Person из предыдущего упражнения,
перегрузив операторы >, <, >= и <= так, чтобы они
выполняли сравнение свойств Age экземпляров класса person.
3. Добавьте в класс People метод Getoidesto, который будет
возвращать массив объектов Person с наибольшим значением
свойства Age (этот массив состоит из одного и более объектов,
поскольку значение данного свойства может оказаться одинаковым
у нескольких элементов). Для этого воспользуйтесь перегруженными
операторами, определенными выше.
4. Реализуйте В Классе People интерфейс ICloneable,
который бы обеспечивал выполнение глубокого копирования.
*/
namespace HW11
{
    
    /* 1. Создайте класс семейства People (люди), который
представляет собой семейство класса Person (лицо),
приведенного ниже. Доступ к элементам семейства должен быть
организован через строковый индексатор, являющийся именем лица,
КОТОрОе ИДенТИЧНО СВОЙСТВУ Person.Name:*/
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
        //добавил ctor
        //public Person(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}
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
