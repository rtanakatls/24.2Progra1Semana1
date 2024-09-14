using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Progra1Semana1.Game
{
    internal class GameMenu
    {

        public void Execute()
        {
            Player player = new Player();
            player.PickUp(new Potion("Poción de vida"));
            player.PickUp(new Armor("Casco"));
            player.PickUp(new Tile());

            player.CheckAllItems();
        }
    }
}
