// SНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Введите число, состоящее из 5 цифр: ");

int reverse = 0;
int num2 = num;
while (num2 > 0)
{
    reverse = reverse * 10 + num2 % 10;
    num2 /= 10;
}

Console.WriteLine(reverse);

if (reverse == num)
{
    Console.WriteLine($"{num} - палиндром");
}
else
{
    Console.WriteLine($"{num} - не палиндром");
}