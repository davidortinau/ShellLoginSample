using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellLoginSample.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<LoginPage>(this, 
                (UsernameTxt.Text == "admin") ? "admin" : "user"    
            );

            await Shell.Current.GoToAsync("//home");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//login/registration");
        }
    }
}
