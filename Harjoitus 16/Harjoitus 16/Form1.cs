namespace Harjoitus_16
{
    public partial class Ajastin : Form
    {
        public Ajastin()
        {
            InitializeComponent();
        }

        private int kokonaisaika;

        private void Ajastin_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 30;
            sekunnitCB.SelectedIndex = 0;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString("D2") + ":" + sekunnit.ToString("D2");
            }
            else
            {
                ajastinTM.Stop();
                MessageBox.Show("Aikasi Loppui");
            }
        }
    }
}
