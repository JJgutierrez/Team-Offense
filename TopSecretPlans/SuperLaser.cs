using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class SuperLaser
    {
        int laserPowerLevel;
        int laserDamage;
<<<<<<< HEAD
        public SuperLaser(int laserPowerLevel, int laserDamage)
        {
=======
        int chargerPack;
         
        public SuperLaser(int laserPowerLevel, int laserDamage, int chargerPack)
        {
            this.laserPowerLevel = laserPowerLevel;
            this.laserDamage = laserDamage;
            this.chargerPack = chargerPack;
>>>>>>> 13e4e40c1cfd48074776ff887c76dedc8dab7ed4
        }

        public void FireLaser()
        {
<<<<<<< HEAD
=======
            laserPowerLevel -= 5;
            Console.WriteLine("Pew, pew, pew!");
            if (laserPowerLevel <= 0)
            {
                Recharge();
            }
        }
        public void Recharge()
        {
            laserPowerLevel = chargerPack;
            Console.WriteLine("The Super Laser is recharging");
        }
        public void TripleShot()
        {
            laserPowerLevel -= 15;
            Console.WriteLine("PEW PEW PEW... PEW PEW PEW... PEW PEW PEW!!!");
            if (laserPowerLevel <= 0)
            {
                Recharge();
            }

>>>>>>> 13e4e40c1cfd48074776ff887c76dedc8dab7ed4
        }
    }
}
