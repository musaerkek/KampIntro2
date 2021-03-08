using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri = Coorporate
    class TuzelMusteri:Musteri //Buna miras = inheritance diyoruz.
    {      
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
