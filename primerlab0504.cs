using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab504_task1
{
    class Program
    {
        static void selection()
        {
            Clear();
            Computer();
            Console.WriteLine(" Для того чтобы выбрать  задачу нажмите ниже соответствующей ей номер (1-8)");
            User();
            int i0 = int.Parse(Console.ReadLine());
            switch (i0)
            {
                case 1:
                    { Task1(); break; }
                case 2:
                    { Task2(); break; }
                case 3:
                    { Task3(); break; }
                case 4:
                    { Task4(); break; }
                case 5:
                    { Task5(); break; }
                case 6:
                    { Task6(); break; }
                case 7:
                    { Task7(); break; }
                case 8:
                    { Task8(); break; }
                default: { Computer(); Console.WriteLine("Произошла ошибка. Повторите команду."); break; }
            }
        }

        static void Computer()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("COMPUTER: ");
            Console.ResetColor();
        }
        static void User()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("USER: ");
            Console.ResetColor();
        }
        static void Clear()
        {
            Console.Clear();
        }

        static void Nonegative(int[] a)
        {
            int count = 0;
            for (int i3 = 0; i3 < a.Length; i3++)
            {
                int mark;
                mark = Math.Sign(a[i3]);
                if (mark == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Кол-во положительных чисел = " + count);
        }
        static void SumNeg(int[] a)
        {
            int count = 0;
            for (int i4 = 0; i4 < a.Length; i4++)
            {
                int mark2;
                mark2 = Math.Sign(a[i4]);
                if (mark2 == -1)
                {
                    count = count + a[i4];
                }
            }
            Console.WriteLine("Сумма отрицательных чисел = " + count);
        }
        static void MinNeg(int[] a)
        {
            int rez = 0;
            int mark3;
            for (int i5 = 0; i5 < a.Length; i5++)
            {
                mark3 = Math.Sign(a[i5]);
                if (mark3 == -1)
                {
                    if (a[i5] < rez)
                    {
                        rez = a[i5];
                    }
                }
            }
            Console.WriteLine("Самое минимальное отрицательное число = " + rez);
        }
        static void SpecOutput(int[] a)
        {
            Console.WriteLine("Вывод элементов с нечетными номерами");
            for (int i6 = 0; i6 < a.Length; i6++)
            {
                if (i6 % 2 != 0)
                {
                    Console.WriteLine("a[" + i6 + "] = " + a[i6]);
                }
            }
        }
        static void Swapper(int lngth)
        {
            Random rand2 = new Random();
            int[] a2 = new int[lngth];
            for (int i7 = 0; i7 < lngth; i7++)
            {
                a2[i7] = rand2.Next(-10, 11);
            }
            Computer();
            Console.WriteLine("Созданный массив: ");
            Console.Write("                           ");
            for (int i701 = 0; i701 < lngth; i701++)
            {
                Console.Write(" " + a2[i701] + " ");
            }
            Console.WriteLine();
            Computer();
            if (lngth % 2 != 0)
            {
                for (int i703_1 = 1; i703_1 < lngth - 1; i703_1 = i703_1 + 2)
                {
                    int x = a2[i703_1 - 1];
                    a2[i703_1 - 1] = a2[i703_1];
                    a2[i703_1] = x;
                }
            }
            else
            {
                for (int i703_2 = 1; i703_2 < lngth; i703_2 = i703_2 + 2)
                {
                    int x = a2[i703_2 - 1];
                    a2[i703_2 - 1] = a2[i703_2];
                    a2[i703_2] = x;
                }
            }
            Console.WriteLine("Новый массив: ");
            Console.Write("                           ");
            for (int i702 = 0; i702 < lngth; i702++)
            {
                Console.Write(" " + a2[i702] + " ");
            }
            Console.WriteLine();
        }
        static void MergeSort(int[] a, int[] b, int[] result)
        {
            int pos = 0;
            int l = 0;
            int r = 0;
            for (; l < a.Length && r < b.Length;)
            {
                if (a[l] == b[r])
                {
                    result[pos++] = a[l++];
                    result[pos++] = b[r++];
                }
                else
                    if (a[l] < b[r])
                {
                    result[pos++] = a[l++];
                }
                else
                    result[pos++] = b[r++];
            }
            if (l == a.Length)
                for (; r < b.Length;)
                    result[pos++] = b[r++];
            else
                for (; l < a.Length;)
                    result[pos++] = a[l++];
        }
        static void MiddleValue(int[,] a, int m, int n)
        {
            // поиск количетства нечетных чисел
            int k = m*n;
            int sum = 0;
            foreach(int x in a)
            {
                if (x % 2 != 0)
                {
                    sum += x;
                }
                else
                {
                    --k;
                }
            }
            double middle_value = (double)sum / k;
            Computer();
            Console.WriteLine("Среднее значение среди нечетных чисел = " + middle_value);
        }
        static void antialiasing(int[,] a, double[,] b, int m,int n )
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                i++;
                for (int j = 0; j < n; j++)
                { 
                
                }
            }
        }

        static void Task1()
        {
            Console.Clear();
            Computer();
            Console.WriteLine("Создать массив из 15 элементов, заполненный случайными числами в диапазоне от - 100 до 100. Разработать методы:");
            Computer();
            Console.WriteLine("1- расчета количества неотрицательных чисел,");
            Computer();
            Console.WriteLine("2- расчета суммы отрицательных чисел,");
            Computer();
            Console.WriteLine("3- нахождения номера минимального отрицательного числа,");
            Computer();
            Console.WriteLine("4- вывода элементов с нечетными номерами по формату: a[i] = x(i – номер элемента, х – значение).");
            Computer();
            int[] a = new int[15];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-100, 101);
            }
            Console.WriteLine("Coзданный массив: ");
            Console.Write("                           ");
            for (int i2 = 0; i2 < a.Length; i2++)
            {
                Console.Write("" + a[i2] + " ");
            }
            Console.WriteLine();


            Nonegative(a);
            SumNeg(a);
            MinNeg(a);
            SpecOutput(a);

            Computer();
            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }

        }
        static void Task2()
        {
            Computer();
            Console.WriteLine("Переставьте соседние элементы массива (0 - й элемент поменять с 1 - м, 2 - й с 3 - м и т.д.Если элементов нечетное число, то последний элемент остается на своем месте).");
            Computer();
            Console.WriteLine("Введите размерность массива");
            User();
            int lengthA2 = int.Parse(Console.ReadLine());
            Swapper(lengthA2);


            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Task3()
        {
            int[] a = { 1, 4, 6, 7 };
            Computer();
            Console.WriteLine("Массив А: ");
            for (int i2=0; i2<a.Length; i2++)
            {
                Console.Write(" " + a[i2] + " ");
            }
            int[] b = { 2, 3, 5 };
            Console.WriteLine();
            Computer();
            Console.WriteLine("Массив B: ");
            for (int i3 = 0; i3 < b.Length; i3++)
            {
                Console.Write(" " + b[i3] + " ");
            }
            int[] result = new int[a.Length + b.Length];
            MergeSort(a, b, result);
            Console.WriteLine();
            Computer();
            Console.WriteLine("Массив C: ");
            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString()).ToArray()));



            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Task4()
        {
            int m;
            int n;
            User();
            Console.Write("M= ");
             m = int.Parse(Console.ReadLine());
            User();
            Console.Write("N= ");
             n  = int.Parse(Console.ReadLine());
            int[,] a4 = new int[m,n];
            Random rand2 = new Random();
            for (int i = 0; i < m; i++)
            {
                for ( int j = 0; j < n; j++)
                {
                    a4[i,j] = rand2.Next(10,51);
                }
            }
            Computer();
            Console.WriteLine("Coзданный массив: ");
            
            for (int i2 = 0; i2 < m; i2++)
            {
                Console.Write("                           ");
                for (int j2 = 0; j2 < n; j2++)
                {
                    Console.Write(" "+a4[i2,j2]+" ");
                }
                Console.WriteLine();
            }
            MiddleValue(a4,m,n);






            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Task5()
        {
            int m,n;
            User();
            Console.Write("М= ");
       
            
            m=int.Parse(Console.ReadLine());
            User();
            Console.Write("N= ");
            
            n=int.Parse(Console.ReadLine());

            int[,] a5 = new int[m,n];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a5[i, j] = rand.Next(1, 10);
                }
                
            }
            Computer();
            Console.WriteLine("Coзданный массив: ");
            
            for (int i2 = 0; i2 < m; i2++)
            {
                Console.Write("                           ");
                for (int j2 = 0; j2 < n; j2++)
                {
                    Console.Write("" + a5[i2, j2] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            double [,]b5 =new double[m,n];
            antialiasing(a5,b5,m,n);

            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Task6()
        {
            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Task7()
        {
            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Task8()
        {
            Console.WriteLine("Решение завершено. Нажмите 1 для того чтобы вернуться назад");
            User();
            int i01 = int.Parse(Console.ReadLine());
            switch (i01)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 2 "); break;
            }
            User();
            int i011 = int.Parse(Console.ReadLine());
            switch (i011)
            {
                case 1: selection(); break;
                default: Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 1 "); break;
            }
            User();
            int i012 = int.Parse(Console.ReadLine());
            switch (i012)
            {
                case 1: selection(); break;
                default:
                    Computer(); Console.WriteLine("Попробуйте снова. Осталось попыток: 0 ");
                    Computer(); Console.WriteLine("К сожалению вы истратили все попытки. Сеанс работы завершается.");
                    Console.Clear();
                    Main();
                    break;
            }
        }
        static void Main()
        {

            Computer();
            Console.WriteLine(" Добро пожаловать в лабораторную программу №5. Методы и строки");
            Console.ReadKey();


            selection();
        }

    
}
}
