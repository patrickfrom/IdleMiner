namespace IdleMiner.Items
{
    public class Vein
    {
        private string _name;
        private int _health;
        private int _maxHealth;
        private Ore _ore;

        public Vein(string name, int maxHealth, Ore ore)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _ore = ore;
        }

        public string GetName() => _name;
        public int GetHealth() => _health;
        public Ore GetOre() => _ore;

        public void Mine(Player player)
        {
            if(_health > 0) {
                _health -= player.GetPickaxe().GetDamage();
            } else {
                _health = _maxHealth;
                _ore.AddCollectable(player);
            }
        }
    }
}
