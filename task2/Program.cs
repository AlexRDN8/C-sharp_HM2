// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать string[]

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse (Console.ReadLine());
int limit1 = 100;
int limit2 = 1000;
int result = num;
if (num >= limit1)
{
    while (result >= limit2)
    {
        result = result / 10;
    }
    int third_num = result % 10;
    Console.WriteLine(third_num); 
}
else
{
    Console.WriteLine("третьей цифры нет");
}

