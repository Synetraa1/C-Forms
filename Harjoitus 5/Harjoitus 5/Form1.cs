namespace Harjoitus_5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();

        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    if (int.TryParse(uusiLukuTB.Text, out int numero))
                    {
                        jono.Add(numero);
                        uusiLukuTB.Text = "";
                    }
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
            jono.Clear();
            VastausLB.Text = "";
            VastausLB.Visible = false;
        }

        private void LukuLB_Click(object sender, EventArgs e)
        {

        }

        private void uusiLukuTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
