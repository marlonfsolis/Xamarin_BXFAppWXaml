using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXFAppWXaml.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private async void GotoMenuPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"////{nameof(MenuPage)}");
        }
    }
}