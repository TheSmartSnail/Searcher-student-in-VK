using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Searcher_student_in_VK.Infrastructure
{
    static public class BinarySaver
    {
        static public void Save<T>(T item, string fileName) where T : class, new()
        {
            var formatter = new BinaryFormatter ();

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }

        }

        static public T Load<T>(string fileName)
            where T : class, new()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return formatter.Deserialize(fs) as T; 
                
            }
        }
    }
}
