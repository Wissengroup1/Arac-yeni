using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_LinqToObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> liste = new List<int>() { 2, 4, 6, 8, 10, 12 };

            foreach (int sayi in liste)
            {
                lbListe1.Items.Add(sayi);
            }

            //var sayilar = from s in liste where s > 6 select s;

            var sayilar = liste.Where(s => s > 6).Select(s => s);   // => lambda sembolü

            foreach (var item in sayilar)
            {
                lbListe2.Items.Add(item);
            }

            nuriiiiiiiiii   wissennnnn
        }
    }
}
