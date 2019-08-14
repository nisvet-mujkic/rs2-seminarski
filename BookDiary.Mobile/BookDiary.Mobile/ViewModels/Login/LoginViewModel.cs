using BookDiary.Mobile.Services;
using BookDiary.Mobile.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ApiService _usersService = new ApiService("Users");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login()); ;
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public ICommand LoginCommand { get; set; }

        public async Task Login()
        {
            IsBusy = true;
            ApiService.Username = Username;
            ApiService.Password = Password;

            try
            {
                await _usersService.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
