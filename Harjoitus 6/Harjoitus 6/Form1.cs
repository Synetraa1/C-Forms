namespace Harjoitus_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Nico" && SalasanaTB.Text == "1234")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "K�ytt�j�tunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
