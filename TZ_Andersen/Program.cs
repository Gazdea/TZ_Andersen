using System;
namespace TZ_Andersen
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.WriteLine("Выберите задачу выбрав цифру: ");
            Console.WriteLine("1. Алгоритм на число больше 7");
            Console.WriteLine("2. Алгоритм на слово Вячеслав");
            Console.WriteLine("3. Алгоритм на числа кратные 3");

            string Switch = Console.ReadLine();

            switch (Switch)
            {
                case "1":
                    Console.Write("Введите целое число - ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a > 7) { Console.WriteLine("Привет"); }

                    Console.WriteLine("Нажмите Enter что-бы продолжить");
                    Console.Read();
                    break;

                case "2":
                    Console.Write("Введите имя - ");
                    string name = Console.ReadLine();

                    if (name == "Вячеслав") { Console.WriteLine("Привет, Вячеслав"); }
                    else { Console.WriteLine("Нет такого имени"); }

                    Console.WriteLine("Нажмите Enter что-бы продолжить");
                    Console.Read();
                    break;

                case "3":
                    int i = 0;
                    int[] mass = new int[5];
                    Random rnd = new Random();

                    Console.WriteLine("Выберите цифру: ");
                    Console.WriteLine("1. Набор сгенерированных чисел в массиве");
                    Console.WriteLine("2. Ручной набор чисел");

                    string num = Console.ReadLine();

                    switch (num)
                    {
                        case "1":
                            i = 0;
                            Console.WriteLine();
                            Console.Write("Сгенерированные числа = ");

                            while (i < 5)
                            {
                                mass[i] = rnd.Next(-100, 100);
                                Console.Write(mass[i] + " ");
                                i++;
                            }
                            break;

                        case "2":
                            i = 0;

                            while (i < 5)
                            {
                                Console.Write("Введите число = ");
                                mass[i] = Convert.ToInt32(Console.ReadLine());
                                i++;
                            }
                            break;
                    }
                    int b = 0;
                    i = 0;

                    Console.WriteLine();
                    Console.Write("Числа кратные 3 = ");

                    while (i < 5)
                    {
                        if (mass[i] % 3 == 0) { Console.Write(mass[i] + " "); b++; }
                        i++;
                    }

                    if (b == 0) Console.WriteLine("Нет");

                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter что-бы продолжить");
                    Console.Read();
                    break;
            }
            Console.Clear();
            goto menu;
        }
    }
}
