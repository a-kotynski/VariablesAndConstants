using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Abe";
            bool isWorking = false; //true and false are keywords (dark blue color)
            */

            /*
            //all data types can be assigned as var
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Abe";
            var isWorking = false;

            Console.WriteLine("{0} {1} {2} {3} {4} {5}", number, count, totalPrice,
                character, firstName, isWorking);
            Console.ReadLine();
            */

            /*
            //display range of a byte
            Console.WriteLine("{0} {1} ", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1} ", float.MinValue, float.MaxValue);
            Console.ReadLine();
            */

            const float Pi = 3.14f; // 
            //Pi = 1f;  compiler doesn't allow you to change declared constant 
        }
    }
}