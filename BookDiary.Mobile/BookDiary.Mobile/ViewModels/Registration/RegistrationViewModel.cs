using BookDiary.Mobile.Services;
using BookDiary.Mobile.Views.Login;
using BookDiary.Model.Requests.Users;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Registration
{
    public class RegistrationViewModel : BaseViewModel
    {
        private readonly ApiService _userService = new ApiService("Users");
        public RegistrationViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        public ICommand RegisterCommand { get; set; }

        private UsersUpsertRequest _request = new UsersUpsertRequest();
        public UsersUpsertRequest Request
        {
            get { return _request; }
            set { SetProperty(ref _request, value); }
        }

        public async Task Register()
        {
            IsBusy = true;

            try
            {
                Request.Roles = new System.Collections.Generic.List<int>();
                Request.Roles.Add(2);
                var entity = await _userService.Insert<Model.Models.User>(Request);

                if(entity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "You have been successfully registered", "OK");
                    Application.Current.MainPage = new LoginPage();
                }

            }
            catch (System.Exception)
            {

            }
        }
    }
}
