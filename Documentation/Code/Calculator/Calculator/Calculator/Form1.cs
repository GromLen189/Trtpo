using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s;
            s = "C:\\Users\\Admin\\Desktop\\ТРиТПО\\Calculator\\Documentation\\Code\\Calculator\\Calculator\\Calculators\\Origin\\Calculator\\WindowsFormsApplication1\\obj\\Debug\\WindowsFormsApplication1.exe";
            Process.Start(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s;
            s = "C:\\Users\\Admin\\Desktop\\ТРиТПО\\Calculator\\Documentation\\Code\\Calculator\\Calculator\\Calculators\\Convert\\Number-System-Converter\\Number System Converter One Line\\converter\\obj\\x86\\Debug\\converter.exe";
            Process.Start(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s;
            s = "C:\\Users\\Admin\\Desktop\\ТРиТПО\\Calculator\\Documentation\\Code\\Calculator\\Calculator\\Calculators\\Matrix\\Matrix-Calculator\\WPFlindao\\WPFlindao\\bin\\Debug\\WPFlindao.exe";
            Process.Start(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String s;
            s = "C:\\Users\\Admin\\Desktop\\ТРиТПО\\Calculator\\Documentation\\Code\\Calculator\\Calculator\\Calculators\\Bits\\BitJuggling\\BitJuggling\\bin\\Debug\\BitJuggling.exe";
            Process.Start(s);
        }
    }
}
