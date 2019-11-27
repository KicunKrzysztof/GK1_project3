using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace proj3
{
    class PrintingAreas
    {
        private DirectBitmap left_bitmap, right_bitmap, red_chart_bitmap, green_chart_bitmap, blue_chart_bitmap;
        private PictureBox left_picture, right_picture, red_chart_picture, green_chart_picture, blue_chart_picture;

        public PrintingAreas(PictureBox lpb, PictureBox rpb, PictureBox rrgbpb, PictureBox grgbpb, PictureBox brgbpb)
        {
            {
            left_picture = lpb; right_picture = rpb; red_chart_picture = rrgbpb; green_chart_picture = grgbpb; blue_chart_picture = brgbpb;
            left_bitmap = new DirectBitmap(left_picture.Width, left_picture.Height);
            left_picture.Image = left_bitmap.Bitmap;
            right_bitmap = new DirectBitmap(right_picture.Width, right_picture.Height);
            right_picture.Image = right_bitmap.Bitmap;
            red_chart_bitmap = new DirectBitmap(red_chart_picture.Width, red_chart_picture.Height);
            red_chart_picture.Image = red_chart_bitmap.Bitmap;
            green_chart_bitmap = new DirectBitmap(green_chart_picture.Width, green_chart_picture.Height);
            green_chart_picture.Image = green_chart_bitmap.Bitmap;
            blue_chart_bitmap = new DirectBitmap(blue_chart_picture.Width, blue_chart_picture.Height);
            blue_chart_picture.Image = blue_chart_bitmap.Bitmap;
            }
        }
        public void SetPicture(Bitmap picture)
        {
            Graphics tmp_g_left = Graphics.FromImage(left_bitmap.Bitmap);
            Graphics tmp_g_right = Graphics.FromImage(right_bitmap.Bitmap);
            tmp_g_left.DrawImage(picture, new Point(0, 0));
            left_picture.Refresh();
            tmp_g_right.DrawImage(picture, new Point(0, 0));
            right_picture.Refresh();
            //.....wypełnić wykresy-histogramy rgb
        }

    }
}
