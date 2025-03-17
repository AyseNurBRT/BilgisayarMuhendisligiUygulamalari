using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis2 : MonoBehaviour
{
    public string Sahne2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            SceneManager.LoadScene(Sahne2);
        }
    }
}
