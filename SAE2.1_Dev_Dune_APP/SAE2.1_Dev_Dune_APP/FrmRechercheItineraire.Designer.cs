namespace SAE2._1_Dev_Dune_APP
{
    partial class FrmRechercheItineraire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdRechercheItineraire = new System.Windows.Forms.Button();
            this.CmdHoraireLigne = new System.Windows.Forms.Button();
            this.CmdCarteLigne = new System.Windows.Forms.Button();
            this.CmdAcceuil = new System.Windows.Forms.Button();
            this.CmdAdmin = new System.Windows.Forms.Button();
            this.LblArretDep = new System.Windows.Forms.Label();
            this.TbArretDep = new System.Windows.Forms.TextBox();
            this.CbHorraireDep = new System.Windows.Forms.CheckBox();
            this.TbHorrireDep = new System.Windows.Forms.TextBox();
            this.TbHorraireArr = new System.Windows.Forms.TextBox();
            this.CbHorraireArr = new System.Windows.Forms.CheckBox();
            this.TbArretArr = new System.Windows.Forms.TextBox();
            this.LblArreArr = new System.Windows.Forms.Label();
            this.CmdRecherche = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercheItineraire.Location = new System.Drawing.Point(240, 610);
            this.CmdRechercheItineraire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdRechercheItineraire.Name = "CmdRechercheItineraire";
            this.CmdRechercheItineraire.Size = new System.Drawing.Size(186, 82);
            this.CmdRechercheItineraire.TabIndex = 14;
            this.CmdRechercheItineraire.Text = "Recherche d\'itinéraire";
            this.CmdRechercheItineraire.UseVisualStyleBackColor = true;
            this.CmdRechercheItineraire.Click += new System.EventHandler(this.CmdRechercheItineraire_Click);
            // 
            // CmdHoraireLigne
            // 
            this.CmdHoraireLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHoraireLigne.Location = new System.Drawing.Point(468, 610);
            this.CmdHoraireLigne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdHoraireLigne.Name = "CmdHoraireLigne";
            this.CmdHoraireLigne.Size = new System.Drawing.Size(186, 82);
            this.CmdHoraireLigne.TabIndex = 13;
            this.CmdHoraireLigne.Text = "Horaire des Lignes";
            this.CmdHoraireLigne.UseVisualStyleBackColor = true;
            this.CmdHoraireLigne.Click += new System.EventHandler(this.CmdHoraireLigne_Click);
            // 
            // CmdCarteLigne
            // 
            this.CmdCarteLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarteLigne.Location = new System.Drawing.Point(696, 610);
            this.CmdCarteLigne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdCarteLigne.Name = "CmdCarteLigne";
            this.CmdCarteLigne.Size = new System.Drawing.Size(186, 82);
            this.CmdCarteLigne.TabIndex = 12;
            this.CmdCarteLigne.Text = "Carte par ligne";
            this.CmdCarteLigne.UseVisualStyleBackColor = true;
            this.CmdCarteLigne.Click += new System.EventHandler(this.CmdCarteLigne_Click);
            // 
            // CmdAcceuil
            // 
            this.CmdAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAcceuil.Location = new System.Drawing.Point(14, 610);
            this.CmdAcceuil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAcceuil.Name = "CmdAcceuil";
            this.CmdAcceuil.Size = new System.Drawing.Size(186, 82);
            this.CmdAcceuil.TabIndex = 11;
            this.CmdAcceuil.Text = "Acceuil";
            this.CmdAcceuil.UseVisualStyleBackColor = true;
            this.CmdAcceuil.Click += new System.EventHandler(this.CmdAcceuil_Click);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.ForeColor = System.Drawing.Color.Red;
            this.CmdAdmin.Location = new System.Drawing.Point(909, 610);
            this.CmdAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(142, 82);
            this.CmdAdmin.TabIndex = 10;
            this.CmdAdmin.Text = "Mode admin";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            this.CmdAdmin.Click += new System.EventHandler(this.CmdAdmin_Click);
            // 
            // LblArretDep
            // 
            this.LblArretDep.AutoSize = true;
            this.LblArretDep.Location = new System.Drawing.Point(236, 88);
            this.LblArretDep.Name = "LblArretDep";
            this.LblArretDep.Size = new System.Drawing.Size(116, 20);
            this.LblArretDep.TabIndex = 15;
            this.LblArretDep.Text = "Arret de depart";
            // 
            // TbArretDep
            // 
            this.TbArretDep.Location = new System.Drawing.Point(150, 168);
            this.TbArretDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbArretDep.Name = "TbArretDep";
            this.TbArretDep.Size = new System.Drawing.Size(273, 26);
            this.TbArretDep.TabIndex = 16;
            // 
            // CbHorraireDep
            // 
            this.CbHorraireDep.AutoSize = true;
            this.CbHorraireDep.Location = new System.Drawing.Point(199, 282);
            this.CbHorraireDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbHorraireDep.Name = "CbHorraireDep";
            this.CbHorraireDep.Size = new System.Drawing.Size(164, 24);
            this.CbHorraireDep.TabIndex = 17;
            this.CbHorraireDep.Text = "Horraire de depart";
            this.CbHorraireDep.UseVisualStyleBackColor = true;
            // 
            // TbHorrireDep
            // 
            this.TbHorrireDep.Location = new System.Drawing.Point(150, 370);
            this.TbHorrireDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbHorrireDep.Name = "TbHorrireDep";
            this.TbHorrireDep.Size = new System.Drawing.Size(273, 26);
            this.TbHorrireDep.TabIndex = 19;
            // 
            // TbHorraireArr
            // 
            this.TbHorraireArr.Location = new System.Drawing.Point(644, 370);
            this.TbHorraireArr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbHorraireArr.Name = "TbHorraireArr";
            this.TbHorraireArr.Size = new System.Drawing.Size(273, 26);
            this.TbHorraireArr.TabIndex = 23;
            // 
            // CbHorraireArr
            // 
            this.CbHorraireArr.AutoSize = true;
            this.CbHorraireArr.Location = new System.Drawing.Point(727, 282);
            this.CbHorraireArr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbHorraireArr.Name = "CbHorraireArr";
            this.CbHorraireArr.Size = new System.Drawing.Size(151, 24);
            this.CbHorraireArr.TabIndex = 22;
            this.CbHorraireArr.Text = "Horraire d\'arriver";
            this.CbHorraireArr.UseVisualStyleBackColor = true;
            // 
            // TbArretArr
            // 
            this.TbArretArr.Location = new System.Drawing.Point(644, 168);
            this.TbArretArr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbArretArr.Name = "TbArretArr";
            this.TbArretArr.Size = new System.Drawing.Size(273, 26);
            this.TbArretArr.TabIndex = 21;
            // 
            // LblArreArr
            // 
            this.LblArreArr.AutoSize = true;
            this.LblArreArr.Location = new System.Drawing.Point(736, 88);
            this.LblArreArr.Name = "LblArreArr";
            this.LblArreArr.Size = new System.Drawing.Size(103, 20);
            this.LblArreArr.TabIndex = 20;
            this.LblArreArr.Text = "Arret d\'arriver";
            // 
            // CmdRecherche
            // 
            this.CmdRecherche.Location = new System.Drawing.Point(443, 469);
            this.CmdRecherche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmdRecherche.Name = "CmdRecherche";
            this.CmdRecherche.Size = new System.Drawing.Size(225, 116);
            this.CmdRecherche.TabIndex = 24;
            this.CmdRecherche.Text = "Rechercher";
            this.CmdRecherche.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAE2._1_Dev_Dune_APP.Properties.Resources.Vertical_Line_Free_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(274, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 435);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRechercheItineraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 708);
            this.Controls.Add(this.CmdRecherche);
            this.Controls.Add(this.TbHorraireArr);
            this.Controls.Add(this.CbHorraireArr);
            this.Controls.Add(this.TbArretArr);
            this.Controls.Add(this.LblArreArr);
            this.Controls.Add(this.TbHorrireDep);
            this.Controls.Add(this.CbHorraireDep);
            this.Controls.Add(this.TbArretDep);
            this.Controls.Add(this.LblArretDep);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.CmdAcceuil);
            this.Controls.Add(this.CmdAdmin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmRechercheItineraire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobus Levis - Recherche d\'itinéraire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdRechercheItineraire;
        private System.Windows.Forms.Button CmdHoraireLigne;
        private System.Windows.Forms.Button CmdCarteLigne;
        private System.Windows.Forms.Button CmdAcceuil;
        private System.Windows.Forms.Button CmdAdmin;
        private System.Windows.Forms.Label LblArretDep;
        private System.Windows.Forms.TextBox TbArretDep;
        private System.Windows.Forms.CheckBox CbHorraireDep;
        private System.Windows.Forms.TextBox TbHorrireDep;
        private System.Windows.Forms.TextBox TbHorraireArr;
        private System.Windows.Forms.CheckBox CbHorraireArr;
        private System.Windows.Forms.TextBox TbArretArr;
        private System.Windows.Forms.Label LblArreArr;
        private System.Windows.Forms.Button CmdRecherche;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}