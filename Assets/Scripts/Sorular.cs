using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sorular : MonoBehaviour
{
    private string[] soru, secenekA, secenekB, secenekC, secenekD; 
    // Start is called before the first frame update
    private int[] dogruCevap; 
    public Text buttonTextA, buttonTextB, buttonTextC, buttonTextD;

    [HideInInspector]
    
    private Text soruYazisi;
    public int soruSayisi, maxSoru;

    void Start()
    {
        soruSayisi = 1;
        maxSoru = 10;

        soru = new string[maxSoru + 1];

        secenekA = new string[maxSoru +1];
        secenekB = new string[maxSoru +1];
        secenekC = new string[maxSoru +1];
        secenekD = new string[maxSoru +1];
        dogruCevap = new int[maxSoru + 1];
        soruYazisi = gameObject.GetComponent<Text>();

        

        soru[1] = "Akýllý bir þehirde aþaðýdaki teknolojilerden hangisi kullanýlabilir?";

        secenekA[1] = "Uzay gemileri";
        secenekB[1] = "Yapay Zeka";
        secenekC[1] = "Süper Kahramanlar";
        secenekD[1] = "Oyuncuk Arabalar";
        dogruCevap[1] = 2;

        soru[2] = "Akýllý þehirlerde kullanýlan trafik ýþýklarý hangi amaçla kullanýlýr?";

        secenekA[2] = "Ýnsanlarý korkutmak";
        secenekB[2] = "Trafik akýþýný yönetmek";
        secenekC[2] = "Uçan arabalarý durdurmak";
        secenekD[2] = "Çiçek yetiþtirmek";
        dogruCevap[2] = 2;


        soru[3] = "Bir þehir akýllý olabilir mi?";

        secenekA[3] = "Evet, yalnýzca masallarda";
        secenekB[3] = "Hayýr, sadece robotlar akýllý olabilir";
        secenekC[3] = "Evet, teknolojiyi kullanarak";
        secenekD[3] = "Hayýr, sadece büyücüler akýllý olabilir";
        dogruCevap[3] = 3;


        soru[4] = "Akýllý þehirlerdeki sensörler ne iþe yarar?";

        secenekA[4] = "Çiçek yetiþirmek";
        secenekB[4] = "Sesli hikayeler anlatmak için";
        secenekC[4] = "Veri toplamak ve þehri daha iyi yönetmek için";
        secenekD[4] = "Yýldýzlarý izlemek için";
        dogruCevap[4] = 3;


        soru[5] = "Akýllý þehirlerde hangi tür cihazlar kullanýlýr?";

        secenekA[5] = "Dinozorlar";
        secenekB[5] = "Elektronik cihazlar";
        secenekC[5] = "Masal kitaplarý";
        secenekD[5] = "Rüzgar türbinleri";
        dogruCevap[5] = 2;

        soru[6] = "Bir þehri akýllý yapan nedir?";

        secenekA[6] = "Mutlu insanlar";
        secenekB[6] = "Süper kahramanlar";
        secenekC[6] = "Düþünceli hayvanlar";
        secenekD[6] = "Teknoloji ve veri kullanýmý";
        dogruCevap[6] = 4;

        soru[7] = "Akýllý þehirlerde hangi ulaþým yöntemi yaygýn olarak kullanýlabilir?";

        secenekA[7] = "At arabalarý";
        secenekB[7] = "Yürüyerek gitmek";
        secenekC[7] = "Uçan arabalar";
        secenekD[7] = "Uzay gemileri";
        dogruCevap[7] = 2;

        soru[8] = "Bir þehirdeki insanlarýn hayatlarýný daha iyi hale getirmek için hangi teknolojiler kullanýlabilir?";

        secenekA[8] = "Yalnýzca büyücülerin sihirli güçleriyle";
        secenekB[8] = "Teknoloji ve akýllý sistemler kullanarak";
        secenekC[8] = "Sadece balonlar";
        secenekD[8] = "El emeði dokuma halýlar";
        dogruCevap[8] = 2;

        soru[9] = "Akýllý þehirlerde hangi tür hizmetler bulunabilir?";

        secenekA[9] = "Sadece oyuncak dükkanlarý";
        secenekB[9] = "Enerji yönetimi";
        secenekC[9] = "Yalnýza çay bahçeleri";
        secenekD[9] = "Sadece çiçekçiler";
        dogruCevap[9] = 2;

        soru[10] = "Akýllý þehirlerdeki teknolojilerin amacý nedir?";

        secenekA[10] = "Ýnsanlarýn hayatýný daha kolay hale getirmek";
        secenekB[10] = "Kahramanlarý bulmak";
        secenekC[10] = "Robotlarý eðlendirmek";
        secenekD[10] = "Büyücüleri iþini kolaylaþtýrmak";
        dogruCevap[10] = 1;

    }

    // Update is called once per frame
    void Update()
    {
        soruYazisi.text = soru[soruSayisi];
        buttonTextA.text = secenekA[soruSayisi];
        buttonTextB.text = secenekB[soruSayisi];
        buttonTextC.text = secenekC[soruSayisi];
        buttonTextD.text = secenekD[soruSayisi];
    }

    public void ButtonSecenekA()
    {
       if (soruSayisi < maxSoru)
       {
           if(dogruCevap[soruSayisi]==1)
           {
               Debug.Log("Dogru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if (dogruCevap[soruSayisi] == 1)
           {
               Debug.Log("Doðru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }
           oyunBitti();
       }
    }

     public void ButtonSecenekB()
    {
        if (soruSayisi < maxSoru)
       {
           if(dogruCevap[soruSayisi]==2)
           {
               Debug.Log("Dogru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if (dogruCevap[soruSayisi] == 2)
           {
               Debug.Log("Doðru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }

           oyunBitti();
       }
    }

     public void ButtonSecenekC()
    {
         if (soruSayisi < maxSoru)
       {
           if(dogruCevap[soruSayisi]==3)
           {
               Debug.Log("Dogru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if(dogruCevap[soruSayisi] == 3)
           {
               Debug.Log("Doðru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }
           oyunBitti();
       }
    }

     public void ButtonSecenekD()
    {
        if (soruSayisi < maxSoru)
       {
           if(dogruCevap[soruSayisi]==4)
           {
               Debug.Log("Dogru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if(dogruCevap[soruSayisi] == 4)
           {
               Debug.Log("Doðru Cevap");
           }
           else
           {
               Debug.Log("Yanlýþ Cevap");
           }

           oyunBitti();
       }
    }

    public void oyunBitti()
    {
        Debug.Log("Oyun Bitti !");
    }
}
