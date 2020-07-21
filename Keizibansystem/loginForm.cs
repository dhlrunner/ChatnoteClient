using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keizibansystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !checkBox1.Checked;          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!checkBox1.Checked)
            {
                if (textBox1.Text != string.Empty)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    checkBox1.Enabled = false;
                    label2.Visible = true;
                    var form1 = new Form1(textBox1.Text);
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ニックネームを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                textBox1.Enabled = false;
                button1.Enabled = false;
                checkBox1.Enabled = false;
                label2.Visible = true;
                var form1 = new Form1(string.Empty);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                this.Hide();

            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
