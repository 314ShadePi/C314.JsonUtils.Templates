using C314.JsonUtils.Templates;

CList list = new CList
{
    name = "list",
    boards = new List<Board>
    {
        new Board
        {
            name = "board1",
            description = "board1 description",
            items = new List<Item>
            {
                new Item
                {
                    name = "item1",
                    description = "item1 description"
                },
                new Item
                {
                    name = "item2",
                    description = "item2 description"
                }
            }
        },
        new Board
        {
            name = "board2",
            description = "board2 description",
            items = new List<Item>
            {
                new Item
                {
                    name = "item2",
                    description = "item2 description"
                },
                new Item
                {
                    name = "item2",
                    description = "item2 description"
                }
            }
        }        
    },
};

list.PrettyPrint();
/*prettyprint
 *
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
Console.ReadKey();
