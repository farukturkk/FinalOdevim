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

        

        soru[1] = "Ak�ll� bir �ehirde a�a��daki teknolojilerden hangisi kullan�labilir?";

        secenekA[1] = "Uzay gemileri";
        secenekB[1] = "Yapay Zeka";
        secenekC[1] = "S�per Kahramanlar";
        secenekD[1] = "Oyuncuk Arabalar";
        dogruCevap[1] = 2;

        soru[2] = "Ak�ll� �ehirlerde kullan�lan trafik ���klar� hangi ama�la kullan�l�r?";

        secenekA[2] = "�nsanlar� korkutmak";
        secenekB[2] = "Trafik ak���n� y�netmek";
        secenekC[2] = "U�an arabalar� durdurmak";
        secenekD[2] = "�i�ek yeti�tirmek";
        dogruCevap[2] = 2;


        soru[3] = "Bir �ehir ak�ll� olabilir mi?";

        secenekA[3] = "Evet, yaln�zca masallarda";
        secenekB[3] = "Hay�r, sadece robotlar ak�ll� olabilir";
        secenekC[3] = "Evet, teknolojiyi kullanarak";
        secenekD[3] = "Hay�r, sadece b�y�c�ler ak�ll� olabilir";
        dogruCevap[3] = 3;


        soru[4] = "Ak�ll� �ehirlerdeki sens�rler ne i�e yarar?";

        secenekA[4] = "�i�ek yeti�irmek";
        secenekB[4] = "Sesli hikayeler anlatmak i�in";
        secenekC[4] = "Veri toplamak ve �ehri daha iyi y�netmek i�in";
        secenekD[4] = "Y�ld�zlar� izlemek i�in";
        dogruCevap[4] = 3;


        soru[5] = "Ak�ll� �ehirlerde hangi t�r cihazlar kullan�l�r?";

        secenekA[5] = "Dinozorlar";
        secenekB[5] = "Elektronik cihazlar";
        secenekC[5] = "Masal kitaplar�";
        secenekD[5] = "R�zgar t�rbinleri";
        dogruCevap[5] = 2;

        soru[6] = "Bir �ehri ak�ll� yapan nedir?";

        secenekA[6] = "Mutlu insanlar";
        secenekB[6] = "S�per kahramanlar";
        secenekC[6] = "D���nceli hayvanlar";
        secenekD[6] = "Teknoloji ve veri kullan�m�";
        dogruCevap[6] = 4;

        soru[7] = "Ak�ll� �ehirlerde hangi ula��m y�ntemi yayg�n olarak kullan�labilir?";

        secenekA[7] = "At arabalar�";
        secenekB[7] = "Y�r�yerek gitmek";
        secenekC[7] = "U�an arabalar";
        secenekD[7] = "Uzay gemileri";
        dogruCevap[7] = 2;

        soru[8] = "Bir �ehirdeki insanlar�n hayatlar�n� daha iyi hale getirmek i�in hangi teknolojiler kullan�labilir?";

        secenekA[8] = "Yaln�zca b�y�c�lerin sihirli g��leriyle";
        secenekB[8] = "Teknoloji ve ak�ll� sistemler kullanarak";
        secenekC[8] = "Sadece balonlar";
        secenekD[8] = "El eme�i dokuma hal�lar";
        dogruCevap[8] = 2;

        soru[9] = "Ak�ll� �ehirlerde hangi t�r hizmetler bulunabilir?";

        secenekA[9] = "Sadece oyuncak d�kkanlar�";
        secenekB[9] = "Enerji y�netimi";
        secenekC[9] = "Yaln�za �ay bah�eleri";
        secenekD[9] = "Sadece �i�ek�iler";
        dogruCevap[9] = 2;

        soru[10] = "Ak�ll� �ehirlerdeki teknolojilerin amac� nedir?";

        secenekA[10] = "�nsanlar�n hayat�n� daha kolay hale getirmek";
        secenekB[10] = "Kahramanlar� bulmak";
        secenekC[10] = "Robotlar� e�lendirmek";
        secenekD[10] = "B�y�c�leri i�ini kolayla�t�rmak";
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
               Debug.Log("Yanl�� Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if (dogruCevap[soruSayisi] == 1)
           {
               Debug.Log("Do�ru Cevap");
           }
           else
           {
               Debug.Log("Yanl�� Cevap");
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
               Debug.Log("Yanl�� Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if (dogruCevap[soruSayisi] == 2)
           {
               Debug.Log("Do�ru Cevap");
           }
           else
           {
               Debug.Log("Yanl�� Cevap");
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
               Debug.Log("Yanl�� Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if(dogruCevap[soruSayisi] == 3)
           {
               Debug.Log("Do�ru Cevap");
           }
           else
           {
               Debug.Log("Yanl�� Cevap");
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
               Debug.Log("Yanl�� Cevap");
           }
           soruSayisi += 1;

       }
       else
       {
           if(dogruCevap[soruSayisi] == 4)
           {
               Debug.Log("Do�ru Cevap");
           }
           else
           {
               Debug.Log("Yanl�� Cevap");
           }

           oyunBitti();
       }
    }

    public void oyunBitti()
    {
        Debug.Log("Oyun Bitti !");
    }
}
