using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace resize_photo
{
     class Resizer

    {

        public static Image Resize(Image image, int newWidth, int newHeight)
        {
            var orginalAspectRation = image.Width / image.Height;

            var res = new Bitmap(newWidth, newHeight);

            using (var graphic = Graphics.FromImage(res))
            {
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;
                graphic.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return res;
        }



        public void PerformReszie(string filePath, int width, int height)
        {
            var filename = Path.GetFileNameWithoutExtension(filePath);
            var basepath = Path.GetDirectoryName(filePath);
            System.Drawing.Image imgbef;
            imgbef = System.Drawing.Image.FromFile(filePath);

            System.Drawing.Image _imageResized;
            _imageResized = Resizer.Resize(imgbef, width, height);
            string newfilename = filename + "new.png";
            _imageResized.Save(Path.Combine(basepath, newfilename));

        }
    }
}
