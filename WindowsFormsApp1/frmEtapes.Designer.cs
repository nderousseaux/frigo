namespace FormEtape_Etape
{
    partial class frmEtape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtape));
            this.btnLastFrm = new System.Windows.Forms.Button();
            this.btnLastEt = new System.Windows.Forms.Button();
            this.btnNextEt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEtape = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLastFrm
            // 
            this.btnLastFrm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLastFrm.BackgroundImage")));
            this.btnLastFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLastFrm.Location = new System.Drawing.Point(12, 388);
            this.btnLastFrm.Name = "btnLastFrm";
            this.btnLastFrm.Size = new System.Drawing.Size(50, 50);
            this.btnLastFrm.TabIndex = 1;
            this.btnLastFrm.UseVisualStyleBackColor = true;
            this.btnLastFrm.Click += new System.EventHandler(this.btnLastFrm_Click);
            // 
            // btnLastEt
            // 
            this.btnLastEt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLastEt.BackgroundImage")));
            this.btnLastEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLastEt.Location = new System.Drawing.Point(319, 294);
            this.btnLastEt.Name = "btnLastEt";
            this.btnLastEt.Size = new System.Drawing.Size(50, 50);
            this.btnLastEt.TabIndex = 2;
            this.btnLastEt.UseVisualStyleBackColor = true;
            this.btnLastEt.Click += new System.EventHandler(this.btnLastEt_Click);
            // 
            // btnNextEt
            // 
            this.btnNextEt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextEt.BackgroundImage")));
            this.btnNextEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextEt.Location = new System.Drawing.Point(423, 294);
            this.btnNextEt.Name = "btnNextEt";
            this.btnNextEt.Size = new System.Drawing.Size(50, 50);
            this.btnNextEt.TabIndex = 3;
            this.btnNextEt.UseVisualStyleBackColor = true;
            this.btnNextEt.Click += new System.EventHandler(this.btnNextEt_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(66, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 207);
            this.panel1.TabIndex = 4;
            // 
            // lblEtape
            // 
            this.lblEtape.AutoSize = true;
            this.lblEtape.BackColor = System.Drawing.Color.Transparent;
            this.lblEtape.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtape.ForeColor = System.Drawing.Color.Red;
            this.lblEtape.Location = new System.Drawing.Point(79, 28);
            this.lblEtape.Name = "lblEtape";
            this.lblEtape.Size = new System.Drawing.Size(54, 19);
            this.lblEtape.TabIndex = 0;
            this.lblEtape.Text = "label1";
            // 
            // frmEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cuisine_fun_ludiqueflou;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEtape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNextEt);
            this.Controls.Add(this.btnLastEt);
            this.Controls.Add(this.btnLastFrm);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmEtape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEtape_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLastFrm;
        private System.Windows.Forms.Button btnLastEt;
        private System.Windows.Forms.Button btnNextEt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEtape;
    }
}

