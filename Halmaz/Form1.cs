using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halmaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            //A halmaz generálása
            Halmazgen(lbxA, nudA);
            //B halmaz generálása
            Halmazgen(lbxB, nudB);
            //Metszet
            Metszet(lbxAmB, lbxA, lbxB);
            //Unió
            Unio(lbxAuB, lbxA, lbxB);
            //A-B
            AbolB(lbxAbolB, lbxA, lbxB);
            //B-A
            BbolA(lbxBbolA, lbxA, lbxB);
        }

        private void BbolA(ListBox lbxBbolA, ListBox lbxA, ListBox lbxB)
        {
            throw new NotImplementedException();
        }

        private void AbolB(ListBox lbxAbolB, ListBox lbxA, ListBox lbxB)
        {
            throw new NotImplementedException();
        }

        private void Unio(ListBox lbxAuB, ListBox lbxA, ListBox lbxB)
        {
            throw new NotImplementedException();
        }

        private void Metszet(ListBox lbxAmB, ListBox lbxA, ListBox lbxB)
        {
            throw new NotImplementedException();
        }

        private void Halmazgen(ListBox lbxB, NumericUpDown nudB)
        {
            Random rnd = new Random();
            
           
        }
    }
}
