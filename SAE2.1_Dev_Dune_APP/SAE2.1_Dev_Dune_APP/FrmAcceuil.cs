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

        private void CmdAcceuil_Click(object sender, EventArgs e)//Evénement qui se déclenche lors d'un clic sur le bouton acceuil
        {
            
            Hide(); //Cache le form actuellement sur l'écran
            FrmAcceuil fHacceuil = new FrmAcceuil();//Crée le form
            fHacceuil.Show();//Affiche le form
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)//Evénement qui se déclenche lors d'un clic sur le bouton horaire ligne
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmHoraire fHoraire = new FrmHoraire();//Crée le form
            fHoraire.Show();//Affiche le form
        }

        private void CmdCarteLigne_Click(object sender, EventArgs e)//Evénement qui se déclenche lors d'un clic sur le bouton carte des lignes
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmCarteLigne fCarteLigne = new FrmCarteLigne();//Crée le form
            fCarteLigne.Show();//Affiche le form
        }

        private void FrmAcceuil_Load(object sender, EventArgs e)//Evénement qui se déclenche lorsque le Form Acceuil s'ouvre
        {
            bool ConnexionOuverte;

            ConnexionOuverte = BDD.initConnexion();//On ouvre la connection avec la base de données

            if (ConnexionOuverte)//Si le bool ConnexionOuverte est vrai donc que la connexion est un succés
            {
                //La connexion est un succés
            }
            else
            {
                MessageBox.Show("La connexion à la base de donnée a échoué.");//On affiche un message d'erreur si la connexion a échoué
            }
            ImgCarteLevis.Load(BDD.imageBDD(7));//On fait appel la fonction imageBDD de BDD.cs pour charger la carte du réseau depuis la base de données
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
