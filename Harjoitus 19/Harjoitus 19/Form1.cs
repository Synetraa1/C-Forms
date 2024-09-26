namespace Harjoitus_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin. \n";
            meistaLB.Text += "9.00-14.30 joka päivä maanataista perjantaihin. \n";
            meistaLB.Text += "Keudan oppilaskunnan kahvilasta saa lämpimien. \n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa ja makeisia. \n";
            meistaLB.Text += "Tervetuloa tutustumaan! \n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruuatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruuatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruuatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruuatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruuatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }
    }
}
