using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    class Program
    {
        static void Main()
        {
            OffenseMode gh = new OffenseMode();
            gh.CheckMode();
            gh.SystemOk();
            gh.LaserSound();
            SuperLaser hj = new SuperLaser(9,9,9);
            hj.FireLaser();
            hj.Recharge();

        }
    }
}
