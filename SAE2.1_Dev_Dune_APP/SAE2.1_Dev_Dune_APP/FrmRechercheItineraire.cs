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
            Hide();
            FrmAcceuil fHacceuil = new FrmAcceuil();
            fHacceuil.Show();
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

        private void CmdCarteLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCarteLigne fCarteLigne = new FrmCarteLigne();
            fCarteLigne.Show();
        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdmin fHAdmin = new FrmAdmin();
            fHAdmin.Show();
        }
    }
}
