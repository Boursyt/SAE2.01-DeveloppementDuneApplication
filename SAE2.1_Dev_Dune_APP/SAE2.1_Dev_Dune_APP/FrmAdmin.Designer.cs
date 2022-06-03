namespace CLassLibrairieBDD
{
    partial class FrmAdmin
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
            this.cmdAcceuil = new System.Windows.Forms.Button();
            this.CmdAdmin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupr = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // cmdAcceuil
            // 
            this.cmdAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAcceuil.Location = new System.Drawing.Point(14, 610);
            this.cmdAcceuil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAcceuil.Name = "cmdAcceuil";
            this.cmdAcceuil.Size = new System.Drawing.Size(186, 82);
            this.cmdAcceuil.TabIndex = 11;
            this.cmdAcceuil.Text = "Acceuil";
            this.cmdAcceuil.UseVisualStyleBackColor = true;
            this.cmdAcceuil.Click += new System.EventHandler(this.cmdAcceuil_Click);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(333, 69);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(717, 504);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbxTable
            // 
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Items.AddRange(new object[] {
            "Ligne",
            "Arret",
            "Passage",
            "Horaire",
            "Image"});
            this.cbxTable.Location = new System.Drawing.Point(14, 40);
            this.cbxTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(185, 28);
            this.cbxTable.TabIndex = 16;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(14, 89);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(287, 105);
            this.cmdAjouter.TabIndex = 18;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(14, 201);
            this.cmdModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(287, 105);
            this.cmdModifier.TabIndex = 19;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            // 
            // cmdSupr
            // 
            this.cmdSupr.Location = new System.Drawing.Point(14, 314);
            this.cmdSupr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSupr.Name = "cmdSupr";
            this.cmdSupr.Size = new System.Drawing.Size(287, 105);
            this.cmdSupr.TabIndex = 20;
            this.cmdSupr.Text = "Supprimer ";
            this.cmdSupr.UseVisualStyleBackColor = true;
            // 
            // cmdValider
            // 
            this.cmdValider.Location = new System.Drawing.Point(206, 40);
            this.cmdValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(94, 30);
            this.cmdValider.TabIndex = 21;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 708);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.cmdSupr);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cbxTable);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.cmdAcceuil);
            this.Controls.Add(this.CmdAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobus Levis - Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdRechercheItineraire;
        private System.Windows.Forms.Button CmdHoraireLigne;
        private System.Windows.Forms.Button CmdCarteLigne;
        private System.Windows.Forms.Button cmdAcceuil;
        private System.Windows.Forms.Button CmdAdmin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupr;
        private System.Windows.Forms.Button cmdValider;
    }
}