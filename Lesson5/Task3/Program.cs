using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Tip Çevirmelerine aid 5 nümunə yazın
             */

            //Ex1
            byte a = 1;
            byte b = 2;

            var sum = a + b;
            Console.WriteLine($"byte a = 1, byte b = 2, a+b");
            Console.WriteLine($"Sum: {sum}, Type: {sum.GetType().ToString()}");
            Console.WriteLine();


            //Ex2
            int ab = 5;
            double ac = 3.14;

            var res = ab + ac;
            Console.WriteLine($"int ab = 5, double ac = 3.14, ab+bc");
            Console.WriteLine($"Result: {res}, Type: {res.GetType().ToString()}");
            Console.WriteLine();


            //Ex3
            string stringNumber = "123";
            int intNumber = Convert.ToInt32(stringNumber);

            Console.WriteLine($"string 123 to int");
            Console.WriteLine($"String Value: {stringNumber}, Type: {intNumber.GetType().ToString()}");
            Console.WriteLine();


            //Ex4
            int intNumber2 = 255;
            byte byteNumber = (byte)intNumber2;
            Console.WriteLine($"intNumber2 = 255 to byte 255");
            Console.WriteLine($"Byte Value: {byteNumber}, Type: {byteNumber.GetType().ToString()}");
            Console.WriteLine();


            //Ex5
            string name = "Arda";
            string surname = "Guler";
            string fullname = name + " " + surname;

            Console.WriteLine($"Name: Arda, Surname: Guler, string to char");
            Console.WriteLine("Fullname:");
            foreach (char c in fullname)
            {
                Console.WriteLine(c);
            }



        }
    }
}
