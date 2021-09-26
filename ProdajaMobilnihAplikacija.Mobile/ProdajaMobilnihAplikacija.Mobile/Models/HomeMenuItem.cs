using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        Softver,
        Racun,
        MojSoftver,
        MojiKomentari,
        PostavkeProfila,
        About,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
