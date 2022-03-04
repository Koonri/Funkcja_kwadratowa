namespace Funkcja_kwadratowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LiczbaA = int.Parse(LA.Text);
            int LiczbaB = int.Parse(LB.Text);
            int LiczbaC = int.Parse(LC.Text);
            double Delta = Math.Pow(LiczbaB, 2) - (4 * LiczbaA * LiczbaC);
            double pDelta = Math.Sqrt(Delta);
            double xfirst = ((-1)*LiczbaB - pDelta) / (LiczbaA * 2);
            double xsecond = ((-1)*LiczbaB + pDelta) / (LiczbaA * 2);
            xfirst = Math.Round(xfirst, 1);
            xsecond = Math.Round(xsecond, 1);
            
            if (Delta < 0)
            {
                delta.Text = "Delta jest mniejsza od 0";
                x1.Text =  "Miejsce zerowe nie istnieje";
                x2.Text = "Miejsce zerowe nie istnieje";
            } else if (Delta == 0)
            {
                delta.Text = "Delta jest równa 0";
                x1.Text = "Miejsce zerowe jest równe" + xfirst;
                x2.Text = "Miejsce zerowe nie istnieje";
            } else if (Delta > 0)
            {
                delta.Text = "Delta jest wiêksza od 0";
                x1.Text = "Miejsce zerowe jest równe" + Convert.ToString(xfirst);
                x2.Text = "Miejsce zerowe jest równe" + Convert.ToString(xsecond);
            } 
            

            /*Label d = delta;
            d.Text = Convert.ToString(Delta);
            Label x = x1;
            x.Text = Convert.ToString(xfirst);
            Label xx = x2;
            xx.Text = Convert.ToString(xsecond); */
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}