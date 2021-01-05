using DersBilgileriBilgeAdamOdev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileriBilgeAdamOdev.Classes
{
    class MemoryOperations : Ioperations
    {

        private static Ders[] _dersler = new Ders[3]
        {
            new Ders()
            {
                Id = 1,
                Adi = "Matematik",
                Kategorisi = KategoriEnum.Sayisal,
                Icerigi = "Teaches equations",
                Kredi = 4
            },
            new Ders()
            {
                Id = 2,
                Adi = "Tarih",
                Kategorisi = KategoriEnum.Sosyal,
                Icerigi = "Teaches history",
                Kredi = 4
            },
            new Ders()
            {
                Id = 3,
                Adi = "Ingilizce",
                Kategorisi = KategoriEnum.Sosyal,
                Icerigi = "Teaches grammer",
                Kredi = 4
            },
        };

        public Ders[] GetDersler()
        {
            return _dersler;
        }

        public void AddDers(Ders ders)
        {
            int dersId = _dersler[_dersler.Length - 1].Id + 1;
            ders.Id = dersId;
            Ders[] tmpDersler = _dersler; //stands for temporary dersler -- tmpDersler
            _dersler = new Ders[_dersler.Length + 1];
             
            for (int i = 0; i < tmpDersler.Length; i++)
            {
                _dersler[i] = tmpDersler[i];
            }
            _dersler[_dersler.Length - 1] = ders;

        }

    }
}
