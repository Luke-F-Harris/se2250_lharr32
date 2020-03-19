using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // fields for enemy objects
    protected float _speed = 7f;
    protected Vector3 _tempPos;
    protected BoxCollider2D _collider2D;
    protected BoxCollider2D thisCollider;
    public Vector3 _pos;

    void Start()
    {
        // references the box collider that acts as bounds
        _collider2D = GameObject.FindWithTag("spawntag").GetComponent<BoxCollider2D>();
        thisCollider = GameObject.FindWithTag("ENEMY").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void enemyMove()
    {
        // moves the enemy down the y axis 
        _tempPos = _pos;
        _tempPos.y -= _speed * Time.deltaTime;
        _pos = _tempPos;
        this.transform.position = _pos;
    }

    protected float getSpeed()
    {
        return _speed;
    }
}
