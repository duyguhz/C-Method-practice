using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 4, 4, 6, 5, 8, 98 };
            Console.WriteLine(NumberCount(numbers, 4));
            int[] values = { 4, 7, 6, 90, 65, 11 };
            Console.WriteLine($"Average Score:{AverageNumber(values)}");
            string[] names = { "Duygu", "Banu", "Revan", "Aqsin", "Leyla" };
            string name = "Duygu";
            Console.WriteLine(NameList(names, "Duygu"));
           
        }

        //Verilmis ededler siyahisindaki verilmis n ededin sayini tapan metod
        static int NumberCount(int[] numbers, int number)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    count++;


            }
            return count;
        }//Verilmis qiymetlerin ortalamasini hesablayan qaytaran metod

        static int AverageNumber(int[] values)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < values.Length; i++)

                sum += values[i];

            if (values.Length > 0)
            {
                average = sum / values.Length;
            }
            return average;
        }


        //Verilmis adlar siyahisinda axtarilan adin olub 
        //olmadigini tapan bir metod
        static bool NameList(string[] names, string searchedname)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == searchedname)
                    return true;

            }


            return false;
        }
    }
}  
              

            
                
            
            
