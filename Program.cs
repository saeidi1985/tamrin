using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("about personal information");
            Console.WriteLine("*******************");
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine(" enter your national code");
            string natinalcode = Console.ReadLine();
            Console.WriteLine("-----------------------");
            //Console.WriteLine("firstnam:" + firstname +   "   " +"lastname:" + lastname + "age:" + age + "nationalcode:" + natinalcode);
            Console.WriteLine($"firstname {firstname} and lastname{lastname}");
        }
    }
}