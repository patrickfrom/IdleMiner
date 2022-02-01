namespace IdleMiner.Interfaces
{
    public interface IBuyable
    {
        int Price { get; set; }

        void Buy(Player player);
    }
}
