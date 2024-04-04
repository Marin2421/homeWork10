//Домашнее задание. Тема 10. Урок 1. Класс Math
Console.Write("Введите радиус:");
double r = double.Parse(Console.ReadLine());
double l = 2 * Math.PI * r;
double s = Math.PI * r * r;
Console.WriteLine($"Длинна: {l:F2}\nПлощадь: {s:F2}");
//Домашнее задание. Тема 10. Урок 2. Класс Math
Console.Write("Введите катет:");
double k = double.Parse(Console.ReadLine());
Console.Write("Введите гипотенузу:");
double g = double.Parse(Console.ReadLine());
double k2 = Math.Sqrt(g * g - k * k);
Console.WriteLine($"Второй катет равен: {k2}");
