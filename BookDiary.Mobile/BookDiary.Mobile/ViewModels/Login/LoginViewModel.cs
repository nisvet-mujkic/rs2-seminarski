using BookDiary.Mobile.Services;
using BookDiary.Mobile.Views;
using BookDiary.Mobile.Views.Quotes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ApiService _usersService = new ApiService("Users");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
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
                var users = await _usersService.Get<List<Model.Models.User>>(null);

                SetLoggedUser(users);

                Application.Current.MainPage = new QuotePage();
            }
            catch (Exception ex)
            {

            }
        }

        private void SetLoggedUser(List<Model.Models.User> users)
        {
            users.ForEach(user =>
            {
                if (ApiService.Username == user.Username)
                {
                    if (Application.Current.Properties.ContainsKey("id"))
                    {
                        Application.Current.Properties.Clear();
                        Application.Current.Properties.Add("id", user.Id);
                    }
                }
            });
        }
    }
}
