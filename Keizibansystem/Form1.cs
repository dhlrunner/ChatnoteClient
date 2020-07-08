using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Keizibansystem
{
    public partial class Form1 : Form
    {
        public static Form1 frm;
        JArray db = new JArray();
        public string nickname = string.Empty; 
        public string mainURL = "https://run.uaz.kr:9000";
        public int messageNum = 0;
        public Form1(string name)
        {
            nickname = name;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm = this;
            if(nickname == string.Empty)
            {
                toolStripStatusLabel1.Text = "匿名モードでログインしました。";
                this.Text = "ChatNote - 匿名モード";
            }
            else
            {
                toolStripStatusLabel1.Text = nickname+"さんでログインしました。";
                this.Text = "ChatNote - " + nickname + "さん";
            }
            refresh();                             
        }
        private void addDB(JObject d)
        {
           using(WebClient wc = new WebClient())
            {
                wc.UploadData(mainURL+ "/writeMessage",Encoding.UTF8.GetBytes(d.ToString()));
            }
            refresh();
        }
        private void refresh()
        {
            JArray dn = new JArray();
            using (WebClient wc = new WebClient())
            {
                dn = JArray.Parse(Encoding.UTF8.GetString(wc.DownloadData(mainURL + "/getMainDB")));
            }
            listView1.Items.Clear();
            foreach(var d in dn)
            {
                listView1.Items.Add(new ListViewItem(new string[] { d["index"].ToString(), d["title"].ToString(),
                d["likes"].ToString(), d["commentCount"].ToString(),d["author"].ToString(),DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(d["timestamp"])).LocalDateTime.ToString()})) ;
            }
            db = new JArray(dn);
        }
        private void writeBtn_Click(object sender, EventArgs e)
        {
            writeForm wf = new writeForm();
            if (wf.ShowDialog() == DialogResult.OK)
            {
                addDB(wf.ReturnValue1); 
            }
        }
        private void addMessage(JObject d)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                
                ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                ListViewItem lvItem = items[0];
                string index = lvItem.SubItems[0].Text;
                //MessageBox.Show(index);
                detailForm df = new detailForm(int.Parse(index));
                df.Show();
            }
        }
    }
}
