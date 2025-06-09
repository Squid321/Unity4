using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerPrefab;
    private float spawnRange = 9;
    private int round = 3;
    public int enemyCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EWave(round);
    }
    void EWave(int spawnint)
    {
        for (int i = 0; i < spawnint; i++) {
            Instantiate(enemyPrefab, Generate(), enemyPrefab.transform.rotation);
        }
    }
    void Update()
    {
        enemyCount = FindObjectsByType<EnemyController>(FindObjectsSortMode.None).Length;
        if (enemyCount == 0)
        {
            round += 1;
            EWave(round);
            Instantiate(powerPrefab, Generate(), powerPrefab.transform.rotation);
        }
    }
    private Vector3 Generate()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos; 
    }
    
}
