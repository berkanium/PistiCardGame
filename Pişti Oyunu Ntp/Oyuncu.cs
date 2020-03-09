using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pişti_Oyunu_Ntp
{
    class Oyuncu
    {
        
        public int OyuncuPuani=0;
        public ComboBox OyuncuAldigiKart;
        public ListBox OyuncununElindekiKart;
        public Oyuncu()
        {

        }
        public void playerOyna(ListBox lstOrta, ListBox oyuncuElindekiKart, ComboBox oyuncuAldigiKart, int x)
        {
            if (lstOrta.Items.Count != 0)
            {
                for (int i = 0; i < oyuncuElindekiKart.Items.Count; i++)
                {
                    if (oyuncuElindekiKart.Items[i].ToString().Substring(oyuncuElindekiKart.Items[i].ToString().Length - 2) == lstOrta.Items[0].ToString().Substring(lstOrta.Items[0].ToString().Length - 2) || oyuncuElindekiKart.Items[i].ToString().Substring(oyuncuElindekiKart.Items[i].ToString().Length - 2) == "le")
                    {
                       
                        if (lstOrta.Items.Count == 1)
                        {

                            if (oyuncuElindekiKart.Items[i].ToString().Substring(oyuncuElindekiKart.Items[i].ToString().Length - 2) == lstOrta.Items[0].ToString().Substring(lstOrta.Items[0].ToString().Length - 2))
                            {

                                MessageBox.Show("PİŞTİ OLDU ! ");
                                if (lstOrta.Items[0].ToString().Substring(lstOrta.Items[0].ToString().Length - 2) == "le")
                                {
                                    oyuncuAldigiKart.Items.Add("2 pişti" +" "+ lstOrta.Items[0].ToString());
                                    oyuncuAldigiKart.Items.Add("2 pişti" +" "+ oyuncuElindekiKart.Items[i].ToString());
                                    oyuncuAldigiKart.Items.Add(oyuncuElindekiKart.Items[i].ToString());
                                }
                                else
                                {
                                    oyuncuAldigiKart.Items.Add("1 pişti" +" "+ lstOrta.Items[0].ToString());
                                    oyuncuAldigiKart.Items.Add("1 pişti" +" "+ oyuncuElindekiKart.Items[i].ToString());
                                    oyuncuAldigiKart.Items.Add(oyuncuElindekiKart.Items[i].ToString());
                                }
                            }
                        }
                       

                        
                        else
                        {
                            lstOrta.Items.Insert(0, oyuncuElindekiKart.Items[i]);
                            MessageBox.Show(x + ".oyuncu "+" " + lstOrta.Items.Count +" "+ "kağıt aldı");
                        }
                       
                     
                        for (int k = 0; k < lstOrta.Items.Count; k++)
                        {
                            oyuncuAldigiKart.Items.Add(lstOrta.Items[k]);
                        }
                        
                        oyuncuElindekiKart.Items.Remove(oyuncuElindekiKart.Items[i]);
                        lstOrta.Items.Clear();
                        break;
                    }
                    if (!(i + 1 < oyuncuElindekiKart.Items.Count))
                    {
                        lstOrta.Items.Insert(0, oyuncuElindekiKart.Items[0]);
                        oyuncuElindekiKart.Items.RemoveAt(0);
                    }
                }
            }
            else
            {
                lstOrta.Items.Insert(0, oyuncuElindekiKart.Items[0]);
                oyuncuElindekiKart.Items.RemoveAt(0);
            }
        }
        public void Hesapla2(ComboBox list, int x, Label lbl)
        {
            int hesap = 0;
            for (int i = 0; i < list.Items.Count; i++)
            {
                string gelen = list.Items[i].ToString();
                if (gelen == "SİNEK 2")
                {
                    lbl.Text = hesap.ToString() + " / " + list.Items.Count;
                    hesap += 2;
                }
                if (gelen == "KARO 10")
                {
                    lbl.Text = hesap.ToString() + " / " + list.Items.Count;
                    hesap += 3;
                }
                if (gelen.Substring(gelen.Length - 2) == "le" || gelen.Substring(gelen.Length - 2) == "As")
                {
                    lbl.Text = hesap.ToString() + " / " + list.Items.Count;
                    hesap += 1;
                }
                if (gelen.Substring(0, 5) == "1 pişt")
                {
                    lbl.Text = hesap.ToString() + " / " + list.Items.Count;
                    hesap += 5;
                }
                if (gelen.Substring(0, 5) == "2 pişt")
                {
                    lbl.Text = hesap.ToString() + " / " + list.Items.Count;
                    hesap += 10;
                }
                if (hesap == 0 && list.Items.Count == 0)
                {
                    lbl.Text = "Hiç Bir Başarı Yok";
                }
                else
                {
                    lbl.Text = hesap.ToString() + " / " + list.Items.Count;
                }
            }

        }
    }
}
