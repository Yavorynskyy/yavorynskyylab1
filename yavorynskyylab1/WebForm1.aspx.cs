using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yavorynskyylab1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double t1;
            double t2;
            if (TextBox1.Text != "" && TextBox2.Text != "" && Double.TryParse(TextBox1.Text, out t1) && Double.TryParse(TextBox2.Text, out t2))
            {
                double a, b, suma;
                a = Convert.ToDouble(TextBox1.Text);
                b = Convert.ToDouble(TextBox2.Text);
                Anima Anima1 = new Anima(a, b);
                suma = Anima1.suma();
                TextBox3.Text = Convert.ToString(suma);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double t1;
            double t2;
            if (TextBox1.Text != "" && TextBox2.Text != "" && Double.TryParse(TextBox1.Text, out t1) && Double.TryParse(TextBox2.Text, out t2))
            {
                
                double a, b, rizn;
                a = Convert.ToDouble(TextBox1.Text);
                b = Convert.ToDouble(TextBox2.Text);
                Anima Anima1 = new Anima(a, b);
                rizn = Anima1.rizn();
                TextBox3.Text = Convert.ToString(rizn);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double t1;
            double t2;
            if (TextBox1.Text != "" && TextBox2.Text != "" && Double.TryParse(TextBox1.Text, out t1) && Double.TryParse(TextBox2.Text, out t2))
            {
                double a, b, dobu;
                a = Convert.ToDouble(TextBox1.Text);
                b = Convert.ToDouble(TextBox2.Text);
                Anima Anima1 = new Anima(a, b);
                dobu = Anima1.dobu();
                TextBox3.Text = Convert.ToString(dobu);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double t1;
            double t2;
            if (TextBox1.Text != "" && TextBox2.Text != "" && Double.TryParse(TextBox1.Text, out t1) && Double.TryParse(TextBox2.Text, out t2))
            {
                double a, b, chas;
                a = Convert.ToDouble(TextBox1.Text);
                b = Convert.ToDouble(TextBox2.Text);
                Anima Anima1 = new Anima(a, b);
                chas = Anima1.chas();
                TextBox3.Text = Convert.ToString(chas);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}