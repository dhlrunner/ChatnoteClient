using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Keizibansystem
{
    public partial class writeForm : Form
    {
        public JObject ReturnValue1 { get; set; }
        public writeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject o = new JObject();
            o.Add("title", textBox1.Text);
            o.Add("author", Form1.frm.nickname);
            o.Add("message", textBox2.Text);
            this.DialogResult = DialogResult.OK;
            ReturnValue1 = o;
            this.Close();
        }
    }
}
