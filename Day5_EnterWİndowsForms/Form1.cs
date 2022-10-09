using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5_EnterWİndowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Soyadı_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            MessageBox.Show("Kaydet Tıklandı");
            MessageBox.Show(isim);
            MessageBox.Show(soyisim);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("guncelle butonu tıklandı");
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            
        }
    }
}
    