namespace AlbumViewer
{
    partial class FormAlbums
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
            this.listAlbums = new System.Windows.Forms.ListView();
            this.albumButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.deleteAlButton = new System.Windows.Forms.Button();
            this.titleAlbums = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // listAlbums
            // 
            this.listAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listAlbums.Location = new System.Drawing.Point(5, 73);
            this.listAlbums.Name = "listAlbums";
            this.listAlbums.Size = new System.Drawing.Size(828, 198);
            this.listAlbums.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listAlbums.TabIndex = 0;
            this.listAlbums.UseCompatibleStateImageBehavior = false;
            this.listAlbums.View = System.Windows.Forms.View.List;
            this.listAlbums.DoubleClick += new System.EventHandler(this.selectAlbum);
            // 
            // albumButton
            // 
            this.albumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.albumButton.Image = global::AlbumViewer.Properties.Resources.accept;
            this.albumButton.Location = new System.Drawing.Point(838, 6);
            this.albumButton.Name = "albumButton";
            this.albumButton.Size = new System.Drawing.Size(64, 64);
            this.albumButton.TabIndex = 1;
            this.albumButton.UseVisualStyleBackColor = true;
            this.albumButton.Click += new System.EventHandler(this.selectAlbum);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.createButton.Image = global::AlbumViewer.Properties.Resources.add;
            this.createButton.Location = new System.Drawing.Point(838, 73);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(64, 64);
            this.createButton.TabIndex = 2;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createAlbum);
            // 
            // renameButton
            // 
            this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.renameButton.Image = global::AlbumViewer.Properties.Resources.rename;
            this.renameButton.Location = new System.Drawing.Point(838, 140);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(64, 64);
            this.renameButton.TabIndex = 3;
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.rename);
            // 
            // deleteAlButton
            // 
            this.deleteAlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.deleteAlButton.Image = global::AlbumViewer.Properties.Resources.delete;
            this.deleteAlButton.Location = new System.Drawing.Point(838, 207);
            this.deleteAlButton.Name = "deleteAlButton";
            this.deleteAlButton.Size = new System.Drawing.Size(64, 64);
            this.deleteAlButton.TabIndex = 4;
            this.deleteAlButton.UseVisualStyleBackColor = true;
            this.deleteAlButton.Click += new System.EventHandler(this.deleteAlbum);
            // 
            // titleAlbums
            // 
            this.titleAlbums.AutoSize = true;
            this.titleAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.titleAlbums.Location = new System.Drawing.Point(327, 12);
            this.titleAlbums.Name = "titleAlbums";
            this.titleAlbums.Size = new System.Drawing.Size(186, 25);
            this.titleAlbums.TabIndex = 5;
            this.titleAlbums.Text = "Liste des albums :";
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 275);
            this.Controls.Add(this.titleAlbums);
            this.Controls.Add(this.deleteAlButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.albumButton);
            this.Controls.Add(this.listAlbums);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAlbums;
        private System.Windows.Forms.Button albumButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button deleteAlButton;
        private System.Windows.Forms.Label titleAlbums;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}