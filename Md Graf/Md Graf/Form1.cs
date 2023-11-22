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

        private void Guzior2_Click(object sender, EventArgs e)
        {
            var w1 = new node2(0);
            var w2 = new node2(5);
            var w3 = new node2(1);
            var w4 = new node2(3);
            var w5 = new node2(2);
            var w6 = new node2(4);

            w1.Add(w3);
            w3.Add(w2);
            w3.Add(w5);
            w3.Add(w6);
            w2.Add(w6);
            w5.Add(w4);

            B(w1);
        }

        void A(node Krzyś)
        {
            MessageBox.Show(Krzyś.wartosc.ToString());
            for (int i = 0; i < Krzyś.dzieci.Count; i++)
            {
                A(Krzyś.dzieci[i]);
            }
        }

        List<node2> visited = new List<node2>();
        void B(node2 Krzyś)
        {
            visited.Add(Krzyś);
            MessageBox.Show(Krzyś.ToString());
            foreach (var somsiad in Krzyś.somsiad)
            {
                if (!visited.Contains(somsiad))
                {
                    B(somsiad);
                }
            }
        }
        //string napis = "";
        //napis += w.ToString();
        //...........click...napis=""; visited.Clear(); A(w1); MB.S(napis);
        // Do domu Bfs(znajdz na wiki bfs gif ktory pokazuje pokazywanie go i zaprogramusj)
        // node3 Drzewo binarne (rodzic / lewe dziecko/ prawe dziecko)
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
    
    class node2
    {
        public int wartosc;
        public List<node2> somsiad = new List<node2>();
        public node2(int liczba)
        {
            this.wartosc = liczba;
        }

        public void Add(node2 s)
        {
            if(!this.somsiad.Contains(s))
            {
                this.somsiad.Add(s);
            }
            if (!s.somsiad.Contains(this))
            {
                s.somsiad.Add(this);
            }
        }

        public override string ToString()
        {
            return this.wartosc.ToString();
        }
    }

    class node3
    {
        public int wartosc;
        public List<node3> family = new List<node3>();
        public node3(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
