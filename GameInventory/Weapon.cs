using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory {
    internal class Weapon : Clue
    {
        public int Damage;
        public DamageType damageType;

        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value, null, null){
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }
        public new string ToString(Item weapon)
        {
            string strWeapon = $"Item Name: {weapon.Name.ToString()}\n" +
                               $"Description: {weapon.Description.ToString()}\n" +
                               $"Weight: {weapon.Weight.ToString()} pounds\n" +
                               $"Value: ${weapon.Value.ToString()}\n" +
                               $"Damage Type: {damageType.ToString()}" +
                               $"Damage Dealt: {Damage.ToString()} kicks in the stomach";
            Console.WriteLine(strWeapon);
            return strWeapon;
        }
    }
}
