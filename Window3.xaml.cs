using Pereverzev_Prac2;
using System;
using System.Windows;

namespace Pereverzev_Prac2
{
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение числа от пользователя
                int number = Convert.ToInt32(InputNumberTextBox.Text);

                // Проверка диапазонов
                if (number >= 0 && number <= 14)
                {
                    ResultLabel.Content = "Число попадает в диапазон [0 - 14].";
                }
                else if (number >= 15 && number <= 35)
                {
                    ResultLabel.Content = "Число попадает в диапазон [15 - 35].";
                }
                else if (number >= 36 && number <= 50)
                {
                    ResultLabel.Content = "Число попадает в диапазон [36 - 50].";
                }
                else if (number >= 51 && number <= 100)
                {
                    ResultLabel.Content = "Число попадает в диапазон [51 - 100].";
                }
                else
                {
                    ResultLabel.Content = "Число не входит ни в один из диапазонов.";
                }
            }
            catch (FormatException)
            {
                ResultLabel.Content = "Ошибка: Введите корректное целое число от 0 до 100.";
            }
            catch (Exception ex)
            {
                ResultLabel.Content = $"Произошла ошибка: {ex.Message}";
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
