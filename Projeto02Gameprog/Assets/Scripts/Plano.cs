using UnityEngine;

public class Aula12 : MonoBehaviour
{
    [SerializeField] Vector2 nova_posicao;
    [SerializeField] Vector3 nova_rotacao;
    [SerializeField] Vector2 nova_escala;

    private void Start()
    {
        //Obtem as informaçoes do componente transform e sua propriedade
        print("Posição: " + transform.position);
        print("Rotação: " + transform.eulerAngles); // rotação em graus(Euler)
        print("Escala: " + transform.localScale);

        //Atribui com valores numericos
        transform.position = new Vector2(0.0f, 0.0f);
    }
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            //Atribui com variáveis
            /*
            transform.position = nova_posicao;
            transform.eulerAngles = nova_rotacao;
            transform.localScale = nova_escala;
            */

            //Alterar a posição do objeto aleatoriamente
            transform.position = new Vector2(Random.Range(-4.0f, 4.0f), Random.Range(-3.0f, 3.0f));
        }
    }
}
