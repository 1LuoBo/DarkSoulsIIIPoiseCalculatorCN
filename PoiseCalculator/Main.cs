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
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
            int high = this.Height;
            int wide = this.Width;

            EnemyWeaponType.Height = high / 10 - 5;
            EnemyWeaponType.Width = wide / 2 - 40;
            EnemyWeapon.Height = high / 10 - 5;
            EnemyWeapon.Width = wide / 2 - 40;
            EnemyAttack.Height = high / 10 - 5;
            EnemyAttack.Width = wide / 2 - 40;
            MyWeapon.Height = high / 10 - 5;
            MyWeapon.Width = wide / 2 - 40;
            MyAttack.Height = high / 10 - 5;
            MyAttack.Width = wide / 2 - 40;
            CalPoise.Height = high / 10 - 10;
            CalPoise.Width = wide / 2 - 40;
            PoiResults.Height = 3 * high / 10 - 5;
            PoiResults.Width = wide / 2 - 40;

            EnemyWeaponType.Top = 30;
            EnemyWeaponType.Left = 20;
            EnemyWeapon.Top = EnemyWeaponType.Top + high / 10 - 5;
            EnemyWeapon.Left = 20;
            EnemyAttack.Top = EnemyWeapon.Top + high / 10 - 5;
            EnemyAttack.Left = 20;
            MyWeapon.Top = EnemyAttack.Top + high / 10 - 5;
            MyWeapon.Left = 20;
            MyAttack.Top = MyWeapon.Top + high / 10 - 5;
            MyAttack.Left = 20;
            CalPoise.Top = MyAttack.Top + high / 10 - 5;
            CalPoise.Left = 20;
            PoiResults.Top = CalPoise.Top + high / 10 - 5;
            PoiResults.Left = 20;

            MyWea.Height = high / 9 - 5;
            MyWea.Width = wide / 2 - 40;
            MyAct.Height = high / 9 - 5;
            MyAct.Width = wide / 2 - 40;
            DmgResult.Height = high / 9 - 5;
            DmgResult.Width = wide / 2 - 40;
            MyPoi.Height = high / 9 - 5;
            MyPoi.Width = wide / 2 - 40;
            CalDmg.Height = high / 9 - 10;
            CalDmg.Width = wide / 2 - 40;
            button3.Height = high / 9 - 10;
            button3.Width = wide / 2 - 40;
            button4.Height = high / 9 - 10;
            button4.Width = wide / 2 - 40;

            MyWea.Top = 30;
            MyWea.Left = wide / 2;
            MyAct.Top = MyWea.Top + high / 9 - 5;
            MyAct.Left = wide / 2;
            MyPoi.Top = MyAct.Top + high / 9 - 5;
            MyPoi.Left = wide / 2;
            CalDmg.Top = MyPoi.Top + high / 9 - 5;
            CalDmg.Left = wide / 2;
            DmgResult.Top = CalDmg.Top + high / 9 - 5;
            DmgResult.Left = wide / 2;
            button3.Top = DmgResult.Top + high / 9 - 5;
            button3.Left = wide / 2;
            button4.Top = button3.Top + high / 9 - 5;
            button4.Left = wide / 2;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void MyPoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnemyAttack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            int high = this.Height;
            int wide = this.Width;

            EnemyWeaponType.Height = high / 10 - 5;
            EnemyWeaponType.Width = wide / 2 - 40;
            EnemyWeapon.Height = high / 10 - 5;
            EnemyWeapon.Width = wide / 2 - 40;
            EnemyAttack.Height = high / 10 - 5;
            EnemyAttack.Width = wide / 2 - 40;
            MyWeapon.Height = high / 10 - 5;
            MyWeapon.Width = wide / 2 - 40;
            MyAttack.Height = high / 10 - 5;
            MyAttack.Width = wide / 2 - 40;
            CalPoise.Height = high / 10 - 10;
            CalPoise.Width = wide / 2 - 40;
            PoiResults.Height = 3 * high / 10 - 5;
            PoiResults.Width = wide / 2 - 40;

            EnemyWeaponType.Top = 30;
            EnemyWeaponType.Left = 20;
            EnemyWeapon.Top = EnemyWeaponType.Top + high / 10 - 5;
            EnemyWeapon.Left = 20;
            EnemyAttack.Top = EnemyWeapon.Top + high / 10 - 5;
            EnemyAttack.Left = 20;
            MyWeapon.Top = EnemyAttack.Top + high / 10 - 5;
            MyWeapon.Left = 20;
            MyAttack.Top = MyWeapon.Top + high / 10 - 5;
            MyAttack.Left = 20;
            CalPoise.Top = MyAttack.Top + high / 10 - 5;
            CalPoise.Left = 20;
            PoiResults.Top = CalPoise.Top + high / 10 - 5;
            PoiResults.Left = 20;

            MyWea.Height = high / 9 - 5;
            MyWea.Width = wide / 2 - 40;
            MyAct.Height = high / 9 - 5;
            MyAct.Width = wide / 2 - 40;
            DmgResult.Height = 2 * high / 9 - 5;
            DmgResult.Width = wide / 2 - 40;
            MyPoi.Height = high / 9 - 5;
            MyPoi.Width = wide / 2 - 40;
            CalDmg.Height = high / 9 - 10;
            CalDmg.Width = wide / 2 - 40;
            button3.Height = high / 9 - 10;
            button3.Width = wide / 2 - 40;
            button4.Height = high / 9 - 10;
            button4.Width = wide / 2 - 40;

            MyWea.Top = 30;
            MyWea.Left = wide / 2;
            MyAct.Top = MyWea.Top + high / 9 - 5;
            MyAct.Left = wide / 2;
            MyPoi.Top = MyAct.Top + high / 9 - 5; 
            MyPoi.Left = wide / 2;
            CalDmg.Top = MyPoi.Top + high / 9 - 5;
            CalDmg.Left = wide / 2;
            DmgResult.Top = CalDmg.Top + high / 9 - 5;
            DmgResult.Left = wide / 2;
            button3.Top = DmgResult.Top + 2 * high / 9 - 5;
            button3.Left = wide / 2;
            button4.Top = button3.Top + high / 9 - 5;
            button4.Left = wide / 2;
        }

        private void MyWea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyPoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            Boolean hasPoint = textBox.Text.Contains(".");
            if (e.KeyChar == '.' && hasPoint)
                e.Handled = true;
            else if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)8) && !(e.KeyChar == '.'))
                e.Handled = true;
            else e.Handled = false;
        }
    }
}
