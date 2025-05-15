using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp3
{
    public partial class Form3 : Form
    {
        private PictureBox pictureBox;
        private Button drawButton;
        private List<Figure> figures = new List<Figure>();
        private Random random = new Random();

        public Form3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Лабораторна робота";
            this.Width = 800;
            this.Height = 600;

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.White;
            pictureBox.Paint += PictureBox_Paint;

            drawButton = new Button();
            drawButton.Text = "Намалювати";
            drawButton.Dock = DockStyle.Top;
            drawButton.Click += DrawButton_Click;

            this.Controls.Add(pictureBox);
            this.Controls.Add(drawButton);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            figures.Clear();

            for (int i = 0; i < 10; i++)
            {
                int type = random.Next(3);
                int x = random.Next(50, pictureBox.Width - 100);
                int y = random.Next(50, pictureBox.Height - 100);
                int size = random.Next(40, 80);
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                switch (type)
                {
                    case 0: figures.Add(new Hexagon(x, y, size, color)); break;
                    case 1: figures.Add(new Rhombus(x, y, size, color)); break;
                    case 2: figures.Add(new CircleWithText(x, y, size, color, "Text")); break;
                }
            }

            pictureBox.Invalidate();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }

    public abstract class Figure
    {
        protected int x, y, size;
        protected Color color;

        public Figure(int x, int y, int size, Color color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.color = color;
        }

        public abstract void Draw(Graphics g);
    }

    public class Hexagon : Figure
    {
        public Hexagon(int x, int y, int size, Color color) : base(x, y, size, color) { }

        public override void Draw(Graphics g)
        {
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i;
                points[i] = new Point(
                    (int)(x + size * Math.Cos(angle)),
                    (int)(y + size * Math.Sin(angle)));
            }
            g.FillPolygon(new SolidBrush(color), points);
        }
    }

    public class Rhombus : Figure
    {
        public Rhombus(int x, int y, int size, Color color) : base(x, y, size, color) { }

        public override void Draw(Graphics g)
        {
            Point[] points = new Point[]
            {
                new Point(x, y - size),
                new Point(x + size, y),
                new Point(x, y + size),
                new Point(x - size, y)
            };
            g.FillPolygon(new SolidBrush(color), points);
        }
    }

    public class CircleWithText : Figure
    {
        private string text;

        public CircleWithText(int x, int y, int size, Color color, string text) : base(x, y, size, color)
        {
            this.text = text;
        }

        public override void Draw(Graphics g)
        {
            Rectangle rect = new Rectangle(x - size / 2, y - size / 2, size, size);
            g.FillEllipse(new SolidBrush(color), rect);
            g.DrawString(text, SystemFonts.DefaultFont, Brushes.Black, x - size / 4, y - size / 4);
        }
    }
}
