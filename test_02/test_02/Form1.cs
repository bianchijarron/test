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


        private void button2_Click(object sender, EventArgs e)
        {
            currentShape = new Models.SinoCircle();
        }
        bool clicked = false;

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
                currentShape.draw_on(g);
                clicked = false;
                currentShape = null;
            }
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            currentShape = new Models.SinoLine();
        }
    }
}
