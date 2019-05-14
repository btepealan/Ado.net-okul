using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_ADONet_OKUL.Models;

namespace wf_ADONet_OKUL.DataModel
{
    public interface IOgrenciServis
    {
        bool OgrenciEkle(Ogrenci o);
        bool OgrenciGuncelle(Ogrenci o);
        bool OgrenciSil(int ID);
        bool OgrenciSil(Ogrenci o);
        Ogrenci OgrenciGetirByID(int ID);
        List<Ogrenci> OgrenciListesi();
    }
}
