using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    public class PlayerCar : Vehicle
    {
        private readonly List<Upgrade> Upgrades;

        public PlayerCar()
        {
            Upgrades = new List<Upgrade>();
        }

        public void AddUpgrade(Upgrade upgrade)
        {
            Upgrades.Add(upgrade);
        }

        public override void Accelerate(int amount)
        {
            throw new NotImplementedException();
        }

    }
}