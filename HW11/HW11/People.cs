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
    public class People : CollectionBase, ICloneable
    {
        //private List<Person> people = new List<Person>();
        public void Add(Person newPerson)
        {
            List.Add(newPerson);
        }
        public void Remove(Person oldPerson)
        {
            List.Remove(oldPerson);
        }
        public People() { }
        public Person this[int personIndex]
            {
            get { return (Person)List[personIndex]; }
            set { List[personIndex] = value; }
            }
        /* 3. Добавьте в класс People метод Getoidesto, который будет
возвращать массив объектов Person с наибольшим значением
свойства Age (этот массив состоит из одного и более объектов,
поскольку значение данного свойства может оказаться одинаковым
у нескольких элементов). Для этого воспользуйтесь перегруженными
операторами, определенными выше.  */
      /*  Person[] Getoidesto()
        {
            return Person[];
        }
      */
/* 4. Реализуйте В Классе People интерфейс ICloneable,
который бы обеспечивал выполнение глубокого копирования. */
         
        public object Clone()
        {
            People clone = new People();

            return clone;        }
    }
}
