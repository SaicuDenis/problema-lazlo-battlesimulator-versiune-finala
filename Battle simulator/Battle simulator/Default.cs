using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_simulator
{
    public enum default_unit
    {
        [unit_att(5,5,2,10,0)]
        Peasent,

        [unit_att(50, 70, 80, 250, 10)]
        Knight,

        [unit_att(80, 60, 80, 500, 20)]
        Orc,

        [unit_att(15,10, 7, 100, 0)]
        Hero,

        [unit_att(110, 80, 100, 1000, 100)]
        Black_Dragon

    }
    public class unit_att:Attribute
    {
        public int As, Ds, Fp, HP, armor;
        public unit_att(int As,int Ds,int Fp,int HP,int armor)
        {
            this.As = As;
            this.Ds = Ds;
            this.armor = armor;
            this.Fp = Fp;
            this.HP = HP;
        }
    }

}
