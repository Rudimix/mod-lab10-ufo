using System;
using System.Drawing;
using System.Windows.Forms;

namespace UfoProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void WithAngle()
        {
            int x2 = Int32.Parse(xLast.Text);
            int y2 = Int32.Parse(yLast.Text);
            int N = Int32.Parse(CountOf.Text);
            int precision = Int32.Parse(Precision.Text);
            double error;

            int x1 = 0, y1 = 0;
            double x = 0, y = 0;
            Point firstPoint = new Point(x1, y1);
            Point secondPoint = new Point(x2, y2);
            int directionX = firstPoint.X < secondPoint.X ? 1 : -1;
            int directionY = firstPoint.Y < secondPoint.Y ? 1 : -1;

            int step = 5;

            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen pen2 = new Pen(Color.Red, 4);
            SolidBrush brush = new SolidBrush(Color.Green);

            double angle = Math.Atan(Math.Abs(y2 - y1) / (double)Math.Abs(x2 - x1)) * 180 / Math.PI;
            double dist = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
            double sin = Trigonometry.Sin(angle, N);
            double cos = Trigonometry.Cos(angle, N);
            Console.WriteLine(""+sin,cos);
            Graphics g = CreateGraphics();
            g.TranslateTransform(Width / 2 + 10, Height / 2 - 10);
            g.ScaleTransform(0.5f, 0.5f);
            g.DrawLine(pen, firstPoint, secondPoint);
            g.FillEllipse(brush, firstPoint.X - 20 , firstPoint.Y - 20 , 40, 40 );
            g.FillEllipse(brush, secondPoint.X - precision / 2, secondPoint.Y - precision / 2, precision * 2, precision * 2);
            while (dist > precision)
            {
                x += directionX * step * cos;
                y += directionY * step * sin;
                g.DrawEllipse(pen2, new Rectangle((int)x, (int)y, 1, 1));
                double prevDist = dist;
                dist = Math.Sqrt(Math.Pow(y2 - y, 2) + Math.Pow(x2 - x, 2));
                
                if (dist > prevDist)
                {
                    error = prevDist - precision / 2;
                    MessageBox.Show("Промах\nОшибка: " + error);
                    return;
                }
            }
            MessageBox.Show("Попадение");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            if (!string.IsNullOrEmpty(xLast.Text)& !string.IsNullOrEmpty(yLast.Text)& !string.IsNullOrEmpty(Precision.Text)& !string.IsNullOrEmpty(CountOf.Text))
            {
                WithAngle();
            }
            else MessageBox.Show("Должны быть заполнены все параметры!");
        }
    }
}
