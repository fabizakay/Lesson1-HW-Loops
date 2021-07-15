using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Loops_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region targil 1
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }

            //}
            #endregion

            #region targil 2
            //int sum = 0;
            //int avg;
            //for (int i = 0; i < 5; i++)
            //{

            //    int num = int.Parse(Console.ReadLine());
            //    sum = sum + num;
            //}

            // Console.WriteLine("Avarege of numbers is " + sum/5);
            #endregion

            #region teargil 3
            //int num1, num2;

            //do

            //{
            //    Console.WriteLine("enter num1");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter num2");
            //    num2 = int.Parse(Console.ReadLine());

            //    if (num1 == 0 || num2 == 0)
            //    {
            //        continue;  
            //    }
            //    if (num1 < 0 ||num2 < 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("add of numbers" + num1 + num2);
            //    Console.WriteLine("sum of numbers" + num1 * num2);
            //}

            //while (true);
            //{
            //    Console.WriteLine("the end");
            //}

            #endregion

            #region targil 4

            //for (int i = 9; i > 0; i--)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    Console.WriteLine("end of region");
            //}

            #endregion

            #region targil 5

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("\t" +  i*j);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region targil while 1
            //int trys = 1;
            //Console.WriteLine("enter a number");
            //int x = int.Parse(Console.ReadLine());
            //while (x < 20)
            //{
            //    if (x >20)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("enter a number");
            //        x = int.Parse(Console.ReadLine());
            //        trys++;
            //    }
            //}
            //Console.WriteLine($"number of trys {trys}");
            #endregion

            #region targil for 1

            //Console.WriteLine("enter a number bigger then 3");
            //int num1 = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num1 * 2; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region targil for 2

            //for (int i = 0, j = 10; i < j; i++,j--)
            //{
            //    Console.WriteLine(i + j);
            //}
            #endregion

            #region targil 1 continue break
            //int i;
            //Console.WriteLine("enter a number bigger then 3");
            //int num1 = int.Parse(Console.ReadLine());
            //for ( i = 1; i <= num1 * 2; i++)
            //{
            //    if (i == 1)
            //    {
            //        continue;
            //    }
            //    else if (i > 10)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("THE END " + i);

            #endregion

            #region targil continue 2
            //int trys = 0;
            //while (true)
            //{
            //    Console.WriteLine("enter a number");
            //    int number1 = int.Parse(Console.ReadLine());
            //    if (number1 == 23)
            //    {
            //        Console.WriteLine("go out of loop: y or n");
            //        string ans = Console.ReadLine();
            //        if (ans == "y")
            //        {
            //            Console.WriteLine("number of trys " + trys);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("loops continues");
            //        }
            //    }
            //    trys++;
            //}

            #endregion

        }
    }
}
