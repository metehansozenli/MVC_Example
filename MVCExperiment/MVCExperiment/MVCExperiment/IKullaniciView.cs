using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExperiment
{
    public interface IKullaniciView
    {
        public void listBoxKullaniciEkle(UrunModel urun);
        public void listBoxKullaniciGuncelle(UrunModel urun);
        string textBoxUrunIsim { get; set; }
        float textBoxUrunFiyat { get; set; }
        string textBoxID { get; set; }
        int textBoxStokAdedi { get; set; }

    }
}
