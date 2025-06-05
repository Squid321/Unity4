using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Instantiate(enemyPrefab, Generate(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    private Vector3 Generate()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos; 
    }
    
}
