using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExperiment
{
    public class SepetUrunModel
    {
        public String ID, sepetUrunId;
        public int stokAdedi;

        public SepetUrunModel(string iD, string sepetUrunId, int stokAdedi)
        {
            ID = iD;
            this.sepetUrunId = sepetUrunId;
            this.stokAdedi = stokAdedi;
        }

        public override bool Equals(object? obj)
        {
            return obj is SepetUrunModel model &&
                   ID == model.ID;
        }
    }
}