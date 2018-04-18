using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPLabTimer
{
    public class Equation
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public int Rezultat { get; set; }
        public enum Operacija { suma, razlika, proizvod, kolicnik }
        public Operacija operacija { get; set; }

        public char Znak { get; set; }

        public Equation()
        {
            Random r = new Random();
            int op = r.Next(0, 4);
            operacija = (Operacija)op;
            Operand1 = r.Next(100);
            if(op == 0)
            {
                Operand2 = r.Next(100);
                Rezultat = Operand1 + Operand2;
                Znak = '+';
            }
            if (op == 1)
            {
                Operand2 = r.Next(Operand1);
                Rezultat = Operand1 - Operand2;
                Znak = '-';
            }
            if(op == 2)
            {
                Operand2 = r.Next(100);
                Rezultat = Operand1 * Operand2;
                Znak = '*';
            }
            if(op == 3)
            {
                int randomOp = r.Next(1,100);
                while(Operand1 % randomOp != 0)
                {
                    randomOp = r.Next(1, 100);
                }
                Operand2 = randomOp;
                Rezultat = Operand1 / Operand2;
                Znak = '/';
            }
            

        }
    }
}
