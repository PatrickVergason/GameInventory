using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Backpack
    {
        ItemFactory itemFactory = new ItemFactory(); // Makes the compiler to shut up about calling functions in other classes.
        public List<Item> contents; // List of Items called contents
        

        /// <summary>
        /// Adds Item objects to a List of Items.
        /// </summary>
        /// <param name="item">An Item to be passed along.</param>
        public void Add(Item item) {
            contents.Add(item);
        }


        /// <summary>
        /// Backpack constructor to instantiate the 
        /// List of Items (contents), then add Item
        /// objects, made from ItemFactory's
        /// methods for making new objects. 
        /// </summary>
        public Backpack()
        {
            contents = new List<Item>();
            Add(item: itemFactory.MakeRandomClue()); // item: -> sets whatever comes out to be equal to the item parameter from Add(Item item)
            Add(item: itemFactory.MakeRandomClue("Colonel Mustard", true)); // Colonel Mustard did it. Here's the clue!
            Add(item: itemFactory.MakeRandomItem());
            Add(item: itemFactory.MakeRandomWeapon());
            Add(item: itemFactory.MakeRandomWeapon("Colonel Mustard", true)); // Colonel Mustard did it. Here's a weapon!
            Add(item: itemFactory.MakeRandomWeapon("Colonel Mustard", true)); // Colonel Mustard did it. Here's another weapon!
        }


        /// <summary>
        /// When called, creates a message string, adding the Clue items and their fields.
        /// </summary>
        /// <returns>The message string that was made.</returns>
        public string ListClues() //FIXME: Need to add to only get Clues
        {
            string messageClues = "Clues-------------------------------------------\n";
            for (int i = 0; i < contents.Count; i++) {
                messageClues += $"{contents[i].Name}\n";
                messageClues += $"{contents[i].Description}\n";
                messageClues += $"{contents[i].Weight}\n";
                messageClues += $"{contents[i].Value}\n";
                messageClues += "--------------------------------------------------\n";
            }
            messageClues += "\n\n";
            return messageClues;
        }

        /// <summary>
        /// When called, creates a message string, calling both ListClues()
        /// and ListWeapons() to combine and print all the items and their fields.
        /// </summary>
        /// <returns>The message string that was made.</returns>
        public string ListItems()
        {
            string messageItems = "";

            messageItems += ListWeapons();
            messageItems += ListClues();
            return messageItems;
        }

        /// <summary>
        /// When called, creates a message string, adding the Weapon items and their fields.
        /// </summary>
        /// <returns>The message string that was made.</returns>
        public string ListWeapons() //FIXME: Need to add to only get Weapons
        {
            string messageWeapons = "Weapons-------------------------------------------\n";
            for (int i = 0; i < contents.Count; i++)
            {
                messageWeapons += $"{contents[i].Name}\n";
                messageWeapons += $"{contents[i].Description}\n";
                messageWeapons += $"{contents[i].Weight}\n";
                messageWeapons += $"{contents[i].Value}\n";
                // TODO: Need to figure out how to add Weapon-only attributes in...
                //messageWeapons += $"{contents[i].damageType}\n"; 
                //messageWeapons += $"{contents[i].Damage}\n";
                messageWeapons += "--------------------------------------------------\n";
            }
            messageWeapons += "--------------------------------------------------\n\n";
            return messageWeapons;
        }
    }
}
