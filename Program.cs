﻿using System;
using System.Collections;

namespace cSharp_Console_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            BigNumber();
        }

        private static void BigNumber(){
                        Random rRandom = new Random();
            int[] numbers = new int[5];

            for(int i=0; i<5; i++){
                numbers[i] = rRandom.Next(1,20);
                Console.WriteLine($"{i}st number: {numbers[i]}");
            }

            Array.Sort(numbers);

            Console.WriteLine($"Big Number : {numbers[4]}");
            Console.ReadKey();
        }
        private static void Comment(){
            // BigNumber(): Kullanıcının klavyeden girdiği dört sayıdan büyük olanının hangisi 
            //              olduğunu ekrana yazan programı yazın.

            
        }
    } 
}
