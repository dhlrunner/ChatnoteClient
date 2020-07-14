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
        public detailForm(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void detailForm_Load(object sender, EventArgs e)
        {
            try
            {
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
                }
            }
            catch(WebException)
            {
                MessageBox.Show("サーバに接続できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
