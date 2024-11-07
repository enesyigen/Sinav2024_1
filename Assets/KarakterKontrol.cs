using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    // Ad Soyad: Emrah Karakoç
    // Öğrenci Numarası: 232011018


    // Soru 1: Karakteri yön tuşları ile hareket ettiren kodu, HareketEt fonksiyonu içerisine yazınız.
    // Soru 2: Karakterin zıplamasını sağlaması beklenen Zipla metodu doğru bir şekilde çalışmıyor, koddaki hatayı düzeltin.
    // Soru 3: Karakterin 'Engel' tag'ine sahip objeye temas ettiğinde metin objesine "Oyun Bitti!" yazısını yazdırınız.
    // Soru 4: Karakterin 'Puan' tag'ine sahip objeye temas ettiğinde skoru 1 arttırınız ve metin objesine yazdırınız.

    // Not: Engel ve Puan nesnelerinin isTrigger özelliği aktiftir.


    public TMP_Text metin;
    
   

    private Rigidbody2D karakterRb;
    public float hiz = 5f;
    public float ziplama = 5f;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal"), 0f);
        transform.position += (Vector3)(velocity * hiz * Time.deltaTime);

        if (Input.GetButtonDown("Zipla"))
            Zipla();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    if (other.CompareTag("Puanınız"))
    {
        skor++;
        metin.text = "Skor: " + skor;
    }
       if (other.CompareTag("Engel"))
    {
        metin.text = "Oyununuz Bitti!";
    }
} // Soru 3 ve soru 4 burada çözülecek.
    

    void Zipla()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            karakterRb.AddForce(Vector2.up * ziplama , ForceMode2D.Impulse);
        }
    }
}
