namespace Harjoitus_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(LukuYksiTB.Text);
            float luku2 = float.Parse(LukuKaksiTB.Text);
            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;
            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    Console.WriteLine("Tapahtui Virhe :(");
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }
    }
}
