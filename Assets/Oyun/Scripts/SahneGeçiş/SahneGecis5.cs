using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis5 : MonoBehaviour
{
    public string Sahne5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            SceneManager.LoadScene(Sahne5);
        }
    }
}