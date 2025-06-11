using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DBUTIL_Utilities_PolyCafe
{
    public class ImageUtil
    {
        // This method copies the selected image to a folder in the project and returns the copied image's file path.
        public static string CopyImageToProjectFolder(string originalImagePath)
        {
            // Define a folder named "ProductImages" in the project's startup directory.
            //string folderPath = Path.Combine(Application.StartupPath, "ProductImages");
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProductImages");

            // Create the folder if it doesn't exist.
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Get the original file name and create a destination path.
            string fileName = Path.GetFileName(originalImagePath);

            // Optionally, to avoid file name conflicts, append a timestamp.
            string uniqueFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{DateTime.Now.Ticks}{Path.GetExtension(fileName)}";

            string destinationPath = Path.Combine(folderPath, uniqueFileName);

            // Copy the file from the source to the destination.
            File.Copy(originalImagePath, destinationPath);

            // You can store a relative path rather than an absolute path if desired.
            string relativePath = Path.Combine("ProductImages", uniqueFileName);

            return relativePath;
        }
    }
}
