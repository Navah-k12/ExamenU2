using UnityEngine;
using UnityEngine.SceneManagement;

public class TrianguloImpacto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("ZonaDano"))
        {
            Debug.Log("Golpe por la espalda");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
