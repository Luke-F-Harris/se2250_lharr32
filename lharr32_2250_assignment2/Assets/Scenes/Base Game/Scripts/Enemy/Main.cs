using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update

    // list of enemies
    public List<GameObject> enemies = new List<GameObject>();
    public System.Random rando = new System.Random();

    public GameObject enemy_1;
    public float spawnTime = 3f;
    public GameObject enemy_2;
    private BoxCollider2D gameBounds;
    void Start()
    {
        gameBounds = GameObject.FindWithTag("spawntag").GetComponent<BoxCollider2D>();
        enemies.Add(enemy_1);
        enemies.Add(enemy_2);

    }

    // Update is called once per frame
    void Update()
    {

        // spawns an enemy every 3 seconds
        if (spawnTime <= 3f)
        {
            spawnTime += Time.deltaTime;

        }
        else
        {
            SpawnEnemy();
            spawnTime = 0;
        }
    }

    void SpawnEnemy()
    {
        // picks random enemy and random x value;
        int index = rando.Next(0, 2);
        int xAxis = rando.Next(-7, 6);


        // spawns enemy at x location and top of screen
        if (rando.Next(0, 2) == 1)
        {
            enemies.Add(Instantiate(enemy_1, new Vector3(xAxis, gameBounds.bounds.max.y, 0), Quaternion.identity));
        }
        else
        {
            enemies.Add(Instantiate(enemy_2, new Vector3(xAxis, gameBounds.bounds.max.y, 0), Quaternion.identity));

        }
    }
}
