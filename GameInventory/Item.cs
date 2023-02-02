using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class Item
    {

        public string Description { get; set; }
        public string Name { get; set; }
        public RarityType Rarity { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }


        /// <summary>
        /// Item Constructor
        /// 
        /// When called, and given parameters, creates an object called Item, with different value types.
        /// Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
        /// 
        /// Used by Clue and Weapon classes to make Items, with specific values.
        /// </summary>
        /// <param name="name">Name of the Item</param>
        /// <param name="description">Description of what the Item does</param>
        /// <param name="weight"> Weight, in pounds, of the Item</param>
        /// <param name="value">Value, in USD, of the Item's worth</param>
        public Item(string name, string description, double weight, double value)
        {
            Description = description;
            Name = name;
            Weight = weight;
            Value = value;

            if (Rarity != RarityType.COMMON)
            {
                name = Rarity.ToString() + " " + name;
            }
        }

        /// <summary>
        /// Takes the given Item, from the parameter, and sets each element to a string, and formatted.
        /// </summary>
        /// <param name="item">The Item, using the constructor above.</param>
        /// <returns></returns>
        public string ToString(Item item)
        {
            string strItem =   $"Item Name: {item.Name.ToString()}\n" +
                               $"Description: {item.Description.ToString()}\n" +
                               $"Weight: {item.Weight.ToString()}\n" +
                               $"Value: {item.Value.ToString()}\n";
            Console.WriteLine(strItem);
            return strItem;
        }
    }
}
