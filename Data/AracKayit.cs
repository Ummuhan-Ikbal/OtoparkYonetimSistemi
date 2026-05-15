using System;

namespace OtoparkOtomasyonu.Data
{
    public class AracKayit
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public string AracTuru { get; set; }
        public DateTime GirisSaati { get; set; }
        public DateTime? CikisSaati { get; set; }
        public decimal Ucret { get; set; }
        public bool IcerideMi { get; set; }
    }
}