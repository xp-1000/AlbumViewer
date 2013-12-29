using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AlbumViewer
{

    // Class to manage exif interrogation informations

    class ExifManager
    {

        Image image;
        public string date
        {
            get { return formateDate(getPropertyAscii(0x132)); }
        }
        public string author
        {
            get { return getPropertyAscii(0x10f) + " " + getPropertyAscii(0x110); }
        }
        public uint width
        {
            get { return getPropertyUInt(0xa002); }
        }
        public uint height
        {
            get { return getPropertyUInt(0xa003); }
        }

        public ExifManager(Image image)
        {
            this.image = image;     
        }

        public void getProperties()
        {
            try
            {
                // For each PropertyItem in the array, display the id, type, and length. 
                int count = 0;
                PropertyItem[] propItems = image.PropertyItems;

                foreach (PropertyItem propItem in propItems)
                {
                    // PropertyItem propItem = mainPicture.Image.GetPropertyItem(0x131);
                    if (propItem != null)
                    {
                        System.Console.WriteLine("ID: 0x" + propItem.Id.ToString("x"));
                        System.Console.WriteLine("Type: " + propItem.Type.ToString());
                        // For each type we apply a special processing
                        switch (propItem.Type)
                        {
                            case 2:
                                string text = decodeAsciiString(propItem);
                                System.Console.WriteLine("Valeur: " + text);
                                break;
                            case 3:
                                ushort uShortValue = BitConverter.ToUInt16(propItem.Value, 0);
                                System.Console.WriteLine("Valeur: " + uShortValue);
                                break;
                            case 4:
                                uint uIntValue = BitConverter.ToUInt32(propItem.Value, 0);
                                System.Console.WriteLine("Valeur: " + uIntValue);
                                break;
                            case 5:
                                int[] cor = Array.ConvertAll(propItem.Value, b => (int)b);
                                System.Console.WriteLine("Valeur: " + cor[0]);
                                break;
                            case 7:
                                long sIntValue = BitConverter.ToInt32(propItem.Value, 0);
                                System.Console.WriteLine("Valeur: " + sIntValue);
                                break;
                        }
                        count += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Get property of type ascii with id 
        private string getPropertyAscii(int id)
        {
            try
            {
                PropertyItem propItem = image.GetPropertyItem(id);
                if (propItem != null)
                    return decodeAsciiString(propItem);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
            }
            return null;
        }

        // Get property of type integer with id 
        private uint getPropertyUInt(int id)
        {
            try
            {
                PropertyItem propItem = image.GetPropertyItem(id);
                if (propItem != null)
                    return BitConverter.ToUInt32(propItem.Value, 0);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
            }
            return 0;
        }

        // Decode Ascii 
        private string decodeAsciiString(PropertyItem prop)
        {
            System.Text.ASCIIEncoding encodingAscii = new System.Text.ASCIIEncoding();
            string text = encodingAscii.GetString(prop.Value, 0, prop.Len - 1);
            return text;
        }

        // Formating date
        private string formateDate(string date)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            if (date != null)
                return DateTime.ParseExact(date, "yyyy:MM:d H:m:s", provider).ToString();
            else
                return null;
        }

    }
}
