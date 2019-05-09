﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaglikUrunleri.PL.MVC.Models
{
    public class cSepet
    {
        public int urunId { get; set; }
        public string urunAd { get; set; }
        public int adet { get; set; }
        public decimal fiyat { get; set; }
        public decimal tutar { get; set; }

        public static List<cSepet> SepetAl()
        {
            HttpContext context = HttpContext.Current;
            if (context.Session["sepet"] == null)
                context.Session["sepet"] = new List<cSepet>();

            return (List<cSepet>)context.Session["sepet"];
        }
        public void SepetEkle(List<cSepet> sepet, cSepet siparis)
        {
            if (sepet.Any(x => x.urunId == siparis.urunId))
            {
                //ürün daha önceden sepete atılmışsa
                foreach (cSepet item in sepet)
                {
                    if (item.urunId == siparis.urunId)
                    {
                        item.adet += siparis.adet;
                        item.tutar += siparis.tutar;

                    }
                }
            }
            else
            {
                //ürün ilk defa sepete atılıyorsa 
                sepet.Add(siparis);
            }
            HttpContext.Current.Session["sepet"] = sepet;
            HttpContext.Current.Session["toplamadet"] = ToplamAdet(sepet);
            HttpContext.Current.Session["tolamtutar"] = ToplamTutar(sepet);
        }

        public   int ToplamAdet(List<cSepet> sepet)
        {
            int TopAdet = 0;
            foreach(cSepet urun in sepet)
            {
                TopAdet += urun.adet;
            }
            return TopAdet;
        }
        public decimal ToplamTutar(List<cSepet> sepet)
        {
            decimal TopTutar = 0;
            foreach (cSepet urun in sepet)
            {
                TopTutar += urun.tutar;
            }
            return TopTutar;
        }
    }
}