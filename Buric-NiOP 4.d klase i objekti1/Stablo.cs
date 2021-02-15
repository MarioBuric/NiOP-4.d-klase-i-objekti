using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buric_NiOP_4.d_klase_i_objekti1
{
    class Stablo:Biljka


    {
        public bool opadajuListovi;
        Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
        public bool OpadajuListovi()
        {
            return opadajuListovi;
        }
    }
}
