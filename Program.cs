using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 2, 24, 12, 20, 30);

            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(dt.ElapsedTime());

            System.Console.WriteLine("alexandre jose dos santos".cut());
        }
    }
}
