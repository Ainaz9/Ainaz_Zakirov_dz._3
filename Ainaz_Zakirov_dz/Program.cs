// DZ3
namespace Dz
{   
    public class Dz31
    {
        public enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7

        }
        public static void Main(string[] arg)
        {
            /* #1 Дана последовательность из 10 чисел. Определить, является ли эта последовательность
            упорядоченной по возрастанию.В случае отрицательного ответа определить
            порядковый номер первого числа, которое нарушает данную последовательность.
            Использовать break. */
            Console.WriteLine("Номер 1: ");
            int[] posled = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 10 };  // Наша последовательность
            for (int i = 0; i < posled.Length - 1; i++)   // Цикл, кот. проходит по каждому элементу
            {
                if (posled[i] > posled[i + 1])
                {
                    Console.WriteLine($"Возрастающаяся последовательность прерывается на {i + 2} элементе");
                    break;
                }
                else if (i == 9)
                {
                    Console.WriteLine("Последовательность возрастающая");
                }
            }
            Console.WriteLine();
            /* #2 Игральным картам условно присвоены следующие порядковые номера в зависимости от
            их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            Порядковые номера остальных карт соответствуют их названиям («шестерка»,
            «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
            соответствующей карты. Использовать try-catch-finally. */
            Console.WriteLine("Номер 2: ");
            try
            {
                Console.Write("Введите значение k (от 6 до 14): ");
                int k = int.Parse(Console.ReadLine());
                if (k >= 6 & k <= 10)
                {
                    Console.WriteLine($"{k}-ка");
                }
                else if (k == 11)
                {
                    Console.WriteLine("Валет");
                }
                else if (k == 12)
                {
                    Console.WriteLine("Дама");
                }
                else if (k == 13)
                {
                    Console.WriteLine("Король");
                }
                else if (k == 14)
                {
                    Console.WriteLine("Туз");
                }
                else
                {
                    Console.WriteLine("Число должно быть от 6 до 14 !!!");
                }
            }
            catch
            {
                Console.WriteLine("Введенное значение не является числом.");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
            Console.WriteLine();
            /* #3 Напишите программу, которая принимает на входе строку и производит выходные
            данные в соответствии со следующей таблицей:
            "Jabroni" - "Patron Tequila"
            "School Counselor" - "Anything with Alcohol"
            "Programmer" - "Hipster Craft Beer"
            "Bike Gang Member" - "Moonshine"
            "Politician" - "Your tax dollar"
            "Rapper" - "Cristal"
            anything else - "Beer"
            Примечание. По умолчанию используется “все остальное”: если входные данные
            функции не соответствуют ни одному из значений в таблице, то возвращаемое значение
            должно быть «Beer».
            Убедитесь, что вы охватили случаи, когда некоторые слова не отображаются с
            правильным написанием заглавных букв. Например, ввод «pOLitiCIaN» должен
            по-прежнему возвращать «Your tax dollars». */
            Console.WriteLine("Номер 3: ");
            Dictionary<string, string> drinkMap = new Dictionary<string, string>
            {
                {"jabroni", "Patron Tequila"},
                {"school counselor", "Anything with Alcohol"},
                {"programmer", "Hipster Craft Beer"},
                {"bike gang member", "Moonshine"},
                {"politician", "Your tax dollars"},
                {"rapper", "Cristal"}
            };
            Console.Write("Введите профессию: ");
            string profession = Console.ReadLine()?.ToLower().Trim();
            if (drinkMap.ContainsKey(profession))
            {
                Console.WriteLine(drinkMap[profession]);
            }
            else
            {
                Console.WriteLine("Beer");
            }
            Console.WriteLine();
            /* #4 Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
            ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
            Использовать enum.
             */
            Console.WriteLine("Номер 4: ");
            Console.Write("Введите порядковый номер дня недели (от 1 до 7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                DayOfWeek day;
                if (Enum.TryParse<DayOfWeek>(dayNumber.ToString(), out day))
                {
                    Console.WriteLine(day.ToString());
                }
                else
                {
                    Console.WriteLine("Не удалось распознать день недели.");
                }
            }
            else
            {
                Console.WriteLine("Неверный номер дня недели. Должно быть от 1 до 7.");
            }
            Console.WriteLine();
            /* #5 Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
            "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
            результату. Вывести на экран сколько кукол в “сумке”. */
            Console.WriteLine("Номер 5: ");
            string[] toys = { "Lego", "Hello Kitty", "Teddy Bear", "Barbie doll", "Spider man", "Hello Kitty" };
            int sumka = 0;
            foreach (var toy in toys)
            {
                if (toy == "Hello Kitty" | toy == "Barbie doll")
                {
                    sumka++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {sumka}");
            Console.WriteLine();
        }
    }
}