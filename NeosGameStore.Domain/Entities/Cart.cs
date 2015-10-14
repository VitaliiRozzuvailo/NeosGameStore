using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosGameStore.Domain.Entities
{
    public class CartLine
    {
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }

    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Game game, int quentity)
        {
            CartLine line = lineCollection
                .Where(g => g.Game.GameId == game.GameId)
                .FirstOrDefault();
            if(line==null)
            {
                this.lineCollection.Add(
                    new CartLine()
                    {
                        Game=game,
                        Quantity=quentity
                    });
            }
            else
            {
                line.Quantity += quentity;
            }
        }

        public void RemoveLine(Game game)
        {
            this.lineCollection.RemoveAll(l => l.Game.GameId == game.GameId);
        }

        public decimal ComputeTotalValue()
        {
            return this.lineCollection.Sum(e => e.Game.Price * e.Quantity);
        }

        public void Clear()
        {
            this.lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return this.lineCollection; }
        }
    }
}
