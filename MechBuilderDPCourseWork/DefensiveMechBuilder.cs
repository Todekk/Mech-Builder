using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Creational_Pattern
{
    internal class DefensiveMechBuilder : MechBuilder
    {
        public DefensiveMechBuilder()
        {
            mech = new Mech("Defensive Mech");
        }
        public override void BuildClass()
        {
            mech["class"] = "Defensive Class";
        }
        public override void BuildEngine()
        {
            mech["engine"] = "2000 HP";
        }
        public override void BuildMainHandWeapon()
        {
            mech["mainHandWeapon"] = ".50 cal Machine gun";
        }
        public override void BuildOffHandWeapon()
        {
            mech["offHandWeapon"] = "Bulletproof Shield";
        }
        public override void BuildSpecialWeapon()
        {
            mech["specialWeapon"] = "Electric coil";
        }
    }
}
