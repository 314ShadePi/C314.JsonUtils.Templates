namespace C314.JsonUtils.Templates
{
    public class Item
    {
        public string name { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return $"{name}\n└───{description}";
        }
    }
}

// tree
//"├───"
//"└───"
//"│   "