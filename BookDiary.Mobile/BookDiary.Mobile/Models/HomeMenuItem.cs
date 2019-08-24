namespace BookDiary.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Books,
        CurrentlyReading,
        Trending,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
