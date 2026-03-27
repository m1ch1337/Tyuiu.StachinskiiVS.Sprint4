using Tyuiu.StachinskiiVS.Sprint4.Task2.V26.Lib;

Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Стачинский В. С. | ИСПб-24-1";
Console.WriteLine("*************************************************************************************");
Console.WriteLine("* Спринт #4                                                                         *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                              *");
Console.WriteLine("* Задание #2                                                                        *");
Console.WriteLine("* Вариант #26                                                                       *");
Console.WriteLine("* Выполнил: Стачинский В. С. | ИСПб-24-1                                            *");
Console.WriteLine("*************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                          *");
Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                               *");
Console.WriteLine("*                                                                                   *");
Console.WriteLine("*************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
Console.WriteLine("*************************************************************************************");

int len = 14;
int[] array = new int[len];
for (int i = 0; i < len - 1; i++)
{
    array[i] = rnd.Next(1, 8);
}

Console.WriteLine("Массив: ");
for (int i = 0; i < len - 1; i++)
{
    Console.Write(array[i] + "\t");
}

int res = ds.Calculate(array);

Console.WriteLine();
Console.WriteLine("*************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
Console.WriteLine("*************************************************************************************");

Console.WriteLine("Произведение нечетных элементов массива = " + res);
Console.ReadKey();