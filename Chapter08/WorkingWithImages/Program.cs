using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace WorkingWithImages
{
    class Program
    {
        static void Main(string[] args)
        {
            var imagesFolder = Path.Combine(Environment.CurrentDirectory, "images");

            var images = Directory.EnumerateFiles(imagesFolder);

            foreach (var imagePath in images)
            {
                var thumbnailPath = Path.Combine(Environment.CurrentDirectory, "images",
                    Path.GetFileNameWithoutExtension(imagePath) + "-thumbnail" + Path.GetExtension(imagePath));

                using (var image = Image.Load(imagePath))
                {
                    image.Mutate(x => x.
                        Resize(image.Width / 10, image.Height / 10));
                    image.Mutate(x => x.Grayscale());
                    image.Save(thumbnailPath);
                }
            }
        }
    }
}
