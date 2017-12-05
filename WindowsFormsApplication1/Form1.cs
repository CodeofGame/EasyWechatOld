using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyWeChat.Container;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(corpid.Text.Trim()!=string.Empty && secret.Text.Trim()!=string.Empty)
            {
                string accessToken=AccessTokenContainer.TryGetToken(corpid.Text, secret.Text);
                richTextBox1.Text+=accessToken+"\n";
                cacheCount.Text = AccessTokenContainer.Count.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var x in AccessTokenContainer.AccessTokenCollection.Keys)
            {
                AccessTokenContainer.AccessTokenCollection[x].ExpireTime = DateTime.MinValue;
            }
             
            
        }
    }
}
