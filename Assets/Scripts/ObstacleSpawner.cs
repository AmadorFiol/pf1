using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstaclePrefab;
    
    [SerializeField]
    private float _spawnRate;

    private float timer=0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= _spawnRate)
        {
            Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5), 0f);
            Instantiate(_obstaclePrefab, randomPos, Quaternion.identity);
            
            timer = 0;
        }
    }
}
