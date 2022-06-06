using CLassLibrairieBDD;
using System;
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
    public partial class FrmRechercheItineraire : Form
    {
        public FrmRechercheItineraire()
        {
            InitializeComponent();
        }

        private void CmdAcceuil_Click(object sender, EventArgs e)
        {
            Hide(); //Cache le form actuellement sur l'écran
            FrmAcceuil fHacceuil = new FrmAcceuil();//Crée le form
            fHacceuil.Show();//Affiche le form
        }

        private void CmdRechercheItineraire_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmRechercheItineraire fHRechercheItineraire = new FrmRechercheItineraire();//Crée le form
            fHRechercheItineraire.Show();//Affiche le form
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmHoraire fHoraire = new FrmHoraire();//Crée le form
            fHoraire.Show();//Affiche le form
        }

        private void CmdCarteLigne_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmCarteLigne fCarteLigne = new FrmCarteLigne();//Crée le form
            fCarteLigne.Show();//Affiche le form
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            Hide();//Cache le form actuellement sur l'écran
            FrmAdmin fHAdmin = new FrmAdmin();//Crée le form
            fHAdmin.Show();//Affiche le form
        }
    }
}
