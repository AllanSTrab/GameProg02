using UnityEngine;

public class PlayerAtiv : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    int score = 0;
    private void Update()
    {
        float mover_x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        float mover_y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        transform.Translate(mover_x, mover_y, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Enter");
        //GetComponent<SpriteRenderer>().color = Color.red;
        if (collision.collider.tag == "Big")
        {
            score += 5;
            print("Moedas: " + score);
            Destroy(collision.gameObject);
        }
        else if (collision.collider.tag == "Small")
        {
            score++;
            print("Moedas: " + score);
            Destroy(collision.gameObject);
        }
    }
}
