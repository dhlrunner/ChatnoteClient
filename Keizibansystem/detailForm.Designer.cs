﻿namespace Keizibansystem
{
    partial class detailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailForm));
            this.titlelabel = new System.Windows.Forms.Label();
            this.authorlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlelabel.Location = new System.Drawing.Point(14, 15);
            this.titlelabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(55, 22);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Title";
            // 
            // authorlabel
            // 
            this.authorlabel.AutoSize = true;
            this.authorlabel.Location = new System.Drawing.Point(15, 47);
            this.authorlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.authorlabel.Name = "authorlabel";
            this.authorlabel.Size = new System.Drawing.Size(56, 18);
            this.authorlabel.TabIndex = 2;
            this.authorlabel.Text = "Author";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(556, 706);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "いいね！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(676, 706);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "コメントを書く";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.author,
            this.message,
            this.date});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 486);
            this.listView1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(824, 206);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "コメント";
            // 
            // datelabel
            // 
            this.datelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datelabel.Location = new System.Drawing.Point(427, 47);
            this.datelabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(405, 18);
            this.datelabel.TabIndex = 6;
            this.datelabel.Text = "1990/01/01 00:00:00";
            this.datelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(824, 355);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(401, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "♥ 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // author
            // 
            this.author.Text = "名前";
            this.author.Width = 110;
            // 
            // message
            // 
            this.message.Text = "コメント";
            this.message.Width = 500;
            // 
            // date
            // 
            this.date.Text = "日付";
            this.date.Width = 200;
            // 
            // detailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authorlabel);
            this.Controls.Add(this.titlelabel);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "detailForm";
            this.Text = "detailForm";
            this.Load += new System.EventHandler(this.detailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label authorlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader message;
        private System.Windows.Forms.ColumnHeader date;
    }
}