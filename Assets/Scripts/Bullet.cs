using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    
   
    public float lifeTime = 5f;

    internal void DestroySelf()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    private void Awake()
    {
        Invoke("DestroySelf", lifeTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        DestroySelf();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Enemy")
        {
            Destroy(gameObject);
        }
    }
}
