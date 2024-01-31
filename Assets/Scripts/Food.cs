using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Pear;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, 3f);

        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(0, 10);
    }



    void Update()
    {
        
        if (transform.position.y < -6)
        {
            print(":(");
            Destroy(gameObject);
        }    
    }

    void Spawn()
    {

        var randPos = new Vector2(Random.Range(-4, 4), Random.Range(-6.3f, -6));

    
         Instantiate(Pear, randPos, Quaternion.identity);
        

        
    }
}
