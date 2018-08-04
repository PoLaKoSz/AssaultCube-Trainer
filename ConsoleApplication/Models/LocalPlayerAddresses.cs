using PoLaKoSz.hu.AssaultCube.Models.Weapons;
using System;
using System.Collections.Generic;

namespace PoLaKoSz.hu.AssaultCube.Models
{
    public class LocalPlayerAddresses
    {
        public static IntPtr Base { get; } = new IntPtr(0x0050F4F4);

        public IntPtr Health { get; }
        public IntPtr Armour { get; }

        public List<WeaponAddresses> Weapons { get; }



        public LocalPlayerAddresses(int baseAddress)
        {
            Health = new IntPtr(baseAddress + 0xF8);
            Armour = new IntPtr(baseAddress + 0xFC);

            Weapons = new List<WeaponAddresses>()
            {
                new KnifeAddresses(baseAddress),

                new PistolAddresses(baseAddress),
                new AkimboAddresses(baseAddress),

                new AssaultRifleAddresses(baseAddress),
                new SubmachineGunAddresses(baseAddress),
                new SniperRiffleAddresses(baseAddress),
                new CombatShotgunAddresses(baseAddress),
                new CarbineAddresses(baseAddress),

                new GrenadeAddresses(baseAddress),
            };
        }
    }
}
