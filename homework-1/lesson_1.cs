using System;
namespace lesson_1
{
    internal static class Program
    {
        static void one_one()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    for (int k = j + 1; k < 10; k++)
                    {
                        for (int z = k + 1; z < 10; z++)
                        {
                            int res = z * 1000 + k * 100 + j * 10 + i;
                            Console.Out.WriteLine(res);
                        }
                    }
                }
            }
        }

        static void one_two()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n-Math.Abs(i-j));
                }
                Console.WriteLine();
            }
        }
        
        static void one_three()
        {
            //???
        }

        static void one_four()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int CK = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(CK);
                    Console.Write(" ");
                    CK = CK * (i - j) / j;
                }
                Console.WriteLine();
            }
        }

        static void two_one()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string n_s="";
            while (n > 0)
            {
                n_s += Convert.ToString(n % 2);
                n = n / 2;
            }

            for (int i = n_s.Length-1; i >= 0; i--)
            {
                Console.Write(n_s[i]);
            }
        }

        static void two_two()
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            string a_s = "", b_s = "", c_s="";
            while (a>0)
            {
                a_s += Convert.ToString(a % 2);
                a = a / 2;
            }

            while (b>0)
            {
                b_s += Convert.ToString(b % 2);
                b = b / 2;
            }

            while (c>0)
            {
                c_s += Convert.ToString(c % 2);
                c = c / 2;
            }
            for (int i = 0; i < Math.Max(c_s.Length, Math.Max(a_s.Length, b_s.Length))-a_s.Length; i++)
            {
                Console.Write(0);
            }
            for (int i = a_s.Length - 1; i >= 0; i--)
            {
                Console.Write(a_s[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Math.Max(c_s.Length, Math.Max(a_s.Length, b_s.Length))-b_s.Length; i++)
            {
                Console.Write(0);
            }

            for (int i = b_s.Length - 1; i >= 0; i--)
            {
                Console.Write(b_s[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Math.Max(c_s.Length, Math.Max(a_s.Length, b_s.Length)); i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
            for (int i = 0; i < Math.Max(c_s.Length, Math.Max(a_s.Length, b_s.Length)) - c_s.Length; i++)
            {
                Console.Write(0);
            }

            for (int i = c_s.Length - 1; i >= 0; i--)
            {
                Console.Write(c_s[i]);
            }
        }

        static void two_three()
        {
            short a = Convert.ToInt16(Console.ReadLine()), b = Convert.ToInt16(Console.ReadLine()), c = Convert.ToInt16(Console.ReadLine()),
                d=Convert.ToInt16(Console.ReadLine());
            long l = 0;
            l += a;
            l = l << 16;
            l += b;
            l = l << 16;
            l += c;
            l = l << 16;
            l += d;
            Console.Write(l);
        }

        static void two_four()
        {
            
            long l = Convert.ToInt64(Console.ReadLine());
            long a, b, c, d;
            a = l & 65535;
            l = l >> 16;
            b = l & 65535;
            l = l >> 16;
            c = l & 65535;
            l = l >> 16;
            d = l;
            Console.WriteLine($"{a} {b} {c} {d}");
        }
        public static void Main(string[] args)
        {
            //номер задачи = номер функции, которая реализует решение этой задачи
            two_four();
        }
    }
}