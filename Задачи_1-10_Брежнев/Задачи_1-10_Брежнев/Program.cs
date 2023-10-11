namespace Brezhnev_nikita_3_11_IP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Задача_1();
            Задача_2();
            Задача_3();
            Задача_4();
            Задача_5();
            Задача_6();
            Задача_7();
            Задача_8();
            Задача_9();
            Задача_10();
        }
        public static void Задача_1()
        {
            Console.WriteLine("-----------------(Задача_1)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            if (chislo % 3 == 0)
            {
                Console.WriteLine("Да, это число делится на 3");
            }
            else
            {
                Console.WriteLine("Нет, это число не делится на 3");
            } 
        }
        public static void Задача_2()
        {
            Console.WriteLine("-----------------(Задача_2)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            if (chislo % 5 == 2 && chislo % 7 == 1)
            {
                Console.WriteLine("Удовлетворяет");
            }
            else
            {
                Console.WriteLine("Не удовлетворяет");
            }
        }
        public static void Задача_3()
        {
            Console.WriteLine("-----------------(Задача_3)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            if (chislo > 10 && chislo % 4 == 0)
            {
                Console.WriteLine("Удовлетворяет");
            }
            else
            {
                Console.WriteLine("Не удовлетворяет");
            }
        }

        public static void Задача_4()
        {
            Console.WriteLine("-----------------(Задача_4)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            if (chislo >= 5 && chislo <= 10)
            {
                Console.WriteLine("Число входит в диапазон");
            }
            else
            {
                Console.WriteLine("Число не входит в диапазон");
            }
        }

        public static void Задача_5()
        {
            Console.WriteLine("-----------------(Задача_5)-----------------");
            int chislo; 
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            int n = chislo / 1000 % 10;
            Console.WriteLine("В числе " + n + " тысяч");
        }
        public static void Задача_6()
        {
            Console.WriteLine("-----------------(Задача_6)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            chislo = (chislo / 8) % 8;
            Console.WriteLine("Вторая цифра восьмеричного представления числа: " + chislo);

        }
        public static void Задача_7()
        {
            Console.WriteLine("-----------------(Задача_7)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            chislo = (chislo >> 2) & 1;
            Console.WriteLine("Третий бит справа - " + chislo);
        }

        public static void Задача_8()
        {
            Console.WriteLine("-----------------(Задача_8)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            chislo = chislo | 1 << 3;
            Console.WriteLine("Конечный вариант - " + chislo);
        }

        public static void Задача_9()
        {
            Console.WriteLine("-----------------(Задача_9)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            chislo &= ~(1 << 4);
            Console.WriteLine("Конечный вариант - " + chislo);
        }

        public static void Задача_10()
        {
            Console.WriteLine("-----------------(Задача_10)-----------------");
            int chislo;
            Console.WriteLine("Введите число: ");

            bool isValidInput = false;
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out chislo);
                if (!isValidInput)
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!isValidInput);

            chislo = chislo ^ (1 << 2);
            Console.WriteLine("Конечный вариант - " + chislo);
        }
    }
}
