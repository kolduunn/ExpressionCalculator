using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionCalculator
{
    //Calculator:
    //Stack<int> – стек операндов.
    //Методы обработки операций.
    //Методы:
    //Evaluate(string expression): Вычислить выражение.
    internal class Calculator
    {
        public Stack<int> _operand = new Stack<int>();

        public int Evaluate(string expression)
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (Int32.TryParse($"{expression[i]}", out int number)) // Странный костыль с $"{expression[i]}"
                {
                    _operand.Push(number);
                }

                else if (($"{expression[i]}") == " ")
                {
                    continue;
                }

                else
                {
                    int operand2 = _operand.Pop();
                    int operand1 = _operand.Pop();

                    string expressionOperator = $"{expression[i]}";

                    switch (expressionOperator)
                    {
                        case "+":
                            _operand.Push(operand1 + operand2);
                            break;
                        case "-":
                            _operand.Push(operand1 - operand2);
                            break;
                        case "*":
                            _operand.Push(operand1 * operand2);
                            break;
                        case "/":
                            _operand.Push(operand1 / operand2);
                            break;
                        default:
                            return -1;
                    }
                }

            }

            return _operand.Peek();
        }
    }
}
