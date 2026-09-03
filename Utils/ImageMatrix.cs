using System.Drawing;
using System.Drawing.Imaging;

namespace SenacQuizApp.Utils
{
    public static class ImageMatrix
    {
        public static Bitmap MakeImageGray(Image originalImage)
        {
            // Create a blank bitmap with the same dimensions as the original
            Bitmap grayBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(grayBitmap))
            {
                // Define the grayscale ColorMatrix (standard luminosity weights)
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    // Apply the matrix to the attributes
                    attributes.SetColorMatrix(colorMatrix);

                    // Draw the original image onto the new bitmap using the grayscale attributes
                    g.DrawImage(originalImage,
                        new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                        0, 0, originalImage.Width, originalImage.Height,
                        GraphicsUnit.Pixel, attributes);
                }
            }

            return grayBitmap;
        }
    }
}
