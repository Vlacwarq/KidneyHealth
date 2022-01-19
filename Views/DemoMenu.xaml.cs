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
    public partial class DemoMenu : TabbedPage
    {
        public DemoMenu ()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("FoodDetail1");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("Restrictments");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("FoodDetail2");
        }
    }
}