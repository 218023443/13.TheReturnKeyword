using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TheReturnKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
            Console.ReadLine();

        }
        //declare a variable with a return type int
        static int cube(int number)
        {
            int result = number * number * number;
            return result;

        }

    }
    }

