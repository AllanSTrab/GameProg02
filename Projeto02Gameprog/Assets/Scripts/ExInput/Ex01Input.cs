using UnityEditor.Rendering;
using UnityEngine;

public class Ex01Input : MonoBehaviour
{
    [SerializeField] float velocidade = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float Rotx = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        float mover_y = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(0f , mover_y, 0f);

        transform.Rotate(0f, 0f, -1f * Rotx);

        if (Input.GetButtonDown("Jump"))
        {
            transform.position = new Vector2(0f, 0f);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
      
    }
}
