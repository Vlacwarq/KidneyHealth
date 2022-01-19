using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MyFirstApp.Views
{

    public partial class AboutPage : ContentPage
    {

        public AboutPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("RegisterForMed");

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("RegisterPage");
        }
    }

    
}