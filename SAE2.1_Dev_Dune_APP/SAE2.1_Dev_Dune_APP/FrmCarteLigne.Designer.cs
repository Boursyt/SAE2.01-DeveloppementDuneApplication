﻿namespace SAE2._1_Dev_Dune_APP
{
    partial class FrmCarteLigne
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
            this.cmdButtonValider = new System.Windows.Forms.Button();
            this.comboBoxLigne = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmdRechercheItineraire = new System.Windows.Forms.Button();
            this.CmdHoraireLigne = new System.Windows.Forms.Button();
            this.CmdCarteLigne = new System.Windows.Forms.Button();
            this.CmdAcceuil = new System.Windows.Forms.Button();
            this.CmdAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdButtonValider
            // 
            this.cmdButtonValider.Location = new System.Drawing.Point(236, 43);
            this.cmdButtonValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdButtonValider.Name = "cmdButtonValider";
            this.cmdButtonValider.Size = new System.Drawing.Size(112, 38);
            this.cmdButtonValider.TabIndex = 20;
            this.cmdButtonValider.Text = "Valider";
            this.cmdButtonValider.UseVisualStyleBackColor = true;
            this.cmdButtonValider.Click += new System.EventHandler(this.cmdButtonValider_Click_1);
            // 
            // comboBoxLigne
            // 
            this.comboBoxLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLigne.FormattingEnabled = true;
            this.comboBoxLigne.Items.AddRange(new object[] {
            "Ligne 24",
            "Ligne 39",
            "Ligne 65"});
            this.comboBoxLigne.Location = new System.Drawing.Point(28, 45);
            this.comboBoxLigne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLigne.Name = "comboBoxLigne";
            this.comboBoxLigne.Size = new System.Drawing.Size(180, 28);
            this.comboBoxLigne.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAE2._1_Dev_Dune_APP.Properties.Resources.carte_ligne_65;
            this.pictureBox1.Location = new System.Drawing.Point(116, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercheItineraire.Location = new System.Drawing.Point(239, 610);
            this.CmdRechercheItineraire.Name = "CmdRechercheItineraire";
            this.CmdRechercheItineraire.Size = new System.Drawing.Size(186, 83);
            this.CmdRechercheItineraire.TabIndex = 26;
            this.CmdRechercheItineraire.Text = "Recherche d\'itinéraire";
            this.CmdRechercheItineraire.UseVisualStyleBackColor = true;
            this.CmdRechercheItineraire.Click += new System.EventHandler(this.CmdRechercheItineraire_Click);
            // 
            // CmdHoraireLigne
            // 
            this.CmdHoraireLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHoraireLigne.Location = new System.Drawing.Point(467, 610);
            this.CmdHoraireLigne.Name = "CmdHoraireLigne";
            this.CmdHoraireLigne.Size = new System.Drawing.Size(186, 83);
            this.CmdHoraireLigne.TabIndex = 25;
            this.CmdHoraireLigne.Text = "Horaire des Lignes";
            this.CmdHoraireLigne.UseVisualStyleBackColor = true;
            this.CmdHoraireLigne.Click += new System.EventHandler(this.CmdHoraireLigne_Click);
            // 
            // CmdCarteLigne
            // 
            this.CmdCarteLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarteLigne.Location = new System.Drawing.Point(695, 610);
            this.CmdCarteLigne.Name = "CmdCarteLigne";
            this.CmdCarteLigne.Size = new System.Drawing.Size(186, 83);
            this.CmdCarteLigne.TabIndex = 24;
            this.CmdCarteLigne.Text = "Carte par ligne";
            this.CmdCarteLigne.UseVisualStyleBackColor = true;
            // 
            // CmdAcceuil
            // 
            this.CmdAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAcceuil.Location = new System.Drawing.Point(13, 610);
            this.CmdAcceuil.Name = "CmdAcceuil";
            this.CmdAcceuil.Size = new System.Drawing.Size(186, 83);
            this.CmdAcceuil.TabIndex = 23;
            this.CmdAcceuil.Text = "Acceuil";
            this.CmdAcceuil.UseVisualStyleBackColor = true;
            this.CmdAcceuil.Click += new System.EventHandler(this.CmdAcceuil_Click_1);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.ForeColor = System.Drawing.Color.Red;
            this.CmdAdmin.Location = new System.Drawing.Point(909, 610);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(142, 83);
            this.CmdAdmin.TabIndex = 22;
            this.CmdAdmin.Text = "Mode admin";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            this.CmdAdmin.Click += new System.EventHandler(this.CmdAdmin_Click);
            // 
            // FrmCarteLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 707);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.CmdAcceuil);
            this.Controls.Add(this.CmdAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdButtonValider);
            this.Controls.Add(this.comboBoxLigne);
            this.MaximizeBox = false;
            this.Name = "FrmCarteLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobus Levis - Carte des lignes";
            this.Load += new System.EventHandler(this.FrmCarteLigne_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdButtonValider;
        private System.Windows.Forms.ComboBox comboBoxLigne;
        private System.Windows.Forms.Button CmdRechercheItineraire;
        private System.Windows.Forms.Button CmdHoraireLigne;
        private System.Windows.Forms.Button CmdCarteLigne;
        private System.Windows.Forms.Button CmdAcceuil;
        private System.Windows.Forms.Button CmdAdmin;
    }
}