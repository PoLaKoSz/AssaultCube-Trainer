using PoLaKoSz.hu.AssaultCube.Models.Weapons;
using System.Collections.Generic;

namespace PoLaKoSz.hu.AssaultCube.Models
{
    public abstract class Player
    {
        public string Name { get; set; }

        public int Health { get; set; }
        public int Armour { get; set; }

        public List<Weapon> Weapons { get; set; }

        public Position Position { get; set; }



        public Player()
        {
            Weapons  = new List<Weapon>();
            Position = new Position();
        }
    }
}
