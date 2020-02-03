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
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
        }

        public void ShowPassword(object sender, EventArgs args)
        {
            Password.IsPassword = Password.IsPassword ? false : true;
            PasswordVisibility.Text = Password.IsPassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
            Password.FontAttributes = FontAttributes.Bold;
        }

        public void ShowPasswordRepeat(object sender, EventArgs args)
        {
            PasswordRepeat.IsPassword = PasswordRepeat.IsPassword ? false : true;
            PasswordRepeatVisibility.Text = PasswordRepeat.IsPassword ? Utils.Icon.Visible : Utils.Icon.Invisible;
            PasswordRepeat.FontAttributes = FontAttributes.Bold;
        }

        public void FocusUsername(object sender, EventArgs args)
        {
            Username.Focus();
        }

        public void FocusPassword(object sender, EventArgs args)
        {
            Password.Focus();
        }

        public void FocusPasswordRepeat(object sender, EventArgs args)
        {
            PasswordRepeat.Focus();
        }


        private async void goToLogin(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}