using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPickerApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                Color color = bitmap.GetPixel(e.X, e.Y);

                labelRed.Text = "Red: " + color.R;
                labelGreen.Text = "Green: " + color.G;
                labelBlue.Text = "Blue: " + color.B;

                this.BackColor = color;
            }
        }
    }
}
