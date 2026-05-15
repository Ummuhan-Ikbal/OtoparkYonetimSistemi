using System;

namespace OtoparkOtomasyonu.Models
{
    public abstract class Arac
    {
        public string Plaka { get; set; }

        public DateTime GirisSaati { get; set; }

        public DateTime CikisSaati { get; set; }

        public abstract decimal UcretHesapla();

        public double KalinanSaat()
        {
            TimeSpan fark = CikisSaati - GirisSaati;
            return fark.TotalHours;
        }
    }
}