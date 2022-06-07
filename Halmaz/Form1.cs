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
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                for (int j = 0; j < lbxB.Items.Count; j++)
                {
                    if (lbxB.Items[i] == )
                }
            }
        }

        private void Halmazgen(ListBox lbx, NumericUpDown nud)
        {
            Random rnd = new Random();
            int elem;
            bool azonos = false;
            //halmaz elemeinek törlése
            lbx.Items.Clear();
            for (int i = 0; i < nud.Value; i++)
            {
                azonos = false;
                //ellenőrizzük hogy van -e már ilyen elem
                elem = rnd.Next(1, 100);
                for (int j = 0; j < lbx.Items.Count; j++)
                {
                    if (lbx.Items[j].Equals(elem))
                    {
                        azonos = true;
                        break;
                    }
                }
                if (!azonos)
                {
                    lbx.Items.Add(elem);
                }
               
            }

           
        }

        

    }
}
