using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_harjoitus
{
    public partial class Opiskelijahaku : Form
    {
        Opiskelija Opiskelija = new Opiskelija();
        public Opiskelijahaku()
        {
            InitializeComponent();
        }

        private void Opiskelijahaku_Load_1(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = Opiskelija.haeOpiskelijat();
            TietotauluDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void tyhjennabt_Click(object sender, EventArgs e)
        {
            idtb.Text = "";
            etutb.Text = "";
            sukutb.Text = "";
            puhtb.Text = "";
            spostitb.Text = "";
            opiskelijanumerotb.Text = "";
        }

        private void tallennabt_Click(object sender, EventArgs e)
        {
            String enimi = etutb.Text;
            String snimi = sukutb.Text;
            String puh = puhtb.Text;
            String email = spostitb.Text;
            int oNro = Int32.Parse(opiskelijanumerotb.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaaOpiskelija = Opiskelija.lisaaOpiskelija(enimi, snimi, puh, email, oNro);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = Opiskelija.haeOpiskelijat();
        }

        private void paivitabt_Click(object sender, EventArgs e)
        {
            String enimi = etutb.Text;
            String snimi = sukutb.Text;
            String puh = puhtb.Text;
            String email = spostitb.Text;
            int oNro = Int32.Parse(opiskelijanumerotb.Text);
            int oid = Int32.Parse(idtb.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelija = Opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, email, oNro);
                if (muokkaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija muokattu onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty muokkaamaan", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = Opiskelija.haeOpiskelijat();
        }

        private void poistabt_Click(object sender, EventArgs e)
        {
            int ktunnus = Int32.Parse(idtb.Text);
            if (Opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = Opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennabt.PerformClick();
        }

        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            etutb.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sukutb.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhtb.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            spostitb.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijanumerotb.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
            idtb.Text = TietotauluDG.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
