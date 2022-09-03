Console.WriteLine("Пожалуйста введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее,а какое меньшее.");
Console.Write("Введите первое число:");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2)
{
    Console.WriteLine("Число" + num_1 + "большее");
    Console.Write("Число" + num_2 + "меньшее");
}
else if (num_1 == num_2)
{
    Console.WriteLine("Число" + num_1 + "равно числу" + num_2);
}
else
{
    Console.WriteLine("Число" + num_2 + "большее");
    Console.Write("Число" + num_1 + "меньшее");
}