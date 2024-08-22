namespace Harjoitus_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huolto, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huolto = Convert.ToDouble(HuoltoTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            energia = Convert.ToDouble(PolttoaineTB.Text);
            kustannukset = (laina + nesteet + pesut + huolto + muut + energia) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
        }
    }
}
