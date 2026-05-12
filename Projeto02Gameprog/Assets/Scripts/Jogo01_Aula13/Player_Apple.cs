using UnityEngine;

public class Player_Apple : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] int score = 0;
    void Start()
    {
        transform.position = new Vector2(0f, 0f);
    }

    void Update()
    {
        float mover_x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        float mover_y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        transform.Translate(mover_x, mover_y, 0f);
    }
}
