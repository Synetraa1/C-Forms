namespace Harjoitus_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PainoindeksiBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text) / 100;
            double bmi = Math.Round((paino) / (pituus * pituus),2);
            if (pituus <= 1.00 || pituus >= 2.90)
            {
                KuvausLB.Text = "Virheellinen pituus";
                KuvausLB.Visible = true;
                KuvausLB.ForeColor = Color.Magenta;
                TulosLB.Visible = false;
            }
            else if (paino <= 40 || paino >= 300)
            {
                KuvausLB.Text = "Virheellinen paino";
                KuvausLB.Visible = true;
                KuvausLB.ForeColor = Color.Magenta;
                TulosLB.Visible = false;
            }

            else
            {
                if (bmi < 18.5)
                {
                    TulosLB.Text = "Painoindeksisi on " + bmi;
                    TulosLB.ForeColor = Color.Aqua;
                    KuvausLB.Text = "Alipaino";
                    KuvausLB.ForeColor = Color.Aqua;
                    KuvausLB.Visible = true;
                    TulosLB.Visible = true;
                }
                else if (bmi < 25)
                {
                    TulosLB.Text = "Painoindeksisi on " + bmi;
                    TulosLB.ForeColor = Color.Green;
                    KuvausLB.Text = "Normaalipaino";
                    KuvausLB.ForeColor = Color.Green;
                    KuvausLB.Visible = true;
                    TulosLB.Visible = true;
                }
                else if (bmi < 40)
                {
                    TulosLB.Text = "Painoindeksisi on " + bmi;
                    TulosLB.ForeColor = Color.Gold;
                    KuvausLB.Text = "Lievä Ylipaino";
                    KuvausLB.ForeColor = Color.Gold;
                    KuvausLB.Visible = true;
                    TulosLB.Visible = true;
                }
                else
                {
                    TulosLB.Text = "Painoindeksisi on " + bmi;
                    TulosLB.ForeColor = Color.Red;
                    KuvausLB.Text = "Ylipaino";
                    KuvausLB.ForeColor = Color.Red;
                    KuvausLB.Visible = true;
                    TulosLB.Visible = true;
                }
            }
        }
    }
}
