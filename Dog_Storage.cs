using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Windows;

namespace DogCare
{
    internal class Dog_Storage
    {
        internal static void WriteXml<T>(T data, string file)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream;

            stream = new FileStream(file, FileMode.Create);

            serializer.Serialize(stream, data);
            stream.Close();


        }

        //    internal static T ReadXml<T>(string file)
        //    {

        //        using (StreamReader sr = new StreamReader(file))
        //        {
        //            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
        //            return (T)xmlSer.Deserialize(sr);
        //        }







        //    }
        //}

        internal static T ReadXml<T>(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    //(T) cast it
                    return (T)serializer.Deserialize(sr);

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
                return default(T);
            }
        }
    }
}
