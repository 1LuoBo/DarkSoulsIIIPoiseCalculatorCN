using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PoiseCalculator
{
    partial class Main
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
            this.EnemyWeaponType = new System.Windows.Forms.ComboBox();
            this.EnemyAttack = new System.Windows.Forms.ComboBox();
            this.MyWeapon = new System.Windows.Forms.ComboBox();
            this.MyAttack = new System.Windows.Forms.ComboBox();
            this.CalPoise = new System.Windows.Forms.Button();
            this.MyWea = new System.Windows.Forms.ComboBox();
            this.MyAct = new System.Windows.Forms.ComboBox();
            this.MyPoi = new System.Windows.Forms.TextBox();
            this.PoiResults = new System.Windows.Forms.RichTextBox();
            this.DmgResult = new System.Windows.Forms.RichTextBox();
            this.CalDmg = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EnemyWeapon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EnemyWeaponType
            // 
            this.EnemyWeaponType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyWeaponType.Items.AddRange(new object[] {
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
            this.EnemyWeaponType.Location = new System.Drawing.Point(83, 54);
            this.EnemyWeaponType.Name = "EnemyWeaponType";
            this.EnemyWeaponType.Text = "请选择敌方武器种类";
            this.EnemyWeaponType.Size = new System.Drawing.Size(121, 23);
            this.EnemyWeaponType.TabIndex = 0;
            this.EnemyWeaponType.SelectedValueChanged += new System.EventHandler(this.EnemyWeaponType_SelectedValueChanged);
            // 
            // EnemyAttack
            // 
            this.EnemyAttack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyAttack.Items.AddRange(new object[] {
            "单持R1a",
            "单持R1b",
            "单持R1c",
            "单持R2a",
            "单持R2b",
            "满蓄单持R2a",
            "满蓄单持R2b",
            "单持滚攻",
            "单持跑攻",
            "单持跳跃攻击",
            "双持R1a",
            "双持R1b",
            "双持R1c",
            "双持R2a",
            "双持R2b",
            "满蓄双持R2a",
            "满蓄双持R2b",
            "双持滚攻",
            "双持跑攻",
            "双持跳跃攻击",
            "踢技",
            "战技1",
            "战技2",
            "战技3",
            "战技4",
            "箭步R1a",
            "箭步R1b",
            "箭步R2a",
            "箭步R2b",
            "战技子弹",
            "L1a",
            "L1b",
            "L1c",
            "成对武器滚攻",
            "成对武器跑攻"});
            this.EnemyAttack.Location = new System.Drawing.Point(83, 112);
            this.EnemyAttack.Name = "EnemyAttack";
            this.EnemyAttack.Text = "请选择敌方攻击";
            this.EnemyAttack.Size = new System.Drawing.Size(121, 23);
            this.EnemyAttack.TabIndex = 1;
            this.EnemyAttack.SelectedIndexChanged += new System.EventHandler(this.EnemyAttack_SelectedIndexChanged);
            // 
            // MyWeapon
            // 
            this.MyWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeapon.Items.AddRange(new object[] {
            "斧类",
            "十字弩",
            "大曲剑类",
            "曲剑类",
            "匕首类",
            "拳套&爪",
            "巨斧类",
            "大锤类",
            "大盾类",
            "大剑类",
            "竖劈戟类",
            "锤&幽魂火把",
            "太刀类",
            "杂项",
            "刺剑类",
            "镰刀类",
            "枪类",
            "直剑类",
            "护符类",
            "突刺戟",
            "特大剑类",
            "鞭类"});
            this.MyWeapon.Location = new System.Drawing.Point(83, 141);
            this.MyWeapon.Name = "MyWeapon";
            this.MyWeapon.Text = "请选择你的武器种类";
            this.MyWeapon.Size = new System.Drawing.Size(121, 23);
            this.MyWeapon.TabIndex = 2;
            this.MyWeapon.SelectedValueChanged += new System.EventHandler(this.MyWeaChanged);
            // 
            // MyAttack
            // 
            this.MyAttack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyAttack.FormattingEnabled = true;
            this.MyAttack.Location = new System.Drawing.Point(83, 170);
            this.MyAttack.Name = "MyAttack";
            this.MyAttack.Text = "请选择你的攻击";
            this.MyAttack.Size = new System.Drawing.Size(121, 23);
            this.MyAttack.TabIndex = 3;
            // 
            // CalPoise
            // 
            this.CalPoise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalPoise.Location = new System.Drawing.Point(83, 229);
            this.CalPoise.Name = "CalPoise";
            this.CalPoise.Size = new System.Drawing.Size(75, 23);
            this.CalPoise.TabIndex = 4;
            this.CalPoise.Text = "计算";
            this.CalPoise.UseVisualStyleBackColor = true;
            this.CalPoise.Click += new System.EventHandler(this.PoiseCal);
            // 
            // MyWea
            // 
            this.MyWea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWea.Items.AddRange(new object[] {
            "斧类",
            "十字弩",
            "大曲剑类",
            "曲剑类",
            "匕首类",
            "拳套&爪",
            "巨斧类",
            "大锤类",
            "大盾类",
            "大剑类",
            "竖劈戟类",
            "锤&幽魂火把",
            "太刀类",
            "杂项",
            "刺剑类",
            "镰刀类",
            "枪类",
            "直剑类",
            "护符类",
            "突刺戟",
            "特大剑类",
            "鞭类"});
            this.MyWea.Location = new System.Drawing.Point(512, 53);
            this.MyWea.Name = "MyWea";
            this.MyWea.Text = "请选择你的武器种类";
            this.MyWea.Size = new System.Drawing.Size(121, 23);
            this.MyWea.TabIndex = 8;
            this.MyWea.SelectedValueChanged += new System.EventHandler(this.MyWea_SelectedValueChanged);
            // 
            // MyAct
            // 
            this.MyAct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyAct.FormattingEnabled = true;
            this.MyAct.Location = new System.Drawing.Point(512, 82);
            this.MyAct.Name = "MyAct";
            this.MyAct.Text = "请选择你的动作";
            this.MyAct.Size = new System.Drawing.Size(121, 23);
            this.MyAct.TabIndex = 9;
            // 
            // MyPoi
            // 
            this.MyPoi.AcceptsReturn = true;
            this.MyPoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyPoi.Location = new System.Drawing.Point(532, 109);
            this.MyPoi.Name = "MyPoi";
            this.MyPoi.Text = "请输入韧性";
            this.MyPoi.GotFocus += new System.EventHandler(this.MyPoi_GotFocus);
            this.MyPoi.Size = new System.Drawing.Size(100, 25);
            this.MyPoi.TabIndex = 10;
            this.MyPoi.TextChanged += new System.EventHandler(this.MyPoi_TextChanged);
            this.MyPoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyPoi_KeyPress);
            this.MyPoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyPoi_KeyDown);
            // 
            // PoiResults
            // 
            this.PoiResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoiResults.Location = new System.Drawing.Point(83, 281);
            this.PoiResults.Name = "PoiResults";
            this.PoiResults.Size = new System.Drawing.Size(100, 96);
            this.PoiResults.TabIndex = 11;
            this.PoiResults.Text = "你需要最少  的强韧度才能与对方拼一次，最少  的强韧度才能与对方一直拼";
            // 
            // DmgResult
            // 
            this.DmgResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DmgResult.Location = new System.Drawing.Point(512, 168);
            this.DmgResult.Name = "DmgResult";
            this.DmgResult.Size = new System.Drawing.Size(120, 25);
            this.DmgResult.TabIndex = 12;
            this.DmgResult.Text = "你能和最高   削韧的武器一直拼，和最高   削韧的武器拼一次";
            // 
            // CalDmg
            // 
            this.CalDmg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalDmg.Location = new System.Drawing.Point(512, 141);
            this.CalDmg.Name = "CalDmg";
            this.CalDmg.Size = new System.Drawing.Size(75, 23);
            this.CalDmg.TabIndex = 13;
            this.CalDmg.Text = "计算";
            this.CalDmg.UseVisualStyleBackColor = true;
            this.CalDmg.Click += new System.EventHandler(this.CalDmg_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(512, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "展示完整削韧表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(512, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "战斗模拟器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // EnemyWeapon
            // 
            this.EnemyWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyWeapon.FormattingEnabled = true;
            this.EnemyWeapon.Location = new System.Drawing.Point(83, 83);
            this.EnemyWeapon.Name = "EnemyWeapon";
            this.EnemyWeapon.Text = "请选择敌方武器";
            this.EnemyWeapon.Size = new System.Drawing.Size(121, 23);
            this.EnemyWeapon.TabIndex = 16;
            this.EnemyWeapon.SelectedValueChanged += new System.EventHandler(this.EnemyWeaponType_SelectedValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnemyWeapon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CalDmg);
            this.Controls.Add(this.DmgResult);
            this.Controls.Add(this.PoiResults);
            this.Controls.Add(this.MyPoi);
            this.Controls.Add(this.MyAct);
            this.Controls.Add(this.MyWea);
            this.Controls.Add(this.CalPoise);
            this.Controls.Add(this.MyAttack);
            this.Controls.Add(this.MyWeapon);
            this.Controls.Add(this.EnemyAttack);
            this.Controls.Add(this.EnemyWeaponType);
            this.Name = "Main";
            this.Text = "黑暗之魂3韧性计算器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox EnemyWeaponType;
        private System.Windows.Forms.ComboBox EnemyAttack;
        private System.Windows.Forms.ComboBox MyWeapon;
        private System.Windows.Forms.ComboBox MyAttack;
        private System.Windows.Forms.Button CalPoise;
        public System.Windows.Forms.ComboBox MyWea;
        public System.Windows.Forms.ComboBox MyAct;
        public System.Windows.Forms.TextBox MyPoi;
        private System.Windows.Forms.RichTextBox PoiResults;
        private System.Windows.Forms.RichTextBox DmgResult;
        private System.Windows.Forms.Button CalDmg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private double oneP;
        private double onceO;
        private double onceT;
        private double onceA;
        private double moreP;
        private double moreA;
        private Program.PoiseDmg poisedmg;
        private Program.Poise poise;
        private String temp;
        private double poi;
        private string[] templist;
        private List<String> dataSource = new List<String>();

        private void EnemyWeaponType_SelectedValueChanged(object sender, EventArgs e)
        {
            EnemyWeapon.DataSource = Program.Global.Weapons[Program.Global.WeaponTypes.IndexOf(Program.Global.WeaponTypes[Program.Global.WeaTypeCh.IndexOf(EnemyWeaponType.Text)])];
            if (Program.Global.AxeActTypes.Contains(Program.Global.WeaponTypes[Program.Global.WeaTypeCh.IndexOf(EnemyWeaponType.Text)]))
                templist = Program.Global.AxeActions;
            else if (EnemyWeaponType.Text == "弓箭类")
                templist = new string[] { "正常发射", "强力射击", "法里斯三连射", "贯穿射击", "地面射击" };
            else if (EnemyWeaponType.Text == "弩箭类")
                templist = new string[] { "正常发射", "雅帆琳" };
            else if (EnemyWeaponType.Text == "道具类")
                templist = new string[] { "削韧", "溅射" };
            else if (EnemyWeaponType.Text == "咒术类")
                templist = new string[] { "子弹削韧", "溅射", "爆炸前", "爆炸", "残留", "投射物", "岩浆", "浮空火球", "附近" };
            else if (EnemyWeaponType.Text == "魔法类")
                templist = new string[] { "削韧" };
            else if (EnemyWeaponType.Text == "奇迹类")
                templist = new string[] { "削韧", "在水中", "溅射" };
            else if (EnemyWeaponType.Text == "" || EnemyWeaponType.Text == "请选择敌方武器种类")
                templist = null;
            else
                templist = Program.Global.NormActions;

            foreach (String a in templist)
            {
                int Position = Program.Global.WeaTypeCh.IndexOf(EnemyWeaponType.Text);
                int Position2 = Array.IndexOf(Program.Global.Weapons[Position], EnemyWeapon.Text);
                temp = Program.Global.PoiseDmgs[Position].Rows[Position2][a].ToString();
                if (temp != "")
                    dataSource.Add(a);
            }
            EnemyAttack.DataSource = dataSource;
            dataSource = new List<string>();
        }

        

        private void MyWeaChanged(object sender, EventArgs e)
        {
            this.MyAttack.DataSource = Program.Global.PoiseActions[Program.Global.PoiTypeCh.IndexOf(MyWeapon.Text)];
        }

        private void PoiseCal(object sender, EventArgs e)
        {
            if (this.MyWeapon.Text == "" || this.EnemyWeaponType.Text == "" || this.MyWeapon.Text == "请选择你的武器种类" || this.EnemyWeaponType.Text == "请选择敌方武器种类")
            {
                this.PoiResults.Text = "兄啊你总得先选个武器动作我才能帮你算吧";
                return;
            }
            else if (!Program.Global.WeaTypeCh.Contains(EnemyWeaponType.Text) || !((String[])EnemyWeapon.DataSource).ToList().Contains(EnemyWeapon.Text) || !((List<string>)EnemyAttack.DataSource).Contains(EnemyAttack.Text) || !Program.Global.PoiTypeCh.Contains(MyWeapon.Text) || !((string[])MyAttack.DataSource).ToList().Contains(MyAttack.Text))
            {
                this.PoiResults.Text = "亲亲，这边建议用下拉框捏";
                return;
            }
            int Position = Program.Global.WeaTypeCh.IndexOf(EnemyWeaponType.Text);
            int Position2 = Array.IndexOf(Program.Global.Weapons[Position], EnemyWeapon.Text);
            temp = Program.Global.PoiseDmgs[Position].Rows[Position2][EnemyAttack.Text].ToString();
            if (temp == "")
                this.PoiResults.Text = "无效的敌方攻击输入";
            else
            {
                poisedmg = new Program.PoiseDmg(Program.Global.WeaponTypes[Program.Global.WeaTypeCh.IndexOf(EnemyWeaponType.Text)], this.EnemyWeapon.Text, this.EnemyAttack.Text, Program.Global.PoiseTypes[Program.Global.PoiTypeCh.IndexOf(MyWeapon.Text)], this.MyAttack.Text);
                if (poisedmg.DmgType == "OneDmg")
                {
                    if (MyWeapon.Text == "护符类")
                        this.PoiResults.Text = "你可以承受对方" + poisedmg.PrayerHits() + "次攻击";
                    else
                    {
                        oneP = Math.Round(poisedmg.OnePoise(), 2);
                        moreP = Math.Round(poisedmg.MorePoise(), 2);
                        this.PoiResults.Text = "你需要最少" + oneP + "的强韧度才能与对方拼一次，最少" + moreP + "的强韧度才能与对方一直拼";
                    }

                }
                else
                {
                    onceO = Math.Round(poisedmg.OnceOne(), 2);
                    onceT = Math.Round(poisedmg.OnceTwo(), 2);
                    onceA = Math.Round(poisedmg.OnceAll(), 2);
                    moreA = Math.Round(poisedmg.MoreAll(), 2);
                    moreP = Math.Round(poisedmg.MorePoise(), 2);
                    if (poisedmg.DmgType == "twoDmgs")
                        if (MyWeapon.Text == "护符类")
                            this.PoiResults.Text = poisedmg.PrayerO() + "承受一次对方第一段攻击\n" + poisedmg.PrayerT() + "承受一次对方第二段攻击\n" + "在两段攻击都吃的情况下，" + poisedmg.PrayerA();
                        else this.PoiResults.Text = "你需要" + onceO + "的强韧度与对方第一段拼一次\n" + onceT + "的强韧度与对方第二段拼一次\n" + onceA + "的强韧度与对方两段都拼\n" + moreA + "的强韧度与对方一直拼";
                    else if (poisedmg.DmgType == "bulletDmg")
                        if (MyWeapon.Text == "护符类")
                            this.PoiResults.Text = poisedmg.PrayerO() + "承受对方武器的攻击\n" + poisedmg.PrayerT() + "承受对方特效子弹的攻击\n" + "在武器与子弹全吃的情况下" + poisedmg.PrayerA();
                        else this.PoiResults.Text = "你需要" + onceO + "的强韧度与对方武器拼一次\n" + onceT + "的强韧度与对方特效子弹拼一次\n" + onceA + "的强韧度与对方子弹武器都拼\n" + moreA + "的强韧度在子弹武器全吃的情况下一直拼\n" + moreP + "的强韧度与对方武器一直拼";
                    else if (poisedmg.DmgType == "splashDmg")
                        if (MyWeapon.Text == "护符类")
                            this.PoiResults.Text = poisedmg.PrayerO() + "承受对方武器的攻击\n" + poisedmg.PrayerT() + "承受对方震荡波的削韧\n" + "可以承受" + poisedmg.PrayerHits() + "次对方武器攻击";
                        else this.PoiResults.Text = "你需要" + onceO + "的强韧度与对方武器拼一次\n" + onceT + "的强韧度与对方溅射伤害拼一次\n" + moreP + "的强韧度与对方武器一直拼";
                    else
                        if (MyWeapon.Text == "护符类")
                        this.PoiResults.Text = poisedmg.PrayerO() + "承受对方特效子弹的一次攻击\n" + poisedmg.PrayerT() + "承受对方落雷的一次攻击\n" + "在子弹落雷全吃的情况下，" + poisedmg.PrayerA();
                    else this.PoiResults.Text = "你需要" + onceO + "的强韧度与对方特效子弹拼一次\n" + onceT + "的强韧度与对方落雷拼一次\n" + onceA + "在子弹落雷都吃的情况下拼一次\n" + moreP + "在子弹落雷都吃的情况下一直拼";
                }

            }

        }

        private void MyWea_SelectedValueChanged(object sender, EventArgs e)
        {
            MyAct.DataSource = Program.Global.PoiseActions[Program.Global.PoiTypeCh.IndexOf(MyWea.Text)];
        }

        private System.Windows.Forms.ComboBox EnemyWeapon;

        private void CalDmg_Click(object sender, EventArgs e)
        {
            if (this.MyPoi.Text == "" || this.MyWea.Text == "" || this.MyAct.Text == "" || this.MyPoi.Text == "请输入韧性" || this.MyWea.Text == "请输入你的武器种类")
                DmgResult.Text = "至少一个输入框为空，请先选择武器动作/填写韧性";
            else if (!Program.Global.PoiTypeCh.Contains(MyWea.Text) || !((string[])MyAct.DataSource).ToList().Contains(MyAct.Text))
                DmgResult.Text = "亲亲，这边建议用下拉框捏";
            else
            {
                poi = double.Parse(MyPoi.Text);
                poise = new Program.Poise(Program.Global.PoiseTypes[Program.Global.PoiTypeCh.IndexOf(MyWea.Text)], MyAct.Text, poi);
                DmgResult.Text = "你可以承受" + poise.OneTrade + "削韧的一次攻击\n" + "可以承受" + poise.MoreTrade + "削韧的一直攻击";
            }

        }

        private void MyPoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.CalDmg_Click(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1;
            if (MyWea.Text == "" || MyPoi.Text == "" || MyWea.Text == "请选择你的武器种类" || !Program.Global.PoiTypeCh.Contains(MyWea.Text) || !((string[])MyAct.DataSource).ToList().Contains(MyAct.Text))
            {
                form1 = new Form1();
            }
            else form1 = new Form1(Program.Global.PoiseTypes[Program.Global.PoiTypeCh.IndexOf(MyWea.Text)], MyAct.Text, double.Parse(MyPoi.Text));
            //Debug.WriteLine("a");
            form1.ShowDialog();
        }

        private void MyPoi_GotFocus(object sender, EventArgs e)
        {
            if (MyPoi.Text == "请输入韧性")
            {
                this.MyPoi.Text = "";
            }
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}