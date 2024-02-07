using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class FoodEntry
{
    public bool isBomb;
    public float x;
    public float delay;
    public bool isRandomPosition;
    public Vector2 velocity = new Vector2(0, 10);
}

[System.Serializable]

public class Wave
{
    public List<FoodEntry> foods;
}

public class Spawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public int bombChance = 20;
    public float spawnSpeed = 1f;
    public GameObject bombPrefab;

    
    public int currentWave;
    public List<Wave> waves;



    void Spawn()
    {
        var chance = Random.Range(0, 100);
        var prefab = chance > bombChance ? fruitPrefab : bombPrefab;
        var obj = Instantiate(prefab);
        
        var X = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(X, -5, 0);
    }


    async void Start()
    {
        while (currentWave < waves.Count)
        {
            var wave = waves[currentWave];
            for (int i = 0; i < wave.foods.Count; i++)
            {
                var food = wave.foods[i];
                await new WaitForSeconds(food.delay);

                var prefab = food.isBomb ? bombPrefab : fruitPrefab;
                var go = Instantiate(prefab);
                var x = food.isRandomPosition ? Random.Range(-5f, 5f) : food.x;
                go.transform.position = new Vector3(x, -5, 0);
                go.GetComponent<Rigidbody2D>().velocity = food.velocity;
            }
            
            //var prefab = waves[currentWave].isBomb ? bombPrefab : fruitPrefab;
            //var obj = Instantiate(prefab);
            //var x = waves[currentWave].x;
            //obj.transform.position = new Vector3(x, -5, 0);
            
            
            await new WaitForSeconds(3f);
            currentWave++;
        }
    }

    
    void Update()
    {
        
    }
}
