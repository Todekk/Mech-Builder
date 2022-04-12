using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern
{
    internal abstract class MechBuilder
    {
        protected Mech mech;
        public Mech Mech
        {
            get { return mech; }
        }
        public abstract void BuildEngine();
        public abstract void BuildClass();
        public abstract void BuildMainHandWeapon();
        public abstract void BuildOffHandWeapon();
        public abstract void BuildSpecialWeapon();
        

    }
}
