using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class FavoriteList
    {
        public int FavoriteListId { get; set; }
        public int? AccountId { get; set; }
        public int? MusicId { get; set; }
    }
}
