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

        protected async void OnClicked(object source, EventArgs args)
        {
            await Shell.Current.GoToAsync("//main");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//login/registration");
        }
    }
}
