using System;

namespace PoLaKoSz.hu.AssaultCube.Models.Weapons
{
    public abstract class Weapon
    {
        public int Bullets { get; set; }
        public int MagazineBullets { get; set; }

        public int FireDelay { get; set; }



        public Weapon()
        {
            Bullets         =  99;
            MagazineBullets = 999;
            
            FireDelay       =   0;
        }
    }
}
