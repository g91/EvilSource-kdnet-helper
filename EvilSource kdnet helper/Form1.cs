using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.Net.Dns.GetHostName();
        }
        private void EXEC(string exe, string arg)
        {
            var proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Program Files(x86)\Microsoft Xbox 360 SDK\bin\win32\";
            proc1.FileName = exe;
            proc1.Verb = "runas";
            proc1.Arguments =  arg;
            proc1.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(proc1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EXEC("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\xbsetcfg.exe", "/kdnet set ip="+ textBox1.Text + " port=50000");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EXEC("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\windbg", "/k net:port=50000");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EXEC("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\xbsetcfg.exe", "/kdnet enable");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EXEC("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\xbsetcfg.exe", "/kdnet enable");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EXEC("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32\\cmd.exe", "");
        }
    }
}
