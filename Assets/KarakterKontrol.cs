using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: Enes Yiğen
    // Öğrenci Numarası: 232011047


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
 
    private Rigidbody2D karakterRb;

    public float hiz = 500f;
    public float ziplamaGucu = 1500f;

    public int skor = 0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Zipla();
        HareketEt();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
          
        if (other.gameObject.CompareTag("Puan")) 
            {
            skor++;
            Destroy(other.gameObject);
            metin.text = "Score: " + skor;
            }
           
        if (other.gameObject.CompareTag("Engel"))// burası kapı kodu


            if (keyCount > 0)
            {
                Debug.Log("Oyun Bitti");
                Destroy(other.gameObject);
                

            }
       
    }

    void Zipla()
    {
        // Space tuşuna basınca karakter zıplamalı ancak aşağıdaki kod hatalı.

        if (Input.GetKey(KeyCode.Space))
        {
            _playerRigidbody.AddForce(UnityEngine.Vector2.up * (ziplamaGucu * Time.deltaTime));
        }
        
    }

    void HareketEt()
    {
                if (Input.GetKey(KeyCode.A))
        {
            _playerRigidbody.AddForce(UnityEngine.Vector2.left * (hiz * Time.deltaTime));
        }

        else if (Input.GetKey(KeyCode.D))
        {
            _playerRigidbody.AddForce(UnityEngine.Vector2.right * (hiz * Time.deltaTime));
        }
    }
}