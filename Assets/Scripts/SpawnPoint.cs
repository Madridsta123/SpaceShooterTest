using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject[] asprefab;
    [SerializeField] float spawn = 0.5f;
    [SerializeField] float minX;
    [SerializeField] float maxX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AsteroidSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator AsteroidSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minX, maxX);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(asprefab[Random.Range(0, asprefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(spawn);
            Destroy(gameObject, 5f);
                
        }
    }
}
