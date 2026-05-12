using UnityEngine;

public class Player_Dynamic : MonoBehaviour
{
    float speed = 10f;
    int moedas = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mover_x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        transform.Translate(mover_x, 0f, 0f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Enter");
        //GetComponent<SpriteRenderer>().color = Color.red;
        if(collision.collider.tag == "Big")
        {
            moedas += 5;
            print("Moedas: " + moedas);
            Destroy(collision.gameObject);
        }
        else if(collision.collider.tag == "Small")
        {
            moedas++;
            print("Moedas: " + moedas);
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //print("Stay");
        //transform.localScale = new Vector3(2, 2, 0f);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //print("Exit");
        //transform.
    }
}
