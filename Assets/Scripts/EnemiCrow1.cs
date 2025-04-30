using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemiCrow : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            HeartSystem.health -= 1;

        }

        if(HeartSystem.health <= 0)
        {
            SceneManager.LoadScene("Game_Twoo");
        }

        
    }
}
