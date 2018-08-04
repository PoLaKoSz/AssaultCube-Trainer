using System;

namespace PoLaKoSz.hu.AssaultCube.Models.Weapons
{
    public class PistolAddresses : WeaponAddresses
    {
        public PistolAddresses(int baseAddress)
            : base(baseAddress, 0x13C, 0x114, 0x164)
        {

        }
    }
}
