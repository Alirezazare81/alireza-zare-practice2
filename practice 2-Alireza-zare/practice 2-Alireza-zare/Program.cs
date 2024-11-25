using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2_Alireza_zare
{
    class Program
    {
        static long Factorial(int adad)
        {
            if (adad < 0)
            {
                throw new ArgumentException("Can't be lower than 0");
            }
            if (adad == 0 || adad == 1)
            {
                return 1;
            }
            long hasel = 1;
            for (int i = 2; i <= adad; i++)
            {
                hasel *= i;
            }
            return hasel;
        }
        static void Main(string[] args)
        {
            int AdadVorodi;
            Console.WriteLine("please write a number");
            if (int.TryParse(Console.ReadLine(), out AdadVorodi))
            {
                try
                {
                    long HaselFactorial = Factorial(AdadVorodi);
                    Console.WriteLine($"the factorial of {AdadVorodi} is:  {HaselFactorial}");
                }
                catch (ArgumentException a)
                {
                    Console.WriteLine(a.Message);
                }
            }
            else
            {
                Console.WriteLine("please enter an integer number");
            }
            Console.ReadKey();
        }
     
    }
   
}   
            
            

           

        
    

