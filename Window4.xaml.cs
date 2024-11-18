using System.Windows;
using System.Windows.Controls;

namespace Pereverzev_Prac2
{
    public partial class Window4 : Window
    {
        private string secretPassword = "Хлопковое Поле"; // Задайте новый пароль
        private int attemptCount = 0; // Счетчик попыток

        public Window4()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordBox.Password; // Получаем пароль из PasswordBox

            // Проверка пароля
            if (enteredPassword == secretPassword)
            {
                MessageLabel.Content = "Доступ предоставлен! Тайное сообщение: \"Секретное сообщение здесь!\"";
            }
            else
            {
                attemptCount++;
                if (attemptCount < 3) // Ограничение на 3 попытки
                {
                    MessageLabel.Content = $"Неверный пароль. Попробуйте снова. Осталось попыток: {3 - attemptCount}";
                }
                else
                {
                    MessageLabel.Content = "Превышено количество попыток. Доступ заблокирован.";
                    PasswordBox.IsEnabled = false; // Отключение PasswordBox
                }
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
