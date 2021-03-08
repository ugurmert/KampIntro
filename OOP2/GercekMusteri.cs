using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Individual - Bireysel Müşteri
    class GercekMusteri : Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}

// Bir veri üzerinde matematiksel işlem (toplama, çarpma, bölme, çıkarma) yapmıyorsak, metinsel olarak planlanırsa daha iyi sonuçlar alırız. Örneğin; MusteriNo, TcNo gibi...
