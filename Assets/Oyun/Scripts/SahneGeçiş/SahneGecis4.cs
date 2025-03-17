using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis4 : MonoBehaviour
{
    public string Sahne4;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            SceneManager.LoadScene(Sahne4);
        }
    }
}