using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfAracKiralama
{
    public partial class frmAracSorgulama : Form
    {
        public frmAracSorgulama()
        {
            InitializeComponent();
        }

        private void frmAracSorgulama_Load(object sender, EventArgs e)
        {
            //dgvAraclar.MultiSelect = true;
            this.Top = 0;
            this.Left = 0;
            List<cArac> list = new List<cArac>();
            cArac a = new cArac();

            txtMarkayaGore.Text = "";
            cbKiraDurumu.SelectedIndex = 1;
            cbSanzimanTipi.SelectedIndex = 0;
            cbYakitTuru.SelectedIndex = 0;           

            dgvAraclar.DataSource = a.AraclariGetir();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            cArac a = new cArac();

            if (cbSanzimanTipi.SelectedItem.ToString() == "Hepsi" && cbYakitTuru.SelectedItem.ToString() == "Hepsi" && cbKiraDurumu.SelectedItem.ToString() == "Hepsi" && txtMarkayaGore.Text == null)
            {
                a.AraclariGetir();
            }
            else
            {
                bool kiradurumu = true;

                if (cbKiraDurumu.SelectedItem.ToString() == "Uygun")
                {
                    kiradurumu = true;
                }
                else if (cbKiraDurumu.SelectedItem.ToString() == "Uygun Değil")
                {
                    kiradurumu = false;
                }
               
                dgvAraclar.DataSource = a.AraclariGetirByDetayli(cbSanzimanTipi.SelectedItem.ToString(), cbYakitTuru.SelectedItem.ToString(), kiradurumu,cbKiraDurumu.SelectedItem.ToString(),txtMarkayaGore.Text);
            }
        }

        private void txtMarkayaGore_TextChanged(object sender, EventArgs e)
        {
            cArac a = new cArac();

            if (cbSanzimanTipi.SelectedItem.ToString() == "Hepsi" && cbYakitTuru.SelectedItem.ToString() == "Hepsi" && cbKiraDurumu.SelectedItem.ToString() == "Hepsi" && txtMarkayaGore.Text == null)
            {
                a.AraclariGetir();
            }
            else
            {
                bool kiradurumu = true;

                if (cbKiraDurumu.SelectedItem.ToString() == "Uygun")
                {
                    kiradurumu = true;
                }
                else if (cbKiraDurumu.SelectedItem.ToString() == "Uygun Değil")
                {
                    kiradurumu = false;
                }

                dgvAraclar.DataSource = a.AraclariGetirByDetayli(cbSanzimanTipi.SelectedItem.ToString(), cbYakitTuru.SelectedItem.ToString(), kiradurumu, cbKiraDurumu.SelectedItem.ToString(),txtMarkayaGore.Text);
            }
        }

        private void dgvAraclar_DoubleClick(object sender, EventArgs e)
        {
            
            cArac arc = new cArac();
            cArac a = new cArac();

            arc.AracGetir(dgvAraclar, a);

            cGenel.AracID = a.AracID;

            this.Close();

        }
    }
}
