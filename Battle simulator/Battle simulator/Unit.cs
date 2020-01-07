using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Battle_simulator
{
    public class Unit
    {
        public int As, Ds, Fp, Armor, HP;
        public PointF maploc;
        public int size;
        public string name;
        public Color FillColor;
        public bool destroy;
        public Unit(default_unit T)
        {
            unit_att data = (unit_att)Attribute.GetCustomAttribute(
                typeof (default_unit).GetField(Enum.GetName(
                typeof(default_unit),T)),
                typeof (unit_att));

            As = data.As;
            Ds = data.Ds;
            Fp = data.Fp;
            Armor = data.armor;
            HP = data.HP;
            name = T.ToString();
            maploc = Engine.getrndpoint();
            destroy = false;
        }
        public Unit(string name,int As,int Ds,int Fp,int armor,int hp)
        {
            this.name = name;
            this.As = As;
            this.Ds = Ds;
            this.Fp = Fp;
            Armor = armor;
            HP = hp;
            maploc = Engine.getrndpoint();
            destroy = false;
        }

        public virtual void draw(Graphics grp)
        {
            grp.FillEllipse(new SolidBrush(FillColor), maploc.X - size / 2, maploc.Y - size / 2, size + 1, size + 1);
            grp.DrawEllipse(Pens.Black, maploc.X - size / 2, maploc.Y - size / 2, size + 1, size + 1);
            grp.DrawString(HP.ToString(), new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), maploc);
        }
    }
}
