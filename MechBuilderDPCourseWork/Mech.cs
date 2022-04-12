using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern
{
    internal class Mech
    {
        private string _mechType;
        private Dictionary<string, string> _parts = 
            new Dictionary<string, string>();
        public Mech(string mechType)
        {
            _mechType = mechType;
        }
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value;}
        }
        public void Present()
        {
            Console.WriteLine("Mech Type: {0}", _mechType);            
            Console.WriteLine("Class: {0}", _parts["class"]);
            Console.WriteLine("Engine: {0}", _parts["engine"]);
            Console.WriteLine("Main hand weapon: {0}", _parts["mainHandWeapon"]);
            Console.WriteLine("Off-hand weapon: {0}", _parts["offHandWeapon"]);
            Console.WriteLine("Special weapon: {0}", _parts["specialWeapon"]);            
        }
    }
}
