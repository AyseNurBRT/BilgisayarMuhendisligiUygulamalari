using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis3 : MonoBehaviour
{
    public string Sahne3;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            SceneManager.LoadScene(Sahne3);
        }
    }
}