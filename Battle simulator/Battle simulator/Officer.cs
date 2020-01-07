using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_simulator
{
    public class Officer: Unit
    {
       public int extra;

        public Officer(int extra, string name, int As, int Ds, int Fp, int armor, int hp):base(name,As,Ds,Fp,armor,hp)
        {
            this.extra = extra;
        }
        public override void draw(Graphics grp)
        {
            base.draw(grp);
            grp.DrawString(extra.ToString(), new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Yellow), new PointF(maploc.X, maploc.Y - 12));
        }

    }
}
