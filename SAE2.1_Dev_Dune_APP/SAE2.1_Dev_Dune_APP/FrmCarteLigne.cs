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
    public partial class FrmCarteLigne : Form
    {
        public FrmCarteLigne()
        {
            InitializeComponent();
        }


        private void cmdButtonValider_Click_1(object sender, EventArgs e)
        {
            if (comboBoxLigne.SelectedIndex.Equals(-1))
            {
                cmdButtonValider.Enabled = false;//On désactive le bouton valider
            }
            if (comboBoxLigne.SelectedIndex.Equals(0))
            {
                cmdButtonValider.Enabled = true;//On active le bouton valider
                pictureBox1.Load(BDD.imageBDD(4));//On charge l'image depuis la base de données grâce à la fonctions imageBDD
                pictureBox1.Visible = true;//On rend visible l'image
            }
            if (comboBoxLigne.SelectedIndex.Equals(1))
            {
                cmdButtonValider.Enabled = true;//On active le bouton valider
                pictureBox1.Load(BDD.imageBDD(5));//On charge l'image depuis la base de données grâce à la fonctions imageBDD
                pictureBox1.Visible = true;//On rend visible l'image
            }
            if (comboBoxLigne.SelectedIndex.Equals(2))
            {
                cmdButtonValider.Enabled = true;//On active le bouton valider
                pictureBox1.Load(BDD.imageBDD(6));//On charge l'image depuis la base de données grâce à la fonctions imageBDD
                pictureBox1.Visible = true;//On rend visible l'image
            }
        }

        private void FrmCarteLigne_Load_1(object sender, EventArgs e)
        {
            comboBoxLigne.SelectedIndex = -1;//La combobox sera sur l'index 0 de base
            pictureBox1.Visible = false;//On cache l'image
        }

        private void CmdAcceuil_Click_1(object sender, EventArgs e)
        {
            Hide(); //Cache le form actuellement sur l'écran
            FrmAcceuil fHacceuil = new FrmAcceuil();//Crée le form
            fHacceuil.Show();//Affiche le form
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmHoraire fHoraire = new FrmHoraire();//Crée le form
            fHoraire.Show();//Affiche le form
        }

        private void CmdRechercheItineraire_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmRechercheItineraire fHRechercheItineraire = new FrmRechercheItineraire();//Crée le form
            fHRechercheItineraire.Show();//Affiche le form
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmAdmin fHAdmin = new FrmAdmin();//Crée le form
            fHAdmin.Show();//Affiche le form
        }
    }
}
