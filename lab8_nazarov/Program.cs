//lab8 Вариант 8, Высокий уровень

try
{
    Console.WriteLine("Вводите числа, последним числом введите отрицательное значение");
    int a = 1;
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        number = int.Parse(Console.ReadLine());

        if (number < 0)
            break;

        a *= number;
    }
    if (a != 1)
    {
        Console.WriteLine($"Произведение чисел равно: {a}");
    }
    else
    {
        Console.WriteLine("Не введено ни одного числа перед отрицательным числом!!!");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}