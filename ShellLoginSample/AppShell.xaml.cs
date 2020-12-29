using ShellLoginSample.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellLoginSample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("registration", typeof(RegistrationModal));
        }

        private void Shell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            if(e.Current != null) { 
                var deferral = e.GetDeferral(); // hey shell, wait a moment

                // intercept navigation here and do your custom logic. 
                // continue on to the destination route, cancel it, or reroute as needed

                // e.Cancel(); to stop routing
                // deferral.Complete(); to resume
                if(e.Target.Location.OriginalString.Contains("back"))
                {
                    e.Cancel();//don't actually go to a route called back
                    Shell.Current.GoToAsync(".."); // this is the universal "back" in Shell                   
                }
                else if (e.Target.Location.OriginalString.Contains("logout"))
                {
                    e.Cancel();
                    Shell.Current.GoToAsync("//login");
                }

                deferral.Complete();
            }
        }
    }

    public class HiddenItem : ShellItem
    {

    }
}
