using System;
using static System.Console;


namespace NewMethod
{
    internal class MyMethod1
    {
        public static int InputInt(string msg)
        {
            Write(msg + " ");
            string answer = ReadLine() ?? string.Empty;
            bool flag = int.TryParse(answer, out int number);
            answer = $"Ошибка ввода: {answer} - не является целым числом";
            if (flag) return number;
            else ErrorExit(answer);
            return -1;
        }

        public static double InputDouble(string msg)
        {
            Write(msg + " ");
            string answer = ReadLine() ?? string.Empty;
            if (answer != string.Empty)
            {
                answer = CorrectRus(answer);
            }
            bool flag = double.TryParse(answer, out double number);
            answer = $"Ошибка ввода: {answer} - не является числом";
            if (flag) return number;
            else ErrorExit(answer);
            return -1;
        }

        static string CorrectRus(string msg)
        {
            string result = string.Empty;
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == '.')
                    result += ',';
                else
                    result += msg[i];
            }
            return result;
        }

        public static void ErrorExit(string msg)
        {
            WriteLine(msg);
            Environment.Exit(1);
        }

        public static double PowerNumber(double value)
        {
            return value * value;
        }

        public static bool IsSquareNumber(double value1, double value2)
        {
            return value1 == value2 * value2 ? true : false;
        }

        public static double MaxNumber(double value1, double value2)
        {
            if (value1 > value2) return value1;
            else if (value2 > value1) return value2;
            return 0;
        }

        public static double MinNumber(double value1, double value2)
        {
            if (value1 < value2) return value1;
            else if (value2 < value1) return value2;
            return 0;
        }
    }
}
