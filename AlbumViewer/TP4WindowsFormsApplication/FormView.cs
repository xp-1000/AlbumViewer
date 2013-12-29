using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;


namespace AlbumViewer
{

    // Form which display the album contain : pictures, properties and actions

    public partial class FormView : Form
    {
        // Pictures list of current album
        List <Picture> pictures;
        // Counter to identify current displayed picture
        int counter = 0;
        // True if picture properties is displayed or false else
        bool infosMode = false;
        // Object to manage get or save album contain
        XmlManager xmlManager;
        // Tooltip to allow user to acces button icon description
        ToolTip buttonToolTip = new ToolTip();
        // Informations about database xml path and current album name
        String dbPath, fileName;

        // Constructor
        public FormView(String dbPath, String fileName)
        {
            InitializeComponent();
            this.dbPath = dbPath;
            this.fileName = fileName;
            // Creation of XmlManager for the current album
            xmlManager = new XmlManager(dbPath + fileName + ".xml");
            // Loading appropriate xml for this album into the Picture list
            pictures = xmlManager.loadXml();
            // Display first picture
            if (pictures.Count > 0)
                nextPicture(null,null);
            else
                hideUnnecessaryButtons();
        }

        // Graphical components initialization
        private void FormView_Load(object sender, EventArgs e)
        {
            // Auto scalling to display pictures
            this.mainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            // Browser dialog to allow user to add external folders
            // Define each button tooltip
            buttonToolTip.SetToolTip(this.addFolderButton, Properties.Resources.strAddFolder);
            buttonToolTip.SetToolTip(this.addButton, Properties.Resources.strAdd);
            buttonToolTip.SetToolTip(this.diapoButton, Properties.Resources.strDiapo);
            buttonToolTip.SetToolTip(this.webButton, Properties.Resources.strExportWeb);
            buttonToolTip.SetToolTip(this.infoButton, Properties.Resources.strInfosDisplay);
            buttonToolTip.SetToolTip(this.deleteButton, Properties.Resources.strDelete);
            buttonToolTip.SetToolTip(this.saveButton, Properties.Resources.strSaveAlbum);
            buttonToolTip.SetToolTip(this.backButton, Properties.Resources.strBack);
            // Load combo properties infos from ressources
            this.categoryCombo.Items.AddRange(Properties.Resources.categories.Split(','));
            this.rankCombo.Items.AddRange(Properties.Resources.ranks.Split(','));
            // Adding exif function to click event exif button
            this.exifButton.Click += new System.EventHandler(this.exif);
        }

        // Allow user to change to next picture in current album
        private void nextPicture(object sender, EventArgs e)
        {
            if (pictures.Count == counter)
            {
                // If it is the last picture, go back to the begin
                counter = 0;
            }
            if (pictures.Count > 0 )
            {
                // If album is not empty
                try
                {
                    // Next picture assignation to pictureBox
                    mainPicture.ImageLocation = pictures.ElementAt(counter).path;
                    // If properties are displayed we reload properties for new picture
                    if (infosMode == true)
                        loadInfos(counter);
                    // Counter incrementation pour next future picture
                    counter++;
                }
                catch (Exception exception)
                {
                    System.Console.WriteLine(exception.InnerException);
                }
            }
        }

        // Save the current album state to the db
        private void save(object sender, EventArgs e)
        {
            if (infosMode == true)
            {
                // If properties are displayed, we save change only for current picture and only in the temporary memory
                pictures[counter-1].category = (Categories) categoryCombo.SelectedIndex;
                pictures[counter-1].rank = (Ranks) rankCombo.SelectedIndex;
                pictures[counter-1].comment = commentField.Text;
            }
            else
                // When user changes are finished and properties are not displayed, so we save full album in persistant xml
                xmlManager.saveAsXml(pictures);
        }

        // Adding pictures from the disk
        private void externalAdd(object sender, EventArgs e)
        {
            // temporary array to stock all directory pictures
            string[] files;
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            // Default directory to begin tree
            folderDialog.SelectedPath = @"~";
            // Hide new folder button
            folderDialog.ShowNewFolderButton = false;
            // Display tree ui to get user directory choice
            DialogResult result = folderDialog.ShowDialog();
            // If the user click on OK
            if (result == DialogResult.OK)
            {
                // Loading all images file format
                files = Directory.GetFiles(folderDialog.SelectedPath, "*.*")
                        .Where(file => file.ToLower().EndsWith("jpg") 
                            || file.ToLower().EndsWith("jpeg")
                            || file.ToLower().EndsWith("png")
                            || file.ToLower().EndsWith("bmp"))
                        .ToArray();
                 
                // Adding each image file to Picture list
                foreach (String element in files)
                {
                    pictures.Add(new Picture(element, "", Categories.None));
                }                    
            }

            if(deleteButton.Enabled == false)
            {
                // If album was empty (so actions disabled), we reactive actions
                deleteButton.Enabled = true;
                infoButton.Enabled = true;
                diapoButton.Enabled = true;
                webButton.Enabled = true;
                // and we load first picture
                nextPicture(null,null);
            }
        }

        // Delete the current picture from the memory
        private void delete(object sender, EventArgs e)
        {
            if (pictures.Count == 1)
            {
                // If it is the last picture, we load the empty picture
                mainPicture.Image = global::AlbumViewer.Properties.Resources.no_content;
                // And we disable actions
                hideUnnecessaryButtons();
            }
            if (pictures.Count > 0)
            {
                // If album is not empty, we delete picture from the memory
                pictures.RemoveAt(counter - 1);
                // And decrement pictures counter
                counter--;
                // And load next picture
                nextPicture(null, null);
            }
        }

        private void hideUnnecessaryButtons()
        {
            deleteButton.Enabled = false;
            infoButton.Enabled = false;
            diapoButton.Enabled = false;
            webButton.Enabled = false;
        }

        // Provide personalized and advanced properties
        private void infos(object sender, EventArgs e)
        {
            if (infosMode == false)
            {
                // If preperties mode is disabled, we enable it
                infosMode = true;
                // We load properties for the current displayed picture
                loadInfos(counter-1);
                // We load graphical changes to display properties
                displayInfo();
            }
            else
            {
                // If preperties mode is disabled, we disable it
                infosMode = false;
                // We unload graphical changes to hide properties
                hideInfo();
            }

        }

        // Loading properties for id picture
        private void loadInfos(int id)
        {
            // Creation of Exifmanager for the picture
            ExifManager exifManager = new ExifManager(new Bitmap(mainPicture.ImageLocation));
            // Filling properties fields informations 
            infoNameV.Text = Path.GetFileName(mainPicture.ImageLocation);
            infoSizeV.Text = Convert.ToString(new FileInfo(mainPicture.ImageLocation).Length) + " " + Properties.Resources.strOctets;
            infoDateV.Text = exifManager.date;
            infoAuthorV.Text = exifManager.author;
            infoResolutionV.Text = Convert.ToString(exifManager.width) + " x " + Convert.ToString(exifManager.height);
            categoryCombo.SelectedIndex = (int)pictures[id].category;
            rankCombo.SelectedIndex = (int)pictures[id].rank;
            commentField.Text = pictures[id].comment;
        }

        // Displaying properties informations
        private void displayInfo()
        {
            buttonToolTip.SetToolTip(this.saveButton, Properties.Resources.strSaveProperties);
            buttonToolTip.SetToolTip(this.infoButton, Properties.Resources.strInfosHide);
            this.mainPicture.Size = new System.Drawing.Size(480, 270);
            infoNameL.Visible = true;
            infoNameV.Visible = true;
            infoSizeL.Visible = true;
            infoSizeV.Visible = true;
            infoDateL.Visible = true;
            infoDateV.Visible = true;
            infoAuthorL.Visible = true;
            infoAuthorV.Visible = true;
            infoResolutionL.Visible = true;
            infoResolutionV.Visible = true;
            exifButton.Visible = true;
            categoriesL.Visible = true;
            categoryCombo.Visible = true;
            rankL.Visible = true;
            rankCombo.Visible = true;
            commentL.Visible = true;
            commentField.Visible = true;
        }

        // Hidding properties informations
        private void hideInfo()
        {
            buttonToolTip.SetToolTip(this.saveButton, Properties.Resources.strSaveAlbum);
            buttonToolTip.SetToolTip(this.infoButton, Properties.Resources.strInfosDisplay);
            this.mainPicture.Size = new System.Drawing.Size(828, 466);
            infoNameL.Visible = false;
            infoNameV.Visible = false;
            infoSizeL.Visible = false;
            infoSizeV.Visible = false;
            infoDateL.Visible = false;
            infoDateV.Visible = false;
            infoAuthorL.Visible = false;
            infoAuthorV.Visible = false;
            infoResolutionL.Visible = false;
            infoResolutionV.Visible = false;
            exifButton.Visible = false;
            categoriesL.Visible = false;
            categoryCombo.Visible = false;
            rankL.Visible = false;
            rankCombo.Visible = false;
            commentL.Visible = false;
            commentField.Visible = false;
        }

        // Exif more buttton interrogation informations
        private void exif(object sender, EventArgs e)
        {
            ExifManager exifManager = new ExifManager(mainPicture.Image);
            exifManager.getProperties();
        }

        // Back button action
        private void back(object sender, EventArgs e)
        {
            if (infosMode == false)
            {
                // If properties mode is disabled, we close this form
                this.Dispose();
            }
            else
            {
                // else, we only disable the properties mode
                hideInfo();
            }
        }

        // Adding pictures from database to this album
        private void dbAdd(object sender, EventArgs e)
        {
            new FormListDb(dbPath).ShowDialog();
        }

        // Start the diaporama mode
        private void diapo(object sender, EventArgs e)
        {
            FormDiapo diapoForm = new FormDiapo(pictures, counter-1);
            diapoForm.ShowDialog();
        }
    }
}
