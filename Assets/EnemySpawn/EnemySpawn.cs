using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyRange;
    public Transform melleSpawn;
    public Transform rangeSpawn;
    public GameObject enemyMelee;
    public GameObject tower;
    private float _meleeSpawnInterval = 10;
    private float _rangeSpawnInterval = 25;
    private float _currentMeleeSpawnTime = 0;
    private float _currentRangeSpawnTime = 0;
    private float _bigCountdown = 30;
    private float _currentBigTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        _currentMeleeSpawnTime += Time.deltaTime;
        _currentRangeSpawnTime += Time.deltaTime;
        _currentBigTime += Time.deltaTime;

        if (_currentMeleeSpawnTime >= _meleeSpawnInterval)
        {
            SpawnMelee();
            _currentMeleeSpawnTime = 0;
        }

        if (_currentRangeSpawnTime >= _rangeSpawnInterval)
        {
            SpawnRange();
            _currentRangeSpawnTime = 0;
        }

        if (_currentBigTime >= _bigCountdown)
        {
            _meleeSpawnInterval -= 1f;
            _rangeSpawnInterval -= 1f;
            _currentBigTime = 0;
        }
    }


    public void SpawnRange()
    {
        if (tower.GetComponent<EnemyTower>().hp > 0)
        { Instantiate(enemyRange, rangeSpawn.position, Quaternion.identity);}
        
    }

    public void SpawnMelee()
    {
        if (tower.GetComponent<EnemyTower>().hp > 0)
        {
            Instantiate(enemyMelee, melleSpawn.position, Quaternion.identity);
        }
      
    }
}