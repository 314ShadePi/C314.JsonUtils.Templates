namespace C314.JsonUtils.Templates
{
    public class Board
    {
        public string name { get; set; }
        public string description { get; set; }
        public IList<Item> items { get; set; }

        public override string ToString()
        {
            string itemsFormattet = "";
            items.ToList().ForEach(item => itemsFormattet += item.ToString() + "\n");
            return $"{name}: {description}\n{itemsFormattet}";
        }

        public void PrettyPrint(string indent = "", bool isLast = true)
        {
            var marker = isLast ? "└──" : "├──";
            Console.Write(indent);
            Console.Write(marker);
            Console.Write(name + ": " + description);
            Console.WriteLine();
            indent += isLast ? "   " : "|  ";
            var lastChild = items.Count - 1;
            for (int i = 0; i < items.Count; i++)
            {
                items[i].PrettyPrint(indent, i == lastChild);
            }
        }
    }
}