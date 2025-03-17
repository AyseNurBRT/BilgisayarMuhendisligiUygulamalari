using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float hareketHizi = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector2 sonHareketYon;
    private Vector3 karakterOlcek;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sonHareketYon = Vector2.down; // Başlangıç yönü aşağı
        karakterOlcek = transform.localScale;
    }

    void FixedUpdate()
    {
        float yatayHareket = Input.GetAxisRaw("Horizontal");
        float dikeyHareket = Input.GetAxisRaw("Vertical");

        Vector2 hareket = new Vector2(yatayHareket, dikeyHareket).normalized * hareketHizi;
        rb.linearVelocity = hareket;

        // Animasyon Parametrelerini Ayarla
        animator.SetFloat("Yatay", yatayHareket);
        animator.SetFloat("Dikey", dikeyHareket);

        // Animasyon Kontrolü
        if (hareket != Vector2.zero)
        {
            sonHareketYon = hareket.normalized;
            if (Mathf.Abs(yatayHareket) > Mathf.Abs(dikeyHareket))
            {
                if (yatayHareket > 0)
                {
                    animator.Play("WalkSolKahraman"); // Sağa doğru hareket animasyonu
                    
                    transform.localScale = new Vector3(-Mathf.Abs(karakterOlcek.x), karakterOlcek.y, karakterOlcek.z); // Sola döndür
                }
                else
                {
                    animator.Play("WalkSolKahraman"); // Sola doğru hareket animasyonu
                    transform.localScale = new Vector3(Mathf.Abs(karakterOlcek.x), karakterOlcek.y, karakterOlcek.z); // Sağa döndür
                }
            }
            else
            {
                if (dikeyHareket > 0)
                {
                    animator.Play("WalkYukariKahraman"); // Yukarı doğru hareket animasyonu
                }
                else
                {
                    animator.Play("WalkKahraman"); // Aşağı doğru hareket animasyonu
                }
            }
        }
        else
        {
            IdleAnimasyonuOynat(); // Karakter durduğunda idle animasyonunu oynat
        }

        float hassasiyet = 0.01f; // İstediğiniz hassasiyet değerini ayarlayın

        if (Mathf.Abs(yatayHareket) < hassasiyet)
        {
            yatayHareket = 0f;
        }

        if (Mathf.Abs(dikeyHareket) < hassasiyet)
        {
            dikeyHareket = 0f;
        }

        // Animasyon Parametrelerini Ayarla
        animator.SetFloat("Yatay", yatayHareket);
        animator.SetFloat("Dikey", dikeyHareket);
    }

    void IdleAnimasyonuOynat()
    {
        if (sonHareketYon == Vector2.left)
        {
            animator.Play("idleSolKahraman");
        }
        else if (sonHareketYon == Vector2.up)
        {
            animator.Play("idleYukariKahraman");
        }
        else if (sonHareketYon == Vector2.right)
        {
            animator.Play("idleSolKahraman");
            transform.localScale = new Vector3(Mathf.Abs(karakterOlcek.x), karakterOlcek.y, karakterOlcek.z); // Sağa döndür
        }
        else if (sonHareketYon == Vector2.down)
        {
            animator.Play("idleKahraman");
        }
    }
}