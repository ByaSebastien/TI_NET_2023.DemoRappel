using System.Text;
using TI_NET_2023.Exercices;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//#region Déplacement tableau 2D

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

////#/*endregion*/

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

string[,] plateau = new string[10, 10];
Position pos = new Position(0,0);

plateau[pos.x, pos.y] = "☻";