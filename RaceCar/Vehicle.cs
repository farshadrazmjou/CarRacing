using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int speed { get; set; }

        public virtual void Accelerate(int amount)
        {
            throw new NotImplementedException();
        }
    }
}