using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BoundsCheck : MonoBehaviour
{
    public GameObject player;
    protected BoxCollider2D _collider2D;
    private BoxCollider2D _playerCollider;
    private Player _player;
    void Start()
    {
        _collider2D = GameObject.FindWithTag("bckgrnd").GetComponent<BoxCollider2D>();
        _player = player.GetComponent<Player>();
        _playerCollider = _player.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // if the center point of the player is not within the screen
        // the player is the confined if true
        Vector3 pos = _player.transform.position;

        if (!_collider2D.OverlapPoint(pos))
        {
            if (pos.x > _collider2D.bounds.max.x)
            {
                pos.x = _collider2D.bounds.max.x;
            }
            if (pos.y > _collider2D.bounds.max.y)
            {
                pos.y = _collider2D.bounds.max.y;
            }
            if (pos.x < _collider2D.bounds.min.x)
            {
                pos.x = _collider2D.bounds.min.x;
            }
            if (pos.y < _collider2D.bounds.min.y)
            {
                pos.y = _collider2D.bounds.min.y;
            }
        }

        _player.transform.position = pos;
    }
}
