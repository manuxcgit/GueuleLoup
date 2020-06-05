namespace GueuleLoup
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tBAngle = new System.Windows.Forms.TextBox();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.bImprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBEpaisseur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBLongueur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBIndex = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tBDiametre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle :";
            // 
            // tBAngle
            // 
            this.tBAngle.Location = new System.Drawing.Point(58, 6);
            this.tBAngle.Name = "tBAngle";
            this.tBAngle.Size = new System.Drawing.Size(35, 20);
            this.tBAngle.TabIndex = 1;
            this.tBAngle.Text = "0";
            this.tBAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBAngle.TextChanged += new System.EventHandler(this.e_tBValeur_TextChanged);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(15, 32);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(640, 325);
            this.pBox.TabIndex = 2;
            this.pBox.TabStop = false;
            this.pBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.e_pBox_MouseClick);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_pBox_MouseClick);
            // 
            // bImprimer
            // 
            this.bImprimer.Location = new System.Drawing.Point(460, 4);
            this.bImprimer.Name = "bImprimer";
            this.bImprimer.Size = new System.Drawing.Size(195, 23);
            this.bImprimer.TabIndex = 3;
            this.bImprimer.Text = "Imprimer";
            this.bImprimer.UseVisualStyleBackColor = true;
            this.bImprimer.Click += new System.EventHandler(this.e_bImprimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Epaisseur :";
            // 
            // tBEpaisseur
            // 
            this.tBEpaisseur.Location = new System.Drawing.Point(182, 6);
            this.tBEpaisseur.Name = "tBEpaisseur";
            this.tBEpaisseur.Size = new System.Drawing.Size(35, 20);
            this.tBEpaisseur.TabIndex = 5;
            this.tBEpaisseur.Text = "2";
            this.tBEpaisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBEpaisseur.TextChanged += new System.EventHandler(this.e_tBValeur_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longueur :";
            // 
            // tBLongueur
            // 
            this.tBLongueur.Location = new System.Drawing.Point(76, 370);
            this.tBLongueur.Name = "tBLongueur";
            this.tBLongueur.Size = new System.Drawing.Size(63, 20);
            this.tBLongueur.TabIndex = 7;
            this.tBLongueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Index :";
            // 
            // tBIndex
            // 
            this.tBIndex.Location = new System.Drawing.Point(253, 370);
            this.tBIndex.Name = "tBIndex";
            this.tBIndex.Size = new System.Drawing.Size(63, 20);
            this.tBIndex.TabIndex = 9;
            this.tBIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diamètre :";
            // 
            // tBDiametre
            // 
            this.tBDiametre.Location = new System.Drawing.Point(301, 6);
            this.tBDiametre.Name = "tBDiametre";
            this.tBDiametre.Size = new System.Drawing.Size(35, 20);
            this.tBDiametre.TabIndex = 11;
            this.tBDiametre.Text = "40";
            this.tBDiametre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBDiametre.TextChanged += new System.EventHandler(this.e_tBValeur_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 404);
            this.Controls.Add(this.tBDiametre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBLongueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBEpaisseur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bImprimer);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.tBAngle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Gueule de Loup";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBAngle;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button bImprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBEpaisseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBLongueur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBIndex;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBDiametre;
    }
}

