using IdleMiner.Interfaces;

namespace IdleMiner.Items
{
    public class Ore : Item, ISellable, ICollectable
    {
        public int Value { get; set; }

        public Ore(string name, string description, string icon, int value) : base(name, description, icon)
        {
            Value = value;
        }

        public void Sell(Player player)
        {
            player.GetInventory().Remove(this);
            player.AddMoney(Value);
        }

        public void AddCollectable(Player player)
        {
            player.GetInventory().Add(this);
        }
    }
}