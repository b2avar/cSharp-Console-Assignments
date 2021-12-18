using System;
using System.Collections;
using System.Collections.Generic;
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
            //Console.WriteLine(SalaryAfterFiveYear(1000,0.15,5));

            /*Banknote():Bir bankamatik müşterisine bankamatikten çekmek istediği para sorulacak. 
                         Çekeceği paraya göre kaç tane 200’lük, kaç tane 100’lük, kaç tane 50’lik, 
                         kaç tane 20’lik, kaç tane 10’luk, kaç tane 5’lik ve kaç tane 1'lik verilmesi 
                         gerektiğini bulan programı yazın.*/
            //Banknote(2324);

            /*Factorial(): n sayısının Faktöriyelini (n!) hesaplayan ve yazdıran programı yazınız.*/
            //Console.WriteLine(Factorial(8));

            /* IntegerQuery(): Klavyeden girilen 20 tamsayının kaçının sıfır, kaçının tek ve kaçının 
                               çift olduğunu bulan ve yazdıran programı yazınız.*/
            IntegerQuery();

            Console.ReadKey();
        }

        static int BigNumber(int[] numbers){
            for(int i=0; i<numbers.Length; i++){
                Console.WriteLine($"{i}st number :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers.Max();
        }
        static double SalaryAfterFiveYear(double salary, double percent, double year){
            double increase;
            for(int i=1; i<=year; i++){  
                increase = salary * percent;
                salary = salary + increase;
            }
            return salary;
        }
        static void Banknote(int money){
            int[] banknote = new int[7];
            int[] bNote = new int[]{200,100,50,20,10,5,1};

            banknote[0] = money / bNote[0];
            money = money % 200;

            banknote[1] = money / bNote[1];
            money = money % 100;

            banknote[2] = money / bNote[2];
            money = money % 50;

            banknote[3] = money / bNote[3];
            money = money % 20;

            banknote[4] = money / bNote[4];
            money = money % 10;

            banknote[5] = money / bNote[5];
            money = money % 5;

            banknote[6] = money / bNote[6];
            money = money % 1;

            for(int i=0; i<banknote.Length; i++){
                Console.WriteLine($"{banknote[i]} pieces of {bNote[i]}");
            }
        }
        static long Factorial(int n){
            long result = 1;
            for(int i=1; i<=n; i++)
                result = result * i;
            return result;
        }
        static void IntegerQuery(){
            int[] numbers = new int[20];
            int zeros = 0;
            int evenNumber = 0; 
            int oddNumber = 0;

            for(int i = 0; i<numbers.Length; i++){
                Console.WriteLine($"{i} st number :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int array in numbers){
                Console.Write($"{array},{" "}");
            }
            for(int j = 0; j<numbers.Length; j++){
                    if(numbers[j]==0){
                        zeros++;
                    }
                    else if(numbers[j]%2==0){
                            evenNumber++;
                    }
                    else if(numbers[j]%2!=0){
                        oddNumber++;
                    }
                }

            Console.WriteLine();

            Console.WriteLine($"There are {zeros} zero");
            Console.WriteLine($"There are {evenNumber} even number");
            Console.WriteLine($"There are {oddNumber} odd number");
        }
    } 
}
