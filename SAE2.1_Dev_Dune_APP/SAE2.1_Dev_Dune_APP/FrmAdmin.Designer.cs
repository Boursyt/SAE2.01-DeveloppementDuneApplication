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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdButtonSQLValide = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdRechercheItineraire
            // 
            this.CmdRechercheItineraire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRechercheItineraire.Location = new System.Drawing.Point(160, 366);
            this.CmdRechercheItineraire.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CmdRechercheItineraire.Name = "CmdRechercheItineraire";
            this.CmdRechercheItineraire.Size = new System.Drawing.Size(124, 49);
            this.CmdRechercheItineraire.TabIndex = 14;
            this.CmdRechercheItineraire.Text = "Recherche d\'itinéraire";
            this.CmdRechercheItineraire.UseVisualStyleBackColor = true;
            this.CmdRechercheItineraire.Click += new System.EventHandler(this.CmdRechercheItineraire_Click);
            // 
            // CmdHoraireLigne
            // 
            this.CmdHoraireLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHoraireLigne.Location = new System.Drawing.Point(312, 366);
            this.CmdHoraireLigne.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CmdHoraireLigne.Name = "CmdHoraireLigne";
            this.CmdHoraireLigne.Size = new System.Drawing.Size(124, 49);
            this.CmdHoraireLigne.TabIndex = 13;
            this.CmdHoraireLigne.Text = "Horaire des Lignes";
            this.CmdHoraireLigne.UseVisualStyleBackColor = true;
            this.CmdHoraireLigne.Click += new System.EventHandler(this.CmdHoraireLigne_Click);
            // 
            // CmdCarteLigne
            // 
            this.CmdCarteLigne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCarteLigne.Location = new System.Drawing.Point(464, 366);
            this.CmdCarteLigne.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CmdCarteLigne.Name = "CmdCarteLigne";
            this.CmdCarteLigne.Size = new System.Drawing.Size(124, 49);
            this.CmdCarteLigne.TabIndex = 12;
            this.CmdCarteLigne.Text = "Carte par ligne";
            this.CmdCarteLigne.UseVisualStyleBackColor = true;
            this.CmdCarteLigne.Click += new System.EventHandler(this.CmdCarteLigne_Click);
            // 
            // cmdAcceuil
            // 
            this.cmdAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAcceuil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAcceuil.Location = new System.Drawing.Point(9, 366);
            this.cmdAcceuil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmdAcceuil.Name = "cmdAcceuil";
            this.cmdAcceuil.Size = new System.Drawing.Size(124, 49);
            this.cmdAcceuil.TabIndex = 11;
            this.cmdAcceuil.Text = "Acceuil";
            this.cmdAcceuil.UseVisualStyleBackColor = true;
            this.cmdAcceuil.Click += new System.EventHandler(this.cmdAcceuil_Click);
            // 
            // CmdAdmin
            // 
            this.CmdAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmin.ForeColor = System.Drawing.Color.Red;
            this.CmdAdmin.Location = new System.Drawing.Point(606, 366);
            this.CmdAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CmdAdmin.Name = "CmdAdmin";
            this.CmdAdmin.Size = new System.Drawing.Size(95, 49);
            this.CmdAdmin.TabIndex = 10;
            this.CmdAdmin.Text = "Mode admin";
            this.CmdAdmin.UseVisualStyleBackColor = true;
            this.CmdAdmin.Click += new System.EventHandler(this.CmdAdmin_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(222, 41);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(479, 184);
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
            this.cbxTable.Location = new System.Drawing.Point(9, 24);
            this.cbxTable.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(125, 20);
            this.cbxTable.TabIndex = 16;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Enabled = false;
            this.cmdAjouter.Location = new System.Drawing.Point(9, 53);
            this.cmdAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(191, 63);
            this.cmdAjouter.TabIndex = 18;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Enabled = false;
            this.cmdModifier.Location = new System.Drawing.Point(9, 121);
            this.cmdModifier.Margin = new System.Windows.Forms.Padding(2);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(191, 63);
            this.cmdModifier.TabIndex = 19;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.CmdModifier_Click);
            // 
            // cmdSupr
            // 
            this.cmdSupr.Enabled = false;
            this.cmdSupr.Location = new System.Drawing.Point(9, 188);
            this.cmdSupr.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSupr.Name = "cmdSupr";
            this.cmdSupr.Size = new System.Drawing.Size(191, 63);
            this.cmdSupr.TabIndex = 20;
            this.cmdSupr.Text = "Supprimer ";
            this.cmdSupr.UseVisualStyleBackColor = true;
            this.cmdSupr.Click += new System.EventHandler(this.CmdSupr_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Location = new System.Drawing.Point(137, 24);
            this.cmdValider.Margin = new System.Windows.Forms.Padding(2);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(63, 18);
            this.cmdValider.TabIndex = 21;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 21);
            this.textBox1.TabIndex = 23;
            this.textBox1.Visible = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 21);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // cmdButtonSQLValide
            // 
            this.cmdButtonSQLValide.Location = new System.Drawing.Point(606, 318);
            this.cmdButtonSQLValide.Margin = new System.Windows.Forms.Padding(2);
            this.cmdButtonSQLValide.Name = "cmdButtonSQLValide";
            this.cmdButtonSQLValide.Size = new System.Drawing.Size(82, 39);
            this.cmdButtonSQLValide.TabIndex = 29;
            this.cmdButtonSQLValide.Text = "Valider";
            this.cmdButtonSQLValide.UseVisualStyleBackColor = true;
            this.cmdButtonSQLValide.Click += new System.EventHandler(this.cmdButtonSQLValide_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdButtonSQLValide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobus Levis - Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdButtonSQLValide;
        private System.Windows.Forms.Label label5;
    }
}