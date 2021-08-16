using System;


namespace _1._0._00_шаблон1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.WriteLine(" Програма для вирішення квадратного рівняння");
            int cycl;
            for (cycl = 1; cycl != 0; )
            {
                Console.Clear();
                Console.WriteLine(" Введіть ваші значення за типом ax2+bx+c");
                Console.Write(" a=");
                int.TryParse(Console.ReadLine(), out int a);
                Console.Write(" b=");
                int.TryParse(Console.ReadLine(), out int b);
                Console.Write(" c=");
                int.TryParse(Console.ReadLine(), out int c);
                
                int d = (b * b) - 4 * a * c;
                Console.WriteLine("D = " + d);
                if (d >= 0)
                {
                    double root = Convert.ToDouble(Math.Sqrt(d));
                    double x1 = (-b + root) / (2 * a);
                    double x2 = (-b - root) / (2 * a);
                    if (d == 0)
                    {
                        Console.WriteLine(" x = " + x1);
                    }
                    else
                    {
                        Console.WriteLine("X1 = " + x1);
                        Console.WriteLine("X2 = " + x2);
                    }
                }
                else
                {
                    Console.WriteLine(" Дискримінант менше нуля. Не можу виконати дію");
                }


                Console.WriteLine("Бажаєте прожовжити та ввести нові дані?");
                Console.WriteLine("Так = 1 / Ні = 0");             
                int.TryParse(Console.ReadLine(), out cycl);
                if (cycl != 1)
                {
                    cycl = 0;
                }
            }








        }
    }
}
