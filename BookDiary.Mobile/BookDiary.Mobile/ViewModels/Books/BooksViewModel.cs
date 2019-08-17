using BookDiary.Mobile.Services;
using BookDiary.Model.Requests.Books;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookDiary.Mobile.ViewModels.Books
{
    public class BooksViewModel : BaseViewModel
    {
        private readonly ApiService _booksService = new ApiService("Books");
        private readonly ApiService _genresService = new ApiService("Genres");
        private readonly ApiService _authorsService = new ApiService("Authors");

        public BooksViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Models.Book> Books { get; set; } = new ObservableCollection<Model.Models.Book>();
        public ObservableCollection<Model.Models.Genre> Genres { get; set; } = new ObservableCollection<Model.Models.Genre>();
        public ObservableCollection<Model.Models.Author> Authors { get; set; } = new ObservableCollection<Model.Models.Author>();

        public ICommand InitCommand { get; set; }

        string _searchTerm = string.Empty;
        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                if(value != null)
                    InitCommand.Execute(null);
            }
        }

        Model.Models.Genre _selectedGenre = null;
        public Model.Models.Genre SelectedGenre
        {
            get { return _selectedGenre; }
            set
            {
                SetProperty(ref _selectedGenre, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        Model.Models.Author _selectedAuthor = null;
        public Model.Models.Author SelectedAuthor
        {
            get { return _selectedAuthor; }
            set
            {
                SetProperty(ref _selectedAuthor, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        public async Task Init()
        {
            if (Genres.Count == 0)
            {
                var genreEntities = await _genresService.Get<List<Model.Models.Genre>>(null);
                genreEntities.ForEach((genre) => Genres.Add(genre));
            }

            if (Authors.Count == 0)
            {
                var authorsEntities = await _authorsService.Get<List<Model.Models.Author>>(null);
                authorsEntities.ForEach((author) => Authors.Add(author));
            }

            var searchRequest = new BooksSearchRequest()
            {
                IsAuthorsLoadingEnabled = true,
                IsGenresLoadingEnabled = true
            };

            if (SelectedGenre != null)
            {
                searchRequest.GenreId = SelectedGenre.Id;
            }

            if (SelectedAuthor != null)
            {
                searchRequest.AuthorId = SelectedAuthor.Id;
            }

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                searchRequest.SearchTerm = SearchTerm.Trim();
            }

            var bookEntities = await _booksService.Get<List<Model.Models.Book>>(searchRequest);
            Books.Clear();
            bookEntities.ForEach((book) => Books.Add(book));
        }
    }
}