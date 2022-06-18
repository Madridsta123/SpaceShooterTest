using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    float rand_position;
    Vector2 spawn_position;
    public float spawn_rate = 2.0f;
    private float next_spawn = 0.0f;
    public List<GameObject> enemy_list;
    private GameObject random_enemy;
    // Start is called before the first frame update
    private GameObject RandomEnemy()
    {
        var random_temp = Random.Range(0, enemy_list.Count);

        for (int i = 0; i < enemy_list.Count; i++)
        {
            if (i == random_temp)
            {
                random_enemy = enemy_list[i];
            }
            
        }
        return random_enemy;
    }
    private void SpawnEnemy()
    {
        if(Time.time>next_spawn)
        {
            next_spawn = Time.time + spawn_rate;
            spawn_position = new Vector2(rand_position, 0);
            rand_position = Random.Range(-2.4f, 2.4f);
            Instantiate(RandomEnemy(), spawn_position, Quaternion.identity, this.transform);
        }
    }
    private void Update()
    {
        SpawnEnemy();
    }
}
