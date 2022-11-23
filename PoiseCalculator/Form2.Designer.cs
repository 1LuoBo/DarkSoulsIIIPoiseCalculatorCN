
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PoiseCalculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "请输入韧性";
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "匕首类",
            "直剑类",
            "大剑类",
            "特大剑类",
            "曲剑类",
            "大曲剑类",
            "刺剑类",
            "太刀类",
            "斧类",
            "大斧类",
            "槌类",
            "大锤类",
            "枪类",
            "长枪类",
            "戟类",
            "镰刀类",
            "鞭类",
            "拳爪类",
            "钩爪类",
            "火把类",
            "弓箭类",
            "弩箭类",
            "魔法类",
            "咒术类",
            "奇迹类",
            "道具类"});
            this.comboBox1.Location = new System.Drawing.Point(12, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "请选择敌方武器类型";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_change);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "请选择敌方武器";
            this.comboBox2.SelectedValueChanged += new EventHandler(this.comboBox1_change);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.Text = "请选择敌方动作";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "展示削韧";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(196, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(592, 426);
            this.dataGridView1.TabIndex = 6;
            this.dr = new DataGridViewRow();
            this.dgvtbc1 = new DataGridViewTextBoxCell();
            this.dgvtbc1.Value = "0";
            this.dr.Cells.Add(dgvtbc1);
            this.dgvtbc2 = new DataGridViewTextBoxCell();
            this.dgvtbc2.Value = "0";
            this.dr.Cells.Add(dgvtbc2);
            this.dgvtbc3 = new DataGridViewTextBoxCell();
            this.dgvtbc3.Value = "100.00%";
            this.dr.Cells.Add(dgvtbc3);
            this.dr.ReadOnly = true;
            this.dataGridView1.Rows.Add(dr);
            this.dr = (DataGridViewRow)dr.Clone();
            this.dr.Cells[0].Value = "";
            this.dr.Cells[1].Value = "";
            this.dr.Cells[2].Value = "";
            this.dr.ReadOnly = false;
            this.dataGridView1.Rows.Add(dr);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_changed);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "削韧";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "武器韧性";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "强韧度";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 189);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "红色代表\n强韧度被打空为0\n并且被重置为100%";
            this.richTextBox1.SelectAll();
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox1.BackColor = Color.Red;
            this.richTextBox1.ReadOnly = true;

            this.textBox2.Location = new System.Drawing.Point(12, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 10;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "削韧展示在这里";
            this.textBox2.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form2";
            this.Text = "战斗模拟器";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Resize += new System.EventHandler(this.Form2_Resize);

        }


        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private string[] templist;
        private String temp;
        private List<string> dataSource = new List<string>();
        private DataGridViewColumn dgvc = new DataGridViewColumn();
        private Program.PoiseMeter poiseMeter;
        private bool shouldReset;
        private int length;
        private double poise;
        private DataGridViewRow dr = new DataGridViewRow();
        private DataGridViewTextBoxCell dgvtbc1 = new DataGridViewTextBoxCell();
        private DataGridViewTextBoxCell dgvtbc2 = new DataGridViewTextBoxCell();
        private DataGridViewTextBoxCell dgvtbc3 = new DataGridViewTextBoxCell();
        private System.Windows.Forms.TextBox textBox2;




        private void textBox1_KeyDown(object sender, KeyPressEventArgs e)
        {
            bool hasPoint = textBox1.Text.Contains(".");
            if (e.KeyChar == '.' && hasPoint)
                e.Handled = true;
            else if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == '.'))
                e.Handled = true;
            else e.Handled = false;
        }

        private void comboBox1_change(object sender, EventArgs e)
        {
            comboBox2.DataSource = Program.Global.Weapons[Program.Global.WeaponTypes.IndexOf(Program.Global.WeaponTypes[Program.Global.WeaTypeCh.IndexOf(comboBox1.Text)])];
            if (Program.Global.AxeActTypes.Contains(Program.Global.WeaponTypes[Program.Global.WeaTypeCh.IndexOf(comboBox1.Text)]))
                templist = Program.Global.AxeActions;
            else if (comboBox1.Text == "弓箭类")
                templist = new string[] { "正常发射", "强力射击", "法里斯三连射", "贯穿射击", "地面射击" };
            else if (comboBox1.Text == "弩箭类")
                templist = new string[] { "正常发射", "雅帆琳" };
            else if (comboBox1.Text == "道具类")
                templist = new string[] { "削韧", "溅射" };
            else if (comboBox1.Text == "咒术类")
                templist = new string[] { "子弹削韧", "溅射", "爆炸前", "爆炸", "残留", "投射物", "岩浆", "浮空火球", "附近" };
            else if (comboBox1.Text == "魔法类")
                templist = new string[] { "削韧" };
            else if (comboBox1.Text == "奇迹类")
                templist = new string[] { "削韧", "在水中", "溅射" };
            else if (comboBox1.Text == "" || comboBox1.Text == "请选择敌方武器种类")
                templist = null;
            else
                templist = Program.Global.NormActions;

            foreach (String a in templist)
            {
                int Position = Program.Global.WeaTypeCh.IndexOf(comboBox1.Text);
                int Position2 = Array.IndexOf(Program.Global.Weapons[Position], comboBox2.Text);
                temp = Program.Global.PoiseDmgs[Position].Rows[Position2][a].ToString();
                if (temp != "")
                    dataSource.Add(a);
            }
            comboBox3.DataSource = dataSource;
            dataSource = new List<string>();
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "请输入韧性")
            {
                textBox1.Text = "";
            }
        }

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox control;
        private double hit;
        private String tempstr;

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //只对TextBox类型的单元格进行验证
            if (e.Control.GetType().BaseType.Name == "TextBox")
            {
                control = new TextBox();
                control = (TextBox)e.Control;
                control.KeyPress += new KeyPressEventHandler(control_KeyPress);
            }
        }


        private void control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制只能输入-9的数字，退格键，小数点和回车
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                if (((TextBox)sender).Text.Contains(".") && e.KeyChar == '.')
                    e.Handled = true;
                else e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CalPoiMt(int i)
        {
            if (textBox1.Text == "" || textBox1.Text == "请输入韧性")
                return;
            for(int k = i; k<dataGridView1.RowCount-1; k++)
            {
                poise = System.Convert.ToDouble(textBox1.Text);
                if (dataGridView1.Rows[k].Cells[0].Value != null && dataGridView1.Rows[k - 1].Cells[2].Value.ToString() != "" && dataGridView1.Rows[k].Cells[0].Value.ToString() != "")
                {
                    Debug.WriteLine(dataGridView1.Rows[k - 1].Cells[2].Value.ToString());
                    length = dataGridView1.Rows[k].Cells[0].Value.ToString().Length;
                    tempstr = dataGridView1.Rows[k].Cells[0].Value.ToString();
                    Debug.WriteLine(length + tempstr);
                    if (tempstr[length - 1] == '.')
                        hit = System.Convert.ToDouble(tempstr.Substring(0, length - 1));
                    else hit = System.Convert.ToDouble(tempstr);
                    Debug.WriteLine(hit);
                    length = dataGridView1.Rows[k - 1].Cells[2].Value.ToString().Length;
                    poiseMeter = new Program.PoiseMeter(System.Convert.ToDouble(dataGridView1.Rows[k - 1].Cells[2].Value.ToString().Substring(0, length - 1)));
                    if (dataGridView1.Rows[k].Cells[1].Value.ToString() == "")
                        shouldReset = poiseMeter.getHit(hit, poise);
                    else
                        shouldReset = poiseMeter.getHit(hit, poise, System.Convert.ToDouble(dataGridView1.Rows[k].Cells[1].Value.ToString()));
                    if (!shouldReset)
                    {
                        dataGridView1.Rows[k].Cells[2].Value = poiseMeter.MtStr();
                        dataGridView1.Rows[k].Cells[2].Style.BackColor = dataGridView1.Rows[k].Cells[1].Style.BackColor;
                    }
                    else
                    {
                        dataGridView1.Rows[k].Cells[2].Value = "100.00%";
                        dataGridView1.Rows[k].Cells[2].Style.BackColor = Color.Red;
                    }
                    if (i == dataGridView1.RowCount - 2)
                    {
                        dr = (DataGridViewRow)dr.Clone();
                        dr.Cells[0].Value = "";
                        dr.Cells[1].Value = "";
                        dr.Cells[2].Value = "";
                        this.dataGridView1.Rows.Add(dr);
                        this.dataGridView1.Rows[i + 1].Cells[2].Style.BackColor = dataGridView1.Rows[i].Cells[0].Style.BackColor;
                    }
                }
                else
                {
                    dataGridView1.Rows[k].Cells[2].Value = "";
                    dataGridView1.Rows[k].Cells[2].Style.BackColor = dataGridView1.Rows[k].Cells[1].Style.BackColor;
                }
            }
        }

        private void dataGridView1_changed(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell != null)
            {
                CalPoiMt(((DataGridView)sender).CurrentCell.RowIndex);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.IndexOf(comboBox1.Text) != -1)
            {
                int Position = Program.Global.WeaTypeCh.IndexOf(comboBox1.Text);
                int Position2 = Array.IndexOf(Program.Global.Weapons[Position], comboBox2.Text);
                textBox2.Text = Program.Global.PoiseDmgs[Position].Rows[Position2][comboBox3.Text].ToString();
            }
        }

        private RichTextBox richTextBox1;
    }
}