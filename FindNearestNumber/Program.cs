using System;
namespace FindNearestNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose from following options :\n 1. Find nearest all digit even number ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    NearestEvenNumber.AllTheEvenDigitNumbers();
                    break;
            }
           
        }
    }
}