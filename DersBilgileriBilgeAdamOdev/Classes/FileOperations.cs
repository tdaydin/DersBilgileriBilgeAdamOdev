using DersBilgileriBilgeAdamOdev.Enums;
using System;
using System.IO;
using System.Windows.Forms;

namespace DersBilgileriBilgeAdamOdev.Classes
{
    class FileOperations : Ioperations
    {
        private readonly string _path;

        public FileOperations()
        {
            _path = Application.StartupPath.Replace(@"\bin\Debug", @"\Files") + @"\Dersler.txt";
        }
        

        public Ders[] GetDersler()
        {
            Ders[] dersler = null;
            string[] lines = File.ReadAllLines(_path);
            Ders ders;
            dersler = new Ders[lines.Length];
            int i = 0;

            foreach (var line in lines)
            {
                ders = new Ders()
                {
                    Id = Convert.ToInt32(line.Split(';')[0]),
                    Adi = line.Split(';')[1],
                    Kategorisi = (KategoriEnum)Convert.ToInt32(line.Split(';')[2]),
                    Icerigi = line.Split(';')[3],
                    Kredi = Convert.ToInt16(line.Split(';')[4])
                };
                dersler[i] = ders;
                i++;
            }
            return dersler;
        }

        public void AddDers(Ders ders)
        {
            Ders[] dersler = GetDersler();
            int dersId = dersler[dersler.Length - 1].Id + 1;
            ders.Id = dersId;
            string line = "\n" + ders.Id + ";" + ders.Adi + ";" + (int)ders.Kategorisi + ";" + ders.Icerigi + ";" + ders.Kredi;
            File.AppendAllText(_path, line);
        }
    }
}
