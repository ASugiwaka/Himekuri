using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Himekuri
{
    /// <summary>
    /// //////////////////////////////////////////
    /// ランダムに名言を表示する日めくりカレンダー
    /// //////////////////////////////////////////

    public partial class Form1 : Form
    {
        public static int dispCount;
        public static int dispTimes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //表示位置とサイズ
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Size = new Size(295, 400); //←(295,385) 20230509
            this.Location = new Point(w-300, h-1050);


            //日付と色
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString("dd");

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    label1.ForeColor = Color.Red;
                    labelDay.Text = "日曜日";
                    labelDay.ForeColor = Color.Red;
                    break;
                case DayOfWeek.Monday:
                    label1.ForeColor = Color.ForestGreen;
                    labelDay.Text = "月曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Tuesday:
                    label1.ForeColor = Color.Gold;
                    labelDay.Text = "火曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Wednesday:
                    label1.ForeColor = Color.DeepPink;
                    labelDay.Text = "水曜日";
                    labelDay.ForeColor = Color.Black; 
                    break;
                case DayOfWeek.Thursday:
                    label1.ForeColor = Color.YellowGreen;
                    labelDay.Text = "木曜日";
                    labelDay.ForeColor = Color.Black; 
                    break;
                case DayOfWeek.Friday:
                    label1.ForeColor = Color.DarkMagenta;
                    labelDay.Text = "金曜日";
                    labelDay.ForeColor = Color.Black; 
                    break;
                case DayOfWeek.Saturday:
                    label1.ForeColor = Color.MediumBlue;
                    labelDay.Text = "土曜日";
                    labelDay.ForeColor = Color.MediumBlue;
                    break;

            }

            //金言格言戯言セット
            int listCount;
            listCount = listBox1.Items.Count;

            Random dice = new Random();
            int roll = dice.Next(1, listCount);

            listBox1.SelectedIndex = roll;
            labelDisp.Text = listBox1.SelectedItem.ToString();

            // 一行に表示しきれなかったらスクロール用タイマを動かす
            if (labelDisp.Text.Length > 15)
            {
                timer1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //カレンダー参照したとき何するか（Bingチャット君にやらせてみた）
            label1.Text = dateTimePicker1.Value.Date.Day.ToString();

            // 曜日に応じて文字色を変える
            switch (dateTimePicker1.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    label1.ForeColor = Color.Red;
                    labelDay.Text = "日曜日";
                    labelDay.ForeColor = Color.Red;
                    break;
                case DayOfWeek.Monday:
                    label1.ForeColor = Color.ForestGreen;
                    labelDay.Text = "月曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Tuesday:
                    label1.ForeColor = Color.Gold;
                    labelDay.Text = "火曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Wednesday:
                    label1.ForeColor = Color.DeepPink;
                    labelDay.Text = "水曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Thursday:
                    label1.ForeColor = Color.YellowGreen;
                    labelDay.Text = "木曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Friday:
                    label1.ForeColor = Color.DarkMagenta;
                    labelDay.Text = "金曜日";
                    labelDay.ForeColor = Color.Black;
                    break;
                case DayOfWeek.Saturday:
                    label1.ForeColor = Color.MediumBlue;
                    labelDay.Text = "土曜日";
                    labelDay.ForeColor = Color.MediumBlue;
                    break;
            }

        }

            // タイマイベント：ラベルの内容をスクロールする
            //　　タイマ15回を超えたらスクロール開始し、
            //　　表示する文字がなくなったらカウントを0クリアして空白の余韻を残す
            //　　20回スクロールしたところで、このタイマを止める
            private void timer1_Tick(object sender, EventArgs e)
        {
       
            dispCount++;      

            if (dispCount > 15)
            {
                if (labelDisp.Text == "")
                {
                    labelDisp.Text = listBox1.SelectedItem.ToString();
                    dispCount = 0;

                    if (dispTimes >= 20)
                    {
                        timer1.Enabled = false;
                        labelDisp.Text = listBox1.SelectedItem.ToString();
                    }
                    else
                    {
                        dispTimes++;             
                    }
                }
                else
                {
                    string dispText = labelDisp.Text;                
                    dispText = dispText.Remove(0, 1);
                    labelDisp.Text = dispText;
                }
            }
 
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else 
            {
                timer1.Enabled = true;
            }
            dispTimes = 0;

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dispCount = 0;

            int listCount;
            listCount = listBox1.Items.Count;

            Random dice = new Random();
            int roll = dice.Next(1, listCount);

            listBox1.SelectedIndex = roll;
            labelDisp.Text = listBox1.SelectedItem.ToString();

            if (labelDisp.Text.Length > 15)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        // リストボックスの内容を更新するメソッド
        public void UpdateListBox(string[] items)
        {
            // リストボックスの内容を削除する
            listBox1.Items.Clear();
            // リストボックスにテキストボックスの内容を追加する
            listBox1.Items.AddRange(items);
            buttonNext.PerformClick();
            timer1.Enabled = true;

        }

    }
}
