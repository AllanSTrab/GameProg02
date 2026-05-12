using UnityEngine;

public class ItensAtiv : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            score++;
            print("Score: " + score);
        }
    }
}
