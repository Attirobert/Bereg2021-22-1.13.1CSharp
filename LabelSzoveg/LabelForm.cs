using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelSzoveg
{
    public partial class LabelForm : Form
    {
        public LabelForm()
        {
            InitializeComponent();
        }

        private void LabelForm_Load(object sender, EventArgs e)
        {
            lblFull.Text = "Kattints a formon valahova!";
        }

        private void lblFull_MouseClick(object sender, MouseEventArgs e)
        {
            int o = (int)e.X / (lblFull.Width / 3);     // Hanyadik oszlopba kattintottunk
            int s = (int)e.Y / (lblFull.Height / 3);    // Hanyadik sorba kattintottunk
        }
    }
}
