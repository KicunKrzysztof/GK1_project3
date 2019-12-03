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
        private DirectBitmap left_bitmap, right_bitmap, red_chart_bitmap, green_chart_bitmap, blue_chart_bitmap, right_bitmap_duplicate;
        private PictureBox left_picture, right_picture, red_chart_picture, green_chart_picture, blue_chart_picture;

        public PrintingAreas(PictureBox lpb, PictureBox rpb, PictureBox rrgbpb, PictureBox grgbpb, PictureBox brgbpb)
        {
            {
            left_picture = lpb; right_picture = rpb; red_chart_picture = rrgbpb; green_chart_picture = grgbpb; blue_chart_picture = brgbpb;
            left_bitmap = new DirectBitmap(left_picture.Width, left_picture.Height);
            left_picture.Image = left_bitmap.Bitmap;
            right_bitmap = new DirectBitmap(right_picture.Width, right_picture.Height);
            right_picture.Image = right_bitmap.Bitmap;
            right_bitmap_duplicate = new DirectBitmap(right_picture.Width, right_picture.Height);
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
            Graphics tmp_g_right_duplicate = Graphics.FromImage(right_bitmap_duplicate.Bitmap);
            tmp_g_left.DrawImage(picture, new Point(0, 0));
            left_picture.Refresh();
            tmp_g_right.DrawImage(picture, new Point(0, 0));
            right_picture.Refresh();
            tmp_g_right_duplicate.DrawImage(picture, new Point(0, 0));
            CreateHistograms();
        }
        public void CreateHistograms()
        {
            ClearCharts();
            int[] r_tab = new int[256], g_tab = new int[256], b_tab = new int[256];
            for (int i = 0; i < right_bitmap.Height; i++)
                for (int j = 0; j < right_bitmap.Width; j++)
                {
                    Color c = right_bitmap.GetPixel(j, i);
                    r_tab[c.R]++;
                    g_tab[c.G]++;
                    b_tab[c.B]++;
                }
            int max = int.MinValue;
            for (int i = 0; i < 256; i++)
            {
                if (r_tab[i] > max)
                    max = r_tab[i];
                if (g_tab[i] > max)
                    max = g_tab[i];
                if (b_tab[i] > max)
                    max = b_tab[i];
            }
            double divide_factor = max / 180.0;
            for (int i = 0; i < 256; i++)
            {
                DrawHistogramLine(red_chart_bitmap, i, (int)(r_tab[i] / divide_factor), Color.Red);
                DrawHistogramLine(green_chart_bitmap, i, (int)(g_tab[i] / divide_factor), Color.Green);
                DrawHistogramLine(blue_chart_bitmap, i, (int)(b_tab[i] / divide_factor), Color.Blue);
            }
            red_chart_picture.Refresh();
            green_chart_picture.Refresh();
            blue_chart_picture.Refresh();
        }
        public void DrawHistogramLine(DirectBitmap btm, int x, int y, Color col)
        {
            for(int i = 0; i < y; i++)
                btm.SetPixel(x, btm.Height - i- 1, col);
        }
        public void ClearCharts()
        {
            Graphics red_gr = Graphics.FromImage(red_chart_bitmap.Bitmap);
            Graphics green_gr = Graphics.FromImage(green_chart_bitmap.Bitmap);
            Graphics blue_gr = Graphics.FromImage(blue_chart_bitmap.Bitmap);
            Brush white_brush = new SolidBrush(Color.White);
            red_gr.FillRectangle(white_brush, 0, 0, red_chart_bitmap.Width, red_chart_bitmap.Height);
            green_gr.FillRectangle(white_brush, 0, 0, green_chart_bitmap.Width, green_chart_bitmap.Height);
            blue_gr.FillRectangle(white_brush, 0, 0, blue_chart_bitmap.Width, blue_chart_bitmap.Height);
        }
        public void FilterWholePicture(double[,] filter)
        {
            RefreshRightFromDuplicate();
            double filter_sum = SumFilter(filter);
            for (int i = 0; i < right_bitmap.Height; i++)
                for (int j = 0; j < right_bitmap.Width; j++)
                {
                    ApplyFilterOnPixel(j, i, filter, filter_sum);
                }
            RefreshDuplicate();
            CreateHistograms();
            right_picture.Refresh();
        }
        public void FilterCircle(Point s, int radius, double[,] filter)
        {
            RefreshRightFromDuplicate();
            double filter_sum = SumFilter(filter);
            for (int x = Math.Min(s.X + radius, right_bitmap.Width - 1); x >= Math.Max(s.X - radius, 0); x--)
            {
                double tmp_help = Math.Acos((x - s.X) / radius);
                double tmp_help2 = Math.Sin(Math.Acos((x - s.X) / radius));
                int y_circle_min = (int)Math.Round(s.Y - (Math.Sin(Math.Acos((x - (double)s.X) / radius)) * radius));
                int y_circle_max = (int)Math.Round(s.Y + (Math.Sin(Math.Acos((x - (double)s.X) / radius)) * radius));
                for (int y = Math.Max(y_circle_min, 0); y < Math.Min(y_circle_max, right_bitmap.Height); y++)
                {
                    ApplyFilterOnPixel(x, y, filter, filter_sum);
                }
            }
            RefreshDuplicate();
            CreateHistograms();
            DrawCircle(s, radius);
            right_picture.Refresh();
        }

        public void FilterPoly(List<Point> poly, double [,] filter)
        {
            RefreshRightFromDuplicate();
            double filter_sum = SumFilter(filter);
            FillPolyHelper.FillPolygon(ApplyFilterOnPixel, poly, filter, filter_sum);
            RefreshDuplicate();
            CreateHistograms();
            DrawPoly(poly, true);
            right_picture.Refresh();
        }
        public static double SumFilter(double[,] filter)
        {
            double sum = 0;
            foreach (double d in filter) sum += d;
            return sum;
        }

        //function perform filter on pixel (_x, _y) on right_bitmap
        public void ApplyFilterOnPixel(int _x, int _y, double[,] filter, double filter_sum)
        {
            int bias = filter.GetLength(0) / 2;
            double red_sum = 0, green_sum = 0, blue_sum = 0;
            for (int x = _x - bias, filter_x = 0; x <= _x + bias; x++, filter_x++)    //filter_x is OX-ases index in filter matrix
            {  
                for (int y = _y - bias, filter_y = 0; y <= _y + bias; y++, filter_y++)    //filter_y is OY-axes index in filter matrix
                {
                    //virtual indexes are always within bitmap boundaries
                    int virtual_x = Math.Min(Math.Max(x, 0), right_bitmap.Width - 1);
                    int virtual_y = Math.Min(Math.Max(y, 0), right_bitmap.Height - 1);

                    Color c = left_bitmap.GetPixel(virtual_x, virtual_y);
                    red_sum += c.R * filter[filter_y, filter_x];
                    green_sum += c.G * filter[filter_y, filter_x];
                    blue_sum += c.B * filter[filter_y, filter_x];
                }
            }
            if (filter_sum == 0) filter_sum = 1;    //if translating
            int red = (int)Math.Min(Math.Max(red_sum / filter_sum, 0), 255);
            int green = (int)Math.Min(Math.Max(green_sum / filter_sum, 0), 255);
            int blue = (int)Math.Min(Math.Max(blue_sum / filter_sum, 0), 255);
            right_bitmap.SetPixel(_x, _y, Color.FromArgb(red, green, blue));
        }
        private void RefreshDuplicate()
        {
            Graphics tmp_right_duplicate_g = Graphics.FromImage(right_bitmap_duplicate.Bitmap);
            tmp_right_duplicate_g.DrawImage(right_bitmap.Bitmap, new Point(0, 0));
        }
        private void RefreshRightFromDuplicate()
        {
            Graphics tmp_right_g = Graphics.FromImage(right_bitmap.Bitmap);
            tmp_right_g.DrawImage(right_bitmap_duplicate.Bitmap, new Point(0, 0));
        }
        public void DrawCircle(Point s, int radius)
        {
            RefreshRightFromDuplicate();
            Graphics tmp_right_g = Graphics.FromImage(right_bitmap.Bitmap);
            Pen black_pen = new Pen(Color.Black, 2);
            black_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Rectangle rect = new Rectangle(s.X - radius, s.Y - radius, 2 * radius, 2 * radius);
            tmp_right_g.DrawEllipse(black_pen, rect);
            right_picture.Refresh();
            black_pen.Dispose();
        }

        public void DrawPoly(List<Point> poly, bool closed)
        {
            RefreshRightFromDuplicate();
            Graphics tmp_right_g = Graphics.FromImage(right_bitmap.Bitmap);
            Pen black_pen = new Pen(Color.Black, 2);
            black_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            for (int i = 1; i < poly.Count; i++)
                tmp_right_g.DrawLine(black_pen, poly[i - 1], poly[i]);

            if(closed)
                tmp_right_g.DrawLine(black_pen, poly[poly.Count - 1], poly[0]);

            right_picture.Refresh();
            black_pen.Dispose();
        }
        public void MouseLeavesControl()
        {
            RefreshRightFromDuplicate();
            right_picture.Refresh();
        }
        public void ChangeFilterBase()
        {
            Graphics tmp_left_g = Graphics.FromImage(left_bitmap.Bitmap);
            tmp_left_g.DrawImage(right_bitmap_duplicate.Bitmap, new Point(0, 0));
            left_picture.Refresh();
        }
        public void RefreshRightPicture()
        {
            Graphics tmp_right_g = Graphics.FromImage(right_bitmap.Bitmap);
            Graphics tmp_right_duplicate_g = Graphics.FromImage(right_bitmap_duplicate.Bitmap);
            tmp_right_g.DrawImage(left_bitmap.Bitmap, new Point(0, 0));
            tmp_right_duplicate_g.DrawImage(left_bitmap.Bitmap, new Point(0, 0));
            right_picture.Refresh();
            CreateHistograms();
        }
    }
}
