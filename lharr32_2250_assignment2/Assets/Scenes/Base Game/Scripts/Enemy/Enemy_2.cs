using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy_2 : Enemy
{
    // Start is called before the first frame update
    private Enemy _enemy_2;
    protected BoxCollider2D _spawncollider2D;
    private System.Random rand = new System.Random();
    private int leftOrRight;
    void Start()
    {
        // picks a number: -1 or 1
        leftOrRight = rand.Next(-1, 2);
        while (leftOrRight == 0)
        {
            leftOrRight = rand.Next(-1, 2);
        }
        _enemy_2 = this;
        _spawncollider2D = GameObject.FindWithTag("spawntag").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // moves emeny 
        _enemy_2.enemyMove();
        _pos = this.transform.position;

        if (!_spawncollider2D.OverlapPoint(_enemy_2._pos))
        {
            Destroy(gameObject);
        }

    }
    public override void enemyMove()
    {
        Vector3 pos = this.transform.position;
        // moves left or right diangonally
        pos += new Vector3(leftOrRight * this.getSpeed() * Time.deltaTime, -this.getSpeed() * Time.deltaTime, 0);

        this.transform.position = pos;
    }
}
