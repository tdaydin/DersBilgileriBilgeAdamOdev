using DersBilgileriBilgeAdamOdev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileriBilgeAdamOdev.Classes
{
    class Ders
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public KategoriEnum Kategorisi { get; set; }
        public string Icerigi { get; set; }
        public Int16 Kredi { get; set; }
    }
}
