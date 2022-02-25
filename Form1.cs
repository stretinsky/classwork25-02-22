using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork25_02_2022
{
    public partial class Form1 : Form
    {
        string homePage = "https://cdnn21.img.ria.ru/images/148839/96/1488399659_0:0:960:960_600x0_80_0_1_e38b72053fffa5d3d7e82d2fe116f0b3.jpg";
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(homePage);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goHomeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(homePage);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string url = "http://google.com/search?=" + textBox1.Text.Replace(' ', '+');
            textBox1.Text = url;
            webBrowser1.Navigate(url);
            
        }

        private void menuButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 table = Form2.GetInstance();
            table.Show();
        }
    }
}
