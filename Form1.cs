using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC_DROB
{
    public partial class Form1 : Form
    {
        Fraction frac1;
        Fraction frac2;
        Fraction fracRes;
        public Form1()
        {
            InitializeComponent();
        }

        public void initFraction()
        {
            frac1 = new Fraction((int)edN1.Value, (int)edD1.Value);
            frac2 = new Fraction((int)edN2.Value, (int)edD2.Value);
        }

        public void ShowRes()
        {
            edD3.Value = fracRes.Div;
            edN3.Value = fracRes.Num;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void edPlus_Click(object sender, EventArgs e)
        {
            initFraction();
            fracRes = frac1.sum(frac2);
            ShowRes();
            lbl.Text = "+";

          
        }

        private void edMinus_Click(object sender, EventArgs e)
        {
            initFraction();
            fracRes = frac2.min(frac1);
            ShowRes();
            lbl.Text = "-";
        }

        private void edMultiplication_Click(object sender, EventArgs e)
        {
            initFraction();
            fracRes = frac1.mnog(frac2);
            ShowRes();
            lbl.Text = "*";
        }

        private void edDivision_Click(object sender, EventArgs e)
        {
            initFraction();
            fracRes = frac1.div(frac2);
            ShowRes();
            lbl.Text = "/";
        }

        private void edClear_Click(object sender, EventArgs e)
        {
            edN1.ResetText();
            edN2.ResetText();
            edN3.ResetText();
            edD1.ResetText();
            edD2.ResetText();
            edD3.ResetText();
    
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
