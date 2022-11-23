
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace PoiseCalculator
{
    partial class Form1
    {
        bool isCompared;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        


        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent(String mywea, String myact, double mypoi)
        {
            isCompared = true;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(676, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(694, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 44);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "完全不能拼";
            this.richTextBox1.BackColor = Color.Red;
            this.richTextBox1.SelectAll();
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox1.ReadOnly = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(694, 63);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 44);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "能拼一次/\n在两段削韧攻击都吃的情况下能拼一次";
            this.richTextBox2.BackColor = Color.Yellow;
            this.richTextBox2.SelectAll();
            this.richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox2.ReadOnly = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(694, 113);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 44);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "该攻击存在两段攻击，并且\n在仅吃较高数值削韧攻击的情况下能拼一次";
            this.richTextBox3.BackColor = Color.Orange;
            this.richTextBox3.SelectAll();
            this.richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox3.ReadOnly = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(694, 163);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(100, 44);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "该攻击存在两段攻击，并且\n在仅吃较低数值大削韧攻击的情况下能拼一次";
            this.richTextBox4.BackColor = Color.LightBlue;
            this.richTextBox4.SelectAll();
            this.richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox4.ReadOnly = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(694, 213);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(100, 44);
            this.richTextBox5.TabIndex = 5;
            this.richTextBox5.Text = "能一直拼";
            this.richTextBox5.BackColor = Color.LightGreen;
            this.richTextBox5.SelectAll();
            this.richTextBox5.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox5.ReadOnly = true;
            //this.dataGridView1.DataSource = Program.Global.bigDT;
            poise = new Program.Poise(mywea, myact, mypoi);
            tempstr = "";
            for (int i = 1; i <= 42; i++)
            {
                this.dataGridView1.Columns.Add(i.ToString(), i.ToString());
            }

            foreach(DataRow dr in Program.Global.bigDT.Rows)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                dataGridView1.Rows.Add(dr.ItemArray);
                
            }
            
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                {
                //Debug.WriteLine("a");
                foreach (DataGridViewCell dc in dr.Cells){
                    if (dc.Value != null)
                        tempstr = dc.Value.ToString();
                    columnIndex = dc.ColumnIndex;
                    if (Program.Global.WeaTypeCh.Contains(tempstr))
                        weatype = tempstr;
                    else if (Regex.IsMatch(tempstr, @"^\d*[.]?\d*(\s\d*[.]?\d*)?$") && tempstr != " " && tempstr != "")
                    {
                        //                      if (...)
                        //	...（此处解决columnIndex）
                        //if(dr.Cells[0].Value.ToString() == "月光大剑")Debug.WriteLine(tempstr);
                        poisedmg = new Program.PoiseDmg(weatype, dr.Cells[0].Value.ToString(), columnIndex);
                        colour = poisedmg.CompareToPoise(poise);
                        dc.Style.BackColor = colour;
                        
                    }
                }
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "削韧表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            

            this.Text = "削韧表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void InitializeComponent()
        {
            isCompared = false;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(676, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSource = Program.Global.bigDT;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "削韧表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.DataGridView dataGridView1;
        private String tempstr;
        private Program.Poise poise;
        private String weatype;
        private Color colour;
        private Program.PoiseDmg poisedmg;
        private int columnIndex;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
    }
}

