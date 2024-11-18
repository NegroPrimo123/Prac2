using System;
using System.Windows;

namespace Pereverzev_Prac2
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем числа и оператор из текстовых полей
            if (double.TryParse(FirstNumberTextBox.Text, out double operand1) &&
                double.TryParse(SecondNumberTextBox.Text, out double operand2))
            {
                string operation = OperatorTextBox.Text.Trim();
                double result = 0;
                string message;

                // Выполняем операцию в зависимости от введенного оператора
                switch (operation)
                {
                    case "+":
                        result = operand1 + operand2;
                        message = $"Результат: {result}";
                        break;
                    case "-":
                        result = operand1 - operand2;
                        message = $"Результат: {result}";
                        break;
                    case "*":
                        result = operand1 * operand2;
                        message = $"Результат: {result}";
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            message = "Ошибка: Деление на ноль невозможно.";
                        }
                        else
                        {
                            result = operand1 / operand2;
                            message = $"Результат: {result}";
                        }
                        break;
                    default:
                        message = "Ошибка: Неверный знак операции.";
                        break;
                }

                // Выводим результат или сообщение об ошибке
                ResultLabel.Content = message;
            }
            else
            {
                ResultLabel.Content = "Ошибка: Введите корректные числа.";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pW = new MainWindow();
            pW.Show();
            Close();
        }
    }
}
