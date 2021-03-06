﻿using BookDiary.Mobile.ViewModels.Books;
using BookDiary.Mobile.Views.ReadingList;
using BookDiary.Mobile.Views.Review;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookDiary.Mobile.Views.Books
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookDetailsPage : ContentPage
    {
        private BookDetailsViewModel viewModel;
        public BookDetailsPage(BookDetailsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        public BookDetailsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await viewModel.AddToReadingList();
            await Navigation.PushAsync(new ReadingListPage());
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BookReviewsPage(new ViewModels.Review.BookReviewsViewModel(this.viewModel.Book.Id)));
        }
    }
}