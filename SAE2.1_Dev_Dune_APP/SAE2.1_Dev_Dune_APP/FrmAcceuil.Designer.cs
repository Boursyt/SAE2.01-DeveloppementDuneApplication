namespace SAE2._1_Dev_Dune_APP
{
    partial class FrmAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdAdmin = new System.Windows.Forms.Button();
            this.CmdAcceuil = new System.Windows.Forms.Button();
            this.CmdCarteLigne = new System.Windows.Forms.Button();
            this.CmdHoraireLigne = new System.Windows.Forms.Button();
            this.CmdRechercheItineraire = new System.Windows.Forms.Button();
            this.ImgCarteLevis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCarteLevis)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.ForeColor = System.Drawing.Color.Red;
            this.CmdAdmin.Location = new System.Drawing.Point(909, 610);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(142, 83);
            this.CmdAdmin.TabIndex = 5;
            this.CmdAdmin.Text = "Mode admin";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            this.CmdAdmin.Click += new System.EventHandler(this.CmdAdmin_Click);
            // 
            // CmdAcceuil
            // 
            this.CmdAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAcceuil.Location = new System.Drawing.Point(14, 610);
            this.CmdAcceuil.Name = "CmdAcceuil";
            this.CmdAcceuil.Size = new System.Drawing.Size(186, 83);
            this.CmdAcceuil.TabIndex = 6;
            this.CmdAcceuil.Text = "Acceuil";
            this.CmdAcceuil.UseVisualStyleBackColor = true;
            this.CmdAcceuil.Click += new System.EventHandler(this.CmdAcceuil_Click);
            // 
            // CmdCarteLigne
            // 
            this.CmdCarteLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarteLigne.Location = new System.Drawing.Point(696, 610);
            this.CmdCarteLigne.Name = "CmdCarteLigne";
            this.CmdCarteLigne.Size = new System.Drawing.Size(186, 83);
            this.CmdCarteLigne.TabIndex = 7;
            this.CmdCarteLigne.Text = "Carte par ligne";
            this.CmdCarteLigne.UseVisualStyleBackColor = true;
            this.CmdCarteLigne.Click += new System.EventHandler(this.CmdCarteLigne_Click);
            // 
            // CmdHoraireLigne
            // 
            this.CmdHoraireLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHoraireLigne.Location = new System.Drawing.Point(468, 610);
            this.CmdHoraireLigne.Name = "CmdHoraireLigne";
            this.CmdHoraireLigne.Size = new System.Drawing.Size(186, 83);
            this.CmdHoraireLigne.TabIndex = 8;
            this.CmdHoraireLigne.Text = "Horaire des Lignes";
            this.CmdHoraireLigne.UseVisualStyleBackColor = true;
            this.CmdHoraireLigne.Click += new System.EventHandler(this.CmdHoraireLigne_Click);
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercheItineraire.Location = new System.Drawing.Point(240, 610);
            this.CmdRechercheItineraire.Name = "CmdRechercheItineraire";
            this.CmdRechercheItineraire.Size = new System.Drawing.Size(186, 83);
            this.CmdRechercheItineraire.TabIndex = 9;
            this.CmdRechercheItineraire.Text = "Recherche d\'itinéraire";
            this.CmdRechercheItineraire.UseVisualStyleBackColor = true;
            this.CmdRechercheItineraire.Click += new System.EventHandler(this.CmdRechercheItineraire_Click);
            // 
            // ImgCarteLevis
            // 
            this.ImgCarteLevis.Location = new System.Drawing.Point(-3, -10);
            this.ImgCarteLevis.Name = "ImgCarteLevis";
            this.ImgCarteLevis.Size = new System.Drawing.Size(1068, 718);
            this.ImgCarteLevis.TabIndex = 0;
            this.ImgCarteLevis.TabStop = false;
            // 
            // FrmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 707);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.CmdAcceuil);
            this.Controls.Add(this.CmdAdmin);
            this.Controls.Add(this.ImgCarteLevis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAcceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobus Levis- Acceuil";
            this.Load += new System.EventHandler(this.FrmAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCarteLevis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgCarteLevis;
        private System.Windows.Forms.Button CmdAdmin;
        private System.Windows.Forms.Button CmdAcceuil;
        private System.Windows.Forms.Button CmdCarteLigne;
        private System.Windows.Forms.Button CmdHoraireLigne;
        private System.Windows.Forms.Button CmdRechercheItineraire;
    }
}

