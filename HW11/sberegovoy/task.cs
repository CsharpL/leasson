using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sberegovoy
{

    class task
    {
        static void Main(string[] args)
        {
            Task13();
        }
        #region
        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                
            }
            Console.WriteLine($"{min}");
            Console.ReadLine();
        }
        #endregion
        #region
        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int max = a[0];
            int max2 = a[1];
            /*
             if (max2 > max)
            {
                max = max2;
                max2 = a[0];
            }
            for (int i = 2; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max2 = max;
                    max = a[i];
                }
                if(max2 < a[i] && a[i] != max)
                {max2 = a[i];} 
            }*/
            if (max2 > max)
            {
                max = max2;
                max2 = a[0];
            }
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                
            }
            Console.WriteLine($"{max}");
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == max)
                    continue;
                if (max2 < a[i])
                    max2 = a[i];
            }
            Console.WriteLine($"{max2}");
            Console.ReadLine();
        }
        #endregion
        #region
        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            long res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                res += a[i];
            }
            Console.WriteLine($"{res}");
        }
        #endregion
        #region
        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int[] mas = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                mas[i-1] = i;
            }
            foreach (var item in mas)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadLine();
        }
        #endregion
        #region
        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            Random rnd = new Random();
           //случайное число от 1 до 10

            int[] mas = new int[30];
            for (int i = 0; i < mas.Length; i++)
            {
               
                mas[i] = rnd.Next(1, 104);
            }
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
        }
        #endregion
        #region
        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 6,9, 15, 19, 6 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j =i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine($"{a[i]} повторение {a[j]}");
                    }
                }
            }
            Console.ReadLine();
        }
        #endregion
        #region
        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - i -1 ] = a[i]; //9-0-1=8;9-1-1-7;9-2-1=6;9-3-1=5;9-4-1=4;9-5-1=3;9-6-1=2;9-7-1=1;9-8-1=0;
            }
            foreach (var item in a)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine(  );
            foreach (var items in b)
            {
                Console.Write($" {items}");
            }
            Console.ReadLine();

        }
        #endregion
        #region
        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 12, 13, 2, 9, 15, 19 };

            foreach (var items in a)
            {
                Console.Write($" {items}");
            }
            for (int i = 0, temp; i < a.Length /2; i++)
            {
                temp = a[i]; //12
                a[i]= a[a.Length - i-1];//19
                a[a.Length-i-1] = temp; //19
               
            }
            Console.WriteLine(  );
            foreach (var item in a)
            {
                Console.Write($" {item}");
            }
                Console.ReadLine();
        }
        #endregion
        #region
        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int colums = m.GetUpperBound(0) + 1;
            int row = m.GetUpperBound(1) + 1;
            int r = m.Length / colums;
            int res = 0;
            for (int i = 0; i < colums; i++)
            {
                for (int j = 0; j < row; j++)
                { 
                    res = res + m[i, j];
                }
            }
            Console.WriteLine(  res);
            Console.ReadKey();
        }
        #endregion
        #region
        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
            // int size = 10; для универсальности можно подставить в размерноть массива а также в циклах col =size.row=size;
            int[,] m= new int[10,10];
            Random rnd = new Random();
            
            int columns = m.GetUpperBound(0) + 1;
            int row = m.GetUpperBound(1) + 1;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    m[i, j] = rnd.Next(1,9);
                }
            }
            foreach (var item in m)

            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        #endregion
        #region
        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int[] mas= new int[m.Length];
            int columns = m.GetUpperBound(0) + 1;
            int rows = m.Length / columns; //int rows = m.GetUpperBound(1) + 1;
            int t=0;
            

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    mas[t]=m[i, j];
                    t++;
                }
            }
            foreach (var item in mas)
            {
                Console.Write($" {item}");
            }
            Console.ReadLine();
        }
        #endregion

        #region
        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            int ostatok = 4 % 2; //будет равен нулю
            int size = 3;
            int[,] m = new int[size, size];
            int columns = m.GetUpperBound(0) + 1;
            int rows = m.Length / columns;// rows = m.GetUpperBound(1) + 1;
            Random rnd = new Random();
            int k = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                     int t = (m[i, j] = rnd.Next(1, 99));
                    if (t % 2 == 0)
                    {
                        k++;
                    }
                    
                }
            }
            Console.WriteLine(k);
            foreach (var item in m)
            {
                Console.Write($" {item} \t");
            }
            Console.ReadLine();
        }
        #endregion
        #region
        ///<summary>
        ///одномерный массив скопировать в двумерный 4х4
        ///</summary>
        public static void Task13()
        {
            int[] m = new int[]{5, 6, 8, 77, 7, 2, 0, 99, 88, 44, 55, 98,67,85,41,6};
            int size = 4;
            int[,] mas = new int[size, size];           
            for (int i = 0,k=0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mas[i, j] = m[k];
                    k++;
                    Console.Write($"{mas[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        #endregion
    }
}
