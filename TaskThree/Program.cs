Console.Clear();
Console.WriteLine("Напишите число до которого будем куб возводить");
int a = int.Parse(Console.ReadLine()!);
    for(int i = 1; i <= a; i++)
        Console.WriteLine($"{i} в кубе = {i*i*i}");
