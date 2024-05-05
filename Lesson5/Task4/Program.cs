namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ədədlər üzərində operatorlardan istifadə etməklə nümunələr yazın.
             Hər operotara aid 1 nümunə.Fərqli data typle-lardan istifadə edin
             */

            int a = 5;
            int b = 3;
            int sum = a + b;
            Console.WriteLine($"5 + 3 = {sum}");

            Console.WriteLine();
            double c = 10.5;
            double d = 3.2;
            double difference = c - d;
            Console.WriteLine($"10.5 - 3.2 = {difference}");

            Console.WriteLine();
            long num1 = 5;
            long num2 = 6;
            long multipy = num1 * num2;
            Console.WriteLine($"5 * 6 = {multipy}");

            Console.WriteLine();
            double num3 = 10.0;
            double num4 = 3.0;
            double divade = num3 / num4;
            Console.WriteLine($"10 / 3 = {divade}");

            Console.WriteLine();
            int num5 = 10;
            int num6 = 3;
            int module = num5 % num6;
            Console.WriteLine($"10 % 3 = {module}");

            Console.WriteLine();
            int num7 = 7;
            num7++; 
            Console.WriteLine($"int num = 7 after increment: {num7}");
            num7++;
            Console.WriteLine($"After increment: {num7}");
            num7++;
            Console.WriteLine($"After increment: {num7}");

            Console.WriteLine();
            int num8 = 8;
            num8--;
            Console.WriteLine($"int num = 8 after decrement: {num8}");
            num8--;
            Console.WriteLine($"After decrement: {num8}");
            num8--;
            Console.WriteLine($"After decrement: {num8}");

        }
    }
}
