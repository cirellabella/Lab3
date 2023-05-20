using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class User
    {
        public string _fName;
        public string _lName;
        public List<Sunglasses> sung;

        public string FName { get => _fName; set => _fName = value; }
        public string LName { get => _lName; set => _lName = value; }
        public List<Sunglasses> Sunglasses { get => sung; }

        public User(string fName, string lName)
        {
            _fName = fName;
            _lName = lName;
            sung = new List<Sunglasses>();
        }

        //method

        public void AddSunglasses(Sunglasses sunglasses)
        {
            sung.Add(sunglasses);
        }

        public override string ToString()
        {
            return $"{FName} {LName}";
        }

    }
}
