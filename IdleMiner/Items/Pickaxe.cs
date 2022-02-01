using IdleMiner.Interfaces;

namespace IdleMiner.Items
{
    public class Pickaxe : Item, IBuyable
    {
        private int _damage;
        public int Price { get; set; }

        public Pickaxe(string name, string description, string icon, int price, int damage) : base(name, description, icon)
        {
            _damage = damage;
            Price = price;
        }

        public int GetDamage() => _damage;

        public void Buy(Player player)
        {
            if(player.GetMoney() > Price)
            {
                // Get Shop from GameManage
                  // Remove Pickaxe from Shop and under if the person decides to buy a pickaxe that is higher remove the pickaxes behind that
               // Take players money Hehehe
            }
        }
    }
}
