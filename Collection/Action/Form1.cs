using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Action
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void TaskAction()
        {
            textBox1.Text += "TaskAction - started!\n";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                Thread.Sleep(1000);
                textBox1.Text += $"Count: {i}\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Main thread started \n";

            Task task = new Task(TaskAction);
            task.Start();

            /*for (int i = 0; i < numericUpDown1.Value; i++)
            {
                textBox2.Text += $"Run -> {i}\n";
                Thread.Sleep(500);
            }*/

            textBox1.Text += "Thread shutdown";
        }

    }
}
