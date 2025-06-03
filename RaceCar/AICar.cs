using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    public class AICar : Vehicle
    {
        private readonly int difficulty;

        public void AdjustSpeed(int targetSpeed)
        {

        }

        public override void Accelerate(int amount)
        {
            throw new NotImplementedException();
        }
    }
}