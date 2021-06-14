using BXFAppWXaml.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BXFAppWXaml.ViewModels
{
    class MenuViewModel : BaseViewModel
    {
        public Command GotoAboutCommand { get; }

        public MenuViewModel()
        {
            GotoAboutCommand = new Command(OnAboutCliecked);
        }

        private async void OnAboutCliecked(object obj)
        {
            await Shell.Current.GoToAsync($"////{nameof(AboutPage)}");
        }
    }
}
