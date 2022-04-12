using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern
{
    internal class Director
    {
        public void Construct(MechBuilder mechBuilder)
        {
            mechBuilder.BuildClass();
            mechBuilder.BuildEngine();
            mechBuilder.BuildMainHandWeapon();
            mechBuilder.BuildOffHandWeapon();
            mechBuilder.BuildSpecialWeapon();
        }
        
    }
}
