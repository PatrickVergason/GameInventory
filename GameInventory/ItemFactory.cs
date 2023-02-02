using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class ItemFactory
    {
        public Clue MakeRandomClue()
        {
            Clue clue = new Clue("", "", 0, 0, null, null)
            {

            };
            return clue;
        }
        public Clue MakeRandomClue(string incriminates, bool isAccurate)
        {
            Clue clue = new Clue("", "", 0, 0, incriminates, isAccurate);
            return clue;
        }
        public Item MakeRandomItem()
        {
            Random random = new Random();
            Item item = new Item("", "", 0, 0);

            return item;
        }
        public Weapon MakeRandomWeapon(RarityType rarity)
        {
            Weapon weapon = new Weapon("", "", 0, 0);
            return weapon;
        }
        public Weapon MakeRandomWeapon(RarityType rarity, bool isAccurate, string incriminates)
        {
            Weapon weapon = new Weapon("", "", 0, 0);
            return weapon;
        }
    }
}
