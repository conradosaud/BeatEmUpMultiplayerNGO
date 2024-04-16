using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform tiroPrefab;
    public float velocidade = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movimento = new Vector2(horizontal, vertical);
        movimento *= velocidade * Time.deltaTime;

        transform.Translate(movimento);

        if( Input.GetKeyDown(KeyCode.Space))
        {
            Atirar();
        }

    }

    void Atirar()
    {
        Transform instancia = Instantiate(tiroPrefab);
        instancia.transform.position = transform.position;
    }

}
