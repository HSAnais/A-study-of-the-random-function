using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fluture_indragostit
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int dx, dy, sec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dx = dy = r.Next(30);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            int xnou, ynou;
            xnou = pictureBox1.Location.X + dx;
            ynou = pictureBox1.Location.Y + dy;
            if (xnou > this.Width - pictureBox1.Width)
                dx = -dx;
            if (ynou > this.Height - pictureBox1.Height)
                dy = -dy;
            if (xnou < 0)
                dx = -dx;
            if (ynou < 0)
                dy = -dy;
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("The butterfly found the flower in " + sec + " seconds");
            }
            pictureBox1.Location = new Point(xnou, ynou);
        }
    }
}
