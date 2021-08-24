namespace Form4_recette
{
    partial class frmRec
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
            this.components = new System.ComponentModel.Container();
            this.pnlEtape = new System.Windows.Forms.Panel();
            this.pnlIngr = new System.Windows.Forms.Panel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // pnlEtape
            // 
            this.pnlEtape.AutoScroll = true;
            this.pnlEtape.Location = new System.Drawing.Point(12, 204);
            this.pnlEtape.Name = "pnlEtape";
            this.pnlEtape.Size = new System.Drawing.Size(459, 229);
            this.pnlEtape.TabIndex = 0;
            this.pnlEtape.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlIngr
            // 
            this.pnlIngr.Location = new System.Drawing.Point(491, 204);
            this.pnlIngr.Name = "pnlIngr";
            this.pnlIngr.Size = new System.Drawing.Size(204, 228);
            this.pnlIngr.TabIndex = 1;
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.Red;
            this.btnPdf.Location = new System.Drawing.Point(491, 12);
            this.btnPdf.MaximumSize = new System.Drawing.Size(203, 176);
            this.btnPdf.MinimumSize = new System.Drawing.Size(203, 176);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(203, 176);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Génerer la recette en PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(255, 255);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cuisine_fun_ludiqueflou;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.pnlIngr);
            this.Controls.Add(this.pnlEtape);
            this.Name = "frmRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEtape;
        private System.Windows.Forms.Panel pnlIngr;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ImageList imageList1;
    }
}

