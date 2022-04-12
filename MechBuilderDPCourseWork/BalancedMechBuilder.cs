using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern
{
    internal class BalancedMechBuilder : MechBuilder
    {
        public BalancedMechBuilder()
        {
            mech = new Mech("Balanced Mech");
        }
        public override void BuildClass()
        {
            mech["class"] = "Balanced Class";
        }
        public override void BuildEngine()
        {
            mech["engine"] = "1200 HP";
        }
        public override void BuildMainHandWeapon()
        {
            mech["mainHandWeapon"] = "Plasma rifle";
        }
        public override void BuildOffHandWeapon()
        {
            mech["offHandWeapon"] = "Stalker rifle";
        }
        public override void BuildSpecialWeapon()
        {
            mech["specialWeapon"] = "Healing beacon";
        }
    }
}
