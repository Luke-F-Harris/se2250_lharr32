using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    static public Player player;
    public float speed = 10f;

    private float _xAxis;
    private float _yAxis;
    public float rollMult = -45;

    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        player = this;
    }
    // Update is called once per frame
    void Update()
    {

        // moves the player in relation to key inputs
        _xAxis = Input.GetAxisRaw("Horizontal");
        _yAxis = Input.GetAxisRaw("Vertical");

        pos = player.transform.position;
        pos.x += _xAxis * speed * Time.deltaTime;
        pos.y += _yAxis * speed * Time.deltaTime;

        transform.position = pos;
        // rotates the player when moving in the x axis
        transform.rotation = Quaternion.Euler(0, 0, 90 + _xAxis * rollMult);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        // destroys if collision
        Debug.Log("Enemy");

        if (other.gameObject.tag == "ENEMY")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}


