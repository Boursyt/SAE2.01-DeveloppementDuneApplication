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
            if (cbxTable.SelectedIndex==-1) 
            {
                MessageBox.Show("Veuillez sélectionner une table");
            }
            else
            {
                lbl_nomtable.Text = "Table : " + cbxTable.Text;
                lbl_nomtable.Visible = true;

                string table, sql;
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

                cmdAjouter.Enabled = true;
                cmdModifier.Enabled = true;
                cmdSupr.Enabled = true;
            }
            


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

        private void masquerEntrer()
        {
            textBox1.Location = new Point(145, textBox1.Location.Y);

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox2.Visible = false;

           
        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {
            string sql = "";

            masquerEntrer();

            label1.Text = $"INSERT INTO {cbxTable.Text} (";
            label2.Text = ")";
            label3.Text = " VALUES (";
            label5.Text = ")";

            textBox2.Size = new Size(500, textBox2.Size.Height);

            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox1.Text = "entrer le nom des champs ";
            textBox2.Text = "entrer la valeur des champs";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            sql = label1.Text + textBox1.Text + label2.Text + label3.Text + textBox2.Text + label5.Text + ";";

            label4.Text = sql;
        }

        private void CmdModifier_Click(object sender, EventArgs e)
        {
            string sql = "";

            masquerEntrer();

            label1.Text = $"UPDATE {cbxTable.Text} SET ";
            label3.Text = "WHERE ";

            textBox2.Size = new Size(500, textBox2.Size.Height);

            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox1.Text = "entrer le nom des champs et sa nouvelle valeur";
            textBox2.Text = "entrer la condition de selection";

            label1.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            sql = label1.Text + textBox1.Text + " " +label3.Text + textBox2.Text + ';';

            label4.Text = sql;
        }

        private void CmdSupr_Click(object sender, EventArgs e)
        {
            string sql = "";

            masquerEntrer();

            textBox1.Location = new Point(180,textBox1.Location.Y);

            label1.Text = $"DELETE FROM {cbxTable.Text} WHERE";

            
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "entrer la condition de selection";

            label1.Visible = true;
            textBox1.Visible = true;

            sql = label1.Text + " " + textBox1.Text + ';';

            label4.Text = sql;
        }

        private void cmdButtonSQLValide_Click(object sender, EventArgs e)
        {
            string sql = label4.Text;

            label4.Visible = true;

            //BDD.executeSQL(sql); a decommenter lors de mise en marche car peut detruire la base !

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }



}
