using PoLaKoSz.hu.AssaultCube.DataAccessLayer;
using PoLaKoSz.hu.AssaultCube.Models;
using System;
using System.Threading;

namespace PoLaKoSz.hu.AssaultCube
{
    public class CheatEngine
    {
        private LocalPlayer _localPlayer { get; }
        private LocalPlayerAddresses _localPlayerAddresses { get;  }
        private RAM _dataLayer { get; set; }
        public int Speed { get; set; }



        public CheatEngine(string processName)
        {
            _localPlayer = new LocalPlayer();

            _dataLayer = new RAM(processName);
            
            _localPlayerAddresses = new LocalPlayerAddresses(_dataLayer.ReadInt32(LocalPlayerAddresses.Base));

            Speed = 100;
        }


        
        public void Run()
        {
            if (_localPlayer.Weapons.Count != _localPlayerAddresses.Weapons.Count)
                throw new Exception("Every weapon have to have an address defined!");

            while (true)
            {
                _dataLayer.WriteInt32(_localPlayerAddresses.Health, _localPlayer.Health);
                _dataLayer.WriteInt32(_localPlayerAddresses.Armour, _localPlayer.Armour);

                for (int i = 0; i < _localPlayer.Weapons.Count; i++)
                {
                    var weapon = _localPlayer.Weapons[i];

                    _dataLayer.WriteInt32(_localPlayerAddresses.Weapons[i].Bullets,         weapon.Bullets);
                    _dataLayer.WriteInt32(_localPlayerAddresses.Weapons[i].MagazineBullets, weapon.MagazineBullets);
                    _dataLayer.WriteInt32(_localPlayerAddresses.Weapons[i].FireDelay,       weapon.FireDelay);
                }

                Thread.Sleep(Speed);
            }
        }
    }
}