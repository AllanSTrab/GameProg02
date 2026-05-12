using UnityEngine;
public class Apple : MonoBehaviour
{
    int score = 0;

    private void Update()
    {
        back();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy(collision.gameObject);
            score++;
            print("Score: " + score);
            gameObject.transform.position = new Vector2(Random.Range(-8f, 8f), 6f);
        }
    }
    private void back()
    {
        if (transform.position.y < -5f)
        {
            gameObject.transform.position = new Vector2(Random.Range(-8f, 8f), 6f);
        }
    }
}
