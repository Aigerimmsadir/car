using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image imager = Image.FromFile(@"C:\Users\Lenovo\Pictures\right1.jpg");
        Image imagel = Image.FromFile(@"C:\Users\Lenovo\Pictures\left.jpg");
        Image imaged = Image.FromFile(@"C:\Users\Lenovo\Pictures\down.jpg");
        Image imageu = Image.FromFile(@"C:\Users\Lenovo\Pictures\up.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        int x=30, y=30;
        Pen pen = new Pen(Color.Blue);
        private Position carposition = Position.Down;

        enum Position
        {
            Left,Right,Up,Down
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(carposition==Position.Right) x = x + 5;
            if (carposition == Position.Left) x = x - 5;
            if (carposition == Position.Up) y = y - 5;
            if (carposition == Position.Down) y = y + 5; 
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) carposition = Position.Left;
            if(e.KeyCode == Keys.Right) carposition = Position.Right;
            if(e.KeyCode == Keys.Up) carposition = Position.Up;
            if(e.KeyCode == Keys.Down) carposition = Position.Down;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ///  e.Graphics.FillEllipse(pen.Brush, x, y, 30, 30);
           if(carposition ==Position.Right) e.Graphics.DrawImage(imager, x, y);
           if(carposition == Position.Left) e.Graphics.DrawImage(imagel, x, y);
           if(carposition == Position.Up) e.Graphics.DrawImage(imageu, x, y);
            if (carposition == Position.Down) e.Graphics.DrawImage(imaged, x, y);
        }
    }
}
