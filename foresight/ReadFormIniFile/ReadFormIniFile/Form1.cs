using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFormIniFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath + @"\test.ini");

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadLine();

                    if (text == "[section1]")
                    {
                        textBox1.Text += text + Environment.NewLine;
                    }
                    else
                    {
                        listBox1.Items.Add(text + Environment.NewLine);
                    }
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetupIniIP iniIp = new SetupIniIP();

            string filePath = "test1.ini";

            //iniIp.IniWriteValue("SEC1", "KEY", "1", filePath);
            inivalue.Text = iniIp.IniReadValue("section1", "key", filePath);
        }

        public class SetupIniIP
        {
            public string path;
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal,
            int size, string filePath);
            public void IniWriteValue(string Section, string Key, string Value, string inipath)
            {
                WritePrivateProfileString(Section, Key, Value, Application.StartupPath + "\\" + inipath);
            }
            public string IniReadValue(string Section, string Key, string inipath)
            {
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section, Key, "", temp, 255, Application.StartupPath + "\\" + inipath);
                return temp.ToString();
            }
        }
    }
}
