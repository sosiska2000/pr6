using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SingIn.Elements
{
    /// <summary>
    /// Логика взаимодействия для ElementCapture.xaml
    /// </summary>
    public partial class ElementCapture : UserControl
    {
        public CorrectCapture HandlerCorrectCapture;
        public delegate void CorrectCapture();

        public string StrCapture;
        public int WidhtCapture = 280, HeightCapture = 50;

        public ElementCapture()
        {
            InitializeComponent();
        }
        public void CreateCapture()
        {
            InputCapture.Text = "";
            Capture.Children.Clear();
            StrCapture = "";
            CreateBackground();
            Background();
        }
        void CreateBackground()
        {
            Random ThisRandom = new Random();
            for (int i = 0; i < 100; i++)
            {
                int Number = ThisRandom.Next(0, 9);
                Label lNumber = new Label()
                {
                    Content = Number,
                    FontSize = ThisRandom.Next(10, 16),
                    FontWeight = FontWeights.Bold,
                    Foreground = new SolidColorBrush
                    (Color.FromArgb(
                        100,
                        (byte)ThisRandom.Next(0, 255),
                        (byte)ThisRandom.Next(0, 255),
                        (byte)ThisRandom.Next(0, 255))),
                    Margin = new Thickness(
                        ThisRandom.Next(20, WidhtCapture - 20),
                        ThisRandom.Next(20, HeightCapture - 20), 0, 0)
                };
                Capture.Children.Add(lNumber);
            }
        }
        void Background()
        {
            Random ThisRandom = new Random();
            for (int i = 0; i < 4; i++)
            {
                int Number = ThisRandom.Next(0, 9);
                Label lNumber = new Label()
                {
                    Content = Number,
                    FontSize = 30,
                    FontWeight = FontWeights.Bold,
                    Foreground = new SolidColorBrush
                    (Color.FromArgb(
                        255,
                        (byte)ThisRandom.Next(0, 255),
                        (byte)ThisRandom.Next(0, 255),
                        (byte)ThisRandom.Next(0, 255))),
                    Margin = new Thickness(
                        WidhtCapture/2 - 60 + i*30,
                        ThisRandom.Next(-10, 10), 0, 0)
                };
                Capture.Children.Add(lNumber);
                StrCapture
            }
        }
        private void EnterCapture(object sender, KeyEventArgs e)
        {

        }
    }
}
