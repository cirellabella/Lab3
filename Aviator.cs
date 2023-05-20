using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Aviator : Sunglasses
    {
        public string _lensShape;

        public Aviator(int templeLength, int bridgeWidth, int lensWidth, string color, string logo, string name, int uvProtectionFactor) : base(templeLength, bridgeWidth, lensWidth, color, logo, name, uvProtectionFactor)
        {
        }
    }
}
