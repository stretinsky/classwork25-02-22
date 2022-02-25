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
    public partial class Form3 : Form
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string group { get; private set; }
        public Form3(string name, string surname, string group)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            textBox1.Text = surname;
            InitializeComponent();
        }
        
    }
}
