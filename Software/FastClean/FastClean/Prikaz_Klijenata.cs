using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using FastClean.Models;
using FastClean.Repository;

namespace FastClean
{
    public partial class frmPrikaz : Form
    {
        public string pretrazivanje { get; set; }

        public frmPrikaz()
        {
            InitializeComponent();
            DB.SetConfiguration("IPS23_dposaveck20", "dposaveck20", "-Ik!#j45");
        }

        private void frmPrikaz_Load(object sender, EventArgs e)
        {
            PrikaziKlijente();
        }

        private void PrikaziKlijente()
        {
            List<Klijent> korisnik = KlijentRepository.GetKlijents();
            dgvPrikaz.DataSource = korisnik;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodavanjeAzuriranje FrmDodavanjeAzuriranje = new frmDodavanjeAzuriranje();
            Hide();
            FrmDodavanjeAzuriranje.ShowDialog();
            Close();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            pretrazivanje = txtPretrazivanje.Text;

            if (!string.IsNullOrWhiteSpace(pretrazivanje))
            {
                List<Klijent> rezultatiPretrage = KlijentRepository.GetKlijent(pretrazivanje);
                dgvPrikaz.DataSource = rezultatiPretrage;
            }
            else
            {
                PrikaziKlijente();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Klijent odabraniKlijent = dgvPrikaz.CurrentRow.DataBoundItem as Klijent;

            if (odabraniKlijent != null)
            {
                KlijentRepository klijentRepository = new KlijentRepository();

                klijentRepository.DeleteKlijent(odabraniKlijent.IdKlijent);
            }

            PrikaziKlijente();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Klijent odabraniKlijent = dgvPrikaz.CurrentRow.DataBoundItem as Klijent;

            if (odabraniKlijent != null)
            {
                frmDodavanjeAzuriranje FrmAzuriranje = new frmDodavanjeAzuriranje(odabraniKlijent);
                Hide();
                FrmAzuriranje.ShowDialog();
                Close();
            }
        }
    }
}
