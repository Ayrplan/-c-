// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(n) < 10)
//     Console.WriteLine("Нет второй цифры: ");
// else{
//     while (n > 100)
//         n = n / 10;
//     Console.WriteLine(n % 10);
// }




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(можно использовать индексацию строк)
// 645 -> 5 
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(n) < 100)
//     Console.WriteLine("Нет третьей цифры: ");
// else{
//     while (n > 1000)
//         n = n / 10;
//     Console.WriteLine(n % 10);
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// while (a<1 || a>7)
// {
//     Console.WriteLine("Вы ошиблись!!! Введите число: ");
//     a = Convert.ToInt32(Console.ReadLine());
// }

// if (a == 1) Console.WriteLine ("Понедельник, нет");
// else if (a == 2) Console.WriteLine ("Вторник, нет");
// else if (a == 3) Console.WriteLine ("Среда, нет");
// else if (a == 4) Console.WriteLine ("Четверг, нет");
// else if (a == 5) Console.WriteLine ("Пятница, нет");
// else if (a == 6) Console.WriteLine ("Суббота, да");
// else if (a == 7) Console.WriteLine ("Воскресенье, да");  



