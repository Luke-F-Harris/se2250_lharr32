using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipActions : MonoBehaviour
{
    static public ShipActions S;
    [Header("Set in inspector")]
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;
    [Header("Set in inspector")]
    public float shieldLevel = 1;

    // Start is called before the first frame update
    void Awake()
    {
        if (S == null)
        {
            S = this;
        } else
        {
            Debug.LogError("Hero.Awake() - Attempted to assign second Hero.S!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);
        
    }
}
