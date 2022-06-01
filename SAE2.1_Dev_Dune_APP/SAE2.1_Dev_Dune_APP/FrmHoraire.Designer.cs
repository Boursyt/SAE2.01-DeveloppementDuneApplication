namespace SAE2._1_Dev_Dune_APP
{
    partial class FrmHoraire
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
            this.comboBoxLigne = new System.Windows.Forms.ComboBox();
            this.cmdButtonValider = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercheItineraire.Location = new System.Drawing.Point(160, 374);
            this.CmdRechercheItineraire.Margin = new System.Windows.Forms.Padding(2);
            this.CmdRechercheItineraire.Name = "CmdRechercheItineraire";
            this.CmdRechercheItineraire.Size = new System.Drawing.Size(124, 50);
            this.CmdRechercheItineraire.TabIndex = 14;
            this.CmdRechercheItineraire.Text = "Recherche d\'itinéraire";
            this.CmdRechercheItineraire.UseVisualStyleBackColor = true;
            // 
            // CmdHoraireLigne
            // 
            this.CmdHoraireLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHoraireLigne.Location = new System.Drawing.Point(312, 374);
            this.CmdHoraireLigne.Margin = new System.Windows.Forms.Padding(2);
            this.CmdHoraireLigne.Name = "CmdHoraireLigne";
            this.CmdHoraireLigne.Size = new System.Drawing.Size(124, 50);
            this.CmdHoraireLigne.TabIndex = 13;
            this.CmdHoraireLigne.Text = "Horaire des Lignes";
            this.CmdHoraireLigne.UseVisualStyleBackColor = true;
            // 
            // CmdCarteLigne
            // 
            this.CmdCarteLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarteLigne.Location = new System.Drawing.Point(464, 374);
            this.CmdCarteLigne.Margin = new System.Windows.Forms.Padding(2);
            this.CmdCarteLigne.Name = "CmdCarteLigne";
            this.CmdCarteLigne.Size = new System.Drawing.Size(124, 50);
            this.CmdCarteLigne.TabIndex = 12;
            this.CmdCarteLigne.Text = "Carte par ligne";
            this.CmdCarteLigne.UseVisualStyleBackColor = true;
            // 
            // CmdAcceuil
            // 
            this.CmdAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmdAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAcceuil.Location = new System.Drawing.Point(9, 374);
            this.CmdAcceuil.Margin = new System.Windows.Forms.Padding(2);
            this.CmdAcceuil.Name = "CmdAcceuil";
            this.CmdAcceuil.Size = new System.Drawing.Size(124, 50);
            this.CmdAcceuil.TabIndex = 11;
            this.CmdAcceuil.Text = "Acceuil";
            this.CmdAcceuil.UseVisualStyleBackColor = true;
            this.CmdAcceuil.Click += new System.EventHandler(this.CmdAcceuil_Click);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.ForeColor = System.Drawing.Color.Red;
            this.CmdAdmin.Location = new System.Drawing.Point(606, 374);
            this.CmdAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(95, 50);
            this.CmdAdmin.TabIndex = 10;
            this.CmdAdmin.Text = "Mode admin";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            // 
            // comboBoxLigne
            // 
            this.comboBoxLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLigne.FormattingEnabled = true;
            this.comboBoxLigne.Items.AddRange(new object[] {
            "Ligne 24",
            "Ligne 39",
            "Ligne 65"});
            this.comboBoxLigne.Location = new System.Drawing.Point(21, 28);
            this.comboBoxLigne.Name = "comboBoxLigne";
            this.comboBoxLigne.Size = new System.Drawing.Size(121, 20);
            this.comboBoxLigne.TabIndex = 16;
            // 
            // cmdButtonValider
            // 
            this.cmdButtonValider.Location = new System.Drawing.Point(160, 27);
            this.cmdButtonValider.Name = "cmdButtonValider";
            this.cmdButtonValider.Size = new System.Drawing.Size(75, 23);
            this.cmdButtonValider.TabIndex = 17;
            this.cmdButtonValider.Text = "Valider";
            this.cmdButtonValider.UseVisualStyleBackColor = true;
            this.cmdButtonValider.Click += new System.EventHandler(this.cmdButtonValider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAE2._1_Dev_Dune_APP.Properties.Resources._65;
            this.pictureBox1.Location = new System.Drawing.Point(15, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHoraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdButtonValider);
            this.Controls.Add(this.comboBoxLigne);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.CmdAcceuil);
            this.Controls.Add(this.CmdAdmin);
            this.Name = "FrmHoraire";
            this.Text = "Autobus Levis- Horaire des lignes";
            this.Load += new System.EventHandler(this.FrmHoraire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdRechercheItineraire;
        private System.Windows.Forms.Button CmdHoraireLigne;
        private System.Windows.Forms.Button CmdCarteLigne;
        private System.Windows.Forms.Button CmdAcceuil;
        private System.Windows.Forms.Button CmdAdmin;
        private System.Windows.Forms.ComboBox comboBoxLigne;
        private System.Windows.Forms.Button cmdButtonValider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}