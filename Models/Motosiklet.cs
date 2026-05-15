using System;

namespace OtoparkOtomasyonu.Models
{
    public class Motosiklet : Arac
    {
        public override decimal UcretHesapla()
        {
            return (decimal)KalinanSaat() * 30;
        }
    }
}