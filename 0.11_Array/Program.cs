using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Array
{
    class Program
    {
        static void Main(string[] args)
        {
    //        int[] numbers = new int[5];
    //        numbers[0] = 1;
    //        numbers[1] = 2;
    //        numbers[2] = 3;
    //        numbers[3] = 4;
    //        numbers[4] = 5;
    ////Arrays best to be plural names     //0   1   2   3   4   5
    //        int[] lottoNums = new int[] { 15, 4, 16, 23, 42, 7 };           
    //        Console.WriteLine(numbers[0]);
    //        Console.WriteLine(lottoNums[5]);
            
    //        foreach (int number in numbers)
    //        {
    //            Console.WriteLine(number);
    //        }
    //        Console.ReadLine();
    //        foreach (int lottoNum in lottoNums)
    //        {
    //            Console.WriteLine(lottoNum);
    //        }
    //        Console.ReadLine();

            string[] names = new string[] { "James", "Paul", "Obi Wan", "Anakin", "Meow" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
