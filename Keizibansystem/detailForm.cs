using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keizibansystem
{
    public partial class detailForm : Form
    {
        private int index = 0;
        private int likecount = 0;
        public detailForm(int index)
        {
            this.index = index;
            InitializeComponent();
        }
        private void refreshlikes()
        {
            label1.Text = string.Format("♥ {0}", likecount);
        }
        private void refresh()
        {
            using (WebClient wc = new WebClient())
            {
                JObject req = new JObject();
                req.Add("index", index);
                byte[] responce = wc.UploadData("https://run.uaz.kr:9000/is_likeable", Encoding.UTF8.GetBytes(req.ToString()));
                bool res = bool.Parse(Encoding.UTF8.GetString(responce));
                if (res)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            using (WebClient wc = new WebClient())
            {
                JObject updata = new JObject();
                updata.Add("index", index);
                byte[] responce = wc.UploadData("https://run.uaz.kr:9000/getDetail", Encoding.UTF8.GetBytes(updata.ToString()));
                JObject resjson = JObject.Parse(Encoding.UTF8.GetString(responce));
                titlelabel.Text = resjson["title"].ToString();
                authorlabel.Text = resjson["author"].ToString();
                datelabel.Text = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(resjson["timestamp"])).LocalDateTime.ToString();
                //messagetextBox1.Text = resjson["message"].ToString();
                this.Text = "投稿の詳細 - " + resjson["title"].ToString();
                richTextBox1.Text = resjson["message"].ToString();
                likecount = Convert.ToInt32(resjson["likes"]);
                JArray comment = (JArray)resjson["comment"];
                listView1.Items.Clear();
                if (comment.Count > 0)
                {
                    foreach (var a in comment)
                    {
                        listView1.Items.Add(new ListViewItem(new string[] {
                                a["author"].ToString(),
                                a["message"].ToString(),
                                DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(a["timestamp"])).LocalDateTime.ToString()}));
                    }
                }
                refreshlikes();
            }
        }
        private void detailForm_Load(object sender, EventArgs e)
        {
            try
            {
                refresh();               
            }
            catch(WebException)
            {
                MessageBox.Show("サーバに接続できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    JObject updata = new JObject();
                    updata.Add("index", index);
                    updata.Add("author", Form1.frm.nickname);
                    string responce =Encoding.UTF8.GetString(wc.UploadData("https://run.uaz.kr:9000/setLikes", Encoding.UTF8.GetBytes(updata.ToString())));
                   if(responce == "OK")
                    {
                        button1.Enabled = false;
                        likecount++;
                        refreshlikes();
                    }
                    else
                    {
                        MessageBox.Show("shippai");
                    }
                }
            }
            catch (WebException)
            {
                MessageBox.Show("サーバに接続できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            commentWriteForm cwf = new commentWriteForm(index);           
            if (cwf.ShowDialog() == DialogResult.OK)
            {
                refresh();
            }
        }
    }
}
