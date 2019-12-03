using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace proj3
{
    public enum Mode { wholePicture, poly, circle };

    public partial class Form1 : Form
    {
        private PrintingAreas printing_areas;
        private double[,] current_filter = Config.blur;
        private Mode curr_mode = Mode.wholePicture;
        private bool custom_filter = false, poly_is_closed = false;
        private int radius = 10;
        private List<Point> current_poly = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            printing_areas = new PrintingAreas(LeftPictureBox, RightPictureBox, RedChartPictureBox, GreenChartPictureBox, BlueChartPictureBox);
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("proj3.quokka5.png");
            printing_areas.SetPicture(new Bitmap(new Bitmap(myStream), LeftPictureBox.Width, LeftPictureBox.Height));
        }

        private void OpenFIleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Find file";
            ofd.Filter = "(jpg files; png files)|*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
                printing_areas.SetPicture(new Bitmap(new Bitmap(ofd.FileName), LeftPictureBox.Width, LeftPictureBox.Height));
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            if (custom_filter)
                current_filter = GetCustomFilter();
            if (curr_mode == Mode.wholePicture)
                printing_areas.FilterWholePicture(current_filter);
            else if (curr_mode == Mode.poly && current_poly != null && poly_is_closed)
                printing_areas.FilterPoly(current_poly, current_filter);
        }
        private double[,] GetCustomFilter()
        {
            return new double[,] { { (double)numericUpDown1.Value, (double)numericUpDown2.Value, (double)numericUpDown3.Value }, 
                { (double)numericUpDown4.Value, (double)numericUpDown5.Value, (double)numericUpDown6.Value }, 
                { (double)numericUpDown7.Value, (double)numericUpDown8.Value, (double)numericUpDown9.Value } };
        }

        private void BlurRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = false;
            current_filter = Config.blur;
        }

        private void GaussianBlurRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = false;
            current_filter = Config.gaussian_blur;
        }

        private void SharpenRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = false;
            current_filter = Config.sharpen;
        }

        private void IdentityRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = false;
            current_filter = Config.identity;
        }

        private void EdgesDetectionRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = false;
            current_filter = Config.edges_detection;
        }

        private void EmbossRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = false;
            current_filter = Config.emboss;
        }

        private void CustomFilteRadioButton_Click(object sender, EventArgs e)
        {
            custom_filter = true;
        }

        private void WholePictureRadioButton_Click(object sender, EventArgs e)
        {
            curr_mode = Mode.wholePicture;
        }

        private void CircleRadioButton_Click(object sender, EventArgs e)
        {
            curr_mode = Mode.circle;
        }

        private void PolyRadioButton_Click(object sender, EventArgs e)
        {
            curr_mode = Mode.poly;
        }

        private void CircleTrackBar_Scroll(object sender, EventArgs e)
        {
            radius = CircleTrackBar.Value;
            TrackBarLabel.Text = CircleTrackBar.Value.ToString();
        }

        private void RightPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(curr_mode == Mode.circle)
                printing_areas.DrawCircle(new Point(e.X, e.Y), radius);
            else if (curr_mode == Mode.poly && !poly_is_closed)
            {
                var tmp_poly = new List<Point>(current_poly);
                tmp_poly.Add(new Point(e.X, e.Y));
                printing_areas.DrawPoly(tmp_poly , poly_is_closed);
            }
        }

        private void RightPictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (curr_mode == Mode.circle)
                printing_areas.MouseLeavesControl();
            if (curr_mode == Mode.poly)
                printing_areas.DrawPoly(current_poly, poly_is_closed);
        }

        private void RightPictureBox_Click(object sender, EventArgs e)
        {
            if (curr_mode == Mode.circle)
            {
                if (custom_filter)
                    printing_areas.FilterCircle(RightPictureBox.PointToClient(Cursor.Position), radius, GetCustomFilter());
                else
                    printing_areas.FilterCircle(RightPictureBox.PointToClient(Cursor.Position), radius, current_filter);
            }
            else if (curr_mode == Mode.poly && !poly_is_closed)
            {
                if (current_poly.Count > 0 && FillPolyHelper.CalculateDistance(current_poly[0], RightPictureBox.PointToClient(Cursor.Position)) < 5)
                    poly_is_closed = true;
                else
                    current_poly.Add(RightPictureBox.PointToClient(Cursor.Position));

                printing_areas.DrawPoly(current_poly, poly_is_closed);
            }
        }

        private void ChangeBaseButton_Click(object sender, EventArgs e)
        {
            printing_areas.ChangeFilterBase();
        }

        private void DeletePolyButton_Click(object sender, EventArgs e)
        {
            current_poly = new List<Point>();
            poly_is_closed = false;
            printing_areas.DrawPoly(current_poly, poly_is_closed);
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            printing_areas.Generate();
        }

        private void RefreshRIghtPictureButton_Click(object sender, EventArgs e)
        {
            current_poly = new List<Point>();
            poly_is_closed = false;
            printing_areas.RefreshRightPicture();
        }
    }
}
