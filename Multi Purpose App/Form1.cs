using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Multi_Purpose_App
{
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("My application", Application.ExecutablePath.ToString());
        }

        private void Checker100ms_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateText.Text = dt.ToString("dd/MM/yyyy");
            dayText.Text = dt.ToString("dddd");
        }
    }
}
