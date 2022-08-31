// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Power()
{
Console.WriteLine("Введите целое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
int S = 1;
if (secondValue < 0)
{
    Console.Write("Нужно вводить натуральное число, а не число, которое ввели:  ");
}
else
{
for (int i = 0; i < secondValue; i++)
{
   S = firstValue*S;
}
Console.WriteLine(S);
}
}
try
{
    Power();
 }
catch
{
Console.WriteLine("Нужно вводить число ");
}