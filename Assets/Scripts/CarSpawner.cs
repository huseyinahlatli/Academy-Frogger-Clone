using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject carPrefab;
    [SerializeField] private float spawnDelay = 0.3f;
    [SerializeField] private Transform[] spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnCar());
    }

    private IEnumerator SpawnCar()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Spawn();
        }
    }

    private void Spawn()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex]; 
        Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
