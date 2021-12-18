using System;
using System.Collections;
using System.Linq;

namespace cSharp_Console_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*BigNumber(): Kullanıcının klavyeden girdiği dört sayıdan büyük olanının hangisi 
                           olduğunu ekrana yazan programı yazın. */
            //Console.WriteLine(BigNumber(new int[4]));

            /*SalaryAfterFiveYear(): Bir çalışanın maaşı 1000 TL’dir ve çalıştığı şirketle 
                                    yıllık %15 artış ile anlaşmıştır. Beş yıl sonra maaşını 
                                    hesaplayan programı yazın. */
            Console.WriteLine(SalaryAfterFiveYear(1000,0.15));



            Console.ReadKey();
        }

        static int BigNumber(int[] numbers){

            for(int i=0; i<numbers.Length; i++){

                Console.WriteLine($"{i}st number :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numbers.Max();
        }
        static double SalaryAfterFiveYear(double salary, double percent){
            for(int year=1; year<=5; year++){
                
                double increase;
                increase = salary * percent;
                salary = salary + increase;
            }

            return salary;
        }

    } 
}
