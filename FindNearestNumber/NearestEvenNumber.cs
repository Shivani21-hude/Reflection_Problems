using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestNumber
{
    internal class NearestEvenNumber
    {
        public static void AllTheEvenDigitNumbers()
        {
            Console.WriteLine("Enter a number to check which is nearest even number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int smallest = 0;
            int greatest = 0;

            if (number > 0)
            {
                while (true)
                {
                    number--;

                    if (FindEvenNumber(number))
                    {
                        smallest = number;
                        Console.WriteLine("The smaller Closest Even Digit Number of the given input is " + smallest);
                        break;
                    }
                }
                while (true)
                {
                    number++;

                    if (FindEvenNumber(number))
                    {
                        greatest = number;
                        Console.WriteLine("The larger closest Even Digit Number of the given input is " + greatest);
                        break;
                    }
                }
                var val1 = Math.Abs(smallest - number);  // for to remove negative sign 
                var val2 = greatest - number;


                if (val1 < val2)       // check less distance 
                {
                    Console.WriteLine("The closest Even digit Number of given input is :" + smallest);
                }
                else
                {
                    Console.WriteLine("The closest Even digit Number of given input is :" + greatest);
                }
            }
            // to check for negative number
            else if(number<0)
            {
                number = Math.Abs(number);
                while (true)
                {
                    
                    
                    number--;
                    if (FindEvenNumber(number))
                    {
                        smallest = number*-1;
                        Console.WriteLine("The smaller Closest Even Digit Number of the given input is " + smallest);
                        break;
                    }
                }
                
                while (true)
                {
                    number++;

                    if (FindEvenNumber(number))
                    {
                        greatest = number*-1;
                        Console.WriteLine("The larger closest Even Digit Number of the given input is " + greatest);
                        break;
                    }
                }
                var val1 = Math.Abs(smallest + number);  // for to remove negative sign 
                var val2 = Math.Abs(greatest + number);
                if (val1 < val2)
                {
                    Console.WriteLine("The closest Even digit Number of given input is :"+greatest);
                }
                else
                {
                    Console.WriteLine("The closest Even digit Number of given input is :" +smallest);
                }
            }
        }
        //converting an number into char
        private static bool FindEvenNumber(int number)
        {
            foreach (char num in number.ToString())       //check char 1 by 1
            {
                int digit = (int)char.GetNumericValue(num);      //it will convert char into int 
                if (digit % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }  
    
}

