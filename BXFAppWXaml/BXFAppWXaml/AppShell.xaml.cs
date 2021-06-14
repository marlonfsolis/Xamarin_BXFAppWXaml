using BXFAppWXaml.Views;
using Xamarin.Forms;

namespace BXFAppWXaml
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
