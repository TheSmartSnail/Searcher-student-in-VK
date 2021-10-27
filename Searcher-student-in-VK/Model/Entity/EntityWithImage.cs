using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace Searcher_student_in_VK.Model.Entity
{
    public class EntityWithImage:NamedEntity
    {
        public const string standardImagePath = @"C:\Users\serge\Source\Repos\Searcher-student-in-VK\Searcher-student-in-VK\Infrastructure\Data\TestData\default-avatar.png";
        public string imagePath;

        [NotMapped]
        PngBitmapEncoder Encoder = new PngBitmapEncoder();

        private BitmapImage photo;
        private byte[] convertedPhoto;

        [NotMapped]
        public BitmapImage Photo
        {
            get
            {
                using (MemoryStream ms = new MemoryStream(ConvertedPhoto))
                {
                    BitmapImage photo = new BitmapImage();
                    photo.BeginInit();
                    photo.CacheOption = BitmapCacheOption.OnLoad; // here
                    photo.StreamSource = ms;
                    photo.EndInit();
                    return photo;
                }
            } 
          set 
            {
                photo = value;
                Encoder.Frames.Add(BitmapFrame.Create(photo));
                using (MemoryStream ms = new MemoryStream())
                {
                    Encoder.Save(ms);
                    ConvertedPhoto = ms.ToArray();
                    StringPhoto = String.Join(";", ConvertedPhoto.Select(p => p.ToString()).ToArray());

                }
            } 
        }

        public string StringPhoto { get; set; }
        public byte[] ConvertedPhoto {
            get
            {
                return Array.ConvertAll(StringPhoto.Split(';'), byte.Parse);
            }
            set
            {
                convertedPhoto = value;
                StringPhoto = String.Join(";", convertedPhoto.Select(p => p.ToString()).ToArray());
            }
        }

        public EntityWithImage(string Name, string pathPhoto=standardImagePath) : base(Name)
        {
            imagePath = pathPhoto;
            Uri uri = new Uri(pathPhoto);
            Photo = new BitmapImage(uri);
        }



        private EntityWithImage(string Name) : base(Name)
        {

        }


        public void InitPhoto()
        {
            using (MemoryStream ms = new MemoryStream(ConvertedPhoto))
            {
                Photo.BeginInit();
                Photo.CacheOption = BitmapCacheOption.OnLoad; // here
                Photo.StreamSource = ms;
                Photo.EndInit();
            }
        }
    }
}
