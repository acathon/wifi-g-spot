using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace GSpot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "WSPOT Creator";
            API api = new API();
            api.IsAdmin();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "error");
            String ssid;
            String pwd;
            ssid = textBox1.Text;
            pwd = textBox2.Text;
            bool stat = false;
            API.Hotspot(ssid, pwd, stat);
        }
    }
}
