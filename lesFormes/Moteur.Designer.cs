namespace lesFormes
{
    partial class Moteur
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
            this.nbCotes = new System.Windows.Forms.ComboBox();
            this.nbCotesParallele = new System.Windows.Forms.ComboBox();
            this.nbCotesLongueur = new System.Windows.Forms.ComboBox();
            this.nbAnglesDroit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.resultRech = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nbCotes
            // 
            this.nbCotes.FormattingEnabled = true;
            this.nbCotes.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.nbCotes.Location = new System.Drawing.Point(27, 59);
            this.nbCotes.Name = "nbCotes";
            this.nbCotes.Size = new System.Drawing.Size(251, 24);
            this.nbCotes.TabIndex = 0;
            this.nbCotes.SelectedIndexChanged += new System.EventHandler(this.nbCotes_SelectedIndexChanged);
            // 
            // nbCotesParallele
            // 
            this.nbCotesParallele.FormattingEnabled = true;
            this.nbCotesParallele.Items.AddRange(new object[] {
            "0",
            "2",
            "4"});
            this.nbCotesParallele.Location = new System.Drawing.Point(27, 303);
            this.nbCotesParallele.Name = "nbCotesParallele";
            this.nbCotesParallele.Size = new System.Drawing.Size(251, 24);
            this.nbCotesParallele.TabIndex = 1;
            this.nbCotesParallele.SelectedIndexChanged += new System.EventHandler(this.nbCotesParallele_SelectedIndexChanged);
            // 
            // nbCotesLongueur
            // 
            this.nbCotesLongueur.FormattingEnabled = true;
            this.nbCotesLongueur.Items.AddRange(new object[] {
            "0",
            "2",
            "3",
            "4",
            "5"});
            this.nbCotesLongueur.Location = new System.Drawing.Point(27, 216);
            this.nbCotesLongueur.Name = "nbCotesLongueur";
            this.nbCotesLongueur.Size = new System.Drawing.Size(251, 24);
            this.nbCotesLongueur.TabIndex = 2;
            this.nbCotesLongueur.SelectedIndexChanged += new System.EventHandler(this.nbCotesLongueur_SelectedIndexChanged);
            // 
            // nbAnglesDroit
            // 
            this.nbAnglesDroit.FormattingEnabled = true;
            this.nbAnglesDroit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.nbAnglesDroit.Location = new System.Drawing.Point(27, 137);
            this.nbAnglesDroit.Name = "nbAnglesDroit";
            this.nbAnglesDroit.Size = new System.Drawing.Size(251, 24);
            this.nbAnglesDroit.TabIndex = 3;
            this.nbAnglesDroit.SelectedIndexChanged += new System.EventHandler(this.nbAnglesDroit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de côtés";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre d\'angles droits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de côtés de même taille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de côtés parallèles";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(332, 180);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(124, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // resultRech
            // 
            this.resultRech.AutoSize = true;
            this.resultRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultRech.Location = new System.Drawing.Point(529, 180);
            this.resultRech.Name = "resultRech";
            this.resultRech.Size = new System.Drawing.Size(0, 39);
            this.resultRech.TabIndex = 9;
            // 
            // Moteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 410);
            this.Controls.Add(this.resultRech);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbAnglesDroit);
            this.Controls.Add(this.nbCotesLongueur);
            this.Controls.Add(this.nbCotesParallele);
            this.Controls.Add(this.nbCotes);
            this.Name = "Moteur";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Moteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nbCotes;
        private System.Windows.Forms.ComboBox nbCotesParallele;
        private System.Windows.Forms.ComboBox nbCotesLongueur;
        private System.Windows.Forms.ComboBox nbAnglesDroit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label resultRech;
    }
}

