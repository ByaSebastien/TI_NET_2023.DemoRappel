using System.Text;
using TI_NET_2023.Exercices;

Console.OutputEncoding = System.Text.Encoding.UTF8;

#region Déplacement tableau 2D

//const int TAILLE = 10;
//string[,] map = new string[TAILLE, TAILLE];
//int x = 0;
//int y = 0;

//for (int i = 0; i < map.GetLength(0); i++)
//{
//    for (int j = 0; j < map.GetLength(1); j++)
//    {
//        map[i, j] = " ";
//    }
//}
//map[x, y] = "☻";
//string movement;
//do
//{
//    StringBuilder sb = new StringBuilder();
//    for (int i = 0; i < map.GetLength(0); i++)
//    {
//        for (int j = 0; j < map.GetLength(1); j++)
//        {
//            sb.Append(map[i, j] + " | ");
//        }
//        sb.Append('\n');
//    }
//    Console.WriteLine(sb.ToString());

//    Console.WriteLine("z,q,s,d pour vous déplacer.\na pour quitter");
//    movement = Console.ReadLine();

//    map[x, y] = " ";

//    switch (movement.ToLower())
//    {
//        case "z":
//            if (x <= 0)
//            {
//                x = TAILLE - 1;
//            }
//            else
//            {
//                x--;
//            }
//            break;
//        case "q":
//            if (y <= 0)
//            {
//                y = TAILLE - 1;
//            }
//            else
//            {
//                y--;
//            }
//            break;
//        case "s":
//            if (x >= TAILLE - 1)
//            {
//                x = 0;
//            }
//            else
//            {
//                x++;
//            }
//            break;
//        case "d":
//            if (y >= TAILLE - 1)
//            {
//                y = 0;
//            }
//            else
//            {
//                y++;
//            }
//            break;
//        default:
//            Console.WriteLine("WTF?");
//            break;
//    }

//    map[x, y] = "☻";
//    Console.Clear();
//} while (movement != "a");

#endregion

#region Déplacement tableau 2D ++

//const int TAILLE = 10;
//string[,] map = new string[TAILLE, TAILLE];
//int x = 0;
//int y = 0;

//initMap(map, x, y);

//GameStart(TAILLE, map, ref x, ref y);

//static void initMap(string[,] map, int x, int y)
//{
//    for (int i = 0; i < map.GetLength(0); i++)
//    {
//        for (int j = 0; j < map.GetLength(1); j++)
//        {
//            map[i, j] = " ";
//        }
//    }
//    map[x, y] = "☻";
//}

//static void ShowMap(string[,] map)
//{
//    StringBuilder sb = new StringBuilder();
//    for (int i = 0; i < map.GetLength(0); i++)
//    {
//        for (int j = 0; j < map.GetLength(1); j++)
//        {
//            sb.Append(map[i, j] + " | ");
//        }
//        sb.Append('\n');
//    }
//    Console.WriteLine(sb.ToString());
//}

//static void GameStart(int TAILLE, string[,] map, ref int x, ref int y)
//{
//    ConsoleKeyInfo cki;

//    do
//    {
//        ShowMap(map);

//        Console.WriteLine("↑ → ↓ ← pour vous déplacer.");
//        cki = Console.ReadKey();

//        map[x, y] = " ";

//        switch (cki.Key)
//        {
//            case ConsoleKey.UpArrow:
//                if (x <= 0)
//                {
//                    x = TAILLE - 1;
//                }
//                else
//                {
//                    x--;
//                }
//                break;
//            case ConsoleKey.LeftArrow:
//                if (y <= 0)
//                {
//                    y = TAILLE - 1;
//                }
//                else
//                {
//                    y--;
//                }
//                break;
//            case ConsoleKey.DownArrow:
//                if (x >= TAILLE - 1)
//                {
//                    x = 0;
//                }
//                else
//                {
//                    x++;
//                }
//                break;
//            case ConsoleKey.RightArrow:
//                if (y >= TAILLE - 1)
//                {
//                    y = 0;
//                }
//                else
//                {
//                    y++;
//                }
//                break;
//            default:
//                Console.WriteLine("WTF?");
//                break;
//        }

//        map[x, y] = "☻";
//        Console.Clear();
//    } while (cki.Key != ConsoleKey.Escape);
//}

#endregion

#region Comparaison de 3 nombres

//int a, b, c;
//string op1 = " < ", op2 = " < ";
////int temp;


//Console.WriteLine("Nombre 1 : ");
//a = int.Parse(Console.ReadLine());
//Console.WriteLine("Nombre 2 : ");
//b = int.Parse(Console.ReadLine());
//Console.WriteLine("Nombre 3 : ");
//c = int.Parse(Console.ReadLine());

//if(a > b)
//{
//    (a, b) = (b, a);
//    //temp = a;
//    //a = b;
//    //b = temp;
//}
//if(b > c)
//{
//    (b,c) = (c, b);
//}
//if(a > b)
//{
//    (a, b) = (b, a);
//}

//if(a == b)
//{
//    op1 = " = ";
//}
//if(b == c)
//{
//    op2 = " = ";
//}

//Console.WriteLine(a + op1 + b + op2 + c);

#endregion

#region Comparaison de 3 nombre +

//List<int> numbers = new List<int>();

//for (int i = 0; i < 5; i++)
//{
//    int nb;
//    do
//    {
//        Console.Write($"Nombre {i + 1} : ");
//    } while (!int.TryParse(Console.ReadLine(), out nb));
//    numbers.Add(nb);
//}

//numbers.Sort();

//for (int i = 0;i < numbers.Count - 1; i++)
//{
//    Console.Write(numbers[i] + (numbers[i] == numbers[i+1] ? " = " : " < ") + (i == numbers.Count - 2 ? numbers[i+1] : ""));
//}

#endregion

#region Tri bulle

//List<int> numbers = new List<int>();

//string saisie = "";
//while (saisie.ToLower() != "q")
//{
//    int nb = 0;
//    do
//    {
//        Console.WriteLine("Rentrez un nombre : ( Q pour arreter)");
//        saisie = Console.ReadLine();

//    } while (saisie.ToLower() != "q" && !int.TryParse(saisie, out nb));

//    if (saisie.ToLower() != "q")
//    {
//        numbers.Add(nb);
//    }
//}

////numbers.Sort();

//for (int i = 0; i < numbers.Count - 1; i++)
//{
//    for (int j = 0; j < numbers.Count - 1 - i; j++)
//    {
//        if (numbers[j] > numbers[j + 1])
//        {
//            (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
//        }
//    }
//}

//foreach (int nb in numbers)
//{
//    Console.Write(nb + " | ");
//}

#endregion

#region reverse

List<string> list = new List<string>()
{
    "Pierre",
    "Paul",
    "Jacques",
    "Toto",
    "Dante"
};

//list.Reverse();

for (int i = 0; i < list.Count / 2; i++)
{
    (list[i], list[list.Count - 1 - i]) = (list[list.Count - 1 - i], list[i]);
}

foreach (string s in list)
{
    Console.Write(s + " | ");
}

//list.ForEach(monMot => Console.WriteLine(monMot + " | "));

#endregion
