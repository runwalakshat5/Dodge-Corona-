using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
      public float xPositionLimit=2.2f;
      public float spawnRate=1f;
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnSpike()
    {
      float randomX=Random.Range(-xPositionLimit,xPositionLimit);
      Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
      Instantiate(enemy,spawnPosition,Quaternion.identity);
    }
     void StartSpawning()
    {
      InvokeRepeating("SpawnSpike",1f,spawnRate);
    }
    public void StopSpawning()
    {
      CancelInvoke("SpawnSpike");
    }
}
