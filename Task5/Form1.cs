using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }


        

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen1 = new Pen(Color.Brown, 3);

            SolidBrush brush = new SolidBrush(Color.Aqua);
            graph.FillRectangle(brush, 100, 200, 200, 230);
            graph.DrawRectangle(pen1, 100, 200, 200, 230);

            Point[] roofPoints =
            {
                new Point(100, 200),
                new Point(200, 100),
                new Point(300, 200)
            };
            graph.DrawPolygon(pen1, roofPoints);
             graph.FillPolygon(Brushes.LightGray, roofPoints);
            
            graph.FillRectangle(Brushes.LightSalmon, 230, 330, 50, 100);
            graph.DrawRectangle(pen1, 230, 330, 50, 100);

            graph.FillRectangle(Brushes.Blue, 243, 340, 25, 35);
            graph.DrawRectangle(pen1, 243, 340, 25, 35);
            
   
            graph.FillRectangle(Brushes.Blue, 120, 250, 75, 75);
            graph.DrawRectangle(pen1, 120, 250, 75, 75);

            graph.FillEllipse(Brushes.Blue, 170, 125, 60, 60);
            graph.DrawEllipse(pen1, 170, 125, 60, 60);

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
