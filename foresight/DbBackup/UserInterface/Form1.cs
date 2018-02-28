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
using DbBackup;
using fst.DC.Toolkit.Utility;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        
        private void button_Export_Click(object sender, EventArgs e)
        {
            DataBaseInformation dbInfo = new DataBaseInformation
            {
                DbType = textBox_DbType.Text,
                UID = textBox_UID.Text,
                DSN = textBox_DSN.Text
            };

            DataBackup bk = new DataBackup(dbInfo);

            Process p = new Process();

            bk.Export();
           
        }

        
    }

   
}
