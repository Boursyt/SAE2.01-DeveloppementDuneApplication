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
            if (comboBoxLigne.SelectedItem.Equals(24))
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("Ressources/24.jpg");
            }
            if (comboBoxLigne.SelectedItem.Equals(39))
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("Ressources/39.jpg");
            }
            if (comboBoxLigne.SelectedItem.Equals(65))
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("Ressources/65.jpg");
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
