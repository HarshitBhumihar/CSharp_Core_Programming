using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Marksheet
    {
        internal void pass()
        {
            //int num = 25;
            //switch (num % 2)
            //{
            //    case 0:
            //        Console.WriteLine("even");
            //        break;

            //    default:
            //        Console.WriteLine("odd");
            //        break ;
        //}
            char ch = 'a';
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;

            }

            }
        }
        
            
    }

