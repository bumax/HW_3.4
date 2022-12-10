// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());


int result = new int();

while (number >= 1)
{
    result += number % 10;
    number /= 10;
}

System.Console.WriteLine($"Сумма всех чисел числа равна {result}");