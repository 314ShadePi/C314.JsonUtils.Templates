namespace C314.JsonUtils.Templates
{
    public class Item
    {
        public string name { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return $"{name}: {description}";
        }

        public void PrettyPrint(string indent = "", bool isLast = true)
        {
            var marker = isLast ? "└──" : "├──";
            var descIndent = isLast ? "   └──" : "|  └──";
            Console.Write(indent);
            Console.Write(marker);
            Console.Write(name + "\n" + indent + descIndent + description);
            Console.WriteLine();
            indent += isLast ? "   " : "|  ";
        }
    }
}