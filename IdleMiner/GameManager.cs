using System.Collections.Generic;
using IdleMiner.Items;

namespace IdleMiner
{
    public class GameManager
    {
        public Player player;
        public List<Pickaxe> PickaxeShop = new List<Pickaxe>();
        public List<Vein> Veins = new List<Vein>();

        public void ConductGame()
        {
            GeneratePickaxeShop();
            GenerateVeins();
        }

        public void GeneratePickaxeShop()
        {
            CreatePickaxe("Copper Pickaxe", "Copper Pickaxe which is useful to progress beyond a miners journey.", "Cu⛏️", 250, 3);
            CreatePickaxe("Iron Pickaxe", "Iron Pickaxe made out of iron", "Fe⛏️", 650, 6);
            CreatePickaxe("Gold Pickaxe", "Gold Pickaxe, uuuh shiny!", "Au⛏️", 1025, 9);
        }

        public void GenerateVeins()
        {
            CreateVein("Stone Vein", 4, new Ore("Stone", "A Piece of stone", "🗿", 1));
            CreateVein("Coal Vein", 7, new Ore("Coal", "Coal, this pollutes our lovely Planet Earth but we live in a Capatalistic world so go ahead and sell it!", "🗿C", 3));
            CreateVein("Copper Vein", 13, new Ore("Copper Ingot", "Copper Ingot which could be made into tools or cosmetics", "🗿Cu", 6));
        }

        public void CreatePlayer(string name)
        {
            player = new Player(name);
        }

        public void CreatePickaxe(string name, string description, string icon, int price, int damage)
        {
            Pickaxe pickaxe = new Pickaxe(name, description, icon, price, damage);
            PickaxeShop.Add(pickaxe);
        }

        public void CreateVein(string name, int maxHealth, Ore ore)
        {
            Vein vein = new Vein(name, maxHealth, ore);
            Veins.Add(vein);
        }
    }
}
