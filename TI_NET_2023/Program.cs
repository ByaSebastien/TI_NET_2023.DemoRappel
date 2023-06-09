

#region demo op

//int cpt = 0;

//while(cpt < 10)
//{
//    Console.WriteLine(cpt++);
//}

//Boolean isBreakTime = true;

//if(isBreakTime)
//{
//    Console.WriteLine("Yi ahhh!!!");
//}

//cpt = cpt + 10;
//cpt += 10;
//cpt /= 2;
//cpt *= 10;


#endregion

//#region demo tableau

//using System.Text;
//// Pour remplir ou afficher un tableau, il faut parcourir toutes ses "cases"
//// via l'index. Une boucle for est parfaite pour ça
//string[] strings = new string[5];
//// remplissage du tableau 1D
//for (int i = 0; i < strings.Length; i++)
//{
//    strings[i] = $"elem{i}";
//}
//// affichage avec StringBuilder du tableau 1D
//StringBuilder sb = new StringBuilder();
//for (int i = 0; i < strings.Length; i++)
//{
//    sb.Append(strings[i] + " | ") ;
//}
//Console.WriteLine(sb.ToString());

//int[,] ints = new int[5, 5];
//// remplissage du tableau 2D
//for (int i = 0;i < ints.GetLength(0); i++)
//{
//    for (int j = 0; j < ints.GetLength(1); j++)
//    {
//        ints[i,j] = i + j ;
//    }
//}
//// affichage avec StringBuilder du tableau 2D
//StringBuilder sb2 = new StringBuilder();
//for (int i = 0; i < ints.GetLength(0); i++)
//{
//    for (int j = 0; j < ints.GetLength(1); j++)
//    {
//        sb2.Append(ints[i,j] + " | ") ;
//    }
//    sb2.Append('\n');
//}
//Console.WriteLine(sb2.ToString());
////#endregion

#region demo Collection


//List<string> strings = new List<string>();

//strings.Add("Pierre");
//strings.Add("Paul");
//strings.Add("Jacques");

////strings.Remove("Paul");
////strings.RemoveAt(1);

//strings.Sort();
//strings.Reverse();

//strings.Insert(2, "toto");

//foreach (string s in strings)
//{
//    Console.WriteLine(s);
//}



#endregion


#region Demo Valeur/ref

//int nb = 5;
//int[] ints = { 1, 2, 3, 4, 5 };

//AddOne(nb);
//AddOneToAll(ints);

//Console.WriteLine(nb);
//foreach (int i in ints)
//{
//    Console.WriteLine(i);
//}


//void AddOne(int a)
//{
//    //nb = nb + 1;
//    //nb += 1;
//    a++;
//}
//void AddOneToAll(int[] tab)
//{
//    for (int i = 0; i < tab.Length; i++)
//    {
//        tab[i] = tab[i] + 1;
//    }
//}
#endregion


#region Demo structure

//using TI_NET_2023;
/////
//DateTime dateTime = DateTime.Now;
//Console.WriteLine(dateTime.Hour);
//Console.WriteLine(dateTime.Minute);
//Console.WriteLine(dateTime.Second);

//DateTime birthDate = new DateTime(1991, 3, 27);
//Console.WriteLine(birthDate);

//List<NewDateTime> newDates = new List<NewDateTime>();

//NewDateTime maSuperDateStylee;
//maSuperDateStylee.Year = 1991;
//maSuperDateStylee.Month = "Mars";
//maSuperDateStylee.Day = 27;
//maSuperDateStylee.Hour = 13;
//maSuperDateStylee.Minute = 30;
//maSuperDateStylee.Second = 12;

//newDates.Add(maSuperDateStylee);

//newDates.Add(new NewDateTime(20, "Juin", 1991));
//newDates.Add(new NewDateTime(17, "Décembre", 1988, 13, 12, 52));


//foreach (NewDateTime date in newDates)
//{
//    Console.WriteLine(date);
//}

//Console.WriteLine("Coucou");

#endregion

#region Demo Structure/methode Pokemon

//using TI_NET_2023;

//List<Pokemon> team = new List<Pokemon>()
//{
//    new Pokemon("Ratata",PokemonType.Normal),
//    new Pokemon("Roucoul",PokemonType.Normal),
//    new Pokemon("Chenipan",PokemonType.Poison),
//    new Pokemon("Magicarpe",PokemonType.Eau),
//    new Pokemon("Canidos",PokemonType.Feu),
//    new Pokemon("Nidoking",PokemonType.Poison,50,50,50,50,50,50,50),
//};

////List<Pokemon> team = new List<Pokemon>();
////team.Add(new Pokemon("Ratata"));
////team.Add(new Pokemon("Roucoul"));
////team.Add(new Pokemon("Chenipan"));
////team.Add(new Pokemon("Magicarpe"));
////team.Add(new Pokemon("Canidos"));
////team.Add(new Pokemon("Nidoking", 50, 50, 50, 50, 50, 50, 50));

//Pokemon pikachu = new Pokemon("Pikachu",PokemonType.Electricite,100, 99, 99, 99, 99, 50, 150);
//Pokemon mewtwo = new Pokemon("Mewtwo",PokemonType.Psy,100, 100, 100, 100, 100, 100, 100);


//Console.WriteLine(pikachu.Name);
//Console.WriteLine($"PV : {pikachu.PV}");
//Console.WriteLine($"Atk : {pikachu.Atk}");

//for (int i = 0; i < team.Count; i++)
//{
//    Fight(ref pikachu, team[i]);
//}

//static void Fight(ref Pokemon pikachu, Pokemon pokemon)
//{
//    while (pikachu.PV > 0 && pokemon.PV > 0)
//    {
//        pikachu.Attack(ref pokemon);
//        if (pokemon.PV > 0)
//        {
//            pokemon.Attack(ref pikachu);
//        }
//    }
//    Console.WriteLine("Fin du combat");
//}

#endregion

#region Demo Overloading (Surcharge)

//using TI_NET_2023;
//using static TI_NET_2023.MathDuCool;

//int nb1 = 5;
//int nb2 = 3;

//int result = Addition(nb1, nb2);
//float resultFloat = Addition(5.5F, 3);
//resultFloat = Addition(5.5F, 2.2F);
//resultFloat = Addition(3, 3.7F);
//Console.WriteLine(result);
#endregion

#region Demo overriding (réécriture)

//using TI_NET_2023;

//Pokemon mewtwo = new Pokemon("Mewtwo", 100, 100, 100, 100, 100, 100, 100);
////string result = mewtwo.ToString


////Console.WriteLine fait un ToString() par defaut
//Console.WriteLine(mewtwo);

#endregion

#region Demo Enum

using System.Text;
using TI_NET_2023;

Console.WriteLine("Nom : ");
string name = Console.ReadLine();
//Console.WriteLine("Type : \n" +
//                  "1 :  Feu\n" +
//                  "2 :  Eau\n" +
//                  "3 :  Plante\n" +
//                  "4 :  Glace\n" +
//                  "5 :  Combat\n" +
//                  "6 :  Fee\n" +
//                  "7 :  Acier\n" +
//                  "8 :  Spectre\n" +
//                  "9 :  Electricite\n" +
//                  "10 : Normal\n" +
//                  "11 : Poison\n" +
//                  "12 : Psy\n");

StringBuilder sb = new StringBuilder();
string result = "";
foreach (PokemonType p in Enum.GetValues<PokemonType>())
{
    sb.AppendLine((int)p < 9 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");
    result = result + $"{(int)p + 1} : {p}\n";
}
Console.WriteLine(sb);
Console.WriteLine(result);


string stringType = Console.ReadLine();

int nbType = int.Parse(stringType);

//PokemonType type = Enum.Parse<PokemonType>(stringType);
PokemonType type = (PokemonType)nbType-1;

Console.WriteLine((int)type);


Pokemon pokemon = new Pokemon(name,type);
Console.WriteLine(pokemon);

#endregion