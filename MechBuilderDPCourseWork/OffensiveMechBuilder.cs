using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern
{
    internal class OffensiveMechBuilder : MechBuilder
    {
        public OffensiveMechBuilder()
        {
            mech = new Mech("Offensive Mech");
        }
        public override void BuildClass()
        {
            mech["class"] = "Offensive Class";
        }
        public override void BuildEngine()
        {
            mech["engine"] = "1000 HP";
        }
        public override void BuildMainHandWeapon()
        {
            mech["mainHandWeapon"] = "Assault Rifle";
        }
        public override void BuildOffHandWeapon()
        {
            mech["offHandWeapon"] = "Semi-auto Shotgun";
        }
        public override void BuildSpecialWeapon()
        {
            mech["specialWeapon"] = "Grenade Launcher";
        }
    }
}
