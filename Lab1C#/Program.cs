using System;

while (true)
{
    Console.Clear();
    Console.WriteLine(" Лабораторна робота 1");
    Console.WriteLine("1. Завдання 1: Периметр трикутника");
    Console.WriteLine("2. Завдання 2: Кратнiсть суми цифр (двозначне число)");
    Console.WriteLine("3. Завдання 3: Точка в заштрихованiй областi");
    Console.WriteLine("4. Завдання 4: Назва поточного мiсяця");
    Console.WriteLine("5. Завдання 5: Квадрат добутку двох чисел");
    Console.WriteLine("6. Завдання 6: Обчислення виразу 6.11");
    Console.WriteLine("0. Вихiд");
    Console.Write("\nОберiть номер завдання: ");

    string choice = Console.ReadLine();

    if (choice == "0") break;

    switch (choice)
    {
        case "1":
            Console.WriteLine("\nЗавдання 1");
            Console.Write("Введіть x1, y1, x2, y2, x3, y3 через пробiл: ");
            string[] c = Console.ReadLine().Split();
            double x1 = double.Parse(c[0]), y1 = double.Parse(c[1]);
            double x2 = double.Parse(c[2]), y2 = double.Parse(c[3]);
            double x3 = double.Parse(c[4]), y3 = double.Parse(c[5]);

            double sA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double sB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double sC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            Console.WriteLine($"Периметр: {sA + sB + sC:F2}");
            break;

        case "2":
            Console.WriteLine("\nЗавдання 2");
            Console.Write("Введiть двозначне число: ");
            int num2 = Math.Abs(int.Parse(Console.ReadLine()));
            if (num2 >= 10 && num2 <= 99)
            {
                int sum = (num2 / 10) + (num2 % 10);
                Console.WriteLine($"Сума цифр ({sum}) " + (sum % 3 == 0 ? "кратна 3" : "не кратна 3"));
            }
            else Console.WriteLine("Число не двозначне!");
            break;

        case "3":
            Console.WriteLine("\nЗавдання 3");
            Console.Write("Введiть x та y через пробiл: ");
            string[] p = Console.ReadLine().Split();
            double px = double.Parse(p[0]), py = double.Parse(p[1]);
            if (((px == -50 || px == 50) && (py >= -25 && py <= 25)) || ((py == -25 || py == 25) && (px >= -50 && px <= 50)))
                Console.WriteLine("На межi");
            else if (px > -50 && px < 50 && py > -25 && py < 25)
                Console.WriteLine("Так");
            else Console.WriteLine("Нi");
            break;

        case "4":
            Console.WriteLine("\n Завдання 4 ");
            Console.Write("Введiть m (мiсяцi) та n (днi): ");
            string[] t = Console.ReadLine().Split();
            int m = int.Parse(t[0]);
            string month = ((m % 12) + 1) switch
            {
                1 => "Сiчень",
                2 => "Лютий",
                3 => "Березень",
                4 => "Квiтень",
                5 => "Травень",
                6 => "Червень",
                7 => "Липень",
                8 => "Серпень",
                9 => "Вересень",
                10 => "Жовтень",
                11 => "Листопад",
                12 => "Грудень",
                _ => "Помилка"
            };
            Console.WriteLine($"Поточний мiсяць: {month}");
            break;

        case "5":
            Console.WriteLine("\nЗавдання 5");
            Console.Write("Введiть два числа: ");
            string[] v = Console.ReadLine().Split();
            long prod = (long)int.Parse(v[0]) * int.Parse(v[1]);
            Console.WriteLine($"Квадрат добутку: {prod * prod}");
            break;

        case "6":
            Console.WriteLine("\nЗавдання 6");
            Console.Write("Введiть x та y: ");
            string[] val = Console.ReadLine().Split();
            double x = double.Parse(val[0]), y = double.Parse(val[1]);
            if (x * y + 1 == 0) Console.WriteLine("Помилка: дiлення на нуль");
            else
            {
                double res = ((x * y * y + x * x * y) / (x * y + 1)) * (x - y);
                Console.WriteLine($"Результат: {res:F4}");
            }
            break;

        default:
            Console.WriteLine("Невiрний вибiр!");
            break;
    }

    Console.WriteLine("\nНатиснiть будь-яку клавiшу, щоб повернутися до меню...");
    Console.ReadKey();
}