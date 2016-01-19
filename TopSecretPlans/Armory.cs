using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Armory
    {
        int numberOfWeapons;
        int ammo;
        string[] weapons;
        string[] guns;
        string[] laserShooter;
        string[] grenadeLaunchers;
        string[] bombThrower;
        string[] ammoType;
        string[] grenades;
        string[] bombs;
        string[] superLaser;
        string[] bullets;
        int nWTotal;
        int nWStock;
        int nWTake;
        int nWOut;
        int nATotal;
        int nAStock;
        int nAtake;
        int nAOut;
        bool isWAvailable;

        public Armory(int numberOfWeapons, int ammo)
        {

        }
        public void weaponsList()
        {
            List<string[]> weapons = new List<string[]>() { guns, bombThrower, grenadeLaunchers, laserShooter }; 
        }

        public void ammoList()
        {
            List<string[]> ammoType = new List<string[]>() { bullets, superLaser, grenades, bombs };
        }
        public void TotalWeapons()
        {
            nWTotal = nWStock + nWOut;
            Console.WriteLine("The number of " + weapons + ":" + nWTotal);
        }
        public void WeaponsInStock()
        {
            nWStock = nWTotal - nWOut;
            Console.WriteLine(weapons + " in stock:" + nWStock);
        }
        public void WeaponsOut()
        {
            nWOut = nWTotal - nWStock;
            Console.WriteLine(weapons + " out:" + nWOut);
        }
        public void TakeWeapons()
        {
            Console.WriteLine("How many weapons do you want?");
            string numberWeapons = Console.ReadLine();
            int numberOfWeapons = int.Parse(numberWeapons);

        }

        public void TotalAmmo()
        {
            nATotal = nAStock + nAOut;
            Console.WriteLine("The number of " + ammo + ":" + nATotal);
        }
        public void AmmoInStock()
        {
            nAStock = nATotal - nAOut;
            Console.WriteLine(ammo + " in stock:" + nAStock);
        }
        public void AmmoOut()
        {
            nAOut = nATotal - nAStock;
            Console.WriteLine(ammo + " out:" + nAOut);
        }
        public void TakeAmmo()
        {
            Console.WriteLine("How much ammo do you want?");
            string requestedAmmo = Console.ReadLine();
            ammo = int.Parse(requestedAmmo);

        }
    }
}
