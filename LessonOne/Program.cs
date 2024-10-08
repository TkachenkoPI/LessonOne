﻿using System;
using System.ComponentModel;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                else if (taskNumber == 3) FizzBuzz();
                else if (taskNumber == 4) MinimumAndAverageValues();
                else if (taskNumber == 5) MonthsListing();
                else if (taskNumber == 6) ReverseArray();
                else if (taskNumber == 7) TwoCars();
                else if (taskNumber == 8) Salary();
                else if (taskNumber == 9) Deposits();
                else if (taskNumber == 10) MonthDays();
                else if (taskNumber == 11) TicTacToe();

                Console.WriteLine("");
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

            int[] arrayCopy = new int[10];
            int[] array = NewRandomArray(10);

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
            //Задача состоит в том, чтобы вывести все числа от 1 до 100.Но если число является кратным 3,
            //вместо него следует вывести слово «Fizz». Если число кратно 5, выводим «Buzz». Если число
            //кратно как 3, так и 5(например, 15 или 30), то выводим «FizzBuzz». Например, «1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz...»

            Console.WriteLine("ДЗ: FizzBuzz");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz");
                else if (i % 3 == 0) Console.Write("Fizz");
                else if (i % 5 == 0) Console.Write("Buzz");
                else Console.Write(i);

                Console.Write(" ");
            }
        }

        private static void MinimumAndAverageValues()
        {
            //Задача минимальное и среднее значение

            //Создайте целочисленный массив и заполните его любыми значениями.
            //Выведите в консоль минимальное значение в массиве и среднее значение.
            //Для обхода используйте foreach.

            Console.WriteLine("ДЗ: минимальное и среднее значение");
            Console.WriteLine("");

            int arrayLenght = 3;
            int[] array = NewRandomArray(arrayLenght);
            int minValue = array[0];
            int sum = 0;

            foreach (int i in array)
            {
                if (minValue > i) minValue = i;

                sum += i;
            }

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine("Минимальное значение в массиве: " + minValue);
            Console.WriteLine("Среднее значение в массиве: " + (float)sum / arrayLenght);
        }

        private static void MonthsListing()
        {
            //Задача перечисление месяцев

            //Используя перечисление(enum) DaysOfWeek в качестве примера, создайте перечисление для
            //представления месяцев года.Присвойте им значения от 1 до 12. Напишите программу, которая
            //попросит пользователя ввести число от 1 до 12. Убедитесь, что пользователь ввёл значение
            //в нужном диапазоне и используйте явное приведение типа для преобразования числа в созданный
            //вами enum. Затем выведите название месяца в консоль.

            Console.WriteLine("ДЗ: перечисление месяцев");
            Console.WriteLine("");

            int monthNumber = MonthNumber();

            Console.WriteLine($"Название месяца: {(MonthsOfYear)monthNumber}");
        }

        private static int MonthNumber()
        {
            int monthNumber;

            Console.WriteLine("Введи число от 1 до 12:");

            while (true)
            {
                monthNumber = GetNumber();

                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное целое число.");
                }
            }

            return monthNumber;
        }

        enum MonthsOfYear
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        private static void ReverseArray()
        {
            //Задача перевернуть массив
            //Давайте сделаем программу, которая использует методы для выполнения задачи.Давайте возьмем массив
            //и перевернём его содержимое в обратном порядке. Например, если у вас массив 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            //то результатом будет 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.Чтобы добиться этого, вы создадите три метода:
            //один для создания массива, один для его переворачивания и один для вывода массива в конце.

            //Ваш метод Main будет выглядеть примерно так:
            //            static void Main(string args)
            //            {
            //                int numbers = GenerateNumbers();
            //                Reverse(numbers);
            //                PrintNumbers(numbers);
            //            }
            //
            //Метод GenerateNumbers должен вернуть массив из 10 случайных чисел
            //(бонусное условие -метод должен принимать в качестве аргумента длину желаемого массива).
            //
            //Метод PrintNumbers должен использовать цикл for или foreach для вывода каждого элемента массива.
            //
            //Метод Reverse будет делать основную работу -переворачивать массив.

            //Реализуйте все три метода.

            Console.WriteLine("ДЗ: перевернуть массив");
            Console.WriteLine("");

            int[] numbers = NewRandomArray(10);

            PrintNumbers(numbers);
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        private static void Reverse(int[] numbers)
        {
            int arrayLength = numbers.Length;
            int[] reverse = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                reverse[arrayLength - i - 1] = numbers[i];
            }

            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = reverse[i];
            }
        }

        private static void PrintNumbers(int[] numbers)
        {
            int arrayLength = numbers.Length;
            Console.WriteLine("");

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"{numbers[i]}");

                if (arrayLength != (i + 1)) Console.Write(", ");
            }

        }

        private static void TwoCars()
        {
            //Два автомобиля
            //Два автомобиля едут друг за другом с постоянными скоростями V1 и V2 км / час.
            //Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.

            //Условия и ограничения:
            //Значения V1, V2, S -должны вводиться через стандартный ввод.

            //Результат вывести в стандартный вывод.

            Console.WriteLine("ДЗ: два автомобиля");
            Console.WriteLine("");

            Console.Write("Введите скорость первого автомобиля (V1) км/ч: ");
            int V1 = GetNumber();

            Console.Write("Введите скорость второго автомобиля (V2) км/ч: ");
            int V2 = GetNumber();

            Console.Write("Введите расстояние S (в км) между автомобилями в момент опережения: ");
            int S = GetNumber();

            float time = 0.5f;
            float way1 = V1 * time;
            float way2 = V2 * time;
            float distance = S + (way1 - way2);

            // Вывод результата
            Console.WriteLine($"Расстояние между автомобилями через 30 минут: {distance} км");
        }

        private static void Salary()
        {
            //Зарплата
            //В двумерном массиве хранится информация о зарплате 7ми человек за каждый месяц года
            //(за январь — в первом столбце, за февраль — во втором и т. д.).

            //Определить общую зарплату, выплаченную в выбранном месяце.

            //Условия и ограничения:
            //     Элементы массива заранее заданы в коде программы
            //     Месяц, на который требуется рассчитать зарплату, должен вводиться через стандартный ввод

            Console.WriteLine("ДЗ: зарплата");
            Console.WriteLine("");

            Console.WriteLine("Сгенерированый сет данных:");
            int[,] data = DataSalary();

            Console.WriteLine();

            int monthNumber = MonthNumber();
            int SalarySum = 0;

            for (int i = 0; i < monthNumber; i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    SalarySum += data[i, j];
                }
            }

            Console.WriteLine($"На {(MonthsOfYear)monthNumber} включительно общая зарплата равна {SalarySum}");
        }

        static int[,] DataSalary()
        {
            int[,] data = new int[12, 7];
            Random rand = new Random();

            Console.WriteLine();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rand.Next(10, 20) * 100;
                    Console.Write(data[i, j] + " ");
                }

                Console.WriteLine();
            }

            return data;
        }

        private static void Deposits()
        {
            //Вклады
            //Гражданин 1го марта открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада
            //увеличивается на 2% от имеющейся суммы. Определить:

            //прирост суммы вклада за первый, второй, ..., десятый месяц;
            //сумму вклада через три, четыре, ..., двенадцать месяцев

            //Условия и ограничения:
            //Значение числа должно вводиться через стандартный ввод
            //Результаты вычисления вывести в стандартный вывод
            //Для вычисления использовать рекурсию
            //

            Console.WriteLine("ДЗ: вклады");
            Console.WriteLine("");

            Console.WriteLine("Внесите сумму.");
            float deposit = (float)GetNumber();
            float rate = 0.02f;

            Console.WriteLine("На какое количество месяцев хотите внести сумму?");
            int monthCount = GetNumber();

            float[] growths = new float[monthCount];
            float[] deposits = new float[monthCount];

            GrowthDeposit(growths, deposits, 0, monthCount, deposit, rate);

            Console.WriteLine("Прирост суммы вклада: " + string.Join(", ", growths));
            Console.WriteLine("Cуммы вклада: " + string.Join(", ", deposits));
        }

        private static void GrowthDeposit(float[] growths, float[] deposits, int index, int monthCount, float deposit, float rate)
        {
            if (monthCount == index)
            {
                return;
            }
            else
            {
                float growth = deposit * rate;
                deposit = deposit + growth;

                growths[index] = growth;
                deposits[index] = deposit;

                GrowthDeposit(growths, deposits, ++index, monthCount, deposit, rate);
            }
        }

        private static void MonthDays()
        {
            //Дни месяца
            //Составить программу, которая в зависимости от порядкового номера месяца(1, 2, ..., 12)
            //и года выводит на экран количество дней в этом месяце. При вычисление количества дней учесть високосный год.

            //Год является високосным, если его номер кратен 4, однако из кратных 100 високосными
            //являются лишь кратные 400, например, 1700, 1800 и 1900 — невисокосные года, 2000 — високосный.

            //Условия и ограничения:
            //  Значение номера месяца и год должны вводиться через стандартный ввод
            //  Результаты вычисления вывести в стандартный вывод
            //  Добавить проверку на корректность ввода данных

            Console.WriteLine("ДЗ: дни месяца");
            Console.WriteLine("");

            Console.WriteLine("Введите год:");
            int year = GetNumber();

            Console.WriteLine("Введите месяц:");
            int month = MonthNumber();
            int days = DaysInMonth(year, month);

            Console.WriteLine($"Дней в {(MonthsOfYear)month} {year} г.: {days}");
        }

        //Год является високосным, если его номер кратен 4, однако из кратных 100 високосными
        //являются лишь кратные 400, например, 1700, 1800 и 1900 — невисокосные года, 2000 — високосный.
        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private static int DaysInMonth(int year, int month)
        {
            int days;

            if (month == 1) days = 31;
            else if (month == 2) days = IsLeapYear(year) ? 29 : 28;
            else if (month == 3) days = 31;
            else if (month == 4) days = 30;
            else if (month == 5) days = 31;
            else if (month == 6) days = 30;
            else if (month == 7) days = 31;
            else if (month == 8) days = 31;
            else if (month == 9) days = 30;
            else if (month == 10) days = 31;
            else if (month == 11) days = 30;
            else days = 31;

            return days;
        }

        private static void TicTacToe()
        {
            //Задача крестики-нолики
            //Создайте игру в крестики-нолики, которая соответствует требованиям, изложенным ниже:

            //-Игровой процесс протекает в консоли(не требуется графический интерфейс пользователя).
            //-Два игрока - человека делают ходы по очереди, используя одну и ту же клавиатуру.
            //-Игроки могут указать, в какую клетку они хотят сыграть, используя клавиатуру.
            //  Один из возможных подходов заключается в том, чтобы пронумеровать клетки в доске 3x3 цифрами от 1 до 9,
            //  как цифровая клавиатура NumPad. Если игрок вводит число 7, то выбирается верхний левый угол доски
            //-Игра должна гарантировать соблюдение правил при каждом ходе:
            //  -Нельзя играть в квадрат, который уже занят.
            //  -Игрок не может сделать ход не в свою очередь.
            //  -Если игрок пытается делать запрещённый ход, доска должна остаться неизменной.
            //-Игра должна уметь определять, когда один из игроков выигрывает, или когда ничья.
            //-При обнаружении конца игры результат отображается пользователю.
            //-Приложение может завершиться после одного раунда игры.

            //Пример отображения игрового поля в консоли:
            //   | X |
            //---+---+---
            //   | O | X
            //---+---+---
            // O |   |

            Console.Clear();
            Console.WriteLine("Добро пожаловать в игру крестики-нолики");

            int maxMove = 9;
            int currentMove = 0;
            bool gameIsEnd = false;
            string winner = "";
            string currentPlayer = "X";
            string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            int[,] winConditions = WinConditions();

            while (true)
            {
                ++currentMove;

                DisplayBoard(board);

                Console.WriteLine($"Текущий ход {currentPlayer}");
                int input = Move(board);
                board[input - 1] = currentPlayer;

                if (currentMove > 4)
                {
                    gameIsEnd = CheckResult(maxMove, currentMove, winner, currentPlayer, board, winConditions);
                }

                if (gameIsEnd) break;

                currentPlayer = ReverSecurrentPlaer(currentPlayer);
                Console.Clear();

            }

        }

        private static int[,] WinConditions()
        {
            return new int[,]{
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 0, 3, 6 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 0, 4, 8 },
            { 2, 4, 6 }
            };
        }

        private static bool CheckResult(int maxMove, int currentMove, string winner, string currentPlayer, string[] board, int[,] winConditions)
        {
            bool gameIsEnd = false;

            if (CheckWinner(winner, board, winConditions, currentPlayer))
            {
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine($"Победил игрок: {currentPlayer}");
                gameIsEnd = true;
            }
            else if (maxMove == currentMove)
            {
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine($"Ничья");
                gameIsEnd = true;
            }

            return gameIsEnd;
        }

        private static bool CheckWinner(string winner, string[] board, int[,] winConditions, string currentPlayer)
        {
            bool isVictory = false;

            for (int i = 0; i < winConditions.GetLength(0); i++)
            {
                isVictory = (board[winConditions[i, 0]] == currentPlayer
                    && board[winConditions[i, 1]] == currentPlayer
                    && board[winConditions[i, 2]] == currentPlayer);

                if (isVictory) break;
            }

            return isVictory;
        }

        private static string ReverSecurrentPlaer(string currentPlaer)
        {
            return currentPlaer == "X" ? "O" : "X";
        }

        private static void DisplayBoard(string[] board)
        {
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine();
        }

        private static int Move(string[] board)
        {
            int move;

            Console.WriteLine("Введи число от 1 до 9:");

            while (true)
            {
                move = GetNumber();

                if (move >= 1 && move <= 9)
                {
                    if (board[move - 1] == " ") break;
                    else Console.WriteLine("Эта позиция уже занята.");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное целое число.");
                }
            }

            return move;
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

        private static int[] NewRandomArray(int lenght)
        {
            int[] array = new int[lenght];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            return array;
        }

    }
}