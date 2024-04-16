using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float velocidade = 10f;
    public float tempoVida = 1f;

    void Start()
    {
        Invoke("DestroiBala", tempoVida);
    }

    void Update()
    {
        Vector2 movimento = Vector2.right * velocidade * Time.deltaTime;
        transform.Translate(movimento);
    }

    void DestroiBala()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.TryGetComponent<EnemyController>(out EnemyController enemyController))
        {
            Destroy(collision.gameObject);
            DestroiBala();
        }
    }

}
