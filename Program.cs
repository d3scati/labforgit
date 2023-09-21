namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cумма для двух чисел");
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;
            Console.WriteLine("Результат сложения: {0}", sum);
        }
    }
}