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
            comboBoxLigne.SelectedIndex = 0;
            pictureBox1.Visible = false;
        }
        
        private void cmdButtonValider_Click(object sender, EventArgs e)
        {
            if (comboBoxLigne.SelectedIndex.Equals(0))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Resources._24;
            }
            if (comboBoxLigne.SelectedIndex.Equals(1))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Resources._39;
            }
            if (comboBoxLigne.SelectedIndex.Equals(2))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Resources._65;
            }
        }
        

        private void CmdAcceuil_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAcceuil frmAcceuil = new FrmAcceuil();
            frmAcceuil.Show();
        }

        
    }
}
