using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._04
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, a, c, f;
            int b;
            Console.WriteLine("Пользователь вводит значения x, a, b, c (a, b, c -действительные числа)."+
                " Вычислить значения функции F:");
            Console.WriteLine("Введите данные:");
            Console.Write("x = "); x = int.Parse(Console.ReadLine());
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());
           

            Console.WriteLine();
            Console.Write("Расчет F по формуле ");
            if ((x < 0) & (b != 0))
            {
                Console.WriteLine("a-x/(10+b)");
                f = (a - x) / (10 + b);
            }
            else if ((x > 0) & (b == 0))
            {
                Console.WriteLine("(x-a)/(x-c)");
                f = (a - x) / (10 + b);
            }
            else {
                Console.WriteLine("3*x+2/c");
                f = 3 * x + 2 / c;
            }
            Console.WriteLine("Функция F =  " + f);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Пользователь вводит натуральное число n. ");
            Console.WriteLine("Вычислить сумму первых n членов ряда");
            Console.WriteLine("   n");
            Console.WriteLine("EPSILON = 1/k(k+1), с учетом, что при "+
                "суммировании исключается каждый 4-й член.");
            Console.WriteLine("  k=1");
            double epsilon;
            double k,n,i2;
            
            Console.WriteLine("Введите данные:");
            Console.Write("N=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            k = 1;
            Console.Write("Если K = " + k);
            epsilon = 1 / ((2 * k) + k);
            Console.WriteLine(". Сумма ряда " + n + " членов равна " + epsilon);
            for (k=2; k<=n; k++)
            {
                if ((k%4) == 0)
                {
                    Console.Write("Если K = " + k);
                    Console.WriteLine(". K равен и кратен 4. Исключение из суммы. ");
                    Console.WriteLine("Сумма ряда " + n + " членов равна " + epsilon);
                }
                else
                {
                    Console.Write("Если K = " + k);
                    epsilon = epsilon + ((1) / ((2 * k) + k));
                    Console.WriteLine(". Сумма ряда " + n + " членов равна " + epsilon);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Сумма ряда первых " + n + " членов равна ");
            Console.WriteLine(epsilon);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("По данному натуральному n вычислите сумму 1+1/(1+2)+1/(1+2+3)+...1/(1+...+n).");
            Console.WriteLine("Введите данные:");
            Console.Write("N=");
            int n3 = int.Parse(Console.ReadLine());

            double factsumma = 1;
            double rezult = 1;
            for (int i3 = 2; i3 <= n3; i3++)
            {
                
                Console.Write("I = ");
                Console.WriteLine(i3);
                factsumma = factsumma + i3;
                Console.Write("Сумма: ");
                Console.WriteLine(factsumma);
                double partoffactsum = 1 / factsumma;
                Console.Write("Часть ряда: ");
                Console.WriteLine(partoffactsum);
                rezult = rezult + partoffactsum;
                Console.Write("Сумма заданного ряда: ");
                Console.WriteLine(rezult);

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Сумма заданного ряда: ");
            Console.WriteLine(rezult);
        }
    }
}
