using NeosGameStore.Domain.Abstract;
using NeosGameStore.Domain.Entities;
using System.Collections.Generic;

namespace NeosGameStore.Domain.Concrete
{
    public class EFGameRepository:IGameRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get { return this.context.Games; }
        }
    }
}
