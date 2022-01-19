using MyFirstApp.Services;
using MyFirstApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Jost.ttf", Alias = "Jost")]

[assembly: ExportFont("Jost1.ttf", Alias ="Jost1")]
namespace MyFirstApp
{


    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        
    }
}


