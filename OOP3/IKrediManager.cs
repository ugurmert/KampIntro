using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Okunaklığı artırmak amacıyla interface adı I ile başlar
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}

// IKrediManager sırf bizim için referans tutsun diye ve aynı zamanda tüm kredi tiplerinin uygulaması zorunlu olması istenen operasyonları tutsun diye bu interface'i oluşturuyoruz.
// Bir interface oluşturduğumuzda, o interface içerisindeki operasyonlar alternatif sistemler için bir şablon ve referans tutucu görevi görüyor
// Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
