using FirstAppWithMenu.Services;
using FirstAppWithMenu.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstAppWithMenu
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new StartPage());
        }
    }
}
