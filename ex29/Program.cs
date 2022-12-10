// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
System.Console.Write("Введите 8 чисел через запятую: ");
string[] number = (Console.ReadLine()).Split(',');

// Перевод массива строк в массив интов
int[] stringArray2IntArray(string[] inputArray)
{
    int[] outputArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
        outputArray[i] = Convert.ToInt32(inputArray[i]);
    return outputArray;
}

// Печать массива интов
void printArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        System.Console.Write("{0}, ", array[i]);
    System.Console.WriteLine("{0}]", array[array.Length - 1]); // Последнее значение массива печатаем вне цикла,  чтобы не приписывать запятую
}

printArray(stringArray2IntArray(number));