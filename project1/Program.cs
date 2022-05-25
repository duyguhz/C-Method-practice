using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran  metod

            int number = 44;
            Console.WriteLine(number);

        }
        static int getSum(int number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                while (number != 0)

                {
                    sum += sum + (number - number % 10) / 10;
                }


            }
            return sum;


            #endregion

        }
        #region task 2
        //Verilmiş 3 ədədən ən böyüyünü qaytaran metod
    }    
}       static int BiggestValue(int num1, int num2, int num3)
        {
         if (num1 > num2 && num1 > num3)
        {
           Console.WriteLine("num1 biggest");
        return num1;

        }
    else if (num2>num1 && num2>num3)
    {
        Console.WriteLine("num2 biggest")
            return num2;


    }
}   else
{

    Console.WriteLine("num3 biggest");


}

#endregion







