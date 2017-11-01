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
    public partial class Errors : Form
    {
        public Label label = new Label();
        
        public Errors()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            // Message acknowledged. Close form.
            this.Close();
        }

        private void Errors_Load(object sender, EventArgs e)
        {
           
        }

        public void setLabel(string text)
        {
            this.label.Text = text;
        }
        
    }
}
