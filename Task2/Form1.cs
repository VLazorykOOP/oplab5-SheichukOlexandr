using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FractalDandelion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int order = int.Parse(textBox1.Text);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                DrawDandelion(g, order, pictureBox1.Width / 2, pictureBox1.Height / 2, pictureBox1.Width / 4, 0);
            }
            pictureBox1.Image = bitmap;
        }

        private void DrawDandelion(Graphics g, int order, float x, float y, float length, float angle)
        {
            if (order == 0)
                return;

            float x1 = x + length * (float)Math.Cos(angle);
            float y1 = y - length * (float)Math.Sin(angle);

            g.DrawLine(Pens.Black, x, y, x1, y1);

            float newLength = length * 0.7f;

            DrawDandelion(g, order - 1, x1, y1, newLength, angle + (float)Math.PI / 6);
            DrawDandelion(g, order - 1, x1, y1, newLength, angle - (float)Math.PI / 6);
        }
    }
}
