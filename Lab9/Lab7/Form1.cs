using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Font fnt = new Font("Arial", 10);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.Black;

            //g.draw
            // Draw a string on the PictureBox.
            //g.DrawString("This is a diagonal line drawn on the control",
            //  fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            PointF pointLeft = new PointF(0, pictureBox1.Size.Height);
            //point1 = pictureBox1.Left;
            PointF pointTop = new PointF(pictureBox1.Size.Width / 2, 0);
            PointF pointRight = new PointF(pictureBox1.Size.Width, pictureBox1.Size.Height);
            //Point point4 = new Point(60, 100);
            ////Point point = new Point()
            ///
            int layers = 0;
            if (textBox1.Text.Length > 0)
            {
                layers = Int32.Parse(textBox1.Text);
            }

            ///
            //DrawTriangle(g, layers, pointTop, pointLeft, pointRight);
        }

        private void DrawTriangle(Graphics gr, int level, PointF top_point, PointF left_point, PointF right_point)
        {
            // See if we should stop.
            if (level == 0)
            {
                // Fill the triangle.
                //        PointF[] points =
                //        {
                //    top_point, right_point, left_point
                //};

                PointF[] rightSide = { top_point, right_point };
                PointF[] leftSide = { top_point, left_point };
                PointF[] bottomSide = { right_point, left_point };

                //gr.FillPolygon(Brushes.White, points);
                // gr.FillPolygon(Brushes.White, points);
                Pen myPen = new Pen(Brushes.White, 2f);
                gr.DrawLines(myPen, rightSide);
                gr.DrawLines(myPen, leftSide);
                gr.DrawLines(myPen, bottomSide);
            }
            else
            {
                // Find the edge midpoints.
                PointF left_mid = new PointF(
                    (top_point.X + left_point.X) / 2f,
                    (top_point.Y + left_point.Y) / 2f);
                PointF right_mid = new PointF(
                    (top_point.X + right_point.X) / 2f,
                    (top_point.Y + right_point.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (left_point.X + right_point.X) / 2f,
                    (left_point.Y + right_point.Y) / 2f);

                // Recursively draw smaller triangles.
                DrawTriangle(gr, level - 1,
                    top_point, left_mid, right_mid);
                DrawTriangle(gr, level - 1,
                    left_mid, left_point, bottom_mid);
                DrawTriangle(gr, level - 1,
                    right_mid, bottom_mid, right_point);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics pic = pictureBox1.CreateGraphics();
            pictureBox1.Dock = DockStyle.Fill;
            pic.Clear(Color.Black);
            // pictureBox1.BackColor= Color.Aquamarine;

            //g.draw
            // Draw a string on the PictureBox.
            //g.DrawString("This is a diagonal line drawn on the control",
            //  fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            PointF pointLeft = new PointF(0, pictureBox1.Size.Height);
            //point1 = pictureBox1.Left;
            PointF pointTop = new PointF(pictureBox1.Size.Width / 2, 0);
            PointF pointRight = new PointF(pictureBox1.Size.Width, pictureBox1.Size.Height);
            //Point point4 = new Point(60, 100);
            ////Point point = new Point()
            ///
            int layers = 0;
            if (textBox1.Text.Length > 0)
            {
                layers = Int32.Parse(textBox1.Text);
            }

            ///
            DrawTriangle(pic, layers, pointTop, pointLeft, pointRight);

            // Dock the PictureBox to the form and set its background to white.

            // Connect the Paint event of the PictureBox to the event handler method.


            // Add the PictureBox control to the Form.
            //this.Controls.Add(pictureBox1);


            //g.draw
            // Draw a string on the PictureBox.
            //g.DrawString("This is a diagonal line drawn on the control",
            //  fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.

            //Point point4 = new Point(60, 100);
            ////Point point = new Point()
            ///
            // DrawTriangle(g, 5, pointTop, pointLeft, pointRight);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
