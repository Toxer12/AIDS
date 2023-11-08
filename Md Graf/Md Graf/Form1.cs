using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Md_Graf
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

        private void Guzior_Click(object sender, EventArgs e)
        {
            var w1 = new node(5);
            var w2 = new node(3);
            var w3 = new node(1);
            var w4 = new node(2);
            var w5 = new node(6);
            var w6 = new node(4);

            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);

            A(w1);
        }

        void A(node Krzyś)
        {
            MessageBox.Show(Krzyś.wartosc.ToString());
            for(int i =0; i < Krzyś.dzieci.Count; i++)
            {
                A(Krzyś.dzieci[i]);
            }
        }
    }

    class node
    {
        public int wartosc;
        public List<node> dzieci = new List<node>();
        public node (int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
