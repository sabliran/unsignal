using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField] GameObject enemySpawnPrefab;
    public GameObject spawnTrigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        
    }


    void spawnEnemy()
    {
        GameObject enemySpawn = Instantiate(enemySpawnPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
    }


    //     void OnCollisionEnter2D(Collision2D col)

    // {
    //     //getBullet = GameObject.FindWithTag("bullet");

    //     if (col.collider.tag == "Player")
    //     {
            
    //         spawnEnemy();
    //         print("spawntriggered");
            
            
    //     } 
 

    // }


     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            spawnEnemy();
            print("spawntriggered");
            
            
        } 
 
    }


}
