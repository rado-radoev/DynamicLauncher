using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// CLASS NOT IMPLEMENTED. NOT IN USE RIGHT NOW. RESERVED FOR FUTURE USE.
/// </summary>
namespace DynamicLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = string.Format("{0}\n\n\n{1}\n{2}",
                "Application should be run from comamnd line",
                "Example usage: ",
                "-app=procmon.exe \n-start=C:\\Tools \n-args=/AcceptEula /Quiet /Minimized");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
