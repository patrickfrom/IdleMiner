using IdleMiner.Items;
using System.Collections.Generic;

namespace IdleMiner
{
    public class Player
    {
        private string _name;
        private int _money;
        private Pickaxe _pickaxe;
        private List<Item> inventory = new List<Item>();

        public Player(string name)
        {
            _name = name;
            _pickaxe = new Pickaxe("Flint Pickaxe", "A Flint Pickaxe, your first ever pickaxe.", "⛏️", 0, 1);
        }

        public string GetName() => _name;
        public int GetMoney() => _money;
        public Pickaxe GetPickaxe() => _pickaxe;
        public List<Item> GetInventory() => inventory;

        public void AddMoney(int amount) => _money += amount;
    }
}
