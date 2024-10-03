using System;

class ReverseNumber
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя трехзначное число
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Вызываем метод Reverse с полученным значением
        int reversed = Reverse(number);

        // Выводим результат на консоль
        Console.WriteLine($"Обратное число: {reversed}");
    }

    static int Reverse(int number)
    {
        // Инициализируем переменную для хранения обратного числа
        int reversed = 0;

        // Разбираем число на цифры и переставляем их в обратном порядке
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        // Возвращаем обратное число
        return reversed;
    }
}