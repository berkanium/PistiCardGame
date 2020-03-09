using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
namespace Pişti_Oyunu_Ntp
{
    class YeniOyun
    {
        public void Temizle(Label[] dizi, ListBox[] dizi1, ComboBox[] dizi2)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i].Text = "";
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi1[i].Items.Clear();
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i].Items.Clear();
            }

        }
         
    }
}
