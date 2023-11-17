using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halı_saha
{
    public partial class Form1 : Form
    {
        private List<string> people;
        public Form1()
        {
            InitializeComponent();
            people = new List<string>
            {
                "ahmet","rafet hoca","fevzi","olcay","yusuf","ismail",
                "eren","yüzsüz tunahan","hakan","fatih","halil","muhammed"
            };    
            foreach (var person in people)
            {
                listBox1.Items.Add(person);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(); 
            people= people.OrderBy(x => random.Next()).ToList();

           
            for (int i = 0;i < people.Count; i++)
            {

                if (i>=6 )
                {
                    listBox3.Items.Add(people[i]);
                }
                else
                {
                    listBox2.Items.Add(people[i]);
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count < 6)
            {
                listBox3.Items.Add((string)listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count < 6)
            {
                listBox2.Items.Add((string)listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                listBox2.Items.Add(listBox3.Items[i]);

            }
            listBox3.Items.Clear();
            for (int j = 0; j < 6; j++)
            {
                listBox3.Items.Add(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}
