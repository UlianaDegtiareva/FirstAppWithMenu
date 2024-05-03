using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstAppWithMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        Button startButton;
        public StartPage()
        {
            InitializeComponent();
            CreateLayout();


            startButton.Clicked += StartButton_Clicked;
        }

        private void CreateLayout()
        {
            // Создание Grid для размещения элементов
            Grid grid = new Grid
            {
                BackgroundColor = Color.LightCyan,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            // Добавление строки для круга с надписью "Yummy" в центре
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            // Добавление строки для кнопки "Начать работу"
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            // Добавление строки для кнопки "Инструкция"
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            // Добавление строки для изображения
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            // Добавление строки для надписи "Все права защищены"
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            // Создание круглого BoxView с градиентом от голубого к зеленому
            Brush diagonalGradientBrush = new LinearGradientBrush
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(1, 1),
                GradientStops =
                {
                    new GradientStop { Color = Color.LightSkyBlue, Offset = 0 },
                    new GradientStop { Color = Color.MediumSpringGreen, Offset = 1 }
                }
            };

            BoxView circle = new BoxView
            {
                WidthRequest = 250,
                HeightRequest = 250,
                CornerRadius = 125,
                Background = diagonalGradientBrush,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Создание Label с текстом "Yummy"
            Label label = new Label
            {
                Text = "Yummy",
                FontSize = 50,
                FontFamily = "Times New Roman",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Создание кнопки "Начать работу"
            startButton = new Button
            {
                Text = "Начать работу",
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderColor = Color.LightSkyBlue,
                BorderWidth = 1,
                CornerRadius = 5,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 210, // Увеличение ширины кнопки
                HeightRequest = 80 // Увеличение высоты кнопки
            };

            // Установка градиента для кнопки "Начать работу"
            startButton.Background = new LinearGradientBrush
            {
                GradientStops =
                {
                    new GradientStop { Color = Color.White, Offset = 0 },
                    new GradientStop { Color = Color.LightSkyBlue, Offset = 1 }
                }
            };

            // Создание кнопки "Инструкция"
            Button button = new Button
            {
                Text = "Инструкция",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center
            };

            // Установка градиента для кнопки "Инструкция"
            button.Background = new LinearGradientBrush
            {
                GradientStops =
                {
                    new GradientStop { Color = Color.White, Offset = 0 },
                    new GradientStop { Color = Color.LightGray, Offset = 1 }
                }
            };

            // Установка границы серого цвета для кнопки "Инструкция"
            button.BorderColor = Color.Gray;
            button.BorderWidth = 1;
            button.CornerRadius = 5;

            // Создание изображения
            Image image = new Image
            {
                Source = "https://cdn-icons-png.flaticon.com/512/4310/4310157.png",
                Aspect = Aspect.AspectFit, // Установка типа масштабирования изображения
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand // Расположение изображения по центру вертикально
            };

            // Создание Label с текстом "Все права защищены"
            Label rightsLabel = new Label
            {
                Text = "Все права защищены",
                FontSize = 12,
                TextColor = Color.Gray,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End // Расположение внизу экрана
            };

            // Добавление элементов в Grid с указанием строки и столбца
            grid.Children.Add(circle, 0, 0);
            grid.Children.Add(label, 0, 0);
            grid.Children.Add(startButton, 0, 1); // Кнопка "Начать работу"
            grid.Children.Add(button, 0, 2); // Кнопка "Инструкция"
            grid.Children.Add(image, 0, 3); // Изображение
            grid.Children.Add(rightsLabel, 0, 4); // Надпись "Все права защищены"

            // Установка Grid как содержимого страницы
            Content = grid;
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            AppShell appShell = new AppShell();
            Application.Current.MainPage = appShell; // Устанавливаем AppShell как главную страницу приложения
        }
    }
}