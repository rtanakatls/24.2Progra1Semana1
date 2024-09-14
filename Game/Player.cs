using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Game
{
    internal class Player
    {
        protected List<Item> items;

        public Player()
        {
            items = new List<Item>();
        }

        public void PickUp(IPickable pickable)
        {
            pickable.PickUp();
            items.Add((Item)pickable);
        }

        public void CheckAllItems()
        {
            foreach(Item i in items)
            {
                Console.WriteLine($"Item: {i.Name}");
            }
        }
    }
}
