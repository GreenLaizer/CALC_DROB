using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC_DROB
{
    class Fraction
    {
        public int Num { get; set; } //числитель

        public int Div { get; set; } //делитель

        public Fraction(int N, int D)
        {
            Num = N;
            Div = D;
            Norm();
        }


        public void Norm()
        {
            int M = Math.Min(Num, Div);
            for (int i = M; i > 1; i--)
            {
                if ((Num % i == 0) && (Div % i == 0))
                {
                    Num = Num / i;
                    Div = Div / i;
                    break;
                }
            }
        }
        public Fraction sum(Fraction frac)
        {
            Fraction res = new Fraction(this.Num * frac.Div + frac.Num * this.Div, this.Div * frac.Div);
            return res;
        }

        public Fraction min(Fraction frac)
        {
            Fraction res = new Fraction(this.Num * frac.Div - frac.Num * this.Div, this.Div * frac.Div);
            return res;
        }

        public Fraction mnog(Fraction frac)
        {
            Fraction res = new Fraction(this.Num * frac.Num, this.Div * frac.Div);
            return res;
        }

        public Fraction div(Fraction frac)
        {
            Fraction res = new Fraction(this.Num * frac.Div, this.Div * frac.Num);
            return res;
        }

        




    }
}
