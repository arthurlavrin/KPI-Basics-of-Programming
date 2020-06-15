using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab7
{
    public class LetterG
    {
        public LetterG(Graphics gr, int inc)
        {
            Point bottomPoint = new Point(0 + inc, 100);
            Point topPoint = new Point(0 + inc, 5);
            Point rightPoint = new Point(50 + inc, 5);

            DrawG(gr, bottomPoint, topPoint, rightPoint);

        }
        private void DrawG(Graphics gr, Point bottomPoint, Point topPoint, Point rightPoint)
        {

            Pen myPen = new Pen(Brushes.OrangeRed, 3f);
            Point[] leftSide = { bottomPoint, topPoint };
            Point[] topSide = { topPoint, rightPoint };


            gr.DrawLines(myPen, leftSide);
            gr.DrawLines(myPen, topSide);
        }
    }
    public class LetterP
    {
        public LetterP(Graphics gr, int inc)
        {
            Point leftBottom = new Point(0 + inc, 150);
            Point leftTop = new Point(0 + inc, 50);
            Point rightTop = new Point(30 + inc, 50);
            Point rightMid = new Point(30 + inc, 100);
            Point leftMid = new Point(0 + inc, 100);
            DrawP(gr, leftBottom, leftTop, rightTop, rightMid, leftMid);

        }
        private void DrawP(Graphics gr, Point leftBottom, Point leftTop, Point rightTop, Point rightMid, Point leftMid)
        {

            Pen myPen = new Pen(Brushes.Yellow, 3f);
            Point[] leftSide = { leftBottom, leftTop };
            Point[] topSide = { leftTop, rightTop };

            Point[] rightSide = { rightTop, rightMid };
            Point[] midSide = { rightMid, leftMid };

            gr.DrawLines(myPen, leftSide);
            gr.DrawLines(myPen, topSide);
            gr.DrawLines(myPen, rightSide);
            gr.DrawLines(myPen, midSide);
        }
    }
    public class LetterY
    {
        public LetterY(Graphics gr, int inc)
        {
            Point leftMid = new Point(0 + inc, 100);
            Point leftTop = new Point(0 + inc, 50);
            Point rightTop = new Point(30 + inc, 50);
            Point rightMid = new Point(30 + inc, 100);
            Point rightBottom = new Point(30 + inc, 150);
            Point leftBottom = new Point(0 + inc, 150);


            DrawY(gr, leftMid, leftTop, rightTop, rightBottom, rightMid, leftBottom);

        }
        private void DrawY(Graphics gr, Point leftMid, Point leftTop, Point rightTop, Point rightBottom, Point rightMid, Point leftbottom)
        {

            Pen myPen = new Pen(Brushes.Green, 3f);
            Point[] leftSide = { leftMid, leftTop };

            Point[] rightSide = { rightTop, rightBottom };
            Point[] midSide = { rightMid, leftMid };
            Point[] bottomSide = { rightBottom, leftbottom };

            gr.DrawLines(myPen, leftSide);
            gr.DrawLines(myPen, rightSide);
            gr.DrawLines(myPen, midSide);
            gr.DrawLines(myPen, bottomSide);
        }
    }
    public class LetterSh
    {
        public LetterSh(Graphics gr, int inc)
        {

            Point leftBottom = new Point(0 + inc, 100);
            Point leftTop = new Point(0 + inc, 50);
            Point rightTop = new Point(50 + inc, 50);
            Point rightBottom = new Point(50 + inc, 100);
            Point midBottom = new Point(25 + inc, 100);
            Point midTop = new Point(25 + inc, 50);
            DrawSh(gr, leftBottom, leftTop, rightTop, rightBottom, midBottom, midTop);

        }
        public void DrawSh(Graphics gr, Point leftBottom, Point leftTop, Point rightTop, Point rightBottom, Point midBottom, Point midTop )
        {

            Pen myPen = new Pen(Brushes.Blue, 3f);
            Point[] leftSide = { leftBottom, leftTop };
            Point[] bottomSide = { leftBottom, rightBottom };

            Point[] rightSide = { rightTop, rightBottom };
            Point[] midSide = { midBottom, midTop };

            gr.DrawLines(myPen, leftSide);
            gr.DrawLines(myPen, rightSide);
            gr.DrawLines(myPen, bottomSide);
            gr.DrawLines(myPen, midSide);
        }
    }
    public class LetterK
    {
        public LetterK(Graphics gr, int inc)
        {
            Point leftBottom = new Point(0 + inc, 100);
            Point leftTop = new Point(0 + inc, 50);
            Point rightTop = new Point(30 + inc, 50);
            Point rightBottom = new Point(30 + inc, 100);
            Point midPoint = new Point(0 + inc, 75);

            DrawK(gr, leftBottom, leftTop, rightTop, rightBottom, midPoint);

        }
        private void DrawK(Graphics gr, Point leftBottom, Point leftTop, Point rightTop, Point rightBottom, Point midPoint)
        {

            Pen myPen = new Pen(Brushes.AliceBlue, 3f);
            Point[] leftSide = { leftBottom, leftTop };

            Point[] rightSide = { midPoint, rightBottom };
            Point[] midSide = { midPoint, rightTop };

            gr.DrawLines(myPen, leftSide);
            gr.DrawLines(myPen, rightSide);
            gr.DrawLines(myPen, midSide);
        }
    }
   
    public class LetterO
    {
        public LetterO(Graphics gr, int inc)
        {

            Point leftBottom = new Point(0 + inc, 100);
            Point rightBottom = new Point(30 + inc, 100);
            Point leftTop = new Point(0 + inc, 50);
            Point rightTop = new Point(30 + inc, 50);
            DrawC(gr, leftBottom, rightBottom, leftTop, rightTop);

        }
        private void DrawC(Graphics gr, Point leftBottom, Point rightBottom, Point leftTop, Point rightTop)
        {

            Pen myPen = new Pen(Brushes.Maroon, 3f);
            Point[] leftSide = { leftBottom, leftTop };
            Point[] topSide = { leftTop, rightTop };
            Point[] bottomSide = { leftBottom, rightBottom };
            Point[] rightSide = { rightBottom, rightTop };

            gr.DrawLines(myPen, leftSide);
            gr.DrawLines(myPen, topSide);
            gr.DrawLines(myPen, rightSide);
            gr.DrawLines(myPen, bottomSide);
        }
    }

   
}

