// Тумаков
namespace dzLab
{
    public class Lab
    {
        static bool IsYear(int year)
        {
            return (year % 4 == 0 & year % 100 != 0);
        }
        public static void Main(string[] arg)
        {
            /* #1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
            в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
            февраля(високосный год не учитывать). */
            Console.WriteLine("Номер 1: ");
            Console.Write("Введите номер дня в году (от 1 до 365):");
            string day = Console.ReadLine();
            if (!int.TryParse(day, out int dayNumber))
            {
                Console.WriteLine("Введено неверное значение.");
                return;
            }
            if (dayNumber < 1 | dayNumber > 365)
            {
                Console.WriteLine("Введено неверное значение.");
                return;
            }
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int monthIndex = 0;
            while (dayNumber > days[monthIndex])
            {
                dayNumber -= days[monthIndex];
                monthIndex++;
            }
            Console.WriteLine($"{month[monthIndex]} {dayNumber}");
            Console.WriteLine();
            /* #2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
            исключение, и выдавать на экран сообщение.
                */
            Console.WriteLine("Номер 2: ");
            Console.Write("Введите номер дня в году (от 1 до 365):");
            string day1 = Console.ReadLine();
            if (!int.TryParse(day1, out int dayNumber1))
            {
                Console.WriteLine("Введено неверное значение.");
                return;
            }
            else if (dayNumber1 < 1 | dayNumber1 > 365)
            {
                Console.WriteLine("Введено неверное значение.");
                return;
            }
            int[] days1 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] month1 = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int monthIndex1 = 0;
            while (dayNumber1 > days1[monthIndex1])
            {
                dayNumber1 -= days1[monthIndex1];
                monthIndex1++;
            }
            Console.WriteLine($"{month1[monthIndex1]} {dayNumber1}");
            Console.WriteLine();
            /* #3 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
            учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
            делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
            год. Однако, если он делится без остатка на 400, это високосный год.)
             */
            Console.WriteLine("Номер 3: ");
            int[] days2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] month2 = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine("Введите год:");
            string Year = Console.ReadLine();
            if (!int.TryParse(Year, out int year))
            {
                Console.WriteLine("Введено неверное значение для года.");
                return;
            }
            if (year <= 0)
            {
                Console.WriteLine("Год должен быть больше 0.");
                return;
            }
            if (IsYear(year)) // Проверка не вискосный год
            {
                days2[1] = 29;
            }
            Console.WriteLine("Введите номер дня в году (от 1 до 366):");
            string day2 = Console.ReadLine();
            if (!int.TryParse(day2, out int dayNumber2))
            {
                Console.WriteLine("Введено неверное значение для дня.");
                return;
            }
            if (dayNumber2 < 1 | dayNumber2 > 366)
            {
                Console.WriteLine("Введено неверное значение для дня.");
                return;
            }
            if (days2[1] == 28 & dayNumber2 == 366) 
            {
                Console.WriteLine("Вы ввели 366 день и не високосный год, в не високосном году только 365 дней");
                return;
            }
            int monthIndex2 = 0;
            while (dayNumber2 > days2[monthIndex2])
            {
                dayNumber2 -= days2[monthIndex2];
                monthIndex2++;
            }
            Console.WriteLine($"{month2[monthIndex2]} {dayNumber2}, {year}");
            Console.WriteLine();

        }
    }
}