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

namespace FastClean
{
    public partial class frmOdabir : Form
    {
        public frmOdabir()
        {
            InitializeComponent();
            DB.SetConfiguration("IPS23_dposaveck20", "dposaveck20", "-Ik!#j45");
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            frmPrikaz FrmPrikaz = new frmPrikaz();
            FrmPrikaz.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodavanjeAzuriranje FrmDodavanjeAzuriranje = new frmDodavanjeAzuriranje();
            Hide();
            FrmDodavanjeAzuriranje.ShowDialog();
            Close();
        }
    }
}
