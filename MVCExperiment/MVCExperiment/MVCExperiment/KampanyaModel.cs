using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExperiment
{
    public class KampanyaModel
    {
        public String ID;
        public float minSepetTut,iskontoOranı;

        public KampanyaModel(string iD, float minSepetTut, float iskontoOranı)
        {
            ID = iD;
            this.minSepetTut = minSepetTut;
            this.iskontoOranı = iskontoOranı;
        }

        public override bool Equals(object? obj)
        {
            return obj is KampanyaModel model &&
                   ID == model.ID;
        }
    }
}