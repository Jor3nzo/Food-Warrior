using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject explodeParticles;

    public GameObject leftSlice;
    public GameObject rightSlice;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(0f, 13f);
        rb.angularVelocity = Random.Range(-360f, 360f);
    }



    void Update()
    {
        
        if (transform.position.y < -6)
        {
            Miss(); 
           
        }    
    }

    void Miss()
    {
        print(":("); 
        Destroy(gameObject);
    }

    public void Slice()
    {
        var particles = Instantiate(explodeParticles);
        particles.transform.position = transform.position;

        transform.DetachChildren();
        var leftRb = leftSlice.AddComponent<Rigidbody2D>();
        var rightRb = rightSlice.AddComponent<Rigidbody2D>();
        leftRb.velocity = rb.velocity + new Vector2(-2,0);
        rightRb.velocity = rb.velocity + new Vector2(2,0);
        

        Destroy(gameObject);
    }
}
