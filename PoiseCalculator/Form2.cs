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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form2_Resize(this, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            int high = this.Height;
            int wide = this.Width;

            this.textBox1.Height = high / 9 - 10;
            this.comboBox1.Height = high / 9 - 10;
            this.comboBox2.Height = high / 9 - 10;
            this.comboBox3.Height = high / 9 - 10;
            this.button2.Height = high / 9 - 10;
            this.richTextBox1.Height = 2 * high / 9 - 10;
            this.textBox2.Height = high / 9 - 10;
            this.textBox1.Width = wide / 4 - 10;
            this.comboBox1.Width = wide / 4 - 10;
            this.comboBox2.Width = wide / 4 - 10;
            this.comboBox3.Width = wide / 4 - 10;
            this.button2.Width = wide / 4 - 10;
            this.richTextBox1.Width = wide / 4 - 10;
            this.textBox2.Width = wide / 4 - 10;

            this.dataGridView1.Height = high - 50;
            this.dataGridView1.Width = 3 * wide / 4 - 20;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.textBox1.Top = 5;
            this.comboBox1.Top = textBox1.Top + high / 9;
            this.comboBox2.Top = textBox1.Top + 2 * high / 9;
            this.comboBox3.Top = textBox1.Top + 3 * high / 9;
            this.button2.Top = textBox1.Top + 4 * high / 9;
            this.richTextBox1.Top = textBox1.Top + 5 * high / 9;
            this.textBox2.Top = textBox1.Top + 7 * high / 9;

            this.textBox1.Left = 5;
            this.comboBox1.Left = 5;
            this.comboBox2.Left = 5;
            this.comboBox3.Left = 5;
            this.button2.Left = 5;
            this.richTextBox1.Left = 5;
            this.textBox2.Left = 5;

            this.dataGridView1.Top = 5;
            this.dataGridView1.Left = wide / 4;


        }
    }
}
