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
        Random rnd = new Random();

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
            lblAdb.Text = lbxA.Items.Count.ToString();
            //B halmaz generálása
            Halmazgen(lbxB, nudB);
            lblBdb.Text = lbxB.Items.Count.ToString();
            //Metszet
            Metszet(lbxAmB, lbxA, lbxB);
            lblAmBdb.Text = lbxAmB.Items.Count.ToString();
            //Unió
            Unio(lbxAuB, lbxA, lbxB);
            lblAuBdb.Text = lbxAuB.Items.Count.ToString();
            //A-B
            AbolB(lbxAbolB, lbxA, lbxB);
            lblAbolBdb.Text = lbxAbolB.Items.Count.ToString();
            //B-A
            AbolB(lbxBbolA, lbxB, lbxA);
            lblBbolAdb.Text = lbxBbolA.Items.Count.ToString();
        }

        private bool Bennevan(ListBox miben, object mi)
        {
            for (int i = 0; i < miben.Items.Count; i++)
            {
                if (miben.Items[i].Equals(mi))
                {
                    return true;
                }
            }
            return false;
        }

        private void AbolB(ListBox lbxAbolB, ListBox lbxA, ListBox lbxB)
        {
            lbxAbolB.Items.Clear();
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                if (!Bennevan(lbxB, lbxA.Items[i]))
                {
                    lbxAbolB.Items.Add(lbxA.Items[i]);
                    continue;
                }
            }
        }

        private void Unio(ListBox lbxAuB, ListBox lbxA, ListBox lbxB)
        {
            lbxAuB.Items.Clear();
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                lbxAuB.Items.Add(lbxA.Items[i]);
            }

            for (int i = 0; i < lbxB.Items.Count; i++)
            {
                if (Bennevan(lbxB, lbxAuB.Items[i]))
                {
                    lbxAuB.Items.Add(lbxB.Items[i]);
                    break;
                }
                
            }
        }

        private void Metszet(ListBox lbxAmB, ListBox lbxA, ListBox lbxB)
        {
            bool empty = true;
            lbxAmB.Items.Clear();
            for (int i = 0; i < lbxA.Items.Count; i++)
            {
                if (Bennevan(lbxB, lbxA.Items[i]))
                {
                    lbxAmB.Items.Add(lbxB.Items[i]);
                    empty = false;
                }
            }
            if (empty)
            {
                lbxAmB.Items.Add("Üres halmaz");
            }
        }

        private void Halmazgen(ListBox lbx, NumericUpDown nud)
        {
            int elem;
            //halmaz elemeinek törlése
            lbx.Items.Clear();
            int i = 0;
            do
            {
                //ellenőrizzük hogy van -e már ilyen elem
                elem = rnd.Next(1, 100);
                if (!Bennevan(lbx, elem))
                {
                    lbx.Items.Add(elem);
                    i++;
                }
                
            } while (i != nud.Value);

           
        }

    }
}
