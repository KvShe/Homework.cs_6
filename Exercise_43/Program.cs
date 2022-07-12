Console.WriteLine("\nНапишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:\n" +
                    "y = b1 + k1 * x \n" +
                    "y = b2 + k2 * x \n" +
                    "Значения b1, k1, b2 и k2 задаются пользователем\n" +
                    "b1 = 2, k1 = 5, b2 = 4, k2 = 9\n" +
                    "--> (-0,5; -0,5)");
string[] nameVariable = { "b1", "k1", "b2", "k2" };
int size = 4;
double[] variable = new double[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"\nEnter value {nameVariable[i]}\n");
    variable[i] = EnterNumber(variable[i]);
}
double firstStraight = (variable[2] - variable[0]) / (variable[1] - variable[3]);
double cesondStraigth = variable[0] + variable[1] * firstStraight;

bool checkPoint  =  variable[0] == variable[1] &&
                    variable[0] == variable[2] &&
                    variable[0] == variable[3] &&
                    variable[1] == variable[2] &&
                    variable[1] == variable[3] &&
                    variable[2] == variable[3];
if (checkPoint) Console.WriteLine("\nКак я понял - это точка");
else if (variable[1] == 0 &&
         variable[3] == 0) Console.WriteLine("\nЭто вроде тоже точка");
else if (variable[1] == variable[3]) Console.WriteLine("\nПрямые параллельны");
else
{
    Console.WriteLine($"\n({firstStraight}, {cesondStraigth})");
    Console.WriteLine("У меня какие-то проблемы с вещественными числами\nЯ минут 5 не мог понять, почему у меня через int не выводится -0,5");
}

double EnterNumber(double number)
{
    bool result;
    do
    {
        Console.Write("Enter number: ");
        result = double.TryParse(Console.ReadLine(), out number);
    }
    while (result == false);
    return number;
}
