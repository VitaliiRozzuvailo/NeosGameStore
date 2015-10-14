using NeosGameStore.Domain.Entities;
using System.Collections.Generic;

namespace NeosGameStore.WebUI.Models
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurentCategory { get; set; }
    }
}