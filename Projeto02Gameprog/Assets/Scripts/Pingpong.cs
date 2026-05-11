using System;
using UnityEngine;
using UnityEngine.InputSystem.Processors;
using UnityEngine.InputSystem.XR.Haptics;

public class Pingpong : MonoBehaviour
{
    [SerializeField] float velocidade = 10.0f;
    void Update()
    {
        float mover_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        float mover_y = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(mover_x, 0f, 0f);
        transform.Translate(0f, mover_y, 0f);
        //transform.Rotate(0.0f, 0.0f 1.0f * Time.deltaTime)
        //COM ACELERAÇÃO
        //print(Input.GetAxis("Vertical"));
        //print(Input.GetAxis("Horizontal"));
        //SEM ACELERAÇÃO
        //print(Input.GetAxisRaw("Horizontal");
    }
}
