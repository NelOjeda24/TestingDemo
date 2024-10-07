using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public double AddDecimal(double number1, double number2)
        {
            return number1 + number2;
        }


        public IList<int> GetEvenNumbers(int start, int end)
        {

            //NOTA = 5/10

            //List<int > evenNumbers = new List<int>();
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenNumbers.Add(i);
            //    }
            //}
            //return evenNumbers;


            //NOTA = 7.5/10

            //List<int> Evennumbers = Enumerable.Range(start, end)
            //    .Where(number  => number % 2 == 0).ToList();


            //NOTA = 10/10
            return Enumerable.Range(start, end).Where(number => IsEven(number)).ToList();

        }
    }
}
