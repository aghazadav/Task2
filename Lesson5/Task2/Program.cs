namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             İstifadəçidən 2 int dəyər alın və birinci ədədi ikinciyə bölün . Misal: 16, 5. Nəticə 3 yox, 3,2 olmalıdır.
             */

            int num1;
            int num2;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Please enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine($"Please enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please use only numbers. Lets try again");


                }
            }
            Console.WriteLine();
            double divideDouble = Divide(num1, num2);
            Console.WriteLine($"Result = {divideDouble}");

        }
        private static double Divide(int num1, int num2)
        {
            
            return (double)num1 / num2;
        }
    }
}
