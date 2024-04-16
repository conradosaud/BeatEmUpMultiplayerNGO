using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public Transform enemyPrefab;
    public float velocidade = 5f;
    public float intervaloSpawn = 1.5f;
    public float tamanhoMovimento = 1;

    bool aumentar = true;

    // Start is called before the first frame update
    void Start()
    {
        SpawnInimigo();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > tamanhoMovimento)
            aumentar = false;
        if (transform.position.y < -tamanhoMovimento)
            aumentar = true;

        Vector2 movimento = transform.position;
        if (aumentar)
            movimento.y += velocidade * Time.deltaTime;
        else
            movimento.y -= (velocidade * Time.deltaTime);

        transform.position = movimento;
    }


    void SpawnInimigo()
    {
        Instantiate(enemyPrefab);
        enemyPrefab.position = transform.position;
        float intervalo = Random.Range(intervaloSpawn / 2, intervaloSpawn*2);
        Invoke("SpawnInimigo", intervaloSpawn);
    }

}
