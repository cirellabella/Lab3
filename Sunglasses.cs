using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Sunglasses
    {
        //fields
        public int _templeLength;
        public int _bridgeWidth;
        public int _lensWidth;
        public string _color;
        public int _uvProtectionFactor;
        public string _logo;
        public string _name;

        //constructor
        public Sunglasses(int templeLength, int bridgeWidth, int lensWidth, string color, string logo, string name, int uvProtectionFactor)
        {
            _templeLength = templeLength;
            _bridgeWidth = bridgeWidth;
            _lensWidth = lensWidth;
            _color = color;
            _logo = logo;
            _name = name;
            _uvProtectionFactor = uvProtectionFactor;
        }

        //properties
        public int TempleLength { get => _templeLength; set => _templeLength = value; }
        public int BridgeWidth { get => _bridgeWidth; set => _bridgeWidth = value; }
        public int LensWidth { get => _lensWidth; set => _lensWidth = value; }
        public string Color { get => _color; set => _color = value; }
        public string Logo { get => _logo; set => _logo = value; }
        public string Name { get => _name; set => _name = value; }
        public int UvProtectionFactor { get => _uvProtectionFactor; set => _uvProtectionFactor = value; }

        //method- objects need behavior related to object
        public static void Protection(Sunglasses sunglasses)
        {
            Console.WriteLine("Your sunglasses block " + sunglasses.UvProtectionFactor + "% of the harmful UV rays");
        }

        //override to string
        public override string ToString()
        {
            return GetType().Name + $"The {Logo} {Name} Sunglasses are {Color} and have a {TempleLength} temple length, " +
                $"{BridgeWidth} bridge width, {LensWidth} lens width, and {UvProtectionFactor} UV Protection";
        }
    }
}
