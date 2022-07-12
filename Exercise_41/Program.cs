// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел будешь вводить?\n");
int size = 0;
int[] array = new int[size];
int count = 0;

try
{
    size = EnterNumber(size);
    array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"\nEnter number № {i + 1}");
        array[i] = EnterNumber(array[i]);
        if (array[i] > 0) count++;
    }
    Console.Write($"\n{count} numbers greater than zero\n ");
}

catch (OverflowException)
{
    Console.WriteLine("Судя по всему ты, что-то знаешь про отрицательный размер массива\nЕсли нет, то пожалуйста, не делай так больше");
}

int EnterNumber(int number)
{
    bool result;
    do
    {
        Console.Write("Enter number: ");
        result = int.TryParse(Console.ReadLine(), out number);
    }
    while (result == false);
    return number;
}
