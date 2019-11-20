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
using System.Threading;
using System.Threading.Tasks;
namespace BlockingAndUnBlockingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private int GetCount()
        {
            using (StreamReader reader = new StreamReader("F:/Kanchan/ASP.NET-MVC/WorkLog.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(GetCount);
            task.Start();
            label1.Text = "Reading Please Wait...";
            int count = await task;
            label1.Text = "Total no.of chars " + count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label2.Text = "Reading Please Wait...";
            int count = GetCount();
            label2.Text = "Total no.of chars " + count.ToString();

        }
    }
}
