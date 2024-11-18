using System;
using System.Collections.Generic;
using System.Windows;

namespace Pereverzev_Prac2
{
    public partial class Window1 : Window
    {
        // Словарь для хранения переводов
        private Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "ветер", "wind" },
            { "облако", "cloud" },
            { "снег", "snow" },
            { "туман", "fog" },
            { "гроза", "thunderstorm" },
            { "температура", "temperature" },
            { "влажность", "humidity" },
            { "погода", "weather" }
        };

        public Window1()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string russianWord = InputTextBox.Text.ToLower();
            if (translations.TryGetValue(russianWord, out string englishWord))
            {
                ResultLabel.Content = $"Перевод: {englishWord}";
            }
            else
            {
                ResultLabel.Content = "Такого слова нет.";
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
