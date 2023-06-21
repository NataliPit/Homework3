// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Введите число больше нуля: ");

int count = 1;
while (count <= num)
{
    Console.WriteLine(count * count * count);
    count++;
}
