using System;
using System.Collections;
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
    public class People : DictionaryBase,ICloneable
    {
        // private List<Person> people = new List<Person>();
        //private Dictionary<string, Person> people;
        public void Add(string newId,Person newPerson)
        {
            Dictionary.Add(newId, newPerson);
        }
        // а нужен ли Remove?
        public void Remove(string personId)
        {
            Dictionary.Remove(personId);
        }
        public People()
        {
            
        }
        public Person this[string personId]
        {
            get { return (Person)Dictionary[personId]; }
            //set {Dictionary[personId] = value; }
         
        }
        //public Person this[int personIndex]
        //{
        //    get { return (Person)List[personIndex]; }
        //    set { List[personIndex] = value; }
        //}
        //public Person this[string name]
        //{
        //    get { return people.FirstOrDefault(person => person.Name == name); }
        //}
        /* 3. Добавьте в класс People метод Getoidesto, который будет
        возвращать массив объектов Person с наибольшим значением
        свойства Age (этот массив состоит из одного и более объектов,
        поскольку значение данного свойства может оказаться одинаковым
        у нескольких элементов). Для этого воспользуйтесь перегруженными
        операторами, определенными выше.  */
        public Person[] Getoidesto(Person person)
          {
                Person[] mas = new Person[4];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = person;
                }
                Array.Sort(mas);
            if (mas[0].Age > mas[1].Age)
            {
                return mas; //???
            }
            return null;// ???
          }
        
        /* 4. Реализуйте В Классе People интерфейс ICloneable,
        который бы обеспечивал выполнение глубокого копирования. */

        public object Clone()
        {
            People clone = new People();

            return clone;        }
    }
}
