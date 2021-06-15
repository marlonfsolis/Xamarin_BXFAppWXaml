using BXFAppWXaml.Views;
using System;
using Xamarin.Forms;

namespace BXFAppWXaml
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        private async void OnModalItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());

            /* Set FlyoutIsPresented to false to hide programmatically the Flyout page.
             * When using Navigation the Flyout stay open and need to close manually.
             */
            Shell.Current.FlyoutIsPresented = false;
        }

    }
}
