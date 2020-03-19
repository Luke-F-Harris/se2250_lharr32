using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    /// <summary>
    /// REDUNDANT    
    /// SCRIPT???
    /// </summary>

    [Header("Set in inspector: Enemy")]
    public float speed = 10f;
    public bool angularMove;



    int choice;
    private GameObject lastTriggerGo = null;

    private BoundsCheck bndCheck;

    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
        choice = Random.Range(1, 3);
    }
    void Update()
    {
        Move();
        if (bndCheck != null && (bndCheck.offDown || bndCheck.offLeft || bndCheck.offRight))
        {
            Destroy(gameObject);
        }
    }

    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        if (angularMove)
        {
            if (choice == 1)
            {
                tempPos.x += speed * Time.deltaTime;

            }
            else
            {
                tempPos.x -= speed * Time.deltaTime;

            }
        }
        pos = tempPos;
    }
    void OnTriggerEnter(Collider other)
    {
        Transform rootT = other.gameObject.transform.root;
        GameObject go = rootT.gameObject;

        if (go == lastTriggerGo)
        {
            return;
        }
        lastTriggerGo = go;
        if (go.tag == "Hero")
        {
            Destroy(go);
        }
    }

}
