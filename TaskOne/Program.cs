Console.Clear();
Console.Write("Данная программа проверяет, является ли пятизначное число палиндромом.\n\nВведите пятизначное число: ");
string a = (Console.ReadLine()!);
while (int.Parse(a.ToString()) < 9999 || int.Parse(a.ToString()) >99999)
{
    Console.WriteLine("Число не пятизначное, ну ка давай вводи что бы было пять цифр");
    a = (Console.ReadLine()!);
}
if (int.Parse(a[0].ToString()) == Convert.ToInt32(a[4].ToString()) && 
    int.Parse(a[1].ToString()) == Convert.ToInt32(a[3].ToString()) )
    Console.Write("Да, число является палиндромом, поздравляю, счастья тебе и здоровья");

else
    Console.WriteLine("Нет, число не палиндромом, но все равно успехов тебе и здоровья");