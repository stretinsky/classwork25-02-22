using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace classwork25_02_2022
{
    public partial class Form2 : Form
    {
        private static Form2 instance;
        private List<Student> students = new List<Student>();
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form2();
            }
            return instance;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            instance = null;
        }
        private void ParseStudetnts()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\students.txt";
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    students.Add(new Student(line.Split(' ')[0], line.Split(' ')[1], line.Split(' ')[2]));
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ParseStudetnts();
            dataGridView1.Rows.Add(students.Count);
            for (int i = 0; i < students.Count; i++)
            {
                if (treeView1.Nodes[0].Name.Equals(students[i].group))
                {
                    treeView1.Nodes[0].Nodes.Add($"{students[i].name} {students[i].surname}");
                    dataGridView1.Rows[i].SetValues(students[i].name, students[i].surname, "09-121");
                }
                else if (treeView1.Nodes[1].Name.Equals(students[i].group))
                {
                    treeView1.Nodes[1].Nodes.Add($"{students[i].name} {students[i].surname}");
                    dataGridView1.Rows[i].SetValues(students[i].name, students[i].surname, "09-122");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            Color color = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            splitContainer2.Panel2.BackColor = color;
        }
    }
}
