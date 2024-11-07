using System;
using TMPro;
using UnityEngine;
using TriggerTag.Engel;
using TriggerTag.Puan;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: Meriç Armağan Yücel
    // Öğrenci Numarası: 232011023


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
    private Rigidbody2D karakterRb;

    public float hiz = 5f;
    public float ziplamaGucu = 5f;

    public int skor = 0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yazdığınız metodları çağırınız.
        HareketEt();
        Zipla();
        OnTriggerEnter2D();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Soru 3 ve soru 4 burada çözülecek.
        if(karakterRb(x,y,z)==TriggerTag.Engel(x,y,z))
        {
            TMP_Text metin="Oyun Bitti!";
            transform.Vector3(0,0,0);
        }
        else if(karakterRb(x,y,z)==TriggerTag.Puan(x,y,z))
        {
            skor++;
        }
    }

    void Zipla()
    {
        // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 ziplamaYonu = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f));
            karakterRb.AddForce(UnityEngine.Vector3.ziplamaYonu * (ziplamaGucu / 2), ForceMode2D.Impulse);
        }
    }
    void HareketEt()
    {
        if(input.GetKey(KeyCode.LeftArrow))
        {
            karakterRb.AddForce(UnityEngine.Vector3.Left*hiz);
        }
        else if(input.GetKey(KeyCode.RightArrow))
        {
            karakterRb.AddForce(UnityEngine.Vector3.Right*hiz);
        }
    }
}