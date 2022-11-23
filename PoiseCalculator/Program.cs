using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace PoiseCalculator
{

    static class Program
    {
        
        public class Global
        {
            public static String[][] Weapons = new string[26][];//每个数组存储一个武器类型的所有武器
            public static DataTable[] PoiseDmgs = new DataTable[26];//一个DataTable是一个类型武器的削韧表
            public static String[][] PoiseActions = new string[22][];
            public static DataTable[] Poises = new DataTable[22];
            public static String[] NormActions = {"单持R1a", "单持R1b", "单持R1c", "单持R2a", "单持R2b", "满蓄单持R2a", "满蓄单持R2b", "单持滚攻", "单持跑攻",
                "单持跳跃攻击", "双持R1a", "双持R1b", "双持R1c", "双持R2a", "双持R2b", "满蓄双持R2a", "满蓄双持R2b", "双持滚攻", "双持跑攻", 
                "双持跳跃攻击", "踢技", "战技1", "战技2", "战技3", "战技4", "箭步R1a", "箭步R1b", "箭步R2a", "箭步R2b", "战技子弹",
                "L1a", "L1b", "L1c", "成对武器滚攻", "成对武器跑攻"};
            public static String[] AxeActions = {"单持R1a", "单持R1b", "单持R1c", "单持R2a", "单持R2b", "满蓄单持R2a", "满蓄单持R2b", "单持滚攻", "单持跑攻",
                "单持跳跃攻击", "双持R1a", "双持R1b", "双持R1c", "双持R2a", "双持R2b", "满蓄双持R2a", "满蓄双持R2b", "双持滚攻", "双持跑攻",
                "双持跳跃攻击", "踢技", "战吼单持R2", "满蓄战吼单持R2", "战吼双持R2", "满蓄战吼双持R2", "箭步R1a", "箭步R1b", "箭步R2a", "箭步R2b", "战技子弹",
                "L1a", "L1b", "L1c", "成对武器滚攻", "成对武器跑攻"};
            public static List<String> AxeActTypes = new List<string> { "Axes", "Greataxes", "Hammers", "Great Hammers" };
            public static List<String> WeaTypeCh = new List<string> { "匕首类", "直剑类", "大剑类", "特大剑类", "曲剑类", "大曲剑类", "刺剑类", "太刀类", "斧类",
                "大斧类", "槌类", "大锤类", "枪类", "长枪类", "戟类", "镰刀类", "鞭类", "拳爪类", "钩爪类", "火把类", "弓箭类", "弩箭类", "魔法类", "咒术类", "奇迹类", "道具类"};
            public static List<String> WeaponTypes = new List<string> {"Daggers", "Straight Swords", "Greatswords", "Ultra Greatswords", "Curved Swords",
                "Curved Greatswords", "Thrusting Swords", "Katanas", "Axes", "Greataxes", "Hammers", "Great Hammers", "Spears", "Pikes",
                "Halberds", "Reapers", "Whips", "Fists", "Claws", "Torches", "Arrows", "Bolts", "Sorcery", "Pyromancy", "Miracles", "Items" };
            //所有武器类型
            public static List<String> PoiTypeCh = new List<string> { "斧类", "十字弩", "大曲剑类", "曲剑类", "匕首类", "拳套&爪", "巨斧类", "大锤类", "大盾类", 
                "大剑类", "竖劈戟类", "锤&幽魂火把", "太刀类", "杂项", "刺剑类", "镰刀类", "枪类", "直剑类", "护符类", "突刺戟", "特大剑类", "鞭类"};
            public static List<String> PoiseTypes = new List<string> { "Axes", "Crossbows", "Curved Greatswords", "Curved Swords", "Daggers", "Fists & Claws",
                "Greataxes", "Greathammers", "Greatshields", "Greatswords", "Halberds", "Hammers & Follower Torch", "Katanas", "Misc",
                "Rapiers", "Reapers", "Spears", "Straight Swords", "Talisman", "Thrusting Halberds", "Ultra Greatswords", "Whips"};
            //所有韧性类型
            public static String[] twoDmgs = { "成对山贼短刀", "歌德希尔特对剑", "果敢心", "法兰大剑", "教宗骑士曲剑", "绘画使者曲剑",
                "咕噜腐败曲刀", "短弯刀", "鸦羽", "鬼切与姥断", "黑骑士大斧", "巨斧", "尤姆大柴刀", "羽翼骑士断头斧", "棍棒", "强化棍棒",
                "多兰对槌", "大型棍棒", "巨型棍棒", "多兰对枪", "红柄戟", "戟", "剑刃戟", "弦月斧", "羽翼骑士戟", "黑骑士剑刃戟", "古达的戟",
                "护手带", "恶魔指虎", "钩爪", "傀儡钩爪", "鸦爪", "黑骑士大剑", "佣兵对刀", "守墓人对刀", "成对舞娘魔剑" };
            public static String[] bulletDmg = { "月光大剑" };
            public static String[] splashDmg = { "猎龙大斧" };
            public static String[] twoBulDmg = { "猎龙枪" };
            public static DataTable bigDT = new DataTable();
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            CSVReader csvreader = new CSVReader();
            
            DataTable PoiseDmgDT;
            DataTable PoiseDT;
            CSVReader.readCSV("PoiseDmg\\PoiseDmg.csv", out Global.bigDT, true);

            int i = 0;
            foreach (String WeaponType in Global.WeaponTypes)
            {
                CSVReader.readCSV("PoiseDmg\\" + WeaponType +".csv", out PoiseDmgDT, true);
                //MessageBox.Show(PoiseDmgDT.Rows[1][0].ToString());
                Global.PoiseDmgs[i] = PoiseDmgDT;
                i++;
            }
            i = 0;
            
            foreach (String Poise in Global.PoiseTypes)
            {
                CSVReader.readCSV("Poise\\" + Poise + ".csv", out PoiseDT, true);
                Global.Poises[i] = PoiseDT;
                i++;
            }
            i = 0;

            List<String> temp;
            foreach (String WeaponType in Global.WeaponTypes)
            {
                DataTable dt = Global.PoiseDmgs[i];
                Global.Weapons[i] = new string[0];
                temp = Global.Weapons[i].ToList<String>();
                foreach (DataRow dr in dt.Rows)
                {
                    temp.Add(dr[0].ToString());
                }
                Global.Weapons[i] = temp.ToArray();
                //MessageBox.Show(Weapons[i][0]);
                i++;
            }
            i = 0;

            foreach(String poise in Global.PoiseTypes)
            {
                DataTable dt = Global.Poises[i];
                Global.PoiseActions[i] = new string[0];
                temp = Global.PoiseActions[i].ToList<String>();
                foreach (DataRow dr in dt.Rows)
                {
                    temp.Add(dr[0].ToString());
                }
                Global.PoiseActions[i] = temp.ToArray();
                //MessageBox.Show(Global.PoiseActions[i][0]);
                i++;
            }


            //Poise ap = new Poise("Daggers", "滑步", 12);
            //MessageBox.Show(ap.OneTrade.ToString());

            //PoiseDmg bp = new PoiseDmg("Greataxes", "巨斧", "战吼单持R2", "Daggers", "滑步");
            //MessageBox.Show(bp.DmgType);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public class Poise {
            double PoiseVal;
            int PoisePer = 100;
            public double WeaPoise;
            double maxdmg;
            public double OneTrade;
            public double MoreTrade;
            String[] poisetypes = Global.PoiseTypes.ToArray();

            public Poise(String weatype, String poiseact, double poiseval, int poiseper){
                PoisePer = poiseper;
                PoiseVal = poiseval;
                WeaPoise = double.Parse(Global.Poises[Array.IndexOf(poisetypes, weatype)].Rows[Array.IndexOf(Global.PoiseActions[Array.IndexOf(poisetypes, weatype)], poiseact)][1].ToString());


                //拼一次
                if (PoisePer < 80) maxdmg =  0.8 * WeaPoise / (1 - PoiseVal / 100);
                else maxdmg = PoisePer *  0.01 * WeaPoise / (1 - PoiseVal / 100);
                if (maxdmg < 0) OneTrade = 0;
                else OneTrade = Math.Round(maxdmg, 1);

                //无限拼
                maxdmg =  0.8 * WeaPoise / (1 - PoiseVal / 100);
                if (maxdmg < 0) MoreTrade = 0;
                else MoreTrade = Math.Round(maxdmg, 1);

            }
            
            public Poise(String weatype, String poiseact, double poiseval)
            {
                PoiseVal = poiseval;
                WeaPoise = double.Parse(Global.Poises[Array.IndexOf(poisetypes, weatype)].Rows[Array.IndexOf(Global.PoiseActions[Array.IndexOf(poisetypes, weatype)], poiseact)][1].ToString());

                //拼一次
                if (PoisePer < 80) maxdmg =  0.8 * WeaPoise / (1 - PoiseVal / 100);
                else maxdmg =  (PoisePer * 0.01 * WeaPoise / (1 - PoiseVal / 100));
                if (maxdmg < 0) OneTrade = 0;
                else OneTrade = Math.Round(maxdmg, 1);

                //无限拼
                maxdmg =  0.8 * WeaPoise / (1 - PoiseVal / 100);
                if (maxdmg < 0) MoreTrade = 0;
                else MoreTrade = Math.Round(maxdmg, 1);
            }


            public Poise(String weatype, String poiseact)
            {
                WeaPoise = double.Parse(Global.Poises[Array.IndexOf(poisetypes, weatype)].Rows[Array.IndexOf(Global.PoiseActions[Array.IndexOf(poisetypes, weatype)], poiseact)][1].ToString());
            }

        }


        public class PoiseDmg
        {
            double[] WeaDmg;
            public String DmgType;
            public String temp;
            public Poise usrActPoise;
            double minpoise;
            List<double> templist = new List<double>();



            public PoiseDmg(String weatype, String wea, String weaction){
                int Position = Global.WeaponTypes.IndexOf(weatype);
                int Position2 = Array.IndexOf(Global.Weapons[Position], wea);
                temp = Global.PoiseDmgs[Position].Rows[Position2][weaction].ToString();

                if (temp.Contains(' '))
                {
                    templist.Add(System.Convert.ToDouble(temp.Substring(0, temp.IndexOf(' '))));
                    templist.Add(System.Convert.ToDouble(temp.Substring(temp.IndexOf(' ') + 1)));
                    WeaDmg = templist.ToArray();
                    templist = null;

                    if (Global.twoDmgs.Contains(wea)) DmgType = "twoDmgs";
                    else if (Global.twoBulDmg.Contains(wea)) DmgType = "twoBulDmg";
                    else if (Global.bulletDmg.Contains(wea)) DmgType = "bulletDmg";
                    else if (Global.splashDmg.Contains(wea)) DmgType = "splashDmg";
                    else DmgType = "kurwa";
                }
                else
                {
                    WeaDmg = new double[1] { System.Convert.ToDouble(temp) };
                    DmgType = "OneDmg";
                }
            }
            public PoiseDmg(String weatype, String wea, int weaction)
            {
                int Position = Global.WeaTypeCh.IndexOf(weatype);
                int Position2 = Array.IndexOf(Global.Weapons[Position], wea);
                temp = Global.PoiseDmgs[Position].Rows[Position2][weaction].ToString();

                if (temp.Contains(' '))
                {
                    templist.Add(System.Convert.ToDouble(temp.Substring(0, temp.IndexOf(' '))));
                    templist.Add(System.Convert.ToDouble(temp.Substring(temp.IndexOf(' ') + 1)));
                    WeaDmg = templist.ToArray();
                    templist = null;

                    if (Global.twoDmgs.Contains(wea)) DmgType = "twoDmgs";
                    else if (Global.twoBulDmg.Contains(wea)) DmgType = "twoBulDmg";
                    else if (Global.bulletDmg.Contains(wea)) DmgType = "bulletDmg";
                    else if (Global.splashDmg.Contains(wea)) DmgType = "splashDmg";
                    else DmgType = "kurwa";
                }
                else
                {
                    WeaDmg = new double[1] { System.Convert.ToDouble(temp) };
                    DmgType = "OneDmg";
                }
            }

            public PoiseDmg(String weatype, String wea, String weaction, String UsrWeaType, String UsrWeaAct)
            {
                int Position = Global.WeaponTypes.IndexOf(weatype);
                int Position2 = Array.IndexOf(Global.Weapons[Position], wea);
                temp = Global.PoiseDmgs[Position].Rows[Position2][weaction].ToString();

                if (temp.Contains(' '))
                {
                    String temp2 = temp.Substring(0, temp.IndexOf(' '));
                    templist.Add(System.Convert.ToDouble(temp2));
                    templist.Add(System.Convert.ToDouble(temp.Substring(temp.IndexOf(' ') + 1)));
                    WeaDmg = templist.ToArray();
                    templist = null;

                    if (Global.twoDmgs.Contains(wea)) DmgType = "twoDmgs";
                    else if (Global.twoBulDmg.Contains(wea)) DmgType = "twoBulDmg";
                    else if (Global.bulletDmg.Contains(wea)) DmgType = "bulletDmg";
                    else if (Global.splashDmg.Contains(wea)) DmgType = "splashDmg";
                    else DmgType = "kurwa";
                }
                else
                {
                    WeaDmg = new double[1] { System.Convert.ToDouble(temp) };
                    DmgType = "OneDmg";
                }

                usrActPoise = new Poise(UsrWeaType, UsrWeaAct);
            }


            public double OnePoise()
            {
                minpoise = 100 * (1 - usrActPoise.WeaPoise / WeaDmg[0]) + 0.01;
                if (minpoise < 0) return 0;
                else return minpoise;
            }

            public double MorePoise()
            {
                minpoise = 100 * (1 - 0.8 * usrActPoise.WeaPoise / WeaDmg[0]) + 0.01;
                if (minpoise < 0) return 0;
                else return minpoise;
            }

            public double OnceOne()
            {
                return OnePoise();
            }

            public double OnceTwo()
            {
                minpoise = 100 * (1 - usrActPoise.WeaPoise / WeaDmg[1]) + 0.01;
                if (minpoise < 0) return 0;
                else return minpoise;
            }

            public double OnceAll()
            {
                minpoise = 100 * (1 - usrActPoise.WeaPoise / (WeaDmg[0] + WeaDmg[1])) + 0.01;
                if (minpoise < 0) return 0;
                else return minpoise;
            }

            public double MoreAll()
            {
                minpoise = 100 * (1 - 0.8 * usrActPoise.WeaPoise / (WeaDmg[0] + WeaDmg[1])) + 0.01;
                if (minpoise < 0) return 0;
                else return minpoise;
            }

            public int PrayerHits()
            {
                int result = (int)(usrActPoise.WeaPoise / WeaDmg[0]);
                if (result < 0) return 0;
                else return result;
            }

            public String PrayerO()
            {
                if (usrActPoise.WeaPoise > WeaDmg[0])
                    return "你可以";
                else return "你不可以";
            }

            public String PrayerT()
            {
                if (usrActPoise.WeaPoise > WeaDmg[1])
                    return "你可以";
                else return "你不可以";
            }

            public String PrayerA()
            {
                int result = (int)(usrActPoise.WeaPoise / (WeaDmg[0] + WeaDmg[1]));
                if (result > 0)
                    return "你可以承受对方" + result + "次攻击";
                else return "你会被第一次攻击打断";
            }

            public Color CompareToPoise(Poise poise)
            {
                if (DmgType == "OneDmg")
                {
                    if (poise.OneTrade <= WeaDmg[0])
                        return Color.Red;
                    else if (poise.OneTrade > WeaDmg[0] && WeaDmg[0] >= poise.MoreTrade)
                        return Color.Yellow;
                    else
                        return Color.LightGreen;
                }
                else if (WeaDmg[1] > WeaDmg[0])
                {
                    if (poise.OneTrade <= WeaDmg[0])
                        return Color.Red;
                    else if (poise.OneTrade <= WeaDmg[1] && poise.OneTrade > WeaDmg[0])
                        return Color.LightBlue;
                    else if (poise.OneTrade <= WeaDmg[1] + WeaDmg[0] && poise.OneTrade > WeaDmg[1])
                        return Color.Orange;
                    else if (WeaDmg[1] + WeaDmg[0] < poise.OneTrade && WeaDmg[1] + WeaDmg[0] >= poise.MoreTrade)
                        return Color.Yellow;
                    else
                        return Color.LightGreen;
                }
                else
                {
                    if (poise.OneTrade <= WeaDmg[1])
                        return Color.Red;
                    else if (poise.OneTrade <= WeaDmg[1] + WeaDmg[0] && poise.OneTrade > WeaDmg[0])
                        return Color.Orange;
                    else if (poise.OneTrade <= WeaDmg[0] && poise.OneTrade > WeaDmg[1])
                        return Color.LightBlue;
                    else if (WeaDmg[1] + WeaDmg[0] < poise.OneTrade && WeaDmg[1] + WeaDmg[0] >= poise.MoreTrade)
                        return Color.Yellow;
                    else
                        return Color.LightGreen;
                }
            
            }

        }



        class CSVReader
        {
            static public void readCSV(string filePath, out DataTable dt, bool IsFirst)//从csv读取数据返回table
            {

                dt = new DataTable();

                //            try
                //            {
                System.Text.Encoding encoding = System.Text.Encoding.Default;//GetType(filePath); //
                                                                             // DataTable dt = new DataTable();
                System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Open,
                 System.IO.FileAccess.Read);

                System.IO.StreamReader sr = new System.IO.StreamReader(fs, encoding);

                //记录每次读取的一行记录
                string strLine = "";
                //记录每行记录中的各字段内容
                string[] aryLine = null;
                string[] tableHead = null;
                //标示列数
                int columnCount = 42;
                //标示是否是读取的第一行
                //逐行读取CSV中的数据
                while ((strLine = sr.ReadLine()) != null)
                {
                    if (IsFirst == true)
                    {
                        tableHead = strLine.Split(',');
                        IsFirst = false;
                        columnCount = tableHead.Length;
                        //创建列
                        for (int i = 0; i < columnCount; i++)
                        {
                            DataColumn dc = new DataColumn(tableHead[i]);
                            dt.Columns.Add(dc);
                        }
                    }
                    else
                    {
                        aryLine = strLine.Split(',');
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            dr[j] = aryLine[j];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                /*
                if (aryLine != null && aryLine.Length > 0)
                {
                    dt.DefaultView.Sort = tableHead[0] + " " + "asc";
                }
                */

                sr.Close();
                fs.Close();

                //            }
                //            catch (Exception)
                //            {
                //
                //                return false;
                //            }
            }
        }

        public class PoiseMeter
        {
            double meter;
            public PoiseMeter(double val)
            {
                this.meter = val;
            }

            public bool getHit(double hit, double poise)
            {
                this.meter = meter - hit * (1 - poise / 100);
                if (meter <= 0)
                    return true;
                else return false;
            }

            public bool getHit(double hit, double poise, double poisehp)
            {
                this.meter = meter - 100 * (hit / poisehp) * (1 - poise / 100);
                if (meter <= 0)
                    return true;
                else return false;
            }

            public String MtStr()
            {
                return (meter / 100).ToString("0.##%");
            }
        }

        

    }
}