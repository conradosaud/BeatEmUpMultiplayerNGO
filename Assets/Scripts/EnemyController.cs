using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Transform target;
    float velocidade = 3.5f;

    void Start()
    {
        target = GameObject.FindWithTag("Player")?.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        Vector2 movimento = Vector2.MoveTowards(transform.position, target.position, velocidade * Time.deltaTime);
        transform.position = movimento;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

}
