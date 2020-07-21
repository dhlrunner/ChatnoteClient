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
using Newtonsoft.Json.Linq;

namespace Keizibansystem
{
    public partial class commentWriteForm : Form
    {
        private int index = 0;
        public commentWriteForm(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject send = new JObject();
            send.Add("index", index);
            send.Add("author", Form1.frm.nickname);
            send.Add("message", textBox1.Text);
            using(WebClient wc = new WebClient())
            {
                string res = Encoding.UTF8.GetString(wc.UploadData(Form1.frm.mainURL + "/writeComment",Encoding.UTF8.GetBytes(send.ToString())));
                if(res == "OK")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("shippai");
                }
            }
            //send.Add("timestamp",);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
