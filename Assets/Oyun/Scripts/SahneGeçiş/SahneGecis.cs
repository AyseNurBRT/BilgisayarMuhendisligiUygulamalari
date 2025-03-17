using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public string Sahne1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            SceneManager.LoadScene(Sahne1);
        }
    }
}