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
            this.listBox_contenutable = new System.Windows.Forms.ListBox();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupr = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.lbl_admin1 = new System.Windows.Forms.Label();
            this.txt_admin1 = new System.Windows.Forms.TextBox();
            this.lbl_admin2 = new System.Windows.Forms.Label();
            this.lbl_admin3 = new System.Windows.Forms.Label();
            this.txt_admin2 = new System.Windows.Forms.TextBox();
            this.lbl_admin4 = new System.Windows.Forms.Label();
            this.cmdButtonSQLValide = new System.Windows.Forms.Button();
            this.lbl_admin5 = new System.Windows.Forms.Label();
            this.lbl_nomtable = new System.Windows.Forms.Label();
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
            // listBox_contenutable
            // 
            this.listBox_contenutable.FormattingEnabled = true;
            this.listBox_contenutable.ItemHeight = 20;
            this.listBox_contenutable.Location = new System.Drawing.Point(333, 68);
            this.listBox_contenutable.Name = "listBox_contenutable";
            this.listBox_contenutable.Size = new System.Drawing.Size(716, 304);
            this.listBox_contenutable.TabIndex = 15;
            // 
            // cbxTable
            // 
            this.cbxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Items.AddRange(new object[] {
            "Ligne",
            "Arret",
            "Passage",
            "Horaire",
            "Image"});
            this.cbxTable.Location = new System.Drawing.Point(14, 40);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(186, 28);
            this.cbxTable.TabIndex = 16;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Enabled = false;
            this.cmdAjouter.Location = new System.Drawing.Point(14, 88);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(286, 105);
            this.cmdAjouter.TabIndex = 18;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Enabled = false;
            this.cmdModifier.Location = new System.Drawing.Point(14, 202);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(286, 105);
            this.cmdModifier.TabIndex = 19;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.CmdModifier_Click);
            // 
            // cmdSupr
            // 
            this.cmdSupr.Enabled = false;
            this.cmdSupr.Location = new System.Drawing.Point(14, 313);
            this.cmdSupr.Name = "cmdSupr";
            this.cmdSupr.Size = new System.Drawing.Size(286, 105);
            this.cmdSupr.TabIndex = 20;
            this.cmdSupr.Text = "Supprimer ";
            this.cmdSupr.UseVisualStyleBackColor = true;
            this.cmdSupr.Click += new System.EventHandler(this.CmdSupr_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Location = new System.Drawing.Point(206, 40);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(94, 30);
            this.cmdValider.TabIndex = 21;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // lbl_admin1
            // 
            this.lbl_admin1.AutoSize = true;
            this.lbl_admin1.Location = new System.Drawing.Point(18, 472);
            this.lbl_admin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin1.Name = "lbl_admin1";
            this.lbl_admin1.Size = new System.Drawing.Size(51, 20);
            this.lbl_admin1.TabIndex = 22;
            this.lbl_admin1.Text = "label1";
            this.lbl_admin1.Visible = false;
            // 
            // txt_admin1
            // 
            this.txt_admin1.Location = new System.Drawing.Point(218, 467);
            this.txt_admin1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_admin1.Name = "txt_admin1";
            this.txt_admin1.Size = new System.Drawing.Size(673, 26);
            this.txt_admin1.TabIndex = 23;
            this.txt_admin1.Visible = false;
            this.txt_admin1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // lbl_admin2
            // 
            this.lbl_admin2.AutoSize = true;
            this.lbl_admin2.Location = new System.Drawing.Point(956, 472);
            this.lbl_admin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin2.Name = "lbl_admin2";
            this.lbl_admin2.Size = new System.Drawing.Size(51, 20);
            this.lbl_admin2.TabIndex = 24;
            this.lbl_admin2.Text = "label2";
            this.lbl_admin2.Visible = false;
            // 
            // lbl_admin3
            // 
            this.lbl_admin3.AutoSize = true;
            this.lbl_admin3.Location = new System.Drawing.Point(10, 545);
            this.lbl_admin3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin3.Name = "lbl_admin3";
            this.lbl_admin3.Size = new System.Drawing.Size(51, 20);
            this.lbl_admin3.TabIndex = 25;
            this.lbl_admin3.Text = "label3";
            this.lbl_admin3.Visible = false;
            // 
            // txt_admin2
            // 
            this.txt_admin2.Location = new System.Drawing.Point(111, 540);
            this.txt_admin2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_admin2.Name = "txt_admin2";
            this.txt_admin2.Size = new System.Drawing.Size(748, 26);
            this.txt_admin2.TabIndex = 27;
            this.txt_admin2.Visible = false;
            this.txt_admin2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // lbl_admin4
            // 
            this.lbl_admin4.AutoSize = true;
            this.lbl_admin4.Location = new System.Drawing.Point(330, 398);
            this.lbl_admin4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin4.Name = "lbl_admin4";
            this.lbl_admin4.Size = new System.Drawing.Size(51, 20);
            this.lbl_admin4.TabIndex = 28;
            this.lbl_admin4.Text = "label4";
            this.lbl_admin4.Visible = false;
            // 
            // cmdButtonSQLValide
            // 
            this.cmdButtonSQLValide.Location = new System.Drawing.Point(909, 530);
            this.cmdButtonSQLValide.Name = "cmdButtonSQLValide";
            this.cmdButtonSQLValide.Size = new System.Drawing.Size(123, 65);
            this.cmdButtonSQLValide.TabIndex = 29;
            this.cmdButtonSQLValide.Text = "Valider";
            this.cmdButtonSQLValide.UseVisualStyleBackColor = true;
            this.cmdButtonSQLValide.Click += new System.EventHandler(this.cmdButtonSQLValide_Click);
            // 
            // lbl_admin5
            // 
            this.lbl_admin5.AutoSize = true;
            this.lbl_admin5.Location = new System.Drawing.Point(870, 552);
            this.lbl_admin5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin5.Name = "lbl_admin5";
            this.lbl_admin5.Size = new System.Drawing.Size(51, 20);
            this.lbl_admin5.TabIndex = 30;
            this.lbl_admin5.Text = "label5";
            this.lbl_admin5.Visible = false;
            // 
            // lbl_nomtable
            // 
            this.lbl_nomtable.AutoSize = true;
            this.lbl_nomtable.Location = new System.Drawing.Point(333, 42);
            this.lbl_nomtable.Name = "lbl_nomtable";
            this.lbl_nomtable.Size = new System.Drawing.Size(51, 20);
            this.lbl_nomtable.TabIndex = 31;
            this.lbl_nomtable.Text = "label6";
            this.lbl_nomtable.Visible = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 708);
            this.Controls.Add(this.lbl_nomtable);
            this.Controls.Add(this.lbl_admin5);
            this.Controls.Add(this.cmdButtonSQLValide);
            this.Controls.Add(this.lbl_admin4);
            this.Controls.Add(this.txt_admin2);
            this.Controls.Add(this.lbl_admin3);
            this.Controls.Add(this.lbl_admin2);
            this.Controls.Add(this.txt_admin1);
            this.Controls.Add(this.lbl_admin1);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.cmdSupr);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cbxTable);
            this.Controls.Add(this.listBox_contenutable);
            this.Controls.Add(this.CmdRechercheItineraire);
            this.Controls.Add(this.CmdHoraireLigne);
            this.Controls.Add(this.CmdCarteLigne);
            this.Controls.Add(this.cmdAcceuil);
            this.Controls.Add(this.CmdAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ListBox listBox_contenutable;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupr;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lbl_admin1;
        private System.Windows.Forms.TextBox txt_admin1;
        private System.Windows.Forms.Label lbl_admin2;
        private System.Windows.Forms.Label lbl_admin3;
        private System.Windows.Forms.TextBox txt_admin2;
        private System.Windows.Forms.Label lbl_admin4;
        private System.Windows.Forms.Button cmdButtonSQLValide;
        private System.Windows.Forms.Label lbl_admin5;
        private System.Windows.Forms.Label lbl_nomtable;
    }
}