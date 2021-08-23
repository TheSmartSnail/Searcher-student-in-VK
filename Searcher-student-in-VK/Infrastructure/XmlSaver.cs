using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace Searcher_student_in_VK.Infrastructure
{
    class XmlSaver
    {
        void Save<T>(T item) where T : class
        {
            var formatter = new XmlSerializer(typeof(List<T>));
            var fileName = typeof(T).Name;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }

        }

        List<T> Load<T>() where T : class
        {
            var formatter = new XmlSerializer(typeof(List<T>));
            var fileName = typeof(T).Name;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if(formatter.Deserialize(fs) is List<T> items)
                {
                    return items;
                }

                return new List<T>();
                
            }
        }
    }
}
