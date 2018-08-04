using System;

namespace PoLaKoSz.hu.AssaultCube.Models.Weapons
{
    public abstract class WeaponAddresses
    {
        public IntPtr Bullets { get; }
        public IntPtr MagazineBullets { get; }

        public IntPtr FireDelay { get; }



        public WeaponAddresses(int baseAddress, int bulletsOffset, int magazineBulletsOffset, int timerOffset)
        {
            Bullets         = new IntPtr(baseAddress + bulletsOffset);
            MagazineBullets = new IntPtr(baseAddress + magazineBulletsOffset);

            FireDelay       = new IntPtr(baseAddress + timerOffset);
        }
    }
}
