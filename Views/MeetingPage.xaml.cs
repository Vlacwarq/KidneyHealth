using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace MyFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeetingPage : ContentPage
    {
        public MeetingPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("UserLogin");

        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("AboutPage");

        }
    }

   
}