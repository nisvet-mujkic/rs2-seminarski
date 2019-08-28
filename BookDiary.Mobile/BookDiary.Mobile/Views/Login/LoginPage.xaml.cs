
using BookDiary.Mobile.Views.Registration;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new RegistrationPage();
        }
    }
}