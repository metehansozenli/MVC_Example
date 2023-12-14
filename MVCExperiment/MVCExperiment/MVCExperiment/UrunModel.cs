using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExperiment
{
    public class UrunModel
    {
        public String ID, urunIsim;
        public int stokAdedi;
        public float urunFiyat;

        public UrunModel(string iD, string urunIsim, float urunFiyat, int stokAdedi)
        {
            ID = iD;
            this.urunIsim = urunIsim;
            this.urunFiyat = urunFiyat;
            this.stokAdedi = stokAdedi;
        }

        public override bool Equals(object? obj)
        {
            return obj is UrunModel model &&
                   ID == model.ID;
        }
    }
}
