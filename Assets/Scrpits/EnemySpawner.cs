using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Prefab del enemigo a spawnear
    public GameObject enemyPrefab;

    private float timer;
    private float spawnInterval;

    void Start()
    {
        // Genera el primer intervalo aleatorio
        spawnInterval = Random.Range(3f, 7f);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timer = 0f;
            // Genera un nuevo intervalo aleatorio para el siguiente spawn
            spawnInterval = Random.Range(3f, 7f);
        }
    }
}
