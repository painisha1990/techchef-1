using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace techchef_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str1, str2, opt1, opt2;
            Console.WriteLine("Input the 1st string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the 2nd string : ");
            str2 = Console.ReadLine();

            char[] charArr1 = str1.ToCharArray();
            char[] charArr2 = str2.ToCharArray();

            char[] optchararr1 = charArr1.Except(charArr2).ToArray();
            char[] optchararr2 = charArr2.Except(charArr1).ToArray();
             opt1 = new string(optchararr1);
             opt2 = new string(optchararr2);
            Console.WriteLine("opt1= " +opt1);
            Console.WriteLine("opt2= " +opt2);
            Console.ReadLine();
            }
        }
    }

