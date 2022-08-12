using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme .. - simülasyon
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        //Interface olduğu için hangi alt implementasyonu gönderirse göndersin onun Hesapla methodu çalışacak.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
