using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGen
{
    public partial class Form1 : Form
    {
        private int osszeg = 0,
            db = 0,
            min = int.MaxValue,
            max = int.MinValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Label lb = new Label();

            lb.Location = new Point(e.X, e.Y);
            int randomszam = rnd.Next(1, 101);
            lb.Text = randomszam.ToString().Trim();
            Controls.Add(lb);
            lb.AutoSize = true;
            lb.BackColor = Color.Red;

            db++;
            osszeg += randomszam;

            if (randomszam < min) min = randomszam;

            if (randomszam > max) max = randomszam;

            double atlag = osszeg / db;

            label1.Text = String.Format("A számok összege {0}, a kattintások száma: {1}, az átlaguk: {2}, a minimum érték: {3}, a maximum érték: {4}.", osszeg, db, atlag, min, max);
        }
    }
}
