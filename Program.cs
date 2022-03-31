using System;
using Challenge_1.BL;

namespace Challenge_1
{
    internal class Program
    {
        static void Main()
        {
            clockType time = new clockType(2,18,50);
            time.Print();
            
            time.IncrementMinutes();
            time.Print();
            
            time.IncrementHours();
            time.Print();
            
            time.IncrementSeconds();
            time.Print();

            Console.WriteLine( time.IsEqual(3, 19, 51) );

            Console.WriteLine(time.IsEqual(2, 18, 50));

            clockType Time = new clockType(2, 29, 0);
            Console.WriteLine(Time.IsEqual(time));

            Console.WriteLine(Time.RemainingTime());
            Console.WriteLine(Time.ElapsedTime());

            Time.Difference(time);
        }
    }
}
