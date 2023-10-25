using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace md
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
        private void btn1_Click(object sender, EventArgs e)
        {
            int[] tab = { 7, 2, 5, 4, 1, 6, 3, 6, 3, 4, 3, 2, 1, 9, 5, 1, -987};

            MessageBox.Show(toString(babel(tab)));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = swap(convert(txtB1.Text));
            lstB1.Items.Clear();
            foreach (var i in tab)
            {
                lstB1.Items.Add(i);
            }
            MessageBox.Show(toString(swap(convert(txtB1.Text))));

        }
        private void txtB1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lstB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int[] babel(int[] tab)
        {
            bool a = false;
            int t;
            
            for(int i =0; i < tab.Length-1; i++)
            {
                if (tab[i] > tab[i+1])
                {
                    t = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = t;
                    a = true;
                }
            }

            if(a==true)
            {
                a = false;
                return babel(tab);
            }
            else
            {
                return tab;
            }

        }

        string toString(int[] tab1)
        {
            string wynik = "";
            for (int i = 0; i < tab1.Length; i++)
            {
                wynik += tab1[i] + ", ";
            }
            return wynik;
        }

        int[] convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            int[] liczby=new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
        int[] swap(int[] tab)
        {
            int[] wynik = tab;
            int t = tab[0];
            int ti;

            for(int i =0;i<tab.Length;i++)
            {
                t = tab[i];
                ti = i;
                for (int y = i+1; y < tab.Length; y++)
                {
                    if (t > tab[y])
                    {
                        t = tab[y];
                        ti = y;
                    }
                }
                wynik[ti] = tab[i];
                wynik[i] = t;
            }
            return wynik;
        }


    }
}
