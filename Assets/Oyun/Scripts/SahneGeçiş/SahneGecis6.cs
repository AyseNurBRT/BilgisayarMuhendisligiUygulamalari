using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis6 : MonoBehaviour
{
    public string Sahne6;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            SceneManager.LoadScene(Sahne6);
        }
    }
}