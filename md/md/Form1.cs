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
            int[] tab = { 7, 2, 5, 4, 1 };

            MessageBox.Show(toString(babel(tab)).ToString());
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
    }
}
