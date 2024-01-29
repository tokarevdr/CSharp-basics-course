using System;
using System.ComponentModel;

namespace PracticalExercise9
{
    internal class Program
    {
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        static void Main(string[] args)
        {
            Console.WriteLine("| Простейший кулькулятор |");

            try
            {
                Console.WriteLine("Введите целое число:");
                int operand1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите целое число:");
                int operand2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите номер операции:\n\t1 - сложение\n\t2 - вычитание\n\t3 - умножение\n\t4 - деление");
                Operation operation = (Operation)Convert.ToInt32(Console.ReadLine());

                double result;

                switch (operation)
                {
                    case Operation.Add:
                        result = operand1 + operand2;
                        break;

                    case Operation.Subtract:
                        result = operand1 - operand2;
                        break;

                    case Operation.Multiply:
                        result = operand1 * operand2;
                        break;

                    case Operation.Divide:
                        result = (double)operand1 / operand2;
                        break;

                    default: throw new InvalidEnumArgumentException();
                }

                Console.WriteLine();
                Console.WriteLine($"Результат: {result:f}");
            }
            catch (InvalidEnumArgumentException)
            {
                Console.WriteLine("Ошибка! Нет операции с указанным номером");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
