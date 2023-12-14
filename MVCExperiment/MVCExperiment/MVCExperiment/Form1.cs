using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCExperiment
{
    public partial class Form1 : Form, IKullaniciView
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void listboxKullaniciEkle(UrunModel urun)
        {
            object[] input = new object[] { urun.ID, urun.urunIsim, urun.urunFiyat, urun.stokAdedi };
            this.listBox1.Items.Add(input);

        }

       /* public void gridKullaniciGuncelle(UrunModel urun)
        {
            DataGridViewRow rowToUpdate = null;

            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(usr.ID))
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Cells[0].Value = usr.ID;
                rowToUpdate.Cells[1].Value = usr.ad;
                rowToUpdate.Cells[2].Value = usr.soyad;
                rowToUpdate.Cells[3].Value = usr.bolum;

            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
