// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    if (Number1 > Number3)
    {
        Console.WriteLine("Максимальное число: " + Number1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + Number3);
    }
}

else if (Number2 > Number3)
{
    Console.WriteLine("Максимальное число: " + Number2);
}
else
{
    Console.WriteLine("Максимальное число: " + Number3);
}