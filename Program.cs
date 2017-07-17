using System;
using System.Collections.Generic;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MATH!");
            Random random = new Random();

            List<int> randomNumber = new List<int>();
  
            for(int num = 0; num < 20; num++){
                randomNumber.Add(random.Next(1, 50));
            }
            // foreach(int thing in randomNumber){
            //     Console.WriteLine($"I am a random number {thing}");
            // }

            List<int> squaredList = new List<int>();
            foreach (int item in randomNumber)
            {
                int squareMe = (item * item);
                squaredList.Add(squareMe);
            }

            // foreach (int item in squaredList)
            // {
            //     Console.WriteLine($"I am a sqaured number {item}");
            // }

            List<int> evenList = new List<int>();

            for(int i = 0; i < squaredList.Count; i++)
            {
                if (squaredList[i] % 2 == 0) {
                    evenList.Add(squaredList[i]);
                }
            }

            foreach (var item in evenList)
            {
                Console.WriteLine($"I am only even {item}");
            }
        }
    }

}
