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
    }
}
