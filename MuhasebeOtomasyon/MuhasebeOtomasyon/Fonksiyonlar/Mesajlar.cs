using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeOtomasyon.Fonksiyonlar
{
    class Mesajlar
    {
        AnaForm MesajForm = new AnaForm();

        public void YeniKayit(string Mesaj)
        {
            MesajForm.Mesaj("Yeni Kayıt Girişi", Mesaj);
        }


        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kayıt kalıcı olarak güncellenecektir\nGüncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir\nSilme işlemini onaylıyor musunuz?","Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        

        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme", "Kayıt Güncellenmiştir");
                }


        public void Hata(Exception Hata)
        {
            MesajForm.Mesaj("Hata Oluştu", Hata.Message);
        }

        public void FormAcilis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu açıldı");
        }


        public void FormKapanis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu kapatıldı");
        }

    }
}
