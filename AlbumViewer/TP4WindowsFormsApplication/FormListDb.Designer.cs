namespace AlbumViewer
{
    partial class FormListDb
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
            this.components = new System.ComponentModel.Container();
            this.comboAlbums = new System.Windows.Forms.ComboBox();
            this.listPictures = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAlbums
            // 
            this.comboAlbums.FormattingEnabled = true;
            this.comboAlbums.Location = new System.Drawing.Point(12, 12);
            this.comboAlbums.Name = "comboAlbums";
            this.comboAlbums.Size = new System.Drawing.Size(909, 21);
            this.comboAlbums.TabIndex = 0;
            this.comboAlbums.SelectedValueChanged += new System.EventHandler(this.watchAlbum);
            // 
            // listPictures
            // 
            this.listPictures.LargeImageList = this.imageList1;
            this.listPictures.Location = new System.Drawing.Point(12, 39);
            this.listPictures.Name = "listPictures";
            this.listPictures.Size = new System.Drawing.Size(909, 421);
            this.listPictures.SmallImageList = this.imageList1;
            this.listPictures.TabIndex = 1;
            this.listPictures.TileSize = new System.Drawing.Size(100, 30);
            this.listPictures.UseCompatibleStateImageBehavior = false;
            this.listPictures.View = System.Windows.Forms.View.Tile;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // addDbButton
            // 
            this.addDbButton.Location = new System.Drawing.Point(13, 466);
            this.addDbButton.Name = "addDbButton";
            this.addDbButton.Size = new System.Drawing.Size(908, 23);
            this.addDbButton.TabIndex = 2;
            this.addDbButton.Text = "Ajouter";
            this.addDbButton.UseVisualStyleBackColor = true;
            this.addDbButton.Click += new System.EventHandler(this.selectPictures);
            // 
            // FormListDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 495);
            this.Controls.Add(this.addDbButton);
            this.Controls.Add(this.listPictures);
            this.Controls.Add(this.comboAlbums);
            this.Name = "FormListDb";
            this.Text = "FormListDb";
            this.Load += new System.EventHandler(this.FormListDb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAlbums;
        private System.Windows.Forms.ListView listPictures;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button addDbButton;

    }
}