using System.Diagnostics.CodeAnalysis;

namespace TI_NET_2023
{
    public enum PokemonType
    {
        Feu,
        Eau,
        Plante,
        Glace,
        Combat,
        Fee,
        Acier,
        Spectre,
        Electricite,
        Normal,
        Poison,
        Psy,
        Vol,
        Sol,
        Roche
    }

    public struct Pokemon
    {
        public string Name;
        public int Level;
        public int PV;
        public int Atk;
        public int AtkSpe;
        public int Def;
        public int DefSpe;
        public int Vitesse;
        public PokemonType Type;

        /// <summary>
        /// Cree un nouveau pokemon level 1 avec stats aléatoires
        /// </summary>
        /// <param name="name">Le nom du pokemon</param>
        public Pokemon(string name,PokemonType type)
        {
            Random rng = new Random();
            Name = name;
            Level = 1;
            PV = rng.Next(15, 21);
            Atk = rng.Next(5, 11);
            AtkSpe = rng.Next(5, 11);
            Def = rng.Next(5, 11);
            DefSpe = rng.Next(5, 11);
            Vitesse = rng.Next(5, 11);
            Type = type;
        }

        /// <summary>
        /// Cree un pokemon avec stats pré-definies
        /// </summary>
        /// <param name="name">Le nom du pokemon</param>
        /// <param name="level">Le level du pokemon</param>
        /// <param name="pv">les pv du pokemon</param>
        /// <param name="atk">l'attaque du pokemon</param>
        /// <param name="atkSpe">l'attaque spéciale du pokemon</param>
        /// <param name="def">la defence du pokemon</param>
        /// <param name="defSpe">la defence spéciale du pokemon</param>
        /// <param name="vitesse">la vitesse du pokemon</param>
        public Pokemon(string name,PokemonType type, int level, int pv, int atk, int atkSpe, int def, int defSpe, int vitesse)
        {
            Name = name;
            Level = level;
            PV = pv;
            Atk = atk;
            AtkSpe = atkSpe;
            Def = def;
            DefSpe = defSpe;
            Vitesse = vitesse;
            Type = type;
        }

        public void TakeDamage(int damage)
        {
            // test de garde return; uniquement pour procédure
            if(damage < 0)
            {
                return;
            }
            Console.WriteLine($"{this.Name} recoit {damage} points de dégats");
            this.PV = PV - damage < 0 ? 0 : PV - damage;
            //if(PV - damage < 0)
            //{
            //    this.PV = 0;
            //}
            //else
            //{
            //    this.PV = PV - damage;
            //}
        }

        // même probleme sans le ref target est déja un copie et donc les pv ne change pas réellement
        /// <summary>
        /// Notre pokemon attaque une cible
        /// </summary>
        /// <param name="target">la cible de l'attaque</param>
        public void Attack(ref Pokemon target)
        {
            Console.WriteLine($"{this.Name} attaque {target.Name}");
            target.TakeDamage(this.Atk);
        }

        //Methodes avec ref qui force le comportement type reference
        //public void Attack(ref Pokemon target)
        //{
        //    Console.WriteLine($"{this.Name} attaque {target.Name}");
        //    target.PV -= this.Atk;
        //}

        public override string ToString()
        {
            return $"_______________________________\n" +
                   $"Name : {Name}\n" +
                   $"PV : {PV}\n" +
                   $"Atk : {Atk}\n" +
                   $"AtkSpe : {AtkSpe}\n" +
                   $"Def : {Def}\n" +
                   $"DefSpe : {DefSpe}\n" +
                   $"Vitesse : {Vitesse}\n" +
                   $"Type : {Type}\n" +
                   $"_______________________________\n";
        }
    }
}
