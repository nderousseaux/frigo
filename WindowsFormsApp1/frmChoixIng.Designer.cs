namespace WindowsFormsApp1
{
    partial class frmAccueil
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
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.grpChoix = new System.Windows.Forms.GroupBox();
            this.grpRecap = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.BackColor = System.Drawing.Color.Transparent;
            this.grpSelect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelect.ForeColor = System.Drawing.Color.Red;
            this.grpSelect.Location = new System.Drawing.Point(24, 12);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(291, 561);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Familles d\'ingrédients";
            // 
            // grpChoix
            // 
            this.grpChoix.BackColor = System.Drawing.Color.Transparent;
            this.grpChoix.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpChoix.Location = new System.Drawing.Point(341, 12);
            this.grpChoix.Name = "grpChoix";
            this.grpChoix.Size = new System.Drawing.Size(549, 317);
            this.grpChoix.TabIndex = 1;
            this.grpChoix.TabStop = false;
            this.grpChoix.Visible = false;
            // 
            // grpRecap
            // 
            this.grpRecap.BackColor = System.Drawing.Color.Transparent;
            this.grpRecap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecap.ForeColor = System.Drawing.Color.Red;
            this.grpRecap.Location = new System.Drawing.Point(342, 335);
            this.grpRecap.Name = "grpRecap";
            this.grpRecap.Size = new System.Drawing.Size(548, 182);
            this.grpRecap.TabIndex = 2;
            this.grpRecap.TabStop = false;
            this.grpRecap.Text = "Vous avez choisi : ";
            this.grpRecap.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.button_blue_last;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(839, 523);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNote
            // 
            this.btnNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.Location = new System.Drawing.Point(341, 522);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(116, 50);
            this.btnNote.TabIndex = 4;
            this.btnNote.Text = "Noter une recette";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cuisine_fun_ludiqueflou;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 596);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpRecap);
            this.Controls.Add(this.grpChoix);
            this.Controls.Add(this.grpSelect);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(918, 575);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qu\'est-ce qu\'on mange ce soir ?";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.GroupBox grpChoix;
        private System.Windows.Forms.GroupBox grpRecap;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNote;
    }
}

