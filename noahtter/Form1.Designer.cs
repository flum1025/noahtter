namespace noahtter
{
    partial class noahtter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noahtter));
            this.PIN = new System.Windows.Forms.TextBox();
            this.Oauth = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.timeline = new System.Windows.Forms.Button();
            this.mention = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.sarasty_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rear_sentence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tweet1 = new System.Windows.Forms.Button();
            this.Command = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sarasty_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rear_sentence2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startOauth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rentou = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PIN
            // 
            this.PIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PIN.Cursor = System.Windows.Forms.Cursors.Default;
            this.PIN.Location = new System.Drawing.Point(158, 15);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(100, 19);
            this.PIN.TabIndex = 4;
            this.PIN.TextChanged += new System.EventHandler(this.PIN_TextChanged);
            // 
            // Oauth
            // 
            this.Oauth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Oauth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Oauth.Location = new System.Drawing.Point(287, 15);
            this.Oauth.Name = "Oauth";
            this.Oauth.Size = new System.Drawing.Size(75, 23);
            this.Oauth.TabIndex = 5;
            this.Oauth.Text = "認証";
            this.Oauth.UseVisualStyleBackColor = true;
            this.Oauth.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Location = new System.Drawing.Point(403, 19);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(396, 19);
            this.result.TabIndex = 6;
            // 
            // timeline
            // 
            this.timeline.Location = new System.Drawing.Point(332, 60);
            this.timeline.Name = "timeline";
            this.timeline.Size = new System.Drawing.Size(75, 23);
            this.timeline.TabIndex = 7;
            this.timeline.Text = "TimeLine";
            this.timeline.UseVisualStyleBackColor = true;
            this.timeline.Click += new System.EventHandler(this.timeline_Click);
            // 
            // mention
            // 
            this.mention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mention.Location = new System.Drawing.Point(582, 60);
            this.mention.Name = "mention";
            this.mention.Size = new System.Drawing.Size(75, 23);
            this.mention.TabIndex = 8;
            this.mention.Text = "Mention";
            this.mention.UseVisualStyleBackColor = true;
            this.mention.Click += new System.EventHandler(this.mention_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(332, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 306);
            this.listView1.TabIndex = 11;
            this.listView1.TileSize = new System.Drawing.Size(220, 28);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(582, 89);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(235, 306);
            this.listView2.TabIndex = 11;
            this.listView2.TileSize = new System.Drawing.Size(220, 28);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            // 
            // sarasty_1
            // 
            this.sarasty_1.Location = new System.Drawing.Point(94, 60);
            this.sarasty_1.Name = "sarasty_1";
            this.sarasty_1.Size = new System.Drawing.Size(100, 19);
            this.sarasty_1.TabIndex = 13;
            this.sarasty_1.Text = "@sarasty_noah";
            this.sarasty_1.TextChanged += new System.EventHandler(this.sarasty_1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "コマンド送信先";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "攻撃先";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(94, 87);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(98, 19);
            this.attack.TabIndex = 16;
            this.attack.Tag = "";
            this.attack.TextChanged += new System.EventHandler(this.attack_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "attack",
            "heal",
            "state",
            "start"});
            this.comboBox1.Location = new System.Drawing.Point(13, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 20);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "attack";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(115, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "連投";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(213, 114);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(33, 19);
            this.start.TabIndex = 19;
            this.start.Text = "0";
            this.start.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(275, 114);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(33, 19);
            this.end.TabIndex = 20;
            this.end.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "～";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "後ろにつける文章";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rear_sentence
            // 
            this.rear_sentence.Location = new System.Drawing.Point(117, 158);
            this.rear_sentence.Name = "rear_sentence";
            this.rear_sentence.Size = new System.Drawing.Size(141, 19);
            this.rear_sentence.TabIndex = 23;
            this.rear_sentence.TextChanged += new System.EventHandler(this.rear_sentence_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "ツイート内容";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(94, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tweet1
            // 
            this.tweet1.Enabled = false;
            this.tweet1.Location = new System.Drawing.Point(234, 221);
            this.tweet1.Name = "tweet1";
            this.tweet1.Size = new System.Drawing.Size(75, 23);
            this.tweet1.TabIndex = 26;
            this.tweet1.Text = "送信";
            this.tweet1.UseVisualStyleBackColor = true;
            this.tweet1.Click += new System.EventHandler(this.tweet1_Click);
            // 
            // Command
            // 
            this.Command.FormattingEnabled = true;
            this.Command.Items.AddRange(new object[] {
            "",
            "qa",
            "weather",
            "好き？",
            "learn from",
            "learn",
            "ping",
            "m_ping",
            "markov"});
            this.Command.Location = new System.Drawing.Point(13, 301);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(86, 20);
            this.Command.TabIndex = 27;
            this.Command.SelectedIndexChanged += new System.EventHandler(this.Command_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "コマンド送信先";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sarasty_2
            // 
            this.sarasty_2.Location = new System.Drawing.Point(98, 265);
            this.sarasty_2.Name = "sarasty_2";
            this.sarasty_2.Size = new System.Drawing.Size(98, 19);
            this.sarasty_2.TabIndex = 29;
            this.sarasty_2.Text = "@sarasty_noah";
            this.sarasty_2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(106, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "後ろにつける文章";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(233, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "送信";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // rear_sentence2
            // 
            this.rear_sentence2.Location = new System.Drawing.Point(200, 298);
            this.rear_sentence2.Name = "rear_sentence2";
            this.rear_sentence2.Size = new System.Drawing.Size(126, 19);
            this.rear_sentence2.TabIndex = 32;
            this.rear_sentence2.TextChanged += new System.EventHandler(this.rear_sentence2_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(11, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "ツイート内容";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(106, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 23);
            this.label12.TabIndex = 34;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startOauth
            // 
            this.startOauth.Location = new System.Drawing.Point(13, 13);
            this.startOauth.Name = "startOauth";
            this.startOauth.Size = new System.Drawing.Size(75, 23);
            this.startOauth.TabIndex = 0;
            this.startOauth.Text = "Oauth認証";
            this.startOauth.UseVisualStyleBackColor = true;
            this.startOauth.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(4, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(317, 14);
            this.label13.TabIndex = 35;
            this.label13.Text = "--------------------------------------------------";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentou
            // 
            this.rentou.FormattingEnabled = true;
            this.rentou.Items.AddRange(new object[] {
            "オン",
            "オフ"});
            this.rentou.Location = new System.Drawing.Point(158, 113);
            this.rentou.Name = "rentou";
            this.rentou.Size = new System.Drawing.Size(38, 20);
            this.rentou.TabIndex = 36;
            this.rentou.Text = "オフ";
            this.rentou.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // noahtter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 407);
            this.Controls.Add(this.rentou);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rear_sentence2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sarasty_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.tweet1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rear_sentence);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sarasty_1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mention);
            this.Controls.Add(this.timeline);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Oauth);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startOauth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "noahtter";
            this.Text = "のあったー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.noahtter_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Button Oauth;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button timeline;
        private System.Windows.Forms.Button mention;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox sarasty_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox attack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rear_sentence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tweet1;
        private System.Windows.Forms.ComboBox Command;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sarasty_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rear_sentence2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button startOauth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox rentou;
    }
}

