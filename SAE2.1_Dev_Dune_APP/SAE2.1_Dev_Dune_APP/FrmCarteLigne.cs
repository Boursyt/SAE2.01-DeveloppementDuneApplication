﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE2._1_Dev_Dune_APP.Properties;

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
            if (comboBoxLigne.SelectedIndex.Equals(0))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Resources.carte_ligne_24;
            }
            if (comboBoxLigne.SelectedIndex.Equals(1))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Resources.carte_ligne_39;
            }
            if (comboBoxLigne.SelectedIndex.Equals(2))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Resources.carte_ligne_65;
            }
        }

        private void FrmCarteLigne_Load_1(object sender, EventArgs e)
        {
            comboBoxLigne.SelectedIndex = 0;
            pictureBox1.Visible = false;
        }

        private void CmdAcceuil_Click_1(object sender, EventArgs e)
        {
            Hide();
            FrmAcceuil frmAcceuil = new FrmAcceuil();
            frmAcceuil.Show();
        }

        private void CmdHoraireLigne_Click(object sender, EventArgs e)
        {
            Hide();
            FrmHoraire fHoraire = new FrmHoraire();
            fHoraire.Show();
        }
    }
}