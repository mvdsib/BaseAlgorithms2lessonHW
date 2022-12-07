/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/* Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if ((100 <=num) && (num <= 999))
{
    int num1 = num % 100;
    int num2 = num % 10; 
    int SecondN = (num1 - num2) / 10;
    Console.WriteLine($"{SecondN}");
}
else
Console.WriteLine("Введенное число не трехзначное"); */




/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

/* Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
while (num > 999)
{
    num = num / 10;
}
if (100 <= num)
{
    int num3 = num % 10;
   Console.WriteLine($"{num3}"); 
}
else
Console.WriteLine("третьей цифры нет"); 
 */



/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (num <=5)
{
    Console.WriteLine("Не выходной день");
}
else if ((num >= 6) && (num <= 7))
{
    Console.WriteLine("Выходной день");
}
else
Console.WriteLine("Выберите число от 1 до 7");