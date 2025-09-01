using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Himekuri
{
    public partial class Form2 : Form
    {
        // フォーム1への参照を保持するフィールド★
        private Form1 form1;

        // コンストラクタでフォーム1への参照を受け取る★
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var filePath = "D:\\Tools\\List.txt";//".\\List.txt";
                textBox1.Text = File.ReadAllText(filePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

        // フォーム2の「リスト更新」ボタンをクリックしたとき
        // フォーム2のテキストボックスの内容を
        // テキストファイルに書き出し、
        // フォーム1のリストボックスの内容を更新します
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var filePath = "D:\\Tools\\List.txt";//".\\List.txt";
                string[] items = textBox1.Text.Split('\n');
                File.WriteAllLines(filePath, items);
                form1.UpdateListBox(items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
