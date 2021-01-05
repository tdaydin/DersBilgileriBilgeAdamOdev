using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersBilgileriBilgeAdamOdev.Classes
{
    class DersService
    {
        private readonly Ioperations _operations;

        public DersService(Ioperations operations)
        {
            _operations = operations;
        }

        public Ders[] GetList()
        {
            return _operations.GetDersler();
        }

        public void Add(Ders ders)
        {
            _operations.AddDers(ders);
        }
    }
}
