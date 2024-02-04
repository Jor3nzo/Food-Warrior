using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public int bombChance = 20;
    public float spawnSpeed = 1f;
    public GameObject bombPrefab;



    void Spawn()
    {
        var chance = Random.Range(0, 100);
        var prefab = chance > bombChance ? fruitPrefab : bombPrefab;
        var obj = Instantiate(prefab);
        
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x, -5, 0);
    }


    void Start()
    {
        
        InvokeRepeating("Spawn", 0f, spawnSpeed);
    }

    
    void Update()
    {
        
    }
}
