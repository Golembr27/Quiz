using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    float velocidade = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimentacao = new Vector3 (horizontal, 0f, vertical);
        transform.Translate(movimentacao * velocidade * Time.deltaTime); 
    }
}
