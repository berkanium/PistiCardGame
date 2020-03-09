using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pişti_Oyunu_Ntp
{
   public  class KartDestesi
    {
        List<string> dizi = new List<string>();
        Random q = new Random();
        public KartDestesi()
        {
            dizi.Clear();
            string[] kartTuru = { "KARO", "MAÇA", "SİNEK", "KUPA" };
            string[] deger = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Papaz", "Kız" };
            for (int i = 0; i < deger.Length; i++)
            {
                for (int a = 0; a < kartTuru.Length; a++)
                {
                    dizi.Add(kartTuru[a] + " " + deger[i]);
                }
            }
            
        }
        public void KartDagit(ListBox[] Eklenecek)
        {

            for (int i = 0; i < Eklenecek.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int index = q.Next(0 , dizi.Count);
                    Eklenecek[i].Items.Add(dizi[index]);
                    dizi.RemoveAt(index);
                }
            }
        }

    }
}
