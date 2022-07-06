using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = pictureBox2.CreateGraphics();

        }
        Models.SinoShape currentShape;
        Graphics g;
        bool clicked = false;

        List<Models.SinoShape> shapes = new List<Models.SinoShape>();

        private void button2_Click(object sender, EventArgs e)
        {
            currentShape = new Models.SinoCircle();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.X.ToString() + "," + e.Y.ToString());

            if (currentShape == null)
            {
                MessageBox.Show("請選擇");
                return;
            }
            if (!clicked)
            {
                currentShape.location = e.Location;
                clicked = true;
            }
            else
            {
                currentShape.click_second(e.Location);
                //currentShape.draw_on(g);
                shapes.Add(currentShape);
                clicked = false;
                currentShape = null;
                refresh_picturebox();
            }
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            currentShape = new Models.SinoLine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentShape == null)
            {
                MessageBox.Show("請選擇圖型");
                return;
            }

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentShape.color = colorDialog1.Color;
            }
        }

        void refresh_picturebox()
        {
            g.Clear(Color.White);
            foreach(var shape in shapes)
            {
                shape.draw_on(g);
            }
        }

      private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                refresh_picturebox();
                currentShape.preview(g, e.Location);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (shape_index > shapes.Count - 1)
            {
                timer1.Stop();
                MessageBox.Show("動畫播放完畢");
            }
            shapes[shape_index].draw_on(g);
            shape_index++;
        }

        int shape_index = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            g.Clear(Color.White);
        }
    }
}
