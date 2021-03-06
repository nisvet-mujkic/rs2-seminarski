﻿namespace BookDiary.Mobile.Models
{
    public enum MenuItemType
    {
        Books,
        CurrentlyReading,
        Trending,
        History
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
