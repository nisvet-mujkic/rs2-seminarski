using BookDiary.Mobile.ViewModels.Quote;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Quotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotePage : ContentPage
    {
        private readonly QuoteViewModel viewModel;
        public QuotePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new QuoteViewModel(); 
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            viewModel.Proceed();
        }
    }
}