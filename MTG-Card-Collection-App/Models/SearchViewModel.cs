﻿namespace MTG_Card_Collection_App.Models
{
    public class SearchViewModel
    {
        public List<MtgApiManager.Lib.Model.ICard> Cards { get; set; }
        public string NameFilter { get; set; }
    }
}