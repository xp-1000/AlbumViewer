using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows; 

namespace AlbumViewer
{

    // From which display album list and managing

    public partial class FormAlbums : Form
    {
        private const string dbDir = "\\dbx\\";
        string dbPath;

        public FormAlbums(String currentPath)
        {
            InitializeComponent();
            dbPath = currentPath + dbDir;
            loadDbList();
            
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            // For confirm visibility of all images set 
            this.AutoScroll = true;
        }

        private void loadDbList()
        {
            // Create a new target folder, if necessary.
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }
            // We list all xml file in database directory
            List<string> albums = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(dbPath);
            foreach (FileInfo file in dir.GetFiles("*.xml"))
            {
                Console.WriteLine(file.FullName);
                try
                {
                    // For each xml file we add the album name without ".xml"
                    albums.Add(file.Name.Replace(".xml", ""));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            foreach (string album in albums)
            {
                ListViewItem item = new ListViewItem();
                item.Text = album;
                this.listAlbums.Items.Add(item);
            }
        }

        private void reloadDbList()
        {
            // We delete
            for (int i = listAlbums.Items.Count - 1; i >= 0; i--)
            {
                listAlbums.Items.RemoveAt(i);
            }
            loadDbList();
            // Re-sort list
            this.listAlbums.Sorting = System.Windows.Forms.SortOrder.Ascending;
        }

        // Selecting Album
        private void selectAlbum(object sender, EventArgs e)
        {
            // If at least one album is selected
            if (listAlbums.SelectedIndices.Count > 0)
                openAlbum(listAlbums.Items[listAlbums.SelectedIndices[0]].Text);
        }

        // Creating a new Album
        private void createAlbum(object sender, System.EventArgs e)
        {
            // Open a new input dialog to get the name of new album
            string newName = inputNameDialog(Properties.Resources.strNewName);
            if (newName != null)
            {
                // Same behavier than an album selection (XmlManager will create the xml file)
                openAlbum(newName);
            }
        }

        // Opne FormView to watch album contain
        private void openAlbum(string album)
        {
            // We hide current form
            this.Visible = false;
            // We show the View Form
            new FormView(dbPath, album).ShowDialog();
            // When the view Form is closed, we reload it
            reloadDbList();
            // And we display current form
            this.Visible = true;

        }

        // Deleting one or some albums
        private void deleteAlbum(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = listAlbums.SelectedIndices;
            for (int i = indexes.Count - 1; i >= 0; i--)
            {
                // Delete xml file 
                File.Delete(dbPath + listAlbums.Items[indexes[i]].Text + ".xml");
                // Delete item in listView
                listAlbums.Items.RemoveAt(indexes[i]);
            }
        }

        // Rename only on album
        private void rename(object sender, EventArgs e)
        {
            if (listAlbums.SelectedIndices.Count > 0)
            {
                // Open a new input dialog to get the new name of selected album
                string newName = inputNameDialog(Properties.Resources.strRename, listAlbums.Items[listAlbums.SelectedIndices[0]].Text);
                if (newName != null)
                {
                    // Rename xml file
                    File.Move(dbPath + listAlbums.Items[listAlbums.SelectedIndices[0]].Text + ".xml", dbPath + newName + ".xml");
                    // Rename item in listview
                    listAlbums.Items[listAlbums.SelectedIndices[0]].Text = newName;
                }
            }
        }

        private string inputNameDialog(string formName, string text)
        {
            Form form = new Form();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = formName;
            textBox.Text = text;

            buttonOk.Text = Properties.Resources.strOk;
            buttonCancel.Text = Properties.Resources.strCancel;
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                return textBox.Text;
            }
            return null;
        }

        private string inputNameDialog(string formName)
        {
            return inputNameDialog(formName, "");
        }


    }
}
