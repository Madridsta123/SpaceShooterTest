using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float maxX;
    public float minX;
    
    public Transform muzzle;

   

    
    public float coolDownTime = 0.5f;

    
    public Bullet bulletPrefab;

    private float shootTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer > coolDownTime && Input.GetMouseButtonDown(1))
        {
            shootTimer = 0f;

            Instantiate(bulletPrefab, muzzle.position, Quaternion.identity);
        }
            Vector2 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x, minX, maxX);
        transform.position = playerpos;


        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector2.left * speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Enemy")
        {
            LivesManager.lives_count -=1;
        }
    }
}
