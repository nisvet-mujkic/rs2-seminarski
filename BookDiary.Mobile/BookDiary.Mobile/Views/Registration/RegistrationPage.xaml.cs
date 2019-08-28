using BookDiary.Mobile.ViewModels.Registration;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        private readonly RegistrationViewModel viewModel;
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RegistrationViewModel();
        }

       
    }
}