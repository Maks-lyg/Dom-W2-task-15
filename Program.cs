Console.WriteLine("Введите число");
int day = int.Parse(Console.ReadLine());
if (day < 6)
{
    Console.WriteLine($"{day} -> Нет");
}
else
Console.WriteLine($"{day} -> Да");