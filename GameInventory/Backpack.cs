using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class Backpack
    {
        public List<Item> contents = new List<Item>();

        public void Add(Item item) => contents.Add(item);
        public Backpack()
        {

        }
        public string ListClues()
        {
            string message = "Clues-------------------------------------------";
            for (int i = 0; i < contents.Count; i++) {
                message += contents[i].ToString();
            }
            message += "--------------------------------------------------\n\n";
            return message;
        }
        public string ListItems()
        {
            ListWeapons();
            ListClues();
            return "";
        }
        public string ListWeapons()
        {
            string message = "Weapons-------------------------------------------";
            for (int i = 0; i < contents.Count; i++)
            {
                message += contents[i].ToString();
            }
            message += "--------------------------------------------------\n\n";
            return message;
        }
    }
}
