using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat01(args);

            void feladat01(string[] szinek)
            {
                int szinekdb;
                Console.WriteLine("add meg a szinek szamat!");
                szinekdb = Convert.ToInt32(Console.ReadLine());

                szinek = new string[szinekdb];
                Console.WriteLine("add meg a szineket!");

                for (int i = 0; i < szinekdb; i++)
                {
                    szinek[i] = Console.ReadLine();
                }

                int factorial(int n)
                {
                    int f = 1;
                    for (int i = n; i > 0; i--)
                    {
                        f *= i;
                    }
                    return f;
                }

                void keveres()
                {
                    int kevertdb = 0;

                    for (int i = 2; i <= szinek.Length; i++)
                    {
                        kevertdb += factorial(szinekdb) / (factorial(i) * factorial(szinekdb - i));
                    }
                    Console.WriteLine("lehetséges keverések száma:  ");
                    Console.Write(kevertdb);
                }

                keveres();
            }
        }
    }
}
