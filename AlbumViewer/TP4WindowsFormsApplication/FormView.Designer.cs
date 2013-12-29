namespace AlbumViewer
{
    partial class FormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.titleView = new System.Windows.Forms.Label();
            this.diapoButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.webButton = new System.Windows.Forms.Button();
            this.infoNameL = new System.Windows.Forms.Label();
            this.infoSizeL = new System.Windows.Forms.Label();
            this.infoNameV = new System.Windows.Forms.Label();
            this.infoDateL = new System.Windows.Forms.Label();
            this.infoDateV = new System.Windows.Forms.Label();
            this.infoSizeV = new System.Windows.Forms.Label();
            this.infoAuthorL = new System.Windows.Forms.Label();
            this.infoResolutionL = new System.Windows.Forms.Label();
            this.infoAuthorV = new System.Windows.Forms.Label();
            this.infoResolutionV = new System.Windows.Forms.Label();
            this.exifButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoriesL = new System.Windows.Forms.Label();
            this.rankL = new System.Windows.Forms.Label();
            this.commentField = new System.Windows.Forms.TextBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.rankCombo = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.commentL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleView
            // 
            this.titleView.AutoSize = true;
            this.titleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleView.Location = new System.Drawing.Point(335, 23);
            this.titleView.Name = "titleView";
            this.titleView.Size = new System.Drawing.Size(186, 25);
            this.titleView.TabIndex = 2;
            this.titleView.Text = "Liste des images :";
            // 
            // diapoButton
            // 
            this.diapoButton.AccessibleDescription = "";
            this.diapoButton.AccessibleName = "";
            this.diapoButton.Image = ((System.Drawing.Image)(resources.GetObject("diapoButton.Image")));
            this.diapoButton.Location = new System.Drawing.Point(838, 274);
            this.diapoButton.Name = "diapoButton";
            this.diapoButton.Size = new System.Drawing.Size(64, 64);
            this.diapoButton.TabIndex = 7;
            this.diapoButton.UseVisualStyleBackColor = true;
            this.diapoButton.Click += new System.EventHandler(this.diapo);
            // 
            // infoButton
            // 
            this.infoButton.AccessibleDescription = "";
            this.infoButton.AccessibleName = "";
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.Location = new System.Drawing.Point(838, 408);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(64, 64);
            this.infoButton.TabIndex = 6;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infos);
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleDescription = "";
            this.deleteButton.AccessibleName = "";
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(838, 475);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 64);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.delete);
            // 
            // addButton
            // 
            this.addButton.AccessibleDescription = "";
            this.addButton.AccessibleName = "";
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(838, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 64);
            this.addButton.TabIndex = 4;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.dbAdd);
            // 
            // addFolderButton
            // 
            this.addFolderButton.AccessibleDescription = "";
            this.addFolderButton.AccessibleName = "";
            this.addFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("addFolderButton.Image")));
            this.addFolderButton.Location = new System.Drawing.Point(838, 140);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(64, 64);
            this.addFolderButton.TabIndex = 3;
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.externalAdd);
            // 
            // mainPicture
            // 
            this.mainPicture.Location = new System.Drawing.Point(5, 73);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(828, 466);
            this.mainPicture.TabIndex = 1;
            this.mainPicture.TabStop = false;
            this.mainPicture.Click += new System.EventHandler(this.nextPicture);
            // 
            // webButton
            // 
            this.webButton.AccessibleDescription = "";
            this.webButton.AccessibleName = "";
            this.webButton.Image = ((System.Drawing.Image)(resources.GetObject("webButton.Image")));
            this.webButton.Location = new System.Drawing.Point(838, 341);
            this.webButton.Name = "webButton";
            this.webButton.Size = new System.Drawing.Size(64, 64);
            this.webButton.TabIndex = 8;
            this.webButton.UseVisualStyleBackColor = true;
            // 
            // infoNameL
            // 
            this.infoNameL.AutoSize = true;
            this.infoNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoNameL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoNameL.Location = new System.Drawing.Point(490, 85);
            this.infoNameL.Name = "infoNameL";
            this.infoNameL.Size = new System.Drawing.Size(54, 20);
            this.infoNameL.TabIndex = 11;
            this.infoNameL.Text = "Nom :";
            this.infoNameL.Visible = false;
            // 
            // infoSizeL
            // 
            this.infoSizeL.AutoSize = true;
            this.infoSizeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoSizeL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoSizeL.Location = new System.Drawing.Point(490, 110);
            this.infoSizeL.Name = "infoSizeL";
            this.infoSizeL.Size = new System.Drawing.Size(59, 20);
            this.infoSizeL.TabIndex = 12;
            this.infoSizeL.Text = "Taille :";
            this.infoSizeL.Visible = false;
            // 
            // infoNameV
            // 
            this.infoNameV.AutoSize = true;
            this.infoNameV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoNameV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoNameV.Location = new System.Drawing.Point(600, 85);
            this.infoNameV.Name = "infoNameV";
            this.infoNameV.Size = new System.Drawing.Size(0, 20);
            this.infoNameV.TabIndex = 16;
            // 
            // infoDateL
            // 
            this.infoDateL.AutoSize = true;
            this.infoDateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoDateL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoDateL.Location = new System.Drawing.Point(490, 135);
            this.infoDateL.Name = "infoDateL";
            this.infoDateL.Size = new System.Drawing.Size(55, 20);
            this.infoDateL.TabIndex = 17;
            this.infoDateL.Text = "Date :";
            this.infoDateL.Visible = false;
            // 
            // infoDateV
            // 
            this.infoDateV.AutoSize = true;
            this.infoDateV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoDateV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoDateV.Location = new System.Drawing.Point(600, 135);
            this.infoDateV.Name = "infoDateV";
            this.infoDateV.Size = new System.Drawing.Size(0, 20);
            this.infoDateV.TabIndex = 18;
            this.infoDateV.Visible = false;
            // 
            // infoSizeV
            // 
            this.infoSizeV.AutoSize = true;
            this.infoSizeV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoSizeV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoSizeV.Location = new System.Drawing.Point(600, 110);
            this.infoSizeV.Name = "infoSizeV";
            this.infoSizeV.Size = new System.Drawing.Size(0, 20);
            this.infoSizeV.TabIndex = 19;
            this.infoSizeV.Visible = false;
            // 
            // infoAuthorL
            // 
            this.infoAuthorL.AutoSize = true;
            this.infoAuthorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoAuthorL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoAuthorL.Location = new System.Drawing.Point(490, 160);
            this.infoAuthorL.Name = "infoAuthorL";
            this.infoAuthorL.Size = new System.Drawing.Size(68, 20);
            this.infoAuthorL.TabIndex = 20;
            this.infoAuthorL.Text = "Auteur :";
            this.infoAuthorL.Visible = false;
            // 
            // infoResolutionL
            // 
            this.infoResolutionL.AutoSize = true;
            this.infoResolutionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoResolutionL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoResolutionL.Location = new System.Drawing.Point(490, 185);
            this.infoResolutionL.Name = "infoResolutionL";
            this.infoResolutionL.Size = new System.Drawing.Size(98, 20);
            this.infoResolutionL.TabIndex = 21;
            this.infoResolutionL.Text = "Résolution :";
            this.infoResolutionL.Visible = false;
            // 
            // infoAuthorV
            // 
            this.infoAuthorV.AutoSize = true;
            this.infoAuthorV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoAuthorV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoAuthorV.Location = new System.Drawing.Point(600, 160);
            this.infoAuthorV.Name = "infoAuthorV";
            this.infoAuthorV.Size = new System.Drawing.Size(0, 20);
            this.infoAuthorV.TabIndex = 22;
            this.infoAuthorV.Visible = false;
            // 
            // infoResolutionV
            // 
            this.infoResolutionV.AutoSize = true;
            this.infoResolutionV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoResolutionV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoResolutionV.Location = new System.Drawing.Point(600, 185);
            this.infoResolutionV.Name = "infoResolutionV";
            this.infoResolutionV.Size = new System.Drawing.Size(0, 20);
            this.infoResolutionV.TabIndex = 23;
            this.infoResolutionV.Visible = false;
            // 
            // exifButton
            // 
            this.exifButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.exifButton.Location = new System.Drawing.Point(490, 218);
            this.exifButton.Name = "exifButton";
            this.exifButton.Size = new System.Drawing.Size(98, 23);
            this.exifButton.TabIndex = 26;
            this.exifButton.Text = "Plus (EXIF)";
            this.exifButton.UseVisualStyleBackColor = true;
            this.exifButton.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.AccessibleDescription = "";
            this.saveButton.AccessibleName = "";
            this.saveButton.Image = global::AlbumViewer.Properties.Resources.accept;
            this.saveButton.Location = new System.Drawing.Point(838, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 64);
            this.saveButton.TabIndex = 27;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save);
            // 
            // categoriesL
            // 
            this.categoriesL.AutoSize = true;
            this.categoriesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.categoriesL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoriesL.Location = new System.Drawing.Point(26, 402);
            this.categoriesL.Name = "categoriesL";
            this.categoriesL.Size = new System.Drawing.Size(91, 20);
            this.categoriesL.TabIndex = 28;
            this.categoriesL.Text = "Catégorie :";
            this.categoriesL.Visible = false;
            // 
            // rankL
            // 
            this.rankL.AutoSize = true;
            this.rankL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rankL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rankL.Location = new System.Drawing.Point(26, 428);
            this.rankL.Name = "rankL";
            this.rankL.Size = new System.Drawing.Size(58, 20);
            this.rankL.TabIndex = 29;
            this.rankL.Text = "Rang :";
            this.rankL.Visible = false;
            // 
            // commentField
            // 
            this.commentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.commentField.Location = new System.Drawing.Point(161, 454);
            this.commentField.Name = "commentField";
            this.commentField.Size = new System.Drawing.Size(646, 23);
            this.commentField.TabIndex = 31;
            this.commentField.Visible = false;
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(161, 402);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(646, 21);
            this.categoryCombo.TabIndex = 32;
            this.categoryCombo.Visible = false;
            // 
            // rankCombo
            // 
            this.rankCombo.FormattingEnabled = true;
            this.rankCombo.Location = new System.Drawing.Point(161, 428);
            this.rankCombo.Name = "rankCombo";
            this.rankCombo.Size = new System.Drawing.Size(646, 21);
            this.rankCombo.TabIndex = 33;
            this.rankCombo.Visible = false;
            // 
            // backButton
            // 
            this.backButton.AccessibleDescription = "";
            this.backButton.AccessibleName = "";
            this.backButton.Image = global::AlbumViewer.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(838, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 64);
            this.backButton.TabIndex = 34;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.back);
            // 
            // commentL
            // 
            this.commentL.AutoSize = true;
            this.commentL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.commentL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.commentL.Location = new System.Drawing.Point(26, 454);
            this.commentL.Name = "commentL";
            this.commentL.Size = new System.Drawing.Size(119, 20);
            this.commentL.TabIndex = 35;
            this.commentL.Text = "Commentaire :";
            this.commentL.Visible = false;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.commentL);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rankCombo);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.commentField);
            this.Controls.Add(this.rankL);
            this.Controls.Add(this.categoriesL);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exifButton);
            this.Controls.Add(this.infoResolutionV);
            this.Controls.Add(this.infoAuthorV);
            this.Controls.Add(this.infoResolutionL);
            this.Controls.Add(this.infoAuthorL);
            this.Controls.Add(this.infoSizeV);
            this.Controls.Add(this.infoDateV);
            this.Controls.Add(this.infoDateL);
            this.Controls.Add(this.infoNameV);
            this.Controls.Add(this.infoSizeL);
            this.Controls.Add(this.infoNameL);
            this.Controls.Add(this.webButton);
            this.Controls.Add(this.diapoButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addFolderButton);
            this.Controls.Add(this.titleView);
            this.Controls.Add(this.mainPicture);
            this.Name = "FormView";
            this.Text = "AlbumViewer";
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.Label titleView;
        private System.Windows.Forms.Button addFolderButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button diapoButton;
        private System.Windows.Forms.Button webButton;
        private System.Windows.Forms.Label infoNameL;
        private System.Windows.Forms.Label infoSizeL;
        private System.Windows.Forms.Label infoNameV;
        private System.Windows.Forms.Label infoDateL;
        private System.Windows.Forms.Label infoDateV;
        private System.Windows.Forms.Label infoSizeV;
        private System.Windows.Forms.Label infoAuthorL;
        private System.Windows.Forms.Label infoResolutionL;
        private System.Windows.Forms.Label infoAuthorV;
        private System.Windows.Forms.Label infoResolutionV;
        private System.Windows.Forms.Button exifButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label categoriesL;
        private System.Windows.Forms.Label rankL;
        private System.Windows.Forms.TextBox commentField;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.ComboBox rankCombo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label commentL;
    }
}

