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
        

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Graphics pic = pictureBox1.CreateGraphics();
           
            pic.Clear(Color.Black);
            LetterG g = new LetterG(pic, 10);
            LetterP p = new LetterP(pic, 60);
            LetterY y= new LetterY(pic, 100);
            LetterSh sh = new LetterSh(pic, 140);
            LetterK k = new LetterK(pic, 200);
            LetterO o = new LetterO(pic, 240);

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
