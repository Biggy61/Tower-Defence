using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyRange;
    public Transform enemySpawn;
    public GameObject enemyMelee;
    private float gametime;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gametime += Time.deltaTime;
        timer += Time.deltaTime;
        if (gametime >= 10f) {
            if (timer >= 2f) {SpawnMelee(); timer = 0f; } }
        
        if (gametime >= 15f) { 
            if (timer >= 2f) {SpawnMelee(); SpawnRange(); timer = 0f; } }
    }

    public void SpawnRange()
    {
        Instantiate(enemyRange, enemySpawn.position, Quaternion.identity);
    }

    public void SpawnMelee()
    {
        Instantiate(enemyMelee, enemySpawn.position, Quaternion.identity);
    }
}

