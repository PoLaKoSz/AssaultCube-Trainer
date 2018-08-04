using PoLaKoSz.hu.AssaultCube.Models.Weapons;

namespace PoLaKoSz.hu.AssaultCube.Models
{
    public class LocalPlayer : Player
    {
        public LocalPlayer()
        {
            Health = 999;
            Armour = 999;


            Weapons.Add(new Knife());

            Weapons.Add(new Pistol());
            Weapons.Add(new Akimbo());

            Weapons.Add(new AssaultRifle());
            Weapons.Add(new SubmachineGun());
            Weapons.Add(new SniperRifle());
            Weapons.Add(new CombatShotgun());
            Weapons.Add(new Carbine());

            Weapons.Add(new Grenade());
        }
    }
}
