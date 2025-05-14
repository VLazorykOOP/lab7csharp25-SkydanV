using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        Point startPoint;
        bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            Point endPoint = e.Location;

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen pen = new Pen(Color.Black, 2);

            if (rbLine.Checked)
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
            else if (rbRectangle.Checked)
            {
                g.DrawRectangle(pen, GetRectangle(startPoint, endPoint));
            }
            else if (rbEllipse.Checked)
            {
                g.DrawEllipse(pen, GetRectangle(startPoint, endPoint));
            }
            else if (rbCircle.Checked)
            {
                Rectangle rect = GetRectangle(startPoint, endPoint);
                int size = Math.Min(rect.Width, rect.Height);
                g.DrawEllipse(pen, new Rectangle(rect.X, rect.Y, size, size));
            }

            pictureBox1.Invalidate(); 
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p2.X - p1.X),
                Math.Abs(p2.Y - p1.Y)
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
