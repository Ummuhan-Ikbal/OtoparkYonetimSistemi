using System;

namespace OtoparkOtomasyonu.Models
{
    public class Kamyonet : Arac
    {
        public override decimal UcretHesapla()
        {
            return (decimal)KalinanSaat() * 80;
        }
    }
}