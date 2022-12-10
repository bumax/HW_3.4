// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
System.Console.Write("Введите число: ");
var value = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите cтепень числа: ");
var power = Convert.ToInt32(Console.ReadLine()); // ToUInt32 - если всецело придерживаться условий задачи

double result = 1.0; // инициализируем переменную результата, 0 степень равна 1 (если мы введем отрицательную степень, то результат будет, как правило дробь)

if (power >= 0)
{
    for (int i = 0; i < power; i++) result *= value;
}
else
{
    for (int i = 0; i < -1 * power; i++) result *= value;
    result = 1 / result;
}

System.Console.WriteLine($"{value} в степени {power} = {result}");