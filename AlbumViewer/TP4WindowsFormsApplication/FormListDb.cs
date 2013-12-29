using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlbumViewer
{
    // Class to display all picture of one album to add some pictures

    public partial class FormListDb : Form
    {
        String dbPath;
        List<Picture> pictures;

        public FormListDb(String dbPath)
        {
            InitializeComponent();
            this.dbPath = dbPath;
            // Getting all xml file from db
            DirectoryInfo dir = new DirectoryInfo(dbPath);
            foreach (FileInfo file in dir.GetFiles("*.xml"))
            {
                // For each xml file, we add it to the dropdown select list
                comboAlbums.Items.Add(file.Name);
            }
        }

        private void FormListDb_Load(object sender, EventArgs e)
        {
            // For confirm visibility of all images set 
            this.AutoScroll = true;
        }

        // Adding one or more pictures from selected album to current album
        private void selectPictures(object sender, EventArgs e)
        {
            foreach (int i in listPictures.SelectedIndices)
                Console.WriteLine(pictures[i].path);
        }

        // View all pictures of the selected album
        private void watchAlbum(object sender, EventArgs e)
        {

            // Delete listview contain
            for (int i = listPictures.Items.Count - 1; i >= 0; i--)
            {
                listPictures.Items.RemoveAt(i);
            }

            // We load the matching album xml
            XmlManager xmlManager = new XmlManager(dbPath + comboAlbums.SelectedItem.ToString());
            pictures = xmlManager.loadXml();

            foreach (Picture picture in pictures)
            {
                try
                {
                    Console.WriteLine(picture.path);
                    // We add each picture of the album in the ImageList
                    this.imageList1.Images.Add(Image.FromFile(picture.path));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                // For each Image in ImageList, we create a ListViewItem
                ListViewItem item = new ListViewItem();
                // We define the indice of the picture
                item.ImageIndex = j;
                // We add the list view item to the listview
                this.listPictures.Items.Add(item);
            }
            // Defining the pictures size
            this.listPictures.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(227, 128);
            // We add the image list to the listview to matching indice picture
            this.listPictures.LargeImageList = this.imageList1;
        }

    }

}
