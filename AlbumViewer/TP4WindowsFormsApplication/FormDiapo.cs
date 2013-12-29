using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumViewer
{

    // Form which manage diaporama mode

    public partial class FormDiapo : Form
    {
        // Indices to keep current picture and last picture
        int counter, end;
        // List of Album pictures
        private List<Picture> pictures;
        // Timer to automatically change picture
        Timer timer;

        public FormDiapo(List<Picture> pictures, int inc)
        {
            InitializeComponent();
            // Counter begin from current displayed picture indice which it is also the stop point of the diaporama
            counter = inc;
            end = inc;
            this.pictures = pictures;
        }

        private void FormDiapo_Load(object sender, EventArgs e)
        {
            // Passing this form in fullscreen mode
            fullScreenMode();
            // Getting the resolution of the screen
            Screen screen = Screen.PrimaryScreen;
            int S_width = screen.Bounds.Width;
            int S_height = screen.Bounds.Height;
            // Assignation of screen size to picture box size
            pictureBox1.Size = new System.Drawing.Size(S_width, S_height);
            // Loading first picture in picture box
            setPicture(new Bitmap(pictures[counter].path));
            // Timer creation
            timer = new Timer();
            // change to next picture for each loop of timer interval
            timer.Tick += new EventHandler(nextPicture);
            // Timer interval time between each picture change
            timer.Interval = 3000;
            // Starting timer
            timer.Start();
        }

        private void nextPicture(object sender, EventArgs e)
        {
            if (counter == end)
            {
                // If it is the last (and first) picture to display, we stop the timer
                timer.Stop();
                // We close this form
                this.Dispose();
            }
            if (counter < pictures.Count)
            {
                // If it is not the last picture of the list, we assign next picture in the picturebox
                setPicture(new Bitmap(pictures[counter].path));
            }
            else
            {
                // If it is the last picture of the list, we go back to the begin
                counter = 0;
                if (counter == end)
                {
                    // In case where we begin by the real first picture 
                    // If it is the last picture to display
                    // Stop the timer
                    timer.Stop();
                    // And close this form
                    this.Dispose();
                }
                // Setting the next pciture in picturebox
                setPicture(new Bitmap(pictures[counter].path));
            }
        }

        // Set the picture in the picturebox
        private void setPicture(Bitmap pic)
        {
            pictureBox1.Image = pic;
            counter++;
        }

        public void fullScreenMode()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
