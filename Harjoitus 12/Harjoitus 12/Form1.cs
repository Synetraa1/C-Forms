namespace Harjoitus_12
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
            VastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
            VastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
            VastausDRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radiobutton_CheckChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". Kysymykseen:";
                laskuri++;
            }
            else
            {
                KysymysLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 1; j <= 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
                KysymysLB.Text = "Onneksi olkoon!";
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }

            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }

            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }

            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }


        }
    }
}
