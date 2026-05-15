using System;

namespace OtoparkOtomasyonu.Models
{
    public class Otomobil : Arac
    {
        public override decimal UcretHesapla()
        {
            return (decimal)KalinanSaat() * 50;
        }
    }
}