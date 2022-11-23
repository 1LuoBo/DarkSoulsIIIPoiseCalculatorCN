using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoiseCalculator
{
    public partial class Form1 : Form
    {
        public Form1(String mywea, String myact, double mypoi)
        {
            InitializeComponent(mywea, myact, mypoi);
            Form1_Resize(this, null);
        }

        public Form1()
        {
            InitializeComponent();
            Form1_Resize(this, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int high = this.Height;
            int wide = this.Width;
            if (isCompared)
            {
                this.dataGridView1.Height = high - 50;
                this.dataGridView1.Width = wide * 4 / 5 - 1;
                this.richTextBox1.Height = high / 8 - 7;
                this.richTextBox2.Height = high / 4 - 14;
                this.richTextBox3.Height = high / 4 - 14;
                this.richTextBox4.Height = high / 4 - 14;
                this.richTextBox5.Height = high / 8 - 7;
                this.richTextBox1.Width = wide * 1 / 5 - 23;
                this.richTextBox2.Width = wide * 1 / 5 - 23;
                this.richTextBox3.Width = wide * 1 / 5 - 23;
                this.richTextBox4.Width = wide * 1 / 5 - 23;
                this.richTextBox5.Width = wide * 1 / 5 - 23;

                this.dataGridView1.Top = 5;
                this.dataGridView1.Left = 5;
                this.richTextBox1.Top = 5;
                this.richTextBox2.Top = this.richTextBox1.Top + high / 8 - 7;
                this.richTextBox3.Top = this.richTextBox2.Top + high / 4 - 14;
                this.richTextBox4.Top = this.richTextBox3.Top + high / 4 - 14;
                this.richTextBox5.Top = this.richTextBox4.Top + high / 4 - 14;
                this.richTextBox1.Left = wide * 4 / 5 + 5;
                this.richTextBox2.Left = wide * 4 / 5 + 5;
                this.richTextBox3.Left = wide * 4 / 5 + 5;
                this.richTextBox4.Left = wide * 4 / 5 + 5;
                this.richTextBox5.Left = wide * 4 / 5 + 5;
            }
            else
            {
                this.dataGridView1.Height = high - 50;
                this.dataGridView1.Width = wide - 20;

                this.dataGridView1.Top = 5;
                this.dataGridView1.Left = 5;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
