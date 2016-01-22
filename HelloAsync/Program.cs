using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAsync
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main - Start");

            DoWork();

            Console.WriteLine("Main - End");

            Console.ReadLine();
        }

        static async Task DoWork()
        {
            Console.WriteLine("DoWork - Start");

            var t = await Method1();
            Console.WriteLine("Method1 Result: " + t);

            Console.WriteLine("DoWork - End");
        }

        static async Task<int> Method1()
        {
            Console.WriteLine("--Method1 - Start");

            var t = await Method2();
            Console.WriteLine("--Method2 Result: " + t);

            await Task.Delay(3000);

            Console.WriteLine("--Method1 - End");

            return 1;
        }

        static async Task<int> Method2()
        {
            Console.WriteLine("----Method2 - Start");

            await Task.Delay(3000);

            Console.WriteLine("----Method2 - End");

            return 2;
        }
        
    }
}
