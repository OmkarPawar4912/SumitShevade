using System;
using CalculatorFn;

namespace C_ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add for ask to User 1 No

            Console.WriteLine("Enter 1 No : ");
            int no1 = Int32.Parse(Console.ReadLine());
            //Add for ask to User 2 No
            Console.WriteLine("Enter 2 No : ");
            int no2 = Int32.Parse(Console.ReadLine());
            FnClassLibrary fnClassLibrary = new FnClassLibrary();
            Console.WriteLine("Sum : {0} + {1} = {2}",no1,no2,fnClassLibrary.DoSum(no1,no2));
            Console.WriteLine("Sub : {0} - {1} = {2}",no1,no2,fnClassLibrary.DoSub(no1,no2));
            Console.WriteLine("Multi : {0} * {1} = {2}",no1,no2,fnClassLibrary.DoMulti(no1,no2));
            Console.WriteLine("Division : {0} / {1} = {2}",no1,no2,fnClassLibrary.DoDivi(no1,no2));
            Console.Read();
        }
    }
}
