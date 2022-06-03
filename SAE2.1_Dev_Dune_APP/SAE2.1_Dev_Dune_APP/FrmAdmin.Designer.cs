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
            this.button1 = new System.Windows.Forms.Button();
            this.CmdAdmin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CbxTable = new System.Windows.Forms.ComboBox();
            this.CmdAjouter = new System.Windows.Forms.Button();
            this.CmdModifier = new System.Windows.Forms.Button();
            this.CmdSupr = new System.Windows.Forms.Button();
            this.CmdValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercheItineraire.Location = new System.Drawing.Point(213, 488);
            this.CmdRechercheItineraire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdRechercheItineraire.Name = "CmdRechercheItineraire";
            this.CmdRechercheItineraire.Size = new System.Drawing.Size(165, 66);
            this.CmdRechercheItineraire.TabIndex = 14;
            this.CmdRechercheItineraire.Text = "Recherche d\'itinéraire";
            this.CmdRechercheItineraire.UseVisualStyleBackColor = true;
            // 
            // CmdHoraireLigne
            // 
            this.CmdHoraireLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHoraireLigne.Location = new System.Drawing.Point(416, 488);
            this.CmdHoraireLigne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdHoraireLigne.Name = "CmdHoraireLigne";
            this.CmdHoraireLigne.Size = new System.Drawing.Size(165, 66);
            this.CmdHoraireLigne.TabIndex = 13;
            this.CmdHoraireLigne.Text = "Horaire des Lignes";
            this.CmdHoraireLigne.UseVisualStyleBackColor = true;
            // 
            // CmdCarteLigne
            // 
            this.CmdCarteLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarteLigne.Location = new System.Drawing.Point(619, 488);
            this.CmdCarteLigne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdCarteLigne.Name = "CmdCarteLigne";
            this.CmdCarteLigne.Size = new System.Drawing.Size(165, 66);
            this.CmdCarteLigne.TabIndex = 12;
            this.CmdCarteLigne.Text = "Carte par ligne";
            this.CmdCarteLigne.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Acceuil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.ForeColor = System.Drawing.Color.Red;
            this.CmdAdmin.Location = new System.Drawing.Point(808, 488);
            this.CmdAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(126, 66);
            this.CmdAdmin.TabIndex = 10;
            this.CmdAdmin.Text = "Mode admin";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(296, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(638, 404);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CbxTable
            // 
            this.CbxTable.FormattingEnabled = true;
            this.CbxTable.Items.AddRange(new object[] {
            "Ligne",
            "Arret",
            "Passage",
            "Horaire",
            "Image"});
            this.CbxTable.Location = new System.Drawing.Point(12, 32);
            this.CbxTable.Name = "CbxTable";
            this.CbxTable.Size = new System.Drawing.Size(165, 24);
            this.CbxTable.TabIndex = 16;
            // 
            // CmdAjouter
            // 
            this.CmdAjouter.Location = new System.Drawing.Point(12, 71);
            this.CmdAjouter.Name = "CmdAjouter";
            this.CmdAjouter.Size = new System.Drawing.Size(255, 84);
            this.CmdAjouter.TabIndex = 18;
            this.CmdAjouter.Text = "Ajouter";
            this.CmdAjouter.UseVisualStyleBackColor = true;
            // 
            // CmdModifier
            // 
            this.CmdModifier.Location = new System.Drawing.Point(12, 161);
            this.CmdModifier.Name = "CmdModifier";
            this.CmdModifier.Size = new System.Drawing.Size(255, 84);
            this.CmdModifier.TabIndex = 19;
            this.CmdModifier.Text = "Modifier";
            this.CmdModifier.UseVisualStyleBackColor = true;
            // 
            // CmdSupr
            // 
            this.CmdSupr.Location = new System.Drawing.Point(12, 251);
            this.CmdSupr.Name = "CmdSupr";
            this.CmdSupr.Size = new System.Drawing.Size(255, 84);
            this.CmdSupr.TabIndex = 20;
            this.CmdSupr.Text = "Supprimer ";
            this.CmdSupr.UseVisualStyleBackColor = true;
            // 
            // CmdValider
            // 
            this.CmdValider.Location = new System.Drawing.Point(183, 32);
            this.CmdValider.Name = "CmdValider";
            this.CmdValider.Size = new System.Drawing.Size(84, 24);
            this.CmdValider.TabIndex = 21;
            this.CmdValider.Text = "Valider";
            this.CmdValider.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 566);
            this.Controls.Add(this.CmdValider);
            this.Controls.Add(this.CmdSupr);
            this.Controls.Add(this.CmdModifier);
            this.Controls.Add(this.CmdAjouter);
            this.Controls.Add(this.CbxTable);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmdAdmin);
            this.Name = "FrmAdmin";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdRechercheItineraire;
        private System.Windows.Forms.Button CmdHoraireLigne;
        private System.Windows.Forms.Button CmdCarteLigne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CmdAdmin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CbxTable;
        private System.Windows.Forms.Button CmdAjouter;
        private System.Windows.Forms.Button CmdModifier;
        private System.Windows.Forms.Button CmdSupr;
        private System.Windows.Forms.Button CmdValider;
    }
}