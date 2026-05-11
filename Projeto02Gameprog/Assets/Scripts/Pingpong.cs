using UnityEngine;

public class Pingpong : MonoBehaviour
{
    [SerializeField] float velocidade = 10.0f;
    [SerializeField] float velocidadeRot = 10f;
    void Update()
    {
        //Movimento

        float mover_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        float mover_y = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(mover_x, mover_y, 0f);

        //Tiros

        if (Input.GetButtonDown("Fire1"))
        {
            //Retorna o valor para a coordenada indicada
            transform.position = new Vector2 (0f, 0f);
            transform.eulerAngles = new Vector3 (0f, 0f, 0f);
        }

        if (Input.GetButton("Fire2"))
        {
            transform.Rotate(0f, 0f, velocidadeRot * Time.deltaTime);
            GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        if ()
        /*else if (Input.GetButton("Fire1"))
        {
            print("Button");
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            print("Up");
        }
        transform.Rotate(0.0f, 0.0f 1.0f * Time.deltaTime)
        COM ACELERAÇÃO
        print(Input.GetAxis("Vertical"));
        print(Input.GetAxis("Horizontal"));
        SEM ACELERAÇÃO
        print(Input.GetAxisRaw("Horizontal");*/
    }
}
