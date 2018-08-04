using System;

namespace PoLaKoSz.hu.AssaultCube.Models.Weapons
{
    public class SubmachineGunAddresses : WeaponAddresses
    {
        public SubmachineGunAddresses(int baseAddress)
            : base(baseAddress, 0x148, 0x120, 0x170)
        {

        }
    }
}
