using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
 
namespace LaserGRBL.Tools
{
    public class CarverX
    {

        public static Bitmap TextToImageInArea(
            string text,
            string fontName,
            int fontSize,
            Color textColor,
            Color backColor,
            int imageWidth,
            int imageHeight,
            Rectangle targetArea)
        {
            var bmp = new Bitmap(imageWidth, imageHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(backColor);

                using (Font font = new Font(fontName, fontSize))
                using (Brush brush = new SolidBrush(textColor))
                {
                    // Alignment inside the rectangle
                    StringFormat format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,   // horizontal
                        LineAlignment = StringAlignment.Center // vertical
                    };

                    // Draw inside the given rectangle
                    g.DrawString(text, font, brush, targetArea, format);
                }
            }

            return bmp;
        }
    }
}
