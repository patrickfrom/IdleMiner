namespace IdleMiner.Interfaces
{
    public interface ISellable
    {
        int Value { get; set; }

        void Sell(Player player);
    }
}
