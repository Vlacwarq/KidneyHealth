using MyFirstApp.ViewModels;
using MyFirstApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(AddRegistrationPage), typeof(AddRegistrationPage));
            Routing.RegisterRoute(nameof(UserRegisterPage), typeof(UserRegisterPage));
            Routing.RegisterRoute(nameof(UserRegisterPage1), typeof(UserRegisterPage1));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(RegisterForMed), typeof(RegisterForMed));
            Routing.RegisterRoute(nameof(UserLogin), typeof(UserLogin));
            Routing.RegisterRoute(nameof(FoodDetail1), typeof(FoodDetail1));
            Routing.RegisterRoute(nameof(FoodDetail2), typeof(FoodDetail2));
            Routing.RegisterRoute(nameof(UserProfile), typeof(UserProfile));
            Routing.RegisterRoute(nameof(DemoMenu), typeof(DemoMenu));
            Routing.RegisterRoute(nameof(Restrictments), typeof(Restrictments));
        }

        
    }
}
