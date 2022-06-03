using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLassLibrairieBDD;
using MySql.Data.MySqlClient;
using MySql.Data;
using SAE2._1_Dev_Dune_APP;

namespace CLassLibrairieBDD
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            string table,sql;
            table = cbxTable.Text;
            sql = $"select * from {table}";
            MySqlCommand cmd = new MySqlCommand(sql, BDD.macnx);
            listBox1.Items.Clear();
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    string chaine;
                    if (table == "Horaire")
                    {
                        chaine = rdr[0].ToString() + "  " + rdr[1].ToString() + "  " + rdr[2].ToString() + "  " + rdr[3].ToString() + "  " + rdr[4].ToString() + "  " + rdr[5].ToString();
                        listBox1.Items.Add(chaine);
                    }
                    if (table == "Arret" || table == "Image" || table == "Ligne")
                    {
                        chaine = rdr[0].ToString() + "  " + rdr[1].ToString() + "  " + rdr[2].ToString();
                        listBox1.Items.Add(chaine);
                    }
                    if (table == "Passage")
                    {
                        chaine = rdr[0].ToString() + "  " + rdr[1].ToString() + "  " + rdr[2].ToString() + "  " + rdr[3].ToString() + "  " + rdr[4].ToString();
                        listBox1.Items.Add(chaine);
                    }
                }
            }
            rdr.Close();
            cmd.Dispose();



        }

        private void CmdAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdmin fHAdmin = new FrmAdmin();
            fHAdmin.Show();
        }

        private void CmdCarteLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCarteLigne fCarteLigne = new FrmCarteLigne();
            fCarteLigne.Show();
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmHoraire fHoraire = new FrmHoraire();
            fHoraire.Show();
        }

        private void CmdRechercheItineraire_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRechercheItineraire fHRechercheItineraire = new FrmRechercheItineraire();
            fHRechercheItineraire.Show();
        }

        private void cmdAcceuil_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAcceuil fHacceuil = new FrmAcceuil();
            fHacceuil.Show();
        }
    }
}
