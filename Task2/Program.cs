// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Sum()
{
Console.Write("Введите целое число: ");
var str = Console.ReadLine();  //использовала оператор var без явного указания типа переменной, чтобы "подружить" данные при преобразовании
var count = str.Length;
var array = new int[count];
int sum = 0;
for (int i = 0; i < count; i++)
{
    array[i] = int.Parse(str[i].ToString());
    sum +=array[i];
}
Console.Write(sum);
return sum;
}
try
{
    Sum();
}
catch
{
Console.WriteLine("Нужно вводить число ");
}