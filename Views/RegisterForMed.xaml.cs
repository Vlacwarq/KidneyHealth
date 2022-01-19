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
	public partial class RegisterForMed : ContentPage
	{
		public RegisterForMed ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			Shell.Current.GoToAsync("AddRegistrationPage");
		}
    }
}