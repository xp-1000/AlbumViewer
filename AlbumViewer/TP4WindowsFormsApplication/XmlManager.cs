using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using System.IO;

namespace AlbumViewer
{
    // Class which manage xml (de)serialization operation

    class XmlManager
    {
        XmlDocument xml;
        String filename;

        public XmlManager(String filename)
        {
            xml = new XmlDocument();
            this.filename = filename;
        }

        public List<Picture> loadXml()
        {

            // if album already exists
            if(File.Exists(filename))
            {
                // Desarialize the album xml to get all Picture in list
                List<Picture> pictures = new List<Picture>();
                XmlSerializer xs = new XmlSerializer(typeof(List<Picture>));
                using (StreamReader rd = new StreamReader(filename))
                {
                    pictures =  xs.Deserialize(rd) as List<Picture>;
                }

                return pictures;
            }
            return new List<Picture>();
        }

        public void saveAsXml(List <Picture> pictures)
        {
            // Serialize the list of Picture into the xml to save the db
            XmlSerializer xs = new XmlSerializer(typeof(List<Picture>));
            using (StreamWriter wr = new StreamWriter(filename))
            {
                xs.Serialize(wr, pictures);
            }
        }
    }
}
