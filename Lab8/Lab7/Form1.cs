using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Font fnt = new Font("Arial", 10);        

        //private void DrawBackRectangles()
        //{
        //    Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        //    Graphics graphics = Graphics.FromImage(bitmap);
        //    pictureBox1.Image = bitmap;
        //    Pen pen = new Pen(Color.Red);

        //    //Устанавливаем значения точек первого квадрата 
        //    float x1 = pictureBox1.Width / 10;
        //    float y1 = pictureBox1.Height / 10;
        //    float width = pictureBox1.Width - (2 * x1);
        //    float height = pictureBox1.Height - (2 * y1);
        //    float x2 = x1 + width;
        //    float y2 = y1;
        //    float x3 = x2;
        //    float y3 = y2 + height;
        //    float x4 = x1;
        //    float y4 = y3;
        //    float p = 0.08f;
        //    graphics.DrawRectangle(pen, x1, y1, width, height);
        //    for (int i = 0; i < 50; i++)
        //    {
        //        x1 = x1 + (x2 - x1) * p;
        //        x2 = x2 + (x3 - x2) * p;
        //        x3 = x3 + (x4 - x3) * p;
        //        x4 = x4 + (x1 - x4) * p;
        //        y1 = y1 + (y2 - y1) * p;
        //        y2 = y2 + (y3 - y2) * p;
        //        y3 = y3 + (y4 - y3) * p;
        //        y4 = y4 + (y1 - y4) * p;
        //        graphics.DrawLine(pen, x2, y2, x1, y1);
        //        graphics.DrawLine(pen, x2, y2, x1, y1);
        //        graphics.DrawLine(pen, x3, y3, x2, y2);
        //        graphics.DrawLine(pen, x4, y4, x1, y1);
        //        graphics.DrawLine(pen, x4, y4, x3, y3);
        //    }
        //}

        private void DrawRectangles()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            Pen pen = new Pen(Color.Blue);

            //Устанавливаем значения точек первого квадрата 
            float x4 = pictureBox1.Width / 10;
            float y4 = pictureBox1.Height / 10;
            float width = pictureBox1.Width - (2 * x4);
            float height = pictureBox1.Height - (2 * y4);
            float x3 = x4 + width;
            float y3 = y4;
            float x2 = x3;
            float y2 = y3 + height;
            float x1 = x4;
            float y1 = y2;
            float p = 0.08f;

            graphics.DrawRectangle(pen, x4, y4, width, height);

            for (int i = 50; i > 0; i--)
            {
                x1 = x1 + (x2 - x1) * p;
                x2 = x2 + (x3 - x2) * p;
                x3 = x3 + (x4 - x3) * p;
                x4 = x4 + (x1 - x4) * p;
                y1 = y1 + (y2 - y1) * p;
                y2 = y2 + (y3 - y2) * p;
                y3 = y3 + (y4 - y3) * p;
                y4 = y4 + (y1 - y4) * p;
                graphics.DrawLine(pen, x1, y1, x2, y2);
                graphics.DrawLine(pen, x2, y2, x3, y3);
                graphics.DrawLine(pen, x1, y1, x4, y4);
                graphics.DrawLine(pen, x4, y4, x3, y3);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics pic = pictureBox1.CreateGraphics();

            //pictureBox1.Dock = DockStyle.Fill;
            pic.Clear(Color.Black);

            DrawRectangles();
            // DrawBackRectangles();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();

        }
    }



}
