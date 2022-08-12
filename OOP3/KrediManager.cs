using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager// hepsinin alternatifi var ama şablon aynı olduğu için base bir arayüz, şablon oluşturulur.
    {
        void Hesapla();
        void BiseyYap();
    }
}
