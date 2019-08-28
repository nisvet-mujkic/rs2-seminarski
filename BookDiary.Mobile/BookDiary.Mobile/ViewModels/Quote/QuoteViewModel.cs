using BookDiary.Mobile.Services;
using BookDiary.Mobile.Views;
using BookDiary.Model.Requests.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Quote
{
    public class QuoteViewModel : BaseViewModel
    {
        private readonly ApiService _quotesService = new ApiService("Quotes");
        public QuoteViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ProceedCommand = new Command(() => Proceed());
        }


        private Model.Models.Quote _quote = null;
        public Model.Models.Quote Quote
        {
            get { return _quote; }
            set { SetProperty(ref _quote, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand ProceedCommand { get; set; }

        public async Task Init()
        {
            try
            {
                var searchRequest = new QuotesSearchRequest()
                {
                    IsBooksLoadingEnabled = true
                };

                var quotesEntities = await _quotesService.Get<List<Model.Models.Quote>>(searchRequest);

                var approvedQuotes = quotesEntities.Where(x => !x.Archived);

                var rand = new Random();
                int toSkip = rand.Next(1, approvedQuotes.Count());

                Quote = approvedQuotes.OrderBy(x => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
            }
            catch (System.Exception)
            {

            }
        }

        public void Proceed()
        {
            Application.Current.MainPage = new MainPage();
        }
    }

}
