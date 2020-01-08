using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int general = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int corn,water,tea,ticket,total;
            corn = Convert.ToInt16(textBox1.Text);
            water = Convert.ToInt16(textBox2.Text);
            tea = Convert.ToInt16(textBox3.Text);
            ticket = Convert.ToInt16(textBox4.Text);

            total = corn * 4 + water * 2 + tea * 3 + ticket * 7;
            label10.Text = total.ToString() + " AZN";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();

            general = general + total;
            label12.Text = general.ToString() + " AZN";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
