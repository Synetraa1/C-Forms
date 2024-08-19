namespace Harjoitus_4
{
    public partial class Ik‰Laskuri : Form
    {
        public Ik‰Laskuri()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntynmaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);

            VuosinaLB.Text = Math.Floor(erotus / 365.25) + " Vuotta";
            KuukausinaLB.Text = Math.Floor(erotus / 365.25 * 12) + " Kuukautta";
            PaivinaLB.Text = erotus + " P‰iv‰‰";
            TunteinaLB.Text = (erotus * 24) + " Tuntia";
            MinuutteinaLB.Text = (erotus * 24 * 60) + " Minuuttia";
            SekunteinaLB.Text = (erotus * 24 * 3600) + " Sekuntia";

            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;


        }
    }
}
