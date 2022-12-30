using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProje
{
    public partial class MHRS : Form
    {
        public MHRS()
        {
            InitializeComponent();
        }
        Queue<String> queue = new Queue<String>();
        Stack<String> stack = new Stack<String>();
        String gender;
        String[] arr;
        String[] arr2;
        int priority = 3;

        private void Form3_Load(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.MediumAquamarine;
            tabPage2.BackColor = Color.MediumAquamarine;

        }
        public void ArrToQue()
        { 

            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked == true) 
            {
                gender = radioButton2.Text;
            }
            //if (checkBox1.Checked == true)
            //{
            //    priority = 0;
                
            //}
            //else if (checkBox2.Checked == true && checkBox1.Checked == false)
            //{
            //    priority = 1;
                
            //}
            //else if (checkBox3.Checked == true && checkBox1.Checked == false && checkBox2.Checked == false)
            //{
            //    priority = 2;
                
            //}
            //else if (checkBox1.Checked == false || checkBox2.Checked == false || checkBox3.Checked == false)
            //{
            //    priority = 3;
                
            //}
            String[] arr = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, gender };

            String fullname = arr[1].ToString() + " " + arr[2].ToString();
            queue.Enqueue(fullname);
            stack.Push(fullname);

            
            listView1.Items.Add(new ListViewItem(arr));
            



            label5.Text = "there are " + queue.Count + " patient in line";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrToQue();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked= false;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queue.Count!=0)
            {
                textBox6.Text = queue.Dequeue().ToString();
                label5.Text = "there are " + queue.Count + " patient in line";


            }
            else
            {
                MessageBox.Show("there is no patient in line");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (queue.Count != 0)
            {
                textBox7.Text = queue.Dequeue().ToString();
                label5.Text = "there are " + queue.Count + " patient in line";

            }
            else
            {
                MessageBox.Show("there is no patient in line");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            listView1.Items.RemoveAt(listView1.Items.Count - 1);
            MessageBox.Show(stack.Pop().ToString() + "'s appointment cancelled.");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
