using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : Enemy
{
    // references itself
    private Enemy _enemy_1;
    protected BoxCollider2D _spawncollider2D;

    void Start()
    {
        _enemy_1 = this;
        // different spawn location so object is not destroyed when spawned off screen
        _spawncollider2D = GameObject.FindWithTag("spawntag").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // moves enemy
        _enemy_1.enemyMove();
        _pos = this.transform.position;

        // if not in screen, destroy
        if (!_spawncollider2D.OverlapPoint(_enemy_1._pos))
        {
            Destroy(gameObject);
        }

    }
    public override void enemyMove()
    {
        Vector3 pos = this.transform.position;

        pos += new Vector3(0, -this.getSpeed() * Time.deltaTime, 0);

        this.transform.position = pos;
    }


}
