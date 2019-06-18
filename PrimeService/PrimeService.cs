using System;

namespace Prime.Services
{
    public class PrimeService
    {
       static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++) {
                Console.WriteLine(Fizzbuzz(i));
            }
         }

        public static string Fizzbuzz(int number) 
        {
            if(number == 0) {
                return number.ToString();
            } else if (number % 3 == 0 && number % 5 == 0) {
                return "Fizzbuzz";
            } else if(number % 3 == 0) {
                return "Fizz";
            } else if(number % 5 == 0) {
                return "Buzz";
            } else {
                return number.ToString();
            }
        }
    }
}