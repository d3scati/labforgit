namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Операции для двух чисел");
            Console.WriteLine("Введите первое число (a):");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число (b):");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");

            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine($"Результат сложения: {result}");
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine($"Результат вычитания: {result}");
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine($"Результат умножения: {result}");
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: Нельзя делить на ноль.");
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine($"Результат деления: {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: Неверный выбор операции.");
                    break;
            }
        }
    }
}