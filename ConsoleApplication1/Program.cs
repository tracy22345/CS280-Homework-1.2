using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int name = 0
            Console.Write("Name:");
            try
            {
                char name = char.Parse(Console.ReadLine());
            }
            catch (Exception e);
            {
                Console.WriteLine(e.ToString());
            }
            }
        }
    }