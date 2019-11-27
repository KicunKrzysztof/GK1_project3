using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj3
{
    public partial class Form1 : Form
    {
        private PrintingAreas printing_areas;
        public Form1()
        {
            InitializeComponent();
            printing_areas = new PrintingAreas(LeftPictureBox, RightPictureBox, RedChartPictureBox, GreenChartPictureBox, BlueChartPictureBox);
        }

        private void OpenFIleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Find file";
            ofd.Filter = "(jpg files; png files)|*.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                printing_areas.SetPicture(new Bitmap(new Bitmap(ofd.FileName), LeftPictureBox.Width, LeftPictureBox.Height));
            }
        }
    }
}
