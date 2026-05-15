using OtoparkOtomasyonu.Data;
using OtoparkOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
namespace OtoparkOtomasyonu.Services
{
    public class OtoparkService
    {
        private readonly string dosyaYolu = "araclar.json";
        private List<AracKayit> kayitlar;

        public OtoparkService()
        {
            kayitlar = DosyadanOku();
        }

        public List<AracKayit> TumKayitlariGetir()
        {
            return kayitlar;
        }

        public List<AracKayit> IceridekiAraclariGetir()
        {
            return kayitlar.Where(x => x.IcerideMi).ToList();
        }

        public void AracEkle(string plaka, string aracTuru)
        {
            if (string.IsNullOrWhiteSpace(plaka))
                throw new Exception("Plaka boş bırakılamaz.");

            if (string.IsNullOrWhiteSpace(aracTuru))
                throw new Exception("Araç türü seçilmelidir.");

            if (kayitlar.Any(x => x.Plaka.ToUpper() == plaka.ToUpper() && x.IcerideMi))
                throw new Exception("Bu plaka zaten otoparkta.");

            AracKayit yeniKayit = new AracKayit
            {
                Id = kayitlar.Count == 0 ? 1 : kayitlar.Max(x => x.Id) + 1,
                Plaka = plaka.ToUpper(),
                AracTuru = aracTuru,
                GirisSaati = DateTime.Now,
                CikisSaati = null,
                Ucret = 0,
                IcerideMi = true
            };

            kayitlar.Add(yeniKayit);
            DosyayaYaz();
        }

        public decimal AracCikisYap(int id)
        {
            AracKayit kayit = kayitlar.FirstOrDefault(x => x.Id == id);

            if (kayit == null)
                throw new Exception("Kayıt bulunamadı.");

            if (!kayit.IcerideMi)
                throw new Exception("Bu araç zaten çıkış yapmış.");

            kayit.CikisSaati = DateTime.Now;
            kayit.IcerideMi = false;

            Arac arac = AracNesnesiOlustur(kayit);
            kayit.Ucret = arac.UcretHesapla();

            DosyayaYaz();
            return kayit.Ucret;
        }

        public void AracSil(int id)
        {
            AracKayit kayit = kayitlar.FirstOrDefault(x => x.Id == id);

            if (kayit == null)
                throw new Exception("Silinecek kayıt bulunamadı.");

            kayitlar.Remove(kayit);
            DosyayaYaz();
        }

        public void AracGuncelle(int id, string plaka, string aracTuru)
        {
            AracKayit kayit = kayitlar.FirstOrDefault(x => x.Id == id);

            if (kayit == null)
                throw new Exception("Güncellenecek kayıt bulunamadı.");

            if (string.IsNullOrWhiteSpace(plaka))
                throw new Exception("Plaka boş bırakılamaz.");

            kayit.Plaka = plaka.ToUpper();
            kayit.AracTuru = aracTuru;

            DosyayaYaz();
        }

        private Arac AracNesnesiOlustur(AracKayit kayit)
        {
            Arac arac;

            if (kayit.AracTuru == "Otomobil")
                arac = new Otomobil();
            else if (kayit.AracTuru == "Motosiklet")
                arac = new Motosiklet();
            else
                arac = new Kamyonet();

            arac.Plaka = kayit.Plaka;
            arac.GirisSaati = kayit.GirisSaati;
            arac.CikisSaati = kayit.CikisSaati.Value;

            return arac;
        }

        private List<AracKayit> DosyadanOku()
        {
            try
            {
                if (!File.Exists(dosyaYolu))
                    return new List<AracKayit>();

                string json = File.ReadAllText(dosyaYolu);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<AracKayit>();

                return JsonConvert.DeserializeObject<List<AracKayit>>(json);
            }
            catch
            {
                return new List<AracKayit>();
            }
        }

        private void DosyayaYaz()
        {
            string json = JsonConvert.SerializeObject(kayitlar, Formatting.Indented);

            File.WriteAllText(dosyaYolu, json);
        }
    }
}
