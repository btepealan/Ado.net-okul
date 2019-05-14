using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_ADONet_OKUL.Models;

namespace wf_ADONet_OKUL.DataModel
{
    public interface ISinifServis
    {
        bool SinifEkle(Sinif s);
        bool SinifGuncelle(Sinif s);
        bool SinifSil(int ID);
        bool SinifSil(Sinif s);
        Sinif SinifGetirByID(int ID);
        List<Sinif> SinifListesi();

    }
}
