using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPLabPacman
{
    public class Pacman
    {
        public enum Nasoka { levo,gore,desno,dole }
        public int X { get; set; }
        public int Y { get; set; }
        public Nasoka nasoka { get; set; }

        public static int RADIUS = 20;
        public static int Brzina = 20;
        public bool otvorenaUsta { get; set; }
        public Brush brush { get; set; }

        public Pacman()
        {
            nasoka = Nasoka.desno;
            otvorenaUsta = false;
            brush = new SolidBrush(Color.Yellow);
            X = 5;
            Y = 7;
        }

        public void smeniNasoka(Nasoka n)
        {
            this.nasoka = n;
        }

        public void dvizi(int x, int y)
        {
            if(nasoka == Nasoka.desno)
            {
                if (X == x - 1)
                {
                    X = 0;
                }
                else X++;
            }
            if (nasoka == Nasoka.levo)
            {
                if (X == 0)
                {
                    X = x - 1;
                }
                else X--;
            }
            if (nasoka == Nasoka.dole)
            {
                if (Y == y - 1)
                {
                    Y = 0;
                }
                else Y++;
            }
            if (nasoka == Nasoka.gore)
            {
                if (Y == 0)
                {
                    Y = y - 1;
                }
                else Y--;
            }
            this.otvorenaUsta = !otvorenaUsta;
        }

        public void iscrtaj(Graphics g)
        {
            if (otvorenaUsta)
            {
                if(nasoka==Nasoka.desno)
                    g.FillPie(brush, X* 40 + 10, Y* 40, RADIUS * 2, RADIUS * 2, 45, 270);
                if (nasoka == Nasoka.dole)
                    g.FillPie(brush, X * 40 + 10, Y * 40, RADIUS * 2, RADIUS * 2, 135, 270);
                if (nasoka == Nasoka.gore)
                    g.FillPie(brush, X * 40 + 10, Y * 40, RADIUS * 2, RADIUS * 2, 315, 270);
                if (nasoka == Nasoka.levo)
                    g.FillPie(brush, X * 40 + 10, Y * 40, RADIUS * 2, RADIUS * 2, 225, 270);

            }
            else
            {
                g.FillEllipse(brush, X* 40+10, Y* 40, RADIUS * 2, RADIUS * 2);
            }
        }

    }
}
