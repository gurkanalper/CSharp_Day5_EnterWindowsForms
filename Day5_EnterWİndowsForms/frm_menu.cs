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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void muhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muhasebeGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("giriş formu");
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void öğenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ogrenciListele frm_OgrenciListele = new frm_ogrenciListele();
            frm_OgrenciListele.ShowDialog();
        }
    }
}
