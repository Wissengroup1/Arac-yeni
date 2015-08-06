using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfAracKiralama
{
    class cGenel
    {
        public static string connStr = "Data Source=WISSEN232; Initial Catalog=AraçKiralama; uid=sa; pwd=12345";

        public static string MusteriTipi ="";
        public static string FormMusteri = "";
        public static int AracID = 0;
        public static int BireyselMusteriID = 0;
        public static int KurumsalMusteriID = 0;
        public static int KiraDetayKurumsal = 0;
        public static int AracEkle = 0;
        public static int[] aracid = new int[20];

    }
}
