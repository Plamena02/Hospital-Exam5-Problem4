using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a=0;
            var l = 7;
            var pp = 0;
            var np = 0;
            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                {
                    if (i % 3 == 0 && pp < np)
                        l += 1;
                    if (a > l)
                    {
                        pp += l;
                        np += a - l;
                    }
                    else pp += a;
                }
            }
            Console.WriteLine("Treated patients: {0}.", pp);
            Console.WriteLine("Untreated patients: {0}.", np);
        }
        }
    }

