using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyinkod : MonoBehaviour
{
    public UnityEngine.UI.Text Jacksöz;
    int minSayi = 1;
    int maxSayi = 100;
    int tahmin;
    bool OyunBasladi = false;
    bool OyunBitti = false;
    // Start is called before the first frame update
    void Start()
    {
        Jacksöz.text = "Merhaba ben Jack! Aklından bir sayı tut oyununu oynamak ister misin (E/h)?";
    }

    // Update is called once per frame
    void Update()
    {
        if (!OyunBasladi)
        {
            if (Input.GetKeyDown(KeyCode.E)) //E'ye basarsa altındaki yazı görülecek ve oyun başlıyacak
            {
                Jacksöz.text = ("Aklından 1-100 arası sayi tut ve Enter tuşuna bas!");
            }
            else if (Input.GetKeyDown(KeyCode.H)) //Eğer H'ye basarsa altındaki yazı görülecek ve oyun başlamayacak else if yazmamızın sebebi eğer e'ye basmışsa h'ye basmayacaktır oyuncu bu yüzden eğer e'ye basmamışsa anlamında else if kullanacağız.
            {
                Jacksöz.text = ("Yapma Be :(");
                OyunBitti = true;
            }
            if (Input.GetKeyDown(KeyCode.Return)) //Bu enter tuşuna basıldığında aşağıdaki işlemi yapacak
            {
                tahmin = (minSayi + maxSayi) / 2; //Burayı da Kontrol(); diye yazabiliriz ancak böyle de kalabilir bir sıkıntı oluşmaz her iki şekilde de yazılabildiğini görmek istiyorum
                Jacksöz.text = ("Aklından tuttuğun sayı" + tahmin + "mi? Daha büyük ise yukarı,daha küçük ise aşağı yön tuşuna bas, doğruysa boşluk tuşuna bas!");
                OyunBasladi = true;
            }
        }
        else if (!OyunBitti)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) //Aklımızdaki sayıdan gösterilen sayı daha büyükse bu işlemler kullanılacak
            {
                minSayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)) //Aklımızdaki sayıdan gösterilen sayı daha küçükse bu işlemler kullanılacak 
            {
                maxSayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                Jacksöz.text = ("Yaşasın,aklındaki sayıyı buldum :D !");
                OyunBitti = true;
            }

            void Kontrol()
            { //void komutuyla dosyamızı daha sadeleştirebiliriz
                tahmin = (minSayi + maxSayi) / 2;
                Jacksöz.text = ("Aklından tuttuğun sayı" + tahmin + "mi? Daha büyük ise yukarı,daha küçük ise aşağı yön tuşuna bas, doğruysa boşluk tuşuna bas!");
            }
        }

    }
}
