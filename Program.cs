namespace ExpressionCalculator
{
    internal class Program
    {
        //        4. Калькулятор выражений(Stack)
        //Задача:
        //Реализовать калькулятор, который обрабатывает выражения в обратной польской записи.

        //Пример работы калькулятора:
        //"3 4 + 2 *" → 14.

        //Входные данные примерные, напиши свои с клавиатуры:
        //var calc = new Calculator();
        //        Console.WriteLine(calc.Evaluate("3 4 + 2 *"));
        //Ожидаемый результат:
        //Вывод: 14.
        static void Main()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Evaluate("3 4 + 2 *"));
        }
    }
}
