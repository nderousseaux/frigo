namespace typeRecette
{
    partial class frmChoixCui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixCui));
            this.grbPlat = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBudget = new System.Windows.Forms.GroupBox();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.btnPageSuivante = new System.Windows.Forms.Button();
            this.grbTmpCuisson = new System.Windows.Forms.GroupBox();
            this.txtTemps = new System.Windows.Forms.TextBox();
            this.lblTmpCuisson = new System.Windows.Forms.Label();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.grpBudget.SuspendLayout();
            this.grbTmpCuisson.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlat
            // 
            this.grbPlat.BackColor = System.Drawing.Color.Transparent;
            this.grbPlat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPlat.ForeColor = System.Drawing.Color.Red;
            this.grbPlat.Location = new System.Drawing.Point(59, 34);
            this.grbPlat.Name = "grbPlat";
            this.grbPlat.Size = new System.Drawing.Size(649, 150);
            this.grbPlat.TabIndex = 0;
            this.grbPlat.TabStop = false;
            this.grbPlat.Text = "Type de plat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temps de cuisson voulut ? (en minute)";
            // 
            // grpBudget
            // 
            this.grpBudget.BackColor = System.Drawing.Color.Transparent;
            this.grpBudget.Controls.Add(this.radioButton14);
            this.grpBudget.Controls.Add(this.radioButton13);
            this.grpBudget.Controls.Add(this.radioButton12);
            this.grpBudget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBudget.ForeColor = System.Drawing.Color.Red;
            this.grpBudget.Location = new System.Drawing.Point(59, 190);
            this.grpBudget.Name = "grpBudget";
            this.grpBudget.Size = new System.Drawing.Size(649, 84);
            this.grpBudget.TabIndex = 1;
            this.grpBudget.TabStop = false;
            this.grpBudget.Text = "Budget";
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(444, 33);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(112, 23);
            this.radioButton14.TabIndex = 2;
            this.radioButton14.Tag = "3";
            this.radioButton14.Text = "Assez cher";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(223, 33);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(120, 23);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.Tag = "2";
            this.radioButton13.Text = "Coût moyen";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 33);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(120, 23);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.Tag = "1";
            this.radioButton12.Text = "Bon marché";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // btnPageSuivante
            // 
            this.btnPageSuivante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPageSuivante.BackgroundImage")));
            this.btnPageSuivante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageSuivante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageSuivante.Location = new System.Drawing.Point(658, 379);
            this.btnPageSuivante.Name = "btnPageSuivante";
            this.btnPageSuivante.Size = new System.Drawing.Size(50, 50);
            this.btnPageSuivante.TabIndex = 3;
            this.btnPageSuivante.UseVisualStyleBackColor = true;
            this.btnPageSuivante.Click += new System.EventHandler(this.btnPageSuivante_Click);
            // 
            // grbTmpCuisson
            // 
            this.grbTmpCuisson.BackColor = System.Drawing.Color.Transparent;
            this.grbTmpCuisson.Controls.Add(this.txtTemps);
            this.grbTmpCuisson.Controls.Add(this.lblTmpCuisson);
            this.grbTmpCuisson.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTmpCuisson.ForeColor = System.Drawing.Color.Red;
            this.grbTmpCuisson.Location = new System.Drawing.Point(59, 289);
            this.grbTmpCuisson.Name = "grbTmpCuisson";
            this.grbTmpCuisson.Size = new System.Drawing.Size(649, 84);
            this.grbTmpCuisson.TabIndex = 4;
            this.grbTmpCuisson.TabStop = false;
            this.grbTmpCuisson.Text = "Temp de cuisson";
            // 
            // txtTemps
            // 
            this.txtTemps.Location = new System.Drawing.Point(338, 37);
            this.txtTemps.Name = "txtTemps";
            this.txtTemps.Size = new System.Drawing.Size(100, 26);
            this.txtTemps.TabIndex = 1;
            this.txtTemps.TextChanged += new System.EventHandler(this.txtTemps_TextChanged);
            this.txtTemps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemps_KeyPress);
            // 
            // lblTmpCuisson
            // 
            this.lblTmpCuisson.AutoSize = true;
            this.lblTmpCuisson.Location = new System.Drawing.Point(38, 37);
            this.lblTmpCuisson.Name = "lblTmpCuisson";
            this.lblTmpCuisson.Size = new System.Drawing.Size(294, 19);
            this.lblTmpCuisson.TabIndex = 0;
            this.lblTmpCuisson.Text = "Quel temps de cuisson voulez vous ?";
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrecedent.BackgroundImage")));
            this.btnPrecedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrecedent.Location = new System.Drawing.Point(59, 379);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(50, 50);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // frmChoixCui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cuisine_fun_ludiqueflou;
            this.ClientSize = new System.Drawing.Size(744, 435);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.grbTmpCuisson);
            this.Controls.Add(this.btnPageSuivante);
            this.Controls.Add(this.grpBudget);
            this.Controls.Add(this.grbPlat);
            this.MaximumSize = new System.Drawing.Size(760, 474);
            this.MinimumSize = new System.Drawing.Size(760, 474);
            this.Name = "frmChoixCui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choix du type de cuisine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBudget.ResumeLayout(false);
            this.grpBudget.PerformLayout();
            this.grbTmpCuisson.ResumeLayout(false);
            this.grbTmpCuisson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlat;
        private System.Windows.Forms.GroupBox grpBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPageSuivante;
        private System.Windows.Forms.GroupBox grbTmpCuisson;
        private System.Windows.Forms.TextBox txtTemps;
        private System.Windows.Forms.Label lblTmpCuisson;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

