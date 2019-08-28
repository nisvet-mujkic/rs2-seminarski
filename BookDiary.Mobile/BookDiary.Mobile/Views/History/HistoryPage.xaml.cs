using BookDiary.Mobile.ViewModels.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.History
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        private readonly HistoryViewModel viewModel;
        public HistoryPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HistoryViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await this.viewModel.Init();
        }
    }
}