using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileriBilgeAdamOdev.Classes
{
    interface Ioperations
    {
        Ders[] GetDersler();

        void AddDers(Ders ders);
    }
}
