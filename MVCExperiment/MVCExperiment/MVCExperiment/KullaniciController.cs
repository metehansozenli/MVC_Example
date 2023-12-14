using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCExperiment
{
    public class KullaniciController
    {
        IKullaniciView _view;
        IList _urunler;
        UrunModel _urun;
        SepetUrunModel _sepetUrun;
        KampanyaModel _kampanya;

        public IList urunler
        {
            get { return ArrayList.ReadOnly(_urunler); }
        } 
        private void guncelleView(UrunModel urun)
        {
            _view.textBoxUrunIsim = urun.urunIsim;
            _view.textBoxUrunFiyat = urun.urunFiyat;
            _view.textBoxID = urun.ID;
            _view.textBoxStokAdedi = urun.stokAdedi;

        }

        private void guncelleModel(UrunModel urun)
        {
            urun.urunIsim = _view.textBoxUrunIsim;
            urun.urunFiyat = _view.textBoxUrunFiyat;
            urun.ID = _view.textBoxID;
            urun.stokAdedi = _view.textBoxStokAdedi;

        }
        public void urunEkle()
        {
            _urun = new UrunModel(_view.textBoxID, _view.textBoxUrunIsim, _view.textBoxUrunFiyat, _view.textBoxStokAdedi);

            kaydet();

        }

        public void kaydet()
        {
            guncelleModel(_urun);
            if (!this._urunler.Contains(_urun))
            {
                //Add new user
                this._urunler.Add(_urun);
                this._view.listBoxKullaniciEkle(_urun);
            }
            else
            {
                //Update existing user
                this._view.listBoxKullaniciGuncelle(_urun);
            }
            _view.listBoxKullaniciGuncelle(_urun);


        }
    }
}
