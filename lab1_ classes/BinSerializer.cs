using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using lab1__classes.Lists;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab1__classes
{
    class BinSerializer
    {       

        public byte[] SerializeImages(PicturesList images, string path)
        {
            byte[] result;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            long length;
            //to binary
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, images);

            length = fs.Length;
            result = new byte[length];
            fs.Seek(0, SeekOrigin.Begin);
            fs.Read(result, 0, (int)length);
            fs.Close();
            return result;
        }

        public PicturesList DeserializeImages(string path, ref byte[] temp_array)
        {
            PicturesList result;
            FileStream fs = new FileStream(path, FileMode.Open);
            long length;
            //from binary
            BinaryFormatter bf = new BinaryFormatter();
            result = (PicturesList) bf.Deserialize(fs);

            length = fs.Length;
            temp_array = new byte[length];
            fs.Seek(0, SeekOrigin.Begin);
            fs.Read(temp_array, 0, (int)length);
            fs.Close();
            return result;
        }
    }
}
