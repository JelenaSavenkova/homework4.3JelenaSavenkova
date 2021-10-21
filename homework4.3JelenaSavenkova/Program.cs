using System;
using System.Linq;

namespace homework4._3JelenaSavenkova
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 30, 33, 300, 333, 3000, 3333, 30000, 33333 };
         
            Console.WriteLine($"The total value is {numbers.Sum()}");
            #region odd/even  
            foreach (var resultNumbers in numbers)
            {
                if (resultNumbers % 2 == 0)
                {
                    Console.WriteLine($"Number {resultNumbers} is even");
                }
                else
                {
                    Console.WriteLine($"Number {resultNumbers} is odd");
                }
               
            }
            #endregion
            Console.ReadLine();
        }
    }
}
