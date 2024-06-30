using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(textBoxX1.Text);
            float y1 = float.Parse(textBoxY1.Text);
            float x2 = float.Parse(textBoxX2.Text);
            float y2 = float.Parse(textBoxY2.Text);
            float vx1 = float.Parse(textBoxVx1.Text);
            float vy1 = float.Parse(textBoxVy1.Text);
            float vx2 = float.Parse(textBoxVx2.Text);
            float vy2 = float.Parse(textBoxVy2.Text);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                PointF p1 = new PointF(x1, y1);
                PointF p2 = new PointF(x2, y2);
                PointF v1 = new PointF(vx1, vy1);
                PointF v2 = new PointF(vx2, vy2);

                DrawHermite(g, p1, p2, v1, v2);
            }
            pictureBox1.Image = bmp;
        }

        private void DrawHermite(Graphics g, PointF p1, PointF p2, PointF v1, PointF v2)
        {
            float step = 0.01f;
            for (float t = 0; t < 1; t += step)
            {
                float h1 = 2 * t * t * t - 3 * t * t + 1;
                float h2 = -2 * t * t * t + 3 * t * t;
                float h3 = t * t * t - 2 * t * t + t;
                float h4 = t * t * t - t * t;

                float x = h1 * p1.X + h2 * p2.X + h3 * v1.X + h4 * v2.X;
                float y = h1 * p1.Y + h2 * p2.Y + h3 * v1.Y + h4 * v2.Y;

                g.FillEllipse(Brushes.Black, x, y, 2, 2);
            }
        }
    }
}
