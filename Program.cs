using System;
using System.Collections;

namespace cSharp_Console_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SalaryAfterFiveYear(10000,0.15));
            Console.ReadKey();
        }

        static double SalaryAfterFiveYear(double salary, double percent){
            for(int year=1; year<=5; year++){
                
                double increased;
                increased = salary * percent;
                salary = salary + increased;
            }

            return salary;
        }
        static void BigNumber(){
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
        static void Comments(){
            // BigNumber(): Kullanıcının klavyeden girdiği dört sayıdan büyük olanının hangisi 
            //              olduğunu ekrana yazan programı yazın.

            // SalaryAfterFiveYear(): Bir çalışanın maaşı 1000 TL’dir ve çalıştığı şirketle 
            //                        yıllık %15 artış ile anlaşmıştır. Beş yıl sonra maaşını 
            //                        hesaplayan programı yazın.
        }
    } 
}
