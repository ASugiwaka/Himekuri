
namespace Himekuri
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDisp = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 191);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDisp
            // 
            this.labelDisp.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDisp.Location = new System.Drawing.Point(12, 314);
            this.labelDisp.Name = "labelDisp";
            this.labelDisp.Size = new System.Drawing.Size(245, 20);
            this.labelDisp.TabIndex = 4;
            this.labelDisp.Text = "１２３４５６７８９０１２３４５";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "人生楽あれば楽だけ",
            "にんじんだもの",
            "黙って座れば〇〇〇",
            "8割でやめる。8割でやめない。           そこまで重要でないことは8割の完成度で満足しよう。大切なことは8割の完成度で満足しないようにしよう",
            "あきらめたらそこで試合終了だよ",
            "何かを始めるのに遅すぎるということはない。だが、焦ったほうがいい。",
            "努力をしても成功するとは限らん。だが、成功した者は皆すべからく努力しておる！！",
            "一度なくした信用取り戻すのは、最初に信用作るより大変なんだ",
            "いちばんいけないのは　じぶんなんかだめだと思いこむことだよ",
            "意味のないことをたくさんするのが人生なんじゃよ",
            "やりたいことを思いっきりやるためには、やりたくないことも思いっきりやんなきゃいけないんだ",
            "あきらめたら、解けない。答えは出ないままです。",
            "その人を知りたければその人が何に対して怒りを感じるかを知れ",
            "戦争で世界を変えられるって思うのは、おかしいんだよ！",
            "妥協してちゃ それなりのもんしか手に入んねーぜ",
            "友だちにたすけをもとめられて、知らん顔していられるか!!",
            "おまえ１人が100歩進むよりもみんなが1歩前進する方が大事だろーが",
            "命っちゅうんは限りがあるから大事なんや。限りがあるから頑張れるんやで。",
            "今まで大切にしてくれてどうもありがとう　ぼくは本当に幸せだった",
            "先生が日々成長せずして　どうして生徒に教えることができるでしょうか。",
            "てめぇは人の生き方否定できる程エライんかい？",
            "世の中全員てめぇと同じ考えだと思ったら大マチガイだ",
            "強い言葉を使うなよ、弱く見えるぞ",
            "世の中に不満があるなら自分を変えろ",
            "青春ぜんぶ懸けたって強くなれない？懸けてから言いなさい。",
            "そんな漠然とした目標では、何も出来はしない",
            "プレッシャーが人を次のステージへと成長させるんです！",
            "逃げちゃダメだ。逃げちゃダメだ。逃げちゃダメだ。",
            "本気の失敗には、価値がある",
            "限界はあるものでなく、自分で決めるものでござるよ。",
            "自分で変われるのが人間の強さだ",
            "地球上どこに行っても格差はあります。わしら庶民は、自分の力で登るしかないんです。",
            "人生を楽しむコツは、どれだけ馬鹿なことを考えられるかなんだ。",
            "本当の自由とは、自分のルールで生きるってことなんだよ。",
            "嫌われないように生きるのって大変だけど嫌われないように生きてるってバレたら、嫌われちゃうよ。",
            "足手まといなのは力のない者では無い、覚悟の無い者だ。",
            "我が生涯に一片の悔いなし",
            "人と違う生き方は それなりにしんどいよ。言い訳できないからね。",
            "逃げた事を卑下しないでそれをプラスに変えてこそ、逃げた甲斐があるというものです。",
            "落ちこぼれだって必死で努力すりゃエリートを超えることがあるかもよ",
            "前向きのバカならまだ可能性はあるが 後ろ向きのカはバカは可能性すらゼロ",
            "大きな標的を狙う者にとっては…その手前の小さなイザコザはリスクでしかない  理想のためには理不尽に頭を下げねばならない時がある ",
            "誰にでもできる事とできねェ事がある お前にできねェ事はおれがやる おれにできねェ事をお前がやれ!!!",
            "ところで平凡な俺よ 下を向いている暇はあるのか",
            "憧れるのを辞めましょう。憧れてしまったら超えられない。今日は僕たちは超えるために来た。トップになるために来た。今日1日だけは彼らへの憧れを捨てて、勝つことだけを考" +
                "えていきましょう。さあいこう！",
            "早く上手くなりたい。上手くなりたいと思える今はまだいけるんだと思います。",
            "「普通はマンガではこんな描き方はしない」といわれたら、それは自分にしかない武器やセンスだと思ったほうがいいですね。",
            "「絵に対する拘りが強すぎるからあんたは売れないんだよ！もっとコスパ考えなよ！」って言われた事あるんですけど、拘りが強いおかげで何とかうれたっぽいです",
            "「時間の無駄をしたくない」「コスパ重視」の人が、絵や漫画を仕事にしようなんて、思っちゃ、だ～め～よ～～～（力説）",
            "好きなことや好きな人に今よりも何倍も時間を費やせば、もっと人生は楽しくなる"});
            this.listBox1.Location = new System.Drawing.Point(16, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(241, 16);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.MistyRose;
            this.buttonStop.Location = new System.Drawing.Point(250, 314);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(23, 22);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightCyan;
            this.buttonNext.Location = new System.Drawing.Point(250, 292);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(23, 22);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("メイリオ", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDay.Location = new System.Drawing.Point(108, 239);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(58, 24);
            this.labelDay.TabIndex = 7;
            this.labelDay.Text = "日曜日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(279, 421);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Location = new System.Drawing.Point(0, 650);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "日めくりカレンダー";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDisp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelDay;
    }
}

