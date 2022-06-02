using System;
using CLassLibrairieBDD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAE2._1_Dev_Dune_APP
{
    public partial class FrmAcceuil : Form
    {
        public FrmAcceuil()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CmdAcceuil_Click(object sender, EventArgs e)
        {
            
            Hide();
            FrmAcceuil fHacceuil = new FrmAcceuil();
            fHacceuil.Show();
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmHoraire fHoraire = new FrmHoraire();
            fHoraire.Show();
        }

        private void CmdCarteLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCarteLigne fCarteLigne = new FrmCarteLigne();
            fCarteLigne.Show();
        }

        private void FrmAcceuil_Load(object sender, EventArgs e)
        {
            bool ConnexionOuverte;

            ConnexionOuverte = BDD.initConnexion();

            if (ConnexionOuverte)
            {}
            else
                MessageBox.Show("La connexion à la base de donnée a échoué.");
        }
    }
}
