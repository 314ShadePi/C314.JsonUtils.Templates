using System.Text;

namespace C314.JsonUtils.Templates
{

    public class CList
    {
        public string name { get; set; }
        public IList<Board> boards { get; set; }

        public override string ToString()
        {
            string boardsFormattet = "";
            boards.ToList().ForEach(item => boardsFormattet += item.ToString() + "\n");
            return $"{name}\n{boardsFormattet}";
        }
        
        public void PrettyPrint(string indent = "", bool isLast = true)
        {
            var marker = isLast ? "└──" : "├──";
            Console.Write(indent);
            Console.Write(marker);
            Console.WriteLine(name);
            indent += isLast ? "   " : "|  ";
            var lastChild = boards.Count - 1;
            for (int i = 0; i < boards.Count; i++)
            {
                boards[i].PrettyPrint(indent, i == lastChild);
            }
        }
    }
}

// tree
//"├───"
//"└───"
//"│   "

//prettyprint
/*
 * └───name
 *     ├───board1 : desc
 *     |   ├───item1
 *     |   |   └───desc
 *     |   └───item2
 *     |       └───desc
 *     └───board2 : desc
 *         ├───item1
 *         |   └───desc
 *         └───item2
 *             └───desc
 */