using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemies;


    [Space(3)]
    public float waitingForNextSpawn = 1;
    public float theCountdown = 1;


    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;


    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void update()
    {
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnGoodies();
            theCountdown = waitingForNextSpawn;
        }
    }
    void SpawnGoodies()
    {
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        GameObject enemy = enemies[Random.Range(0, enemies.Length)];
        Instantiate(enemy, pos, Quaternion.identity);

    }
}
