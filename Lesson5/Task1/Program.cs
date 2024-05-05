namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bərabəryanlı düzbucaqlının eni və uzunluğunu istifadəçidən alın. Perimetri və sahəsini hesablayın
             Example
             5
             6
             22
             30

            'Düzbucaqlının"' eni "2" uzunluğu isə "4" olarsa bu düzbucaqlının perimetri 2•("2"+"4")=2•6=12 olar. 
            */

            int side1 = 0;
            int side2 = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine($"Please enter first side");
                    side1=Convert.ToInt32( Console.ReadLine() );
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please use only numbers. Lets try again");

                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine($"Please enter second side");
                    side2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please use only numbers. Lets try again");


                }
            }
            Console.WriteLine();
            int resPer = Perimeter(side1, side2);
            Console.WriteLine($"Perimeter = {resPer}");
            Console.WriteLine();
            int resArea = Area(side1, side2);
            Console.WriteLine($"Area = {resArea}");

        }
        private static int Perimeter(int side1, int side2)
        {
            int resPer = 2* (side1 + side2);
            return resPer;
        }
        private static int Area(int side1, int side2)
        {
            int resArea = side1 * side2;
            return resArea;
        }
    }
}