using Project_Nazarov;

int[,] values = { };
var sort = new SortByBubble();
string matrix = "";
int length1 = 0;
int length2 = 0;

Console.WriteLine("-----------------------");
Console.WriteLine("h - help---------------");
Console.WriteLine("i - input: 1 2 3, 1 2 3");
Console.WriteLine("s - sort---------------");
Console.WriteLine("--- q - minimum--------");
Console.WriteLine("--- w - maximum--------");
Console.WriteLine("--- e - summary--------");
Console.WriteLine("------- a - ask--------");
Console.WriteLine("------- d - desk-------");
Console.WriteLine("-----------------------");

while (true)
{
    switch (char.ToLower(Console.ReadKey(true).KeyChar))
    {
        case 'h':
            Console.WriteLine("-----------------------");
            Console.WriteLine("h - help---------------");
            Console.WriteLine("i - input: 1 2 3, 1 2 3");
            Console.WriteLine("s - sort---------------");
            Console.WriteLine("--- q - minimum--------");
            Console.WriteLine("--- w - maximum--------");
            Console.WriteLine("--- e - summary--------");
            Console.WriteLine("------- a - ask--------");
            Console.WriteLine("------- d - desk-------");
            Console.WriteLine("-----------------------");
            break;
        case 'i':
            Console.WriteLine("length1");
            Int32.TryParse(Console.ReadLine(), out length1);
            Console.WriteLine("length2");
            Int32.TryParse(Console.ReadLine(), out length2);
            values = new int[length1, length2];
            Console.WriteLine("matrix");
            matrix = Console.ReadLine();

            string[] tempMatrix = matrix.Split(", ");
            for (int i = 0; i < length1; i++)
            {
                string[] temp = tempMatrix[i].Split(' ');
                for (int j = 0; j < length2; j++)
                {
                    values[i, j] = int.Parse(temp[j]);
                }
            }
            break;
        case 's':
            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case 'q':
                    switch (char.ToLower(Console.ReadKey(true).KeyChar))
                    {
                        case 'a':
                            sort.Sort(ref values, SortByBubble.Min_El_Sort, SortByBubble.Sort_Asc);
                            break;
                        case 'd':
                            sort.Sort(ref values, SortByBubble.Min_El_Sort, SortByBubble.Sort_Desk);
                            break;
                    }
                    break;
                case 'w':
                    switch (char.ToLower(Console.ReadKey(true).KeyChar))
                    {
                        case 'a':
                            sort.Sort(ref values, SortByBubble.Max_El_Sort, SortByBubble.Sort_Asc);
                            break;
                        case 'd':
                            sort.Sort(ref values, SortByBubble.Max_El_Sort, SortByBubble.Sort_Desk);
                            break;
                    }
                    break;
                case 'e':
                    switch (char.ToLower(Console.ReadKey(true).KeyChar))
                    {
                        case 'a':
                            sort.Sort(ref values, SortByBubble.Sum_Row, SortByBubble.Sort_Asc);
                            break;
                        case 'd':
                            sort.Sort(ref values, SortByBubble.Sum_Row, SortByBubble.Sort_Desk);
                            break;
                    }
                    break;
            }
            break;
    }
    Console.WriteLine("-----------------------");
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            Console.Write("{0} ", values[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------");
}