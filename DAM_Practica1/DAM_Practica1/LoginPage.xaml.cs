using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAM_Practica1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void ShowPassword(object sender, EventArgs args)
        {
            Password.IsPassword = Password.IsPassword ? false : true;
            Visibility.Text = Password.IsPassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
            Password.FontAttributes = FontAttributes.Bold;
        }

        public void FocusPassword(object sender, EventArgs args)
        {
            Password.Focus();
        }


        private async void goToSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}