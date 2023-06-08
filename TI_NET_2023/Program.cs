

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

using TI_NET_2023;
///
DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.Hour);
Console.WriteLine(dateTime.Minute);
Console.WriteLine(dateTime.Second);

DateTime birthDate = new DateTime(1991, 3, 27);
Console.WriteLine(birthDate);

List<NewDateTime> newDates = new List<NewDateTime>();

NewDateTime maSuperDateStylee;
maSuperDateStylee.Year = 1991;
maSuperDateStylee.Month = "Mars";
maSuperDateStylee.Day = 27;
maSuperDateStylee.Hour = 13;
maSuperDateStylee.Minute = 30;
maSuperDateStylee.Second = 12;

newDates.Add(maSuperDateStylee);

newDates.Add(new NewDateTime(20, "Juin", 1991));
newDates.Add(new NewDateTime(17, "Décembre", 1988, 13, 12, 52));


foreach (NewDateTime date in newDates)
{
    Console.WriteLine(date);
}

Console.WriteLine("Coucou");

#endregion