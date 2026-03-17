using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;

    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private float minPositionY;
    [SerializeField] private float maxPositionY;


    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            float randomY = Random.Range(minPositionY, maxPositionY);
            Vector2 spawnPosition = 
                new Vector2(transform.position.x, randomY);
            Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
