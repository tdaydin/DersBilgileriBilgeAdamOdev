using DersBilgileriBilgeAdamOdev.Classes;
using DersBilgileriBilgeAdamOdev.Enums;
using System;
using System.Windows.Forms;

namespace DersBilgileriBilgeAdamOdev
{
    public partial class Form1 : Form
    {

        DersService dersService;

        public Form1()
        {
            InitializeComponent();
            //dersService = new DersService(new MemoryOperations());
            dersService = new DersService(new FileOperations());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
            cbKategori.Items.Add(KategoriEnum.Sayisal);
            cbKategori.Items.Add(KategoriEnum.Sosyal);
        }

        private void FillGrid()
        {
            var dersler = dersService.GetList();
            dgvDersListesi.DataSource = dersler;
        }


        private void bYeniDersEkle_Click(object sender, EventArgs e)
        {
            gbYeniDers.Visible = !gbYeniDers.Visible;
        }

        private void rbHafiza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHafiza.Checked)
            {
                dersService = new DersService(new MemoryOperations());
                FillGrid();
            }
        }

        private void rbDosya_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDosya.Checked)
            {
                dersService = new DersService(new FileOperations());
                FillGrid();
            }
        }

        private void bYeniDersKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                ShowMessageBox("Ogrenci adi bos olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbIcerik.Text))
            {
                ShowMessageBox("Icerik bos olamaz!");
                return;
            }

            Ders ders = new Ders()
            {
                Adi = tbAdi.Text.Trim(),
                Icerigi = tbIcerik.Text.Trim(),
                Kategorisi = (KategoriEnum)cbKategori.SelectedItem,
                Kredi = Convert.ToInt16(nudKredi.Value),
                
            };

            dersService.Add(ders);
            ShowMessageBox("Ders basari ile eklendi.");
            FillGrid();
        }


        private void ShowMessageBox(string message)
        {
            if (message.EndsWith("!"))
                MessageBox.Show(message, "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else //ends with "."
                MessageBox.Show(message, "Basari", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
