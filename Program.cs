using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number (1-3):");
            int num = int.Parse(Console.ReadLine());    
            switch (num)
            {
                case 1: 
                    Console.WriteLine("You entered '1'");
                    break;
                case 2: 
                    Console.WriteLine("You entered '2'") ; 
                    break;    
                case 3: 
                    Console.WriteLine("You entered '3'") ; 
                    break;
                default:
                    Console.WriteLine("Invlaid input the range is 1-3");
                    break; 
            }
            Console.ReadLine(); 

        }
    }
}
