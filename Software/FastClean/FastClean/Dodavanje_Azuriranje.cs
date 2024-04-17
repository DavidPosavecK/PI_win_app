using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastClean.Models;
using FastClean.Repository;

namespace FastClean
{
    public partial class frmDodavanjeAzuriranje : Form
    {
        public int IdKlijenta { get; set; }
        public string ImeKlijenta { get; set; }
        public string PrezimeKlijenta { get; set; }
        public string KontaktKlijenta { get; set; }
        public string EmailKlijenta { get; set; }

        public frmDodavanjeAzuriranje()
        {
            InitializeComponent();
        }

        public frmDodavanjeAzuriranje(Klijent klijent)
        {
            InitializeComponent();

            txtID.Text = klijent.IdKlijent.ToString();
            txtIme.Text = klijent.Ime;
            txtPrezime.Text = klijent.Prezime;
            txtKontakt.Text = klijent.Kontakt;
            txtEmail.Text = klijent.Email;
        }


        private void btnOdustani_Click(object sender, EventArgs e)
        {
            frmPrikaz FrmPrikaz = new frmPrikaz();
            Hide();
            FrmPrikaz.ShowDialog();
            Close();
        }

        private void btnPrimjeni_Click(object sender, EventArgs e)
        {
            ImeKlijenta = txtIme.Text;
            PrezimeKlijenta = txtPrezime.Text;
            KontaktKlijenta = txtKontakt.Text;
            EmailKlijenta = txtEmail.Text;

            KlijentRepository klijentRepository = new KlijentRepository();
            
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                IdKlijenta = int.Parse(txtID.Text);
                klijentRepository.UpdateKlijent(IdKlijenta, ImeKlijenta, PrezimeKlijenta, KontaktKlijenta, EmailKlijenta);
            }
            else
            {
                klijentRepository.InsertKlijenta(ImeKlijenta, PrezimeKlijenta, KontaktKlijenta, EmailKlijenta);
            }

            frmPrikaz FrmPrikaz = new frmPrikaz();
            Hide();
            FrmPrikaz.ShowDialog();
            Close();
        }
    }
}
