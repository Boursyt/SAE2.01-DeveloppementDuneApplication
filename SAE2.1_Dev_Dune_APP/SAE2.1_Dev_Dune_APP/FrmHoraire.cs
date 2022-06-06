using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE2._1_Dev_Dune_APP.Properties;
using CLassLibrairieBDD;


namespace SAE2._1_Dev_Dune_APP
{
    public partial class FrmHoraire : Form
    {
        public FrmHoraire()
        {
            InitializeComponent();
        }

        private void FrmHoraire_Load(object sender, EventArgs e)
        {
            comboBoxLigne.SelectedIndex = -1;
            pictureBox1.Visible = false;
        }
        
        private void cmdButtonValider_Click(object sender, EventArgs e)
        {
            if (comboBoxLigne.SelectedIndex.Equals(-1))
            {
                cmdButtonValider.Enabled = false;//On désactive le bouton valider
            }
            if (comboBoxLigne.SelectedIndex.Equals(0))
            {
                cmdButtonValider.Enabled = true;//On active le bouton valider
                pictureBox1.Load(BDD.imageBDD(1));//On charge l'image depuis la base de données grâce à la fonctions imageBDD
                pictureBox1.Visible = true;//On rend visible l'image
            }
            if (comboBoxLigne.SelectedIndex.Equals(1))
            {
                cmdButtonValider.Enabled = true;//On active le bouton valider
                pictureBox1.Load(BDD.imageBDD(2));//On charge l'image depuis la base de données grâce à la fonctions imageBDD
                pictureBox1.Visible = true;//On rend visible l'image
            }
            if (comboBoxLigne.SelectedIndex.Equals(2))
            {
                cmdButtonValider.Enabled = true;//On active le bouton valider
                pictureBox1.Load(BDD.imageBDD(3));//On charge l'image depuis la base de données grâce à la fonctions imageBDD
                pictureBox1.Visible = true;//On rend visible l'image
            }
        }
        

        private void CmdAcceuil_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAcceuil frmAcceuil = new FrmAcceuil();
            frmAcceuil.Show();
        }

        private void CmdCarteLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCarteLigne fCarteLigne = new FrmCarteLigne();
            fCarteLigne.Show();
        }

        private void CmdRechercheItineraire_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRechercheItineraire fHRechercheItineraire = new FrmRechercheItineraire();
            fHRechercheItineraire.Show();
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmHoraire fHoraire = new FrmHoraire();
            fHoraire.Show();
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdmin fHAdmin = new FrmAdmin();
            fHAdmin.Show();
        }
    }
}
