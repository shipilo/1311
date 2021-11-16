using System;

namespace Met_1311
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1.");

            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher(1);

            string str1 = Console.ReadLine();
            string str2 = aCipher.Encode(str1);
            Console.WriteLine(str2);
            str2 = bCipher.Decode(str2);
            Console.WriteLine(str2);

            Console.WriteLine("\nДомашнее задание 10.1");

            Point p = new Point();
            Console.WriteLine(p.GetSquare());

            Console.ReadLine();
        }
    }
}
