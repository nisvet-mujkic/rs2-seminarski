using BookDiary.Mobile.Models;
using BookDiary.Mobile.Views.Books;
using BookDiary.Mobile.Views.ReadingList;
using BookDiary.Mobile.Views.Trending;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookDiary.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Books:
                        MenuPages.Add(id, new NavigationPage(new BooksPage()));
                        break;
                    case (int)MenuItemType.CurrentlyReading:
                        MenuPages.Add(id, new NavigationPage(new ReadingListPage()));
                        break;
                    case (int)MenuItemType.Trending:
                        MenuPages.Add(id, new NavigationPage(new TrendingPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}