using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using System.Reactive.Linq;
using CoreTweet.Streaming;
using CoreTweet.Streaming.Reactive;
using System.Threading;
using System.IO;

namespace noahtter
{
    public partial class noahtter : Form
    {
        CoreTweet.Tokens tokens;
        CoreTweet.OAuth.OAuthSession session;
        const string ApiKey = "";
        const string ApiSecret = "";

        public noahtter()
        {
            InitializeComponent();
           

            label8.Text = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text;
            if (System.IO.File.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/tokens.txt"))
            {
                string tokenfile = File.ReadAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/tokens.txt", System.Text.Encoding.GetEncoding("Shift_JIS"));
                string[] token = tokenfile.Split(',');
                tokens = Tokens.Create(
                    ApiKey
                    , ApiSecret
                    , token[0]
                    , token[1]);
                result.Text = tokens.ToString();
                tweet1.Enabled = true;
                button2.Enabled = true;
                streming();
                mention2();
            }
            else
            {
                MessageBox.Show("まずOauth認証してください。");
            }

        }
        private void InitializeListView()
        {
            // ListViewコントロールのプロパティを設定
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.View = View.Details;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var task = Task.Factory.StartNew(() =>
            {
                 session = OAuth.Authorize(ApiKey, ApiSecret);
            System.Diagnostics.Process.Start(session.AuthorizeUri.ToString());
            });
            MessageBox.Show("数秒後にブラウザが開くのでログインしてPINを入力してください。\n(クソースだから表示に時間かかる)");
           

        }

        private void PIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tokens = session.GetTokens(PIN.Text);
            result.Text = tokens.ToString();
            tweet1.Enabled = true;
            button2.Enabled = true;
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            File.WriteAllText(@System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/tokens.txt", tokens.AccessToken + "," + tokens.AccessTokenSecret, sjisEnc);
            streming();
            mention2();
        }

        private void noahtter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tokens != null)
            {
                Properties.Settings.Default.AccessToken = tokens.AccessToken;
                Properties.Settings.Default.AccessTokenSecret = tokens.AccessTokenSecret;


            }
        }

        private void timeline_Click(object sender, EventArgs e)
        {
            streming();
        }
        private void streming()
        {
            listView1.GridLines = true;
            var disposable = tokens.Streaming.StartObservableStream(StreamingType.User)
                    .Where((StreamingMessage m) => m.Type == MessageType.Create)
                    .Cast<StatusMessage>()
                //.Select((StatusMessage m) => m.Status.User.Name + "(" + m.Status.User.ScreenName + ")\n" + m.Status.Text)
                    .Select((StatusMessage m) => m.Status.User.Name + "," + m.Status.User.ScreenName + "," + m.Status.Text)
                    .ObserveOn(SynchronizationContext.Current)
                //.Subscribe((string s) => listView1.Items.Add(new ListViewItem(string.Format("{0}{1}", s, Environment.NewLine))));
                    .Subscribe(x => OnNext(x));
        }

        private void OnNext(string x)
        {
            string[] statusdata = x.Split(',');
            string name = "【" + statusdata[0] + "-" + statusdata[1] + "】";
            string text = statusdata[2];
            //listView1.Items.Add(new ListViewItem(name + Environment.NewLine + text));
            listView1.Items.Insert(0, new ListViewItem(name + Environment.NewLine + text)); 
        }

        private void mention2()
        {
            foreach (var status in tokens.Statuses.MentionsTimeline())
                listView2.Items.Add(string.Format("【{0}-{1}】{2}{3}", status.User.Name, status.User.ScreenName, status.Text, Environment.NewLine));

        }


        private void timelabel_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label12.Text = sarasty_2.Text + " " + Command.SelectedItem as string + " " + rear_sentence2.Text;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void attack_TextChanged(object sender, EventArgs e)
        {
            label8.Text = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text;

        }

        private void sarasty_1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            label8.Text = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text;
        }

        private void rear_sentence_TextChanged(object sender, EventArgs e)
        {
            label8.Text = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tweet1_Click(object sender, EventArgs e)
        {
            if (rentou.Text == "オン")
            {
                
                for (int i = int.Parse(start.Text); i <= int.Parse(end.Text); i++)
                {
                    string tweet = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text + i;
                    var task = Task.Factory.StartNew(() =>
                    {
                       tokens.Statuses.Update(status => tweet);
                    });
                }
            }
            else
            {
                string tweet = sarasty_1.Text + " " + comboBox1.SelectedItem as string + " " + attack.Text + " " + rear_sentence.Text;
                var task = Task.Factory.StartNew(() =>
                {
                    tokens.Statuses.Update(status => tweet);
                });
            }
        }

        private void Command_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = sarasty_2.Text + " " + Command.SelectedItem as string + " " + rear_sentence2.Text;

        }

        private void rear_sentence2_TextChanged(object sender, EventArgs e)
        {
            label12.Text = sarasty_2.Text + " " + Command.SelectedItem as string + " " + rear_sentence2.Text;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string tweet = sarasty_2.Text + " " + Command.SelectedItem as string + " " + rear_sentence2.Text;
            var task = Task.Factory.StartNew(() =>
            {
                tokens.Statuses.Update(status => tweet);
            });
        }

        private void mention_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            mention2();
        }

    }
}
