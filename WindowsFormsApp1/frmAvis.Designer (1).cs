namespace avis

{
    partial class frmA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmA));
            this.cboChoix = new System.Windows.Forms.ComboBox();
            this.txtAvis = new System.Windows.Forms.TextBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.lblRecette = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblAvis = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pibCass1 = new System.Windows.Forms.PictureBox();
            this.pibCass5 = new System.Windows.Forms.PictureBox();
            this.pibCass4 = new System.Windows.Forms.PictureBox();
            this.pibCass3 = new System.Windows.Forms.PictureBox();
            this.pibCass2 = new System.Windows.Forms.PictureBox();
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pibCass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass2)).BeginInit();
            this.grpNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChoix
            // 
            this.cboChoix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChoix.FormattingEnabled = true;
            this.cboChoix.Location = new System.Drawing.Point(302, 54);
            this.cboChoix.Margin = new System.Windows.Forms.Padding(5);
            this.cboChoix.Name = "cboChoix";
            this.cboChoix.Size = new System.Drawing.Size(358, 28);
            this.cboChoix.TabIndex = 0;
            // 
            // txtAvis
            // 
            this.txtAvis.Location = new System.Drawing.Point(87, 176);
            this.txtAvis.Margin = new System.Windows.Forms.Padding(5);
            this.txtAvis.Multiline = true;
            this.txtAvis.Name = "txtAvis";
            this.txtAvis.Size = new System.Drawing.Size(469, 174);
            this.txtAvis.TabIndex = 1;
            // 
            // txtPseudo
            // 
            this.txtPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPseudo.Location = new System.Drawing.Point(102, 122);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(5);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(197, 26);
            this.txtPseudo.TabIndex = 2;
            this.txtPseudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPseudo_KeyPress);
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.BackColor = System.Drawing.Color.Transparent;
            this.lblRecette.ForeColor = System.Drawing.Color.Red;
            this.lblRecette.Location = new System.Drawing.Point(23, 62);
            this.lblRecette.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(269, 20);
            this.lblRecette.TabIndex = 3;
            this.lblRecette.Text = "Quel recette voulez-vous noter ?";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.BackColor = System.Drawing.Color.Transparent;
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.Color.Red;
            this.lblPseudo.Location = new System.Drawing.Point(23, 125);
            this.lblPseudo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(69, 20);
            this.lblPseudo.TabIndex = 4;
            this.lblPseudo.Text = "Pseudo";
            // 
            // lblAvis
            // 
            this.lblAvis.AutoSize = true;
            this.lblAvis.BackColor = System.Drawing.Color.Transparent;
            this.lblAvis.ForeColor = System.Drawing.Color.Red;
            this.lblAvis.Location = new System.Drawing.Point(23, 177);
            this.lblAvis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAvis.Name = "lblAvis";
            this.lblAvis.Size = new System.Drawing.Size(42, 20);
            this.lblAvis.TabIndex = 5;
            this.lblAvis.Text = "Avis";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ForeColor = System.Drawing.Color.Red;
            this.btnAnnuler.Location = new System.Drawing.Point(685, 368);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(104, 35);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Red;
            this.btnEnregistrer.Location = new System.Drawing.Point(685, 428);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 35);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregister";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // pibCass1
            // 
            this.pibCass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCass1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibCass1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pibCass1.InitialImage")));
            this.pibCass1.Location = new System.Drawing.Point(20, 39);
            this.pibCass1.Name = "pibCass1";
            this.pibCass1.Size = new System.Drawing.Size(65, 55);
            this.pibCass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCass1.TabIndex = 9;
            this.pibCass1.TabStop = false;
            this.pibCass1.Tag = "1";
            this.pibCass1.Click += new System.EventHandler(this.pibCass1_Click);
            // 
            // pibCass5
            // 
            this.pibCass5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCass5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibCass5.Location = new System.Drawing.Point(321, 39);
            this.pibCass5.Name = "pibCass5";
            this.pibCass5.Size = new System.Drawing.Size(60, 55);
            this.pibCass5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCass5.TabIndex = 10;
            this.pibCass5.TabStop = false;
            this.pibCass5.Tag = "5";
            this.pibCass5.Click += new System.EventHandler(this.pibCass1_Click);
            // 
            // pibCass4
            // 
            this.pibCass4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCass4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibCass4.Location = new System.Drawing.Point(245, 39);
            this.pibCass4.Name = "pibCass4";
            this.pibCass4.Size = new System.Drawing.Size(60, 55);
            this.pibCass4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCass4.TabIndex = 11;
            this.pibCass4.TabStop = false;
            this.pibCass4.Tag = "4";
            this.pibCass4.Click += new System.EventHandler(this.pibCass1_Click);
            // 
            // pibCass3
            // 
            this.pibCass3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCass3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibCass3.Location = new System.Drawing.Point(166, 39);
            this.pibCass3.Name = "pibCass3";
            this.pibCass3.Size = new System.Drawing.Size(60, 55);
            this.pibCass3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCass3.TabIndex = 12;
            this.pibCass3.TabStop = false;
            this.pibCass3.Tag = "3";
            this.pibCass3.Click += new System.EventHandler(this.pibCass1_Click);
            // 
            // pibCass2
            // 
            this.pibCass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCass2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibCass2.Location = new System.Drawing.Point(91, 39);
            this.pibCass2.Name = "pibCass2";
            this.pibCass2.Size = new System.Drawing.Size(60, 55);
            this.pibCass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCass2.TabIndex = 13;
            this.pibCass2.TabStop = false;
            this.pibCass2.Tag = "2";
            this.pibCass2.Click += new System.EventHandler(this.pibCass1_Click);
            // 
            // grpNote
            // 
            this.grpNote.BackColor = System.Drawing.Color.Transparent;
            this.grpNote.Controls.Add(this.pibCass2);
            this.grpNote.Controls.Add(this.pibCass5);
            this.grpNote.Controls.Add(this.pibCass4);
            this.grpNote.Controls.Add(this.pibCass3);
            this.grpNote.Controls.Add(this.pibCass1);
            this.grpNote.ForeColor = System.Drawing.Color.Red;
            this.grpNote.Location = new System.Drawing.Point(87, 363);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(411, 100);
            this.grpNote.TabIndex = 14;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Note";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(577, 90);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(310, 258);
            this.dataGrid1.TabIndex = 15;
            this.dataGrid1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ajouterFarine.jpg");
            this.imageList1.Images.SetKeyName(1, "alarm-clock_icon-icons.com_64799.png");
            this.imageList1.Images.SetKeyName(2, "ampoule.png");
            this.imageList1.Images.SetKeyName(3, "assietteSpaghetti.jpg");
            this.imageList1.Images.SetKeyName(4, "banane.jpg");
            this.imageList1.Images.SetKeyName(5, "batteur.jpg");
            this.imageList1.Images.SetKeyName(6, "battreBlancs.jpg");
            this.imageList1.Images.SetKeyName(7, "bechamel.jpg");
            this.imageList1.Images.SetKeyName(8, "beignetsCourgette.jpg");
            this.imageList1.Images.SetKeyName(9, "beurre.jpg");
            this.imageList1.Images.SetKeyName(10, "biscuitsCuiller.jpg");
            this.imageList1.Images.SetKeyName(11, "blancJaune.jpg");
            this.imageList1.Images.SetKeyName(12, "button_blue_ffw.png");
            this.imageList1.Images.SetKeyName(13, "button_blue_first.png");
            this.imageList1.Images.SetKeyName(14, "button_blue_last.png");
            this.imageList1.Images.SetKeyName(15, "button_blue_rew.png");
            this.imageList1.Images.SetKeyName(16, "cabillaud.jpg");
            this.imageList1.Images.SetKeyName(17, "ceviche.jpg");
            this.imageList1.Images.SetKeyName(18, "ceviche1.jpg");
            this.imageList1.Images.SetKeyName(19, "citronVert.jpg");
            this.imageList1.Images.SetKeyName(20, "cocotte.jpg");
            this.imageList1.Images.SetKeyName(21, "courgette2.jpg");
            this.imageList1.Images.SetKeyName(22, "courgettes1.jpg");
            this.imageList1.Images.SetKeyName(23, "cuire1.jpg");
            this.imageList1.Images.SetKeyName(24, "cuisine-fun-ludique.jpg");
            this.imageList1.Images.SetKeyName(25, "cuissonCocotte.jpg");
            this.imageList1.Images.SetKeyName(26, "curry.jpg");
            this.imageList1.Images.SetKeyName(27, "curryAgneau.jpg");
            this.imageList1.Images.SetKeyName(28, "decor2.jpg");
            this.imageList1.Images.SetKeyName(29, "etaler.jpg");
            this.imageList1.Images.SetKeyName(30, "etaler1.jpg");
            this.imageList1.Images.SetKeyName(31, "Euro.png");
            this.imageList1.Images.SetKeyName(32, "farine.png");
            this.imageList1.Images.SetKeyName(33, "fondantChoc.jpg");
            this.imageList1.Images.SetKeyName(34, "fondBois.jpg");
            this.imageList1.Images.SetKeyName(35, "fondreChoc.jpg");
            this.imageList1.Images.SetKeyName(36, "four.jpg");
            this.imageList1.Images.SetKeyName(37, "huileOlive.jpg");
            this.imageList1.Images.SetKeyName(38, "lait.jpg");
            this.imageList1.Images.SetKeyName(39, "lama.png");
            this.imageList1.Images.SetKeyName(40, "miel.jpg");
            this.imageList1.Images.SetKeyName(41, "minuteur.jpg");
            this.imageList1.Images.SetKeyName(42, "mixer.jpg");
            this.imageList1.Images.SetKeyName(43, "mouleCake.jpg");
            this.imageList1.Images.SetKeyName(44, "nougat2.jpg");
            this.imageList1.Images.SetKeyName(45, "nougatGlace.jpg");
            this.imageList1.Images.SetKeyName(46, "oeufs1.jpg");
            this.imageList1.Images.SetKeyName(47, "oignons.jpg");
            this.imageList1.Images.SetKeyName(48, "oignonsEminces.jpg");
            this.imageList1.Images.SetKeyName(49, "patateDouce.jpg");
            this.imageList1.Images.SetKeyName(50, "pateBrisee.jpg");
            this.imageList1.Images.SetKeyName(51, "patesCourgette.jpg");
            this.imageList1.Images.SetKeyName(52, "piment.jpg");
            this.imageList1.Images.SetKeyName(53, "pistache.jpg");
            this.imageList1.Images.SetKeyName(54, "pistache.jpg.jpeg");
            this.imageList1.Images.SetKeyName(55, "poissonCube.jpg");
            this.imageList1.Images.SetKeyName(56, "pouletAnanas.jpg");
            this.imageList1.Images.SetKeyName(57, "pruneaux.jpg");
            this.imageList1.Images.SetKeyName(58, "quicheCourgettes.jpg");
            this.imageList1.Images.SetKeyName(59, "risottoJaune.jpg");
            this.imageList1.Images.SetKeyName(60, "selPoivre.jpg");
            this.imageList1.Images.SetKeyName(61, "soupeCourgettes.jpg");
            this.imageList1.Images.SetKeyName(62, "soupeTruffe.jpg");
            this.imageList1.Images.SetKeyName(63, "spaghetti.jpg");
            this.imageList1.Images.SetKeyName(64, "tagliatellesCrevettes.jpg");
            this.imageList1.Images.SetKeyName(65, "TajineEtape5.jpg");
            this.imageList1.Images.SetKeyName(66, "TajineEtape7.jpg");
            this.imageList1.Images.SetKeyName(67, "tajinePruneaux.jpg");
            this.imageList1.Images.SetKeyName(68, "tianLegumes.jpg");
            this.imageList1.Images.SetKeyName(69, "tiramisu.jpg");
            this.imageList1.Images.SetKeyName(70, "tiramisu1.jpg");
            this.imageList1.Images.SetKeyName(71, "tiramisu2.jpg");
            this.imageList1.Images.SetKeyName(72, "vacheQuiRit1.jpg");
            this.imageList1.Images.SetKeyName(73, "voirLoupe.jpg");
            // 
            // frmA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cuisine_fun_ludiqueflou;
            this.ClientSize = new System.Drawing.Size(912, 477);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.grpNote);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblAvis);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblRecette);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.txtAvis);
            this.Controls.Add(this.cboChoix);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(928, 516);
            this.MinimumSize = new System.Drawing.Size(928, 516);
            this.Name = "frmA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notez vos recettes";
            this.Load += new System.EventHandler(this.frmAvis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibCass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCass2)).EndInit();
            this.grpNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChoix;
        private System.Windows.Forms.TextBox txtAvis;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblAvis;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.PictureBox pibCass1;
        private System.Windows.Forms.PictureBox pibCass5;
        private System.Windows.Forms.PictureBox pibCass4;
        private System.Windows.Forms.PictureBox pibCass3;
        private System.Windows.Forms.PictureBox pibCass2;
        private System.Windows.Forms.GroupBox grpNote;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

