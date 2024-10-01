namespace LessonOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = GetStartNumber();

            while (taskNumber != 0)
            {
                if (taskNumber == 1) RemainderDivisionethod();
                else if (taskNumber == 2) CopyArray();

                Console.WriteLine("===================================================================");
                taskNumber = GetStartNumber();
            }
        }

        private static int GetStartNumber()
        {
            Console.WriteLine("Введи номер задачи, которую хотите проверить. Для выхода введите 0.");
            Console.WriteLine("1 - Задача остаток от деления.");
            Console.WriteLine("2 - Задача копирование массива");
            Console.WriteLine("3 - Задача FizzBuzz");
            Console.WriteLine("4 - Задача минимальное и среднее значение");
            Console.WriteLine("5 - Задача перечисление месяцев");
            Console.WriteLine("6 - Задача перевернуть массив");
            Console.WriteLine("7 - Два автомобиля");
            Console.WriteLine("8 - Зарплата");
            Console.WriteLine("9 - Вклады");
            Console.WriteLine("10 - Дни месяца");
            Console.WriteLine("11 - Задача крестики-нолики");

            return GetNumber();
        }

        private static int GetNumber()
        {
            int result;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное целое число.");
                }
            }
        }

        private static void RemainderDivisionethod()
        {
            Console.WriteLine("ДЗ: Задача остаток от деления");
            Console.WriteLine("");

            Console.WriteLine("Введи первое число:");
            int a = GetNumber();

            Console.WriteLine("Введи второе число:");
            int b = GetNumber();

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} = {quotient} остаток {remainder}");
        }

        private static void CopyArray()
        {
            Console.WriteLine("ДЗ: копирование массива");
            Console.WriteLine("");
            Console.WriteLine("Создаем масив:");

            int[] array = new int[10];
            int[] arrayCopy = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("Копируем массив:");

            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }

            Console.WriteLine(string.Join(", ", array));

        }

        private static void FizzBuzz()
        {
            
        }

        private static void MinimumAndAverageValues()
        {

        }
        private static void MonthsListing()
        {

        }
        private static void FlipArray()
        {

        }
        private static void TwoCars()
        {

        }
        private static void Salary()
        {

        }
        private static void Deposits()
        {

        }
        private static void MonthDays()
        {

        }
        private static void TicTacToe()
        {

        }

    }
}