namespace IdleMiner.Items
{
    public abstract class Item
    {
        private string _name;
        private string _description;
        private string _icon;

        public Item(string name, string description, string icon)
        {
            _name = name;
            _description = description;
            _icon = icon;
        }

        public string GetName() => _name;
        public string GetDescription() => _description;
        public string GetIcon() => _icon;
    }
}
